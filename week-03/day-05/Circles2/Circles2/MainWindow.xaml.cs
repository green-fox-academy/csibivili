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

namespace Circles2
{

    public partial class MainWindow : Window
    {
        public readonly double m = Math.Sqrt(3) / 2;

        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            foxDraw.BackgroundColor(Color.FromArgb(255, 0, 0, 255));
            foxDraw.FillColor(Color.FromArgb(0, 0, 0, 0));
            foxDraw.StrokeColor(Colors.White);
            //foxDraw.DrawEllipse(0, 0, 600, 600);
            Circle(foxDraw, 600, 5);
        }

        private void Circle(FoxDraw foxDraw, double x, int depth)
        {
            foxDraw.FillColor(Color.FromArgb(0, 0, 0, 0));
            foxDraw.StrokeColor(Colors.White);

            DrawCircles(foxDraw, Size(x), PositionX (m * x / 1.5), PositionY(m * x / 6));
            DrawCircles(foxDraw, Size(x), PositionX(m * x / 12), PositionY(m * x));
            DrawCircles(foxDraw, Size(x), PositionX(m * x / 6 * 7), PositionY(m * x));

            //DrawCircles(foxDraw, Size(x), PositionXX(m * x / 1.5), PositionYY(m * x / 6));
            //DrawCircles(foxDraw, Size(x), PositionXX(m * x / 12), PositionYY(m * x));
            //DrawCircles(foxDraw, Size(x), PositionXX(m * x / 6 * 7), PositionYY(m * x));


            depth--;

            if (depth > 0)
            {
                Circle(foxDraw, x / 3, depth);
                return;
            }
        }

        public void DrawCircles (FoxDraw foxDraw, double x, double xPos, double yPos)
        {          
            foxDraw.DrawEllipse(xPos, yPos, x, x);
        }

        public double Size (double size)
        {
            if (size > 10)
            {
                return m * size / 2;
            }
            return 1;
        }

        public double PositionX (double xPos)
        {
            if (xPos > 20)
            {
                return xPos / 2;
            }
            return 1;
        }

        public double PositionY(double yPos)
        {
            if (yPos > 20)
            {
                return yPos / 2;
            }
            return 1;
        }
        public double PositionXX(double xPos)
        {
            if (xPos > 20)
            {
                return 600 - xPos / 2;
            }
            return 1;
        }

        public double PositionYY(double yPos)
        {
            if (yPos > 20)
            {
                return 600 - yPos / 2;
            }
            return 1;
        }

        public double PositionXXX(double xPos)
        {
            if (xPos > 20)
            {
                return 600 - xPos / 2;
            }
            return 1;
        }

        public double PositionYYY(double yPos)
        {
            if (yPos > 20)
            {
                return 600 - yPos / 2;
            }
            return 1;
        }
    }
}

