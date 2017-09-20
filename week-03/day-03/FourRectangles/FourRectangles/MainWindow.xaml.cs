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

namespace FourRectangles
{
    public partial class MainWindow : Window
    {
        public readonly Random randonGen = new Random();

        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            // draw four different size and color rectangles
            for (int i = 0; i < 500; i++)
            {
                RandomRectangle(foxDraw);
            }

        }

        public void RandomRectangle (FoxDraw foxDraw)
        {
                foxDraw.FillColor(RandomColor());
                foxDraw.DrawRectangle(RandomPositionX(), RandomPositionY(), RandomSizeX(), RandomSizeY());
          
        }

        public Color RandomColor()
        {
            Color randomColor = Color.FromArgb(Convert.ToByte(randonGen.Next(255)), Convert.ToByte(randonGen.Next(255)),
                Convert.ToByte(randonGen.Next(255)), Convert.ToByte(randonGen.Next(255)));
            return randomColor;
        }

        public int RandomSizeX ()
        {
            int randomSize = randonGen.Next(50);
            return randomSize;
        }

        public int RandomSizeY()
        {
            int randomSize = randonGen.Next(100);
            return randomSize;
        }

        public int RandomPositionX()
        {
            int randomSize = randonGen.Next(1200);
            return randomSize;
        }

        public int RandomPositionY()
        {
            int randomSize = randonGen.Next(600);
            return randomSize;
        }

    }
}
