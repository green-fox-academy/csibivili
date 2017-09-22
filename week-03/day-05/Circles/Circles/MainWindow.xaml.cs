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

namespace Circles
{

    public partial class MainWindow : Window
    {
        public readonly double m = Math.Sqrt(3) / 2;

        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            foxDraw.FillColor(Color.FromArgb(0, 0, 0, 0));
            foxDraw.DrawEllipse(0, 0, 600, 600);
            //foxDraw.DrawLine(300, 0, 300, 600);
            //foxDraw.DrawLine(0, 300, 600, 300);
            //foxDraw.DrawEllipse(m * 200, 0, m * 300, m * 300);
            //foxDraw.DrawEllipse(m * 50, m * 300, m * 300, m * 300);
            //foxDraw.DrawEllipse(m * 350, m * 300, m * 300, m * 300);

            //foxDraw.DrawEllipse(x / 3, x - x / 3 * 2, x / 3, x / 3);
            //foxDraw.DrawEllipse(x / 3 * 2, x - x / 3, x / 3, x / 3);
            Circle(foxDraw, 600,600, 600, 3);
        }

        private void Circle(FoxDraw foxDraw, int x,int xPos, int yPos, int depth)
        {
            foxDraw.FillColor(Color.FromArgb(0, 0, 0, 0));

            foxDraw.DrawEllipse(m * x/3, m*  x / 12, m * x / 2, m * x / 2);
            foxDraw.DrawEllipse(m * x / 12, m * x / 2, m * x / 2, m * x / 2);
            foxDraw.DrawEllipse(m * x / 12 * 7, m * x / 2, m * x / 2, m * x / 2);
            depth--;

            if (depth > 0)
            {
                Circle(foxDraw, x / 3, xPos/2,yPos/3, depth);
                return;
            }
        }
    }
}
