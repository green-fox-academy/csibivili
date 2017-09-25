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

namespace Exer11
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            foxDraw.BackgroundColor(Colors.Yellow);
            DrawLines(foxDraw, 0, 0, 600, 600, 6);
        }

        static void DrawLines(FoxDraw foxDraw, double x, double y, double endx, double endy, int depth)
        {
            foxDraw.StrokeColor(Colors.Black);
            foxDraw.DrawLine(x + (endx - x) / 3, y, x + (endx - x) / 3, endy);
            foxDraw.DrawLine(x + (endx - x) / 3 * 2, y, x + (endx - x) / 3 * 2, endy);
            foxDraw.DrawLine(x, y + (endy - y) / 3, endx, y + (endy - y) / 3);
            foxDraw.DrawLine(x, y + (endy - y) / 3 * 2, endx, y + (endy - y) / 3 * 2);

            depth--;

            if (depth > 0)
            {
                DrawLines(foxDraw, x + (endx - x) / 3, y, x + (endx - x) / 1.5, y + (endy - y) / 3, depth);
                DrawLines(foxDraw, x + (endx - x) / 3, y + (endy - y) / 3 * 2, x + (endx - x) / 3 * 2, endy, depth);
                DrawLines(foxDraw, x + (endx - x) / 3 * 2, y + (endy - y) / 3, endx, y + (endy - y) / 3 * 2, depth);
                DrawLines(foxDraw, x, y + (endy - y) / 3, x + (endx - x) / 3, y + (endy - y) / 3 * 2, depth);
                return;
            }
        }


    }
}
