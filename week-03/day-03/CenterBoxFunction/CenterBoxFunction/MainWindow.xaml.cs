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

namespace CenterBoxFunction
{
    public partial class MainWindow : Window
    {
        public readonly Random randonGen = new Random();

        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            // create a square drawing function that takes 1 parameter:
            // the square size
            // and draws a square of that size to the center of the canvas.
            // draw 3 squares with that function.
            for (int i = 700; i > 0; i = i-20)
            {
                DrawSquare(foxDraw, i);
            }

        }

        public void DrawSquare (FoxDraw foxDraw, int value)
        {
            foxDraw.FillColor(RandomColor());
            foxDraw.StrokeColor(RandomColor());
            foxDraw.DrawRectangle((canvas.Width - value) / 2, (canvas.Height - value) / 2, value, value);
        }
        public Color RandomColor()
        {
            Color randomColor = Color.FromArgb(Convert.ToByte(randonGen.Next(255)), Convert.ToByte(randonGen.Next(255)),
                Convert.ToByte(randonGen.Next(255)), Convert.ToByte(randonGen.Next(255)));
            return randomColor;
        }
    }

    

}
