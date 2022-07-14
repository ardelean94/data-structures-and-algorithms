using System.Collections.Generic;
using System;
using DataStructuresAndAlgorithms.Arrays;
using DataStructuresAndAlgorithms.SortingAlgorithms;
using DataStructuresAndAlgorithms.HackerRank_30DaysOfCode.Day_26;
using System.Linq;
using DataStructuresAndAlgorithms.cSharpBasic.LINQ;

namespace DataStructuresAndAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            var coCreators = new CoCreatorsRepository().GetCoCreators();
            var averageAgePerCompany = CompanyAc.AverageAgeForEachCompany(coCreators);

            foreach(KeyValuePair<string, int> keyValue in averageAgePerCompany)
            {
                Console.WriteLine(keyValue.Key + " " + keyValue.Value);
            }
        }
    }
}
