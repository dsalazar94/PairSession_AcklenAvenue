using System;

namespace Kata
{
    public class Calculator
    {
        //private int number_1;
        public int Add(string number = "0")
        {
            int res = 0;
            int i = 0;
            string[] temp;
            string[] newValues;
            if (number.Contains(","))
            {
                
                temp = number.Split(",");
                foreach (var digit in temp)
                {
                    res += Int32.Parse(digit);
                }

                return res;
            }
            else
            {
                return Int32.Parse(number);
            }
            
        }
    }
}