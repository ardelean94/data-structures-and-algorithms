using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.HackerRank_30DaysOfCode.Day_26
{
    static class Store
    {
        /*
         TODO: implement an input validation
         */
        public static int GetFine(string[] returnedDate, string[] dueDate)
        {
            var returnDate = new DateTime(Convert.ToInt32(returnedDate[2]), Convert.ToInt32(returnedDate[1]), Convert.ToInt32(returnedDate[0]));
            var limitDate = new DateTime(Convert.ToInt32(dueDate[2]), Convert.ToInt32(dueDate[1]), Convert.ToInt32(dueDate[0]));

            if (returnDate <= limitDate)
                return 0;

            if (returnDate > limitDate)
            {
                if (returnDate.Month == limitDate.Month && returnDate.Year == limitDate.Year)
                    return 15 * (returnDate.Day - limitDate.Day);

                if (returnDate.Year == limitDate.Year)
                    return 500 * (returnDate.Month - limitDate.Month);
            }

            return 10000;
        }
    }
}
