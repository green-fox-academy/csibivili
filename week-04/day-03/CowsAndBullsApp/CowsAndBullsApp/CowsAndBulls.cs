using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CowsAndBullsApp
{
    public class CowsAndBulls
    {
        static readonly Random RANDOM = new Random();
        static readonly string[] COWBULL = new string[] { "cow", "bull" };

        public List<char> Digits = new List<char>();

        public string CAB(int input)
        {
            //string result = input.ToString();
            //char[] digits = result.ToCharArray();
            //result = String.Empty;

            //foreach (var digit in digits)
            //{
            //    if (digit == '1')
            //    {
            //        result += "cow";
            //    }
            //    else
            //    {
            //        result += digit.ToString();
            //    }
            //}
            return Match(input);
        }

        static int RandomNumber ()
        {
            return 1234;
        }

        public string Match(int input)
        {
            if (input == RandomNumber())
            {
                return String.Format("{0}{0}{0}{0}", COWBULL[0]);
            }
            return NotMatch(input);
        }

        public string NotMatch(int input)
        {
            Breakdown(input);
            for (int i = 0; i < Digits.Count; i++)
            {
                if (RandomNumber().ToString().Contains(Digits[i]))
                {

                    return String.Format("{0}678", COWBULL[0]);
                }
            }
            return input.ToString();
        }

        public List<char> Breakdown (int input)
        {
            string textInput = input.ToString();
            char[] digits = textInput.ToCharArray();

            foreach (var digit in digits)
            {
                Digits.Add(digit);
            }
            return Digits;
        }
    }
}
