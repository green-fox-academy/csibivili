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
            //int x, y, w, y;
            int x = 10;
            int y = 60;
            var colors = new List<string>() { "Red", "Green", "Blue", "Yellow" };

            //var point1 = new Point(x, x);
            //var point2 = new Point(y, x);
            //var point3 = new Point(y, y);
            //var point4 = new Point(x, y);

            //foxDraw.DrawLine(point1, point2);
            //foxDraw.DrawLine(point2, point3);
            //foxDraw.DrawLine(point3, point4);
            //foxDraw.DrawLine(point4, point1);

            DrawSquare(CreatePoints(x, y), colors);

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

        public void DrawSquare (List<Point> points, List<string> colors)
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            for (int i = 1; i < points.Count; i++)
            {
                foxDraw.DrawLine(points[i-1], points[i]);
            }
        }

    }
}
