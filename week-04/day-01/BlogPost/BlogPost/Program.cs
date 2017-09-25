using System;

namespace BlogPost
{
    class Program
    {
        static void Main(string[] args)
        {
            var post1 = new Posts("Jon Doe", "Lorem Ipsum", "Lorem ipsum dolor sit amet.", 2000, 5, 4);
            Console.WriteLine(String.Format("{2}{4}{0} - {1}{4}{3}{4}", post1.author, post1.date, post1.title, post1.text,Environment.NewLine));
          

            var post2 = new Posts("Tim Urban", "Wait but why", "A popular long-form, stick-figure-illustrated blog about almost everything.", 2010, 10, 10);
            Console.WriteLine(String.Format("{2}{4}{0} - {1}{4}{3}{4}", post2.author, post2.date, post2.title, post2.text, Environment.NewLine));

            var post3 = new Posts("William Turton", "One Engineer Is Trying to Get IBM to Reckon With Trump", "Daniel Hanley, a cybersecurity engineer at IBM, doesn’t want to be the center of attention. When I asked to take his picture outside one of IBM’s New York City offices, he told me that he wasn’t really into the whole organizer profile thing.", 2017, 3, 28);
            Console.WriteLine(String.Format("{2}{4}{0} - {1}{4}{3}{4}", post3.author, post3.date, post3.title, post3.text, Environment.NewLine));

            Console.ReadLine();
        }
    }
}
