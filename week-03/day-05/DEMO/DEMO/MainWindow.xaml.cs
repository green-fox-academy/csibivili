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
using System.IO;

namespace DEMO
{

    public partial class MainWindow : Window
    {
        public List<double> listOfNumbers = new List<double>() { 10, 20, 30, 40, 50, 60 };
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            //DrawColumn(foxDraw, ReadData("file"));
            foxDraw.BackgroundColor(Colors.Black);
            foxDraw.FillColor(Colors.Black);
            //foxDraw.DrawRectangle(20, 100, 300, 200);
            DrawColumn(foxDraw, listOfNumbers);
        }


        //public List<double> ReadData(string file1)
        //{
        //    int counter = 0;
        //    string line;
        //    string[] lines = new string[file1.Length];
        //    StreamReader file = new StreamReader(file1);
        //    while ((line = file.ReadLine()) != null)
        //    {
        //        listOfNumbers.Add(Convert.ToDouble(lines[counter]));
        //        counter++;
        //    }
        //    return listOfNumbers;
        //}

        public void DrawColumn (FoxDraw foxDraw, List<double> Paramaters)
        {
            double xPoint = 0;
            double yPoint = 10;

            for (int i = 0; i < Paramaters.Count; i++)
            {

                foxDraw.FillColor(Colors.White);
                foxDraw.StrokeColor(Colors.White);
                xPoint = xPoint + Paramaters[i];
                foxDraw.DrawLine(300, 300 , xPoint, 10);
            }           
        }
    }
}
