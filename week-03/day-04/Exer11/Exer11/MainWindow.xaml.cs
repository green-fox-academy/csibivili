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


    public partial class MainWindow : Window
    {
        public Rectangle Square = new Rectangle();
        public readonly Random randonGen = new Random();
        public int yPosition = 600;
        public int xPosition = 600;
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            DrawSquare(foxDraw, Size(200), Size(200), Size(200));
        }


        public int Size(int value)
        {
            
            if (value > 10)
            {
                return value /= 3;
            }
            else
            {
                return value;
            }
        }

        public void DrawSquare(FoxDraw foxDraw, int x, int y, int size)
        {
            foxDraw.DrawRectangle(x, y, size, size);
        }

        public Color RandomColor()
        {
            Color randomColor = Color.FromArgb(Convert.ToByte(randonGen.Next(255)), Convert.ToByte(randonGen.Next(255)),
                Convert.ToByte(randonGen.Next(255)), Convert.ToByte(randonGen.Next(255)));
            return randomColor;
        }
    }
}
