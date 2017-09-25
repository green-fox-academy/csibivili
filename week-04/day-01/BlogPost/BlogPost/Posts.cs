using System;
using System.Collections.Generic;
using System.Text;

namespace BlogPost
{
    public class Posts
    {

        public string author, title, text, date;

        public Posts (string Author, string Title, string Text, int year, int month, int day)
        {
            author = Author;
            title = Title.ToUpper();
            text = Text;
            date = String.Format("{0}.{1}.{2}", year, month, day);
            
        }
    }
}
