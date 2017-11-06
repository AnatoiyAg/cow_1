﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCow
{
    public class Program
    {
        static void Main(string[] args)
        {


        }

        public static string CowCounter(int n)
        {
            int lastDigit = n % 10;
            int lastTowDigit = n % 100;
          

            string result = string.Empty;

           
            if (11<= lastTowDigit && lastTowDigit <=19)
                result = "коров";
            else if (lastDigit == 1)
                result = "корова";
            else if (2 <= lastDigit && lastDigit <= 4)
                result = "коровы";
            else if (5<=lastDigit && 9<=lastDigit ||  
                lastDigit == 0)
                result = "коров";
            
            return string.Format("{0} {1}", n, result);
        }
    }

}
