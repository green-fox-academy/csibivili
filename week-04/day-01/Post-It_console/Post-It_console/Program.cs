using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Post_It_console
{
    class Program
    {
        public struct PostIt
        {
            public ConsoleColor Background;
            public string Text;
            public ConsoleColor Textcolor;

            public PostIt (ConsoleColor Background, string Text, ConsoleColor Textcolor)
            {
                this.Background = Background;
                this.Text = Text;
                this.Textcolor = Textcolor;
            }

        }

        static void Main(string[] args)
        {
            var postit1 = new PostIt(ConsoleColor.DarkRed, "Idea 1", ConsoleColor.Blue);

            //postit1.Background = ConsoleColor.DarkRed;
            //postit1.Text = "Idea 1";
            //postit1.Textcolor = ConsoleColor.Blue;

            Console.BackgroundColor = postit1.Background;
            Console.ForegroundColor = postit1.Textcolor;
            Console.WriteLine(postit1.Text);

            var postit2 = new PostIt(ConsoleColor.Magenta, "Awesome", ConsoleColor.Black);

            //postit2.Background = ConsoleColor.Magenta;
            //postit2.Text = "Awesome";
            //postit2.Textcolor = ConsoleColor.Black;

            Console.BackgroundColor = postit2.Background;
            Console.ForegroundColor = postit2.Textcolor;
            Console.WriteLine(postit2.Text);

            var postit3 = new PostIt(ConsoleColor.Yellow,"Superb",ConsoleColor.Green);

            //postit3.Background = ConsoleColor.Yellow;
            //postit3.Text = "Superb";
            //postit3.Textcolor = ConsoleColor.Green;

            Console.BackgroundColor = postit3.Background;
            Console.ForegroundColor = postit3.Textcolor;
            Console.WriteLine(postit3.Text);


            Console.ReadLine();
        }
    }
}
