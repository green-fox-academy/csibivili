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

namespace Checkerboard
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            // fill the canvas with a checkerboard pattern.

            int x, y;

            for (y = 0; y < 8 * 70; y = y + 75)
            {
                for (x = 0; x < 8 * 70; x = x + 140)
                {
                    foxDraw.FillColor(Colors.Black);
                    foxDraw.StrokeColor(Colors.Black);
                    DrawSquare(foxDraw, x, y);
                }
                for (x = 70; x < 8 * 70; x = x + 140)
                {
                    foxDraw.FillColor(Colors.White);
                    foxDraw.StrokeColor(Colors.White);
                    DrawSquare(foxDraw, x, y);
                }
                y = y + 75;
                for (x = 0; x < 8 * 70; x = x + 140)
                {
                    foxDraw.FillColor(Colors.White);
                    foxDraw.StrokeColor(Colors.White);
                    DrawSquare(foxDraw, x, y);
                }
                for (x = 70; x < 8 * 70; x = x + 140)
                {
                    foxDraw.FillColor(Colors.Black);
                    foxDraw.StrokeColor(Colors.Black);
                    DrawSquare(foxDraw, x, y);
                }
            }
            
        }

        public void DrawSquare (FoxDraw foxDraw, int x, int y)
        {
            foxDraw.DrawRectangle(x, y, 70, 70);
        }
    }
}
