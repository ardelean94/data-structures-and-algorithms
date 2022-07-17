using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructuresAndAlgorithms.cSharpBasic.LINQ;

namespace DataStructuresAndAlgorithms.cSharpBasic.LINQ
{
    static class CompanyActions
    {
        public static Dictionary<string, int> AverageAgeForEachCompany(List<CoCreator> coCreators)
        {
            //  LINQ Query Operators
            //var coCreatorsPerCompany2 =
            //    from c in repo
            //    group c by c.Company into cGroup
            //    select new { Company = cGroup.Key, Average = cGroup.Average(c => c.Age) };

            //  LINQ Extension Methods
            var averageAgeForEachCompany = coCreators
                .GroupBy(c => c.Company)
                .Select(c => new { Company = c.Key, Average = c.Average(avg => avg.Age) })
                .ToDictionary(c => c.Company, c => Convert.ToInt32(c.Average));

            return averageAgeForEachCompany;
        }

        public static Dictionary<string, int> CountOfCoCreatorsForEachCompany(List<CoCreator> coCreators)
        {
            //LINQ Query Operators
            //var coCreatorsPerCompany2 =
            //    from c in repo
            //    group c by c.Company into cGroup
            //    select new { Company = cGroup.Key, Count = cGroup.Count() };

            //  LINQ Extension Methods
            var coCreatorsPerCompany = coCreators
                .GroupBy(c => c.Company)
                .Select(c => new { Company = c.Key, Count = c.Count() })
                .ToDictionary(c => c.Company, c => c.Count);

            return coCreatorsPerCompany;
        }

        public static Dictionary<string, CoCreator> OldestAgeForEachCompany(List<CoCreator> coCreators)
        {
            //  LINQ Extension Methods
            var oldestAgeForEachCompany = coCreators
                .GroupBy(c => c.Company)
                .Select(c => new { Company = c.Key, MinAge = c.Min(c => c.Age), FirstName = coCreators.Select(c => c.FirstName).ToString(), LastName = coCreators.Select(c => c.LastName).ToString() })
                .ToDictionary(c => c.Company, c => new CoCreator() { FirstName = c.FirstName, LastName = c.LastName, Age = c.MinAge, Company = c.Company });

            return oldestAgeForEachCompany;
        }
    }
}
