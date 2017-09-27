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

        //public List<char> Digits = new List<char>();

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
            string result = String.Empty;
            for (int i = 0; i < Breakdown(input).Count; i++)
            {
                if (Breakdown(RandomNumber())[i] == Breakdown(input)[i])
                {
                    result += COWBULL[0];
                }
                else
                {
                    result += Breakdown(input)[i];
                }
            }
            return result;
        }

        public List<string> Breakdown (int input)
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
