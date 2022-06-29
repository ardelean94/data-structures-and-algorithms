using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.HackerRank_30DaysOfCode.Day_16
{
    public class AAConvert
    {
        public static int ToInt(string input)
        {
            int number = 0;
            try
            {
                number = int.Parse(input);
                
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Bad String");
                return -1;
            }

            return number;
        }
    }
}
