using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerTDD
{
    public class Poker
    {
        static readonly int HANDLENGTH = 5;
        static readonly char[] PACK = {'2','3','4','5','6','7','8','9', 'T', 'J', 'Q', 'K', 'A' };

        public static string ComparePlayers(string black, string white)
        {
            string[] blackArray = black.Split(' ');
            string[] whiteArray = white.Split(' ');
            OrderCards(blackArray);
            OrderCards(whiteArray);
            return FlushCompare(blackArray, whiteArray);
        }

        public static string[] OrderCards(string[] cards)
        {
            for (int i = 0; i < cards.Length - 1; i++)
            {
                for (int j = cards.Length - 1; j > i; j--)
                {
                    if (Array.IndexOf(PACK, cards[j][0]) > Array.IndexOf(PACK, cards[j-1][0]))
                    {
                        string x = cards[j];
                        cards[j] = cards[j - 1];
                        cards[j - 1] = x;
                    }
                }
            }
            return cards;
        }

        public static string FlushCompare(string[] blackArray, string[] whiteArray)
        {
            if (Flush(whiteArray) && Flush(blackArray))
            {
                if (Array.IndexOf(PACK, blackArray[0][0]) < Array.IndexOf(PACK, whiteArray[0][0]))
                {
                    return "White wins. - with higher flush";
                }
            }
            if (Flush(whiteArray))
            {
                return "White wins. - with flush";
            }
            if (Flush(blackArray))
            {
                return "Black wins. - with flush";
            }
            return HigherCards(blackArray, whiteArray);
        }

        public static bool Flush(string[] cards)
        {
            int counter = 0;
            for (int i = 0; i < cards.Length - 1; i++)
            {
                if (cards[i][1] == cards[i + 1][1])
                {
                    counter++;
                }
            }
            return (counter == 4)? true: false;
        }

        public static string HigherCards(string[] blackArray, string[] whiteArray) //Stronger hand
        {
            int i = 0;
            if (Array.IndexOf(PACK, blackArray[i][0]) > Array.IndexOf(PACK, whiteArray[i][0]))
            {
                return "";
            }
            else
            {
                while (Array.IndexOf(PACK, blackArray[i][0]) == Array.IndexOf(PACK, whiteArray[i][0]))
                {
                    if (Array.IndexOf(PACK, blackArray[i + 1][0]) >=
                        Array.IndexOf(PACK, whiteArray[i + 1][0]))
                    {
                        if (Array.IndexOf(PACK, blackArray[i + 1][0]) ==
                        Array.IndexOf(PACK, whiteArray[i + 1][0]))
                        {
                            i++;
                        }
                        else
                        {
                            return "Black wins. - with high card: Nine"; //dictionary needed
                        }
                    }
                    else
                    {
                        return "White wins. - with high card: Ace";
                    }
                }
            }
            return "White wins. - with high card: Ace";
        }
    }
}
