using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAB
{
    class CowsAndBulls
    {       
        static readonly string[] COWBULL = new string[] { "cow", "bull" };

        public int guessNumber;

        public int RandomNumber()
        {
            Random RANDOM = new Random();
            return guessNumber = RANDOM.Next(1000, 10000);
        }

        public string CAB(int input)
        {
            //RandomNumber(); //replace RandomNumber() with guessNumber           
            if (input == guessNumber)
            {
                return String.Format("{0}{0}{0}{0}", COWBULL[0]);
            }
            //need to deal with crazy inputs
            return NotMatch(input);
        }

        public string NotMatch(int input) // REFACTOR!!!
        {
            string result = String.Empty;
            for (int i = 0; i < Breakdown(input).Count; i++)
            {
                if (Breakdown(guessNumber)[i] == Breakdown(input)[i])
                {
                    result += COWBULL[0];
                }
                else
                {
                    for (int j = 0; j < Breakdown(input).Count; j++)
                    {
                        if (Breakdown(guessNumber)[j] == Breakdown(input)[i])
                        {
                            result += COWBULL[1];
                        }
                    }
                    if (!Breakdown(guessNumber).Contains(Breakdown(input)[i]))
                    {
                        result += Breakdown(input)[i];
                    }
                }
            }
            return result;
        }

        //public string Cow (string input)
        //{

        //    return "";
        //}

        //public string Bull (string input)
        //{
        //    return "";
        //}

        public List<string> Breakdown(int input)
        {
            List<string> Digits = new List<string>();
            string textInput = input.ToString();
            char[] digits = textInput.ToCharArray();

            foreach (var digit in digits)
            {
                Digits.Add(digit.ToString());
            }
            return Digits;
        }
    }
}
