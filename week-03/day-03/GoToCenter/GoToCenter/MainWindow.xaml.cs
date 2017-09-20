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

namespace GoToCenter
{
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            // create a line drawing function that takes 2 parameters:
            // the x and y coordinates of the line's starting point
            // and draws a line from that point to the center of the canvas.
            // draw 3 lines with that function.
            LineToCenter(10, 20);
            LineToCenter(20, 30);
            LineToCenter(30, 40);



        }

        //public readonly Random random = new Random();

        public void LineToCenter (int num1, int num2)
        {
            var foxDraw = new FoxDraw(canvas);
            foxDraw.DrawLine(num1, num2, (canvas.Width / 2), (canvas.Height /2));
        }
    }
}
