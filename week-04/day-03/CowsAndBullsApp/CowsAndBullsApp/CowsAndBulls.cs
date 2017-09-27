using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CowsAndBullsApp
{
    public class CowsAndBulls
    {
        public string CAB(int input)
        {
            string result = input.ToString();
            char[] digits = result.ToCharArray();
            //var textDigits = new List<string>();
            result = String.Empty;

            foreach (var digit in digits)
            {
                if (digit == '1')
                {
                    result += "cow";
                }
                else
                {
                    result += digit.ToString();
                }
                
            }


            return result;
        }
    }
}
