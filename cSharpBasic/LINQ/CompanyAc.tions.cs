using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructuresAndAlgorithms.cSharpBasic.LINQ;

namespace DataStructuresAndAlgorithms.cSharpBasic.LINQ
{
    static class CompanyAc
    {
        public static Dictionary<string, int> AverageAgeForEachCompany(List<CoCreator> coCreators)
        {
            var averageAgeForEachCompany = coCreators
                .GroupBy(c => c.Company)
                .Select(c => new { Company = c.Key, Average = c.Average(avg => avg.Age) })
                .ToDictionary(c => c.Company, c => Convert.ToInt32(c.Average));

            return averageAgeForEachCompany;
        }

        public static Dictionary<string, int> CountOfCoCreatorsForEachCompany(List<CoCreator> coCreators)
        {
            var coCreatorsPerCompany = coCreators
                .GroupBy(c => c.Company)
                .Select(c => new { Company = c.Key, Count = c.Count() })
                .ToDictionary(c => c.Company, c => c.Count);

            return coCreatorsPerCompany;
        }

        public static Dictionary<string, CoCreator> OldestAgeForEachCompany(List<CoCreator> coCreators)
        {
            throw new NotImplementedException();
        }
    }
}
