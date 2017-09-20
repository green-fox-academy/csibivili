using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using GreenFox;

namespace ColoredBox
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            // draw a box that has different colored lines on each edge.
            int x = 10;
            int y = 60;

            DrawSquare(CreatePoints(x, y));

        }

        public List<Point> CreatePoints (int x, int y)
        {
            var points = new List<Point>();
            points.Add(new Point(x, x));
            points.Add(new Point(y, x));
            points.Add(new Point(y, y));
            points.Add(new Point(x, y));
            return points;
        }

        public void DrawSquare (List<Point> points) 
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            for (int i = 1; i < points.Count; i++)
            {
                foxDraw.StrokeColor(RandomColor());
                foxDraw.DrawLine(points[i], points[i-1]);
            }
            foxDraw.StrokeColor(RandomColor());
            foxDraw.DrawLine(points[points.Count-1], points[0]);
        }

        public Color RandomColor()
        {
            Random randonGen = new Random();
            Color randomColor = Color.FromArgb(255, Convert.ToByte(randonGen.Next(255)), 
                Convert.ToByte(randonGen.Next(255)), Convert.ToByte(randonGen.Next(255)));
            return randomColor;
        }

    }
}
