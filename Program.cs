using System.Collections.Generic;
using System;
using DataStructuresAndAlgorithms.Arrays;
using DataStructuresAndAlgorithms.SortingAlgorithms;
using DataStructuresAndAlgorithms.HackerRank_30DaysOfCode.Day_26;
using System.Linq;
using DataStructuresAndAlgorithms.cSharpBasic.LINQ;
using DataStructuresAndAlgorithms.cSharpBasic.NoteStore;

namespace DataStructuresAndAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            var repo = new CoCreatorsRepository().GetCoCreators();
            var oldestAgeForEachCompany = CompanyActions.OldestAgeForEachCompany(repo);


            foreach (KeyValuePair<string, CoCreator> keyValue in oldestAgeForEachCompany)
            {
                Console.WriteLine(keyValue.Key + " " + keyValue.Value);
            }
        }
    }
}
