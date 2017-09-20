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




namespace Middle_lines
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);

            //  draw a red horizontal line to the canvas' middle.
            //  draw a green vertical line to the canvas' middle.

            var startPoint = new Point(0,canvas.Height/2);
            var endPoint = new Point(canvas.Width, canvas.Height / 2);

            foxDraw.StrokeColor(Colors.Red);
            foxDraw.DrawLine(startPoint,endPoint);



        }
    }
}
