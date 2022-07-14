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

        public static Dictionary<string, int> CountOfEmployeesForEachCompany(List<CoCreator> coCreators)
        {
            throw new NotImplementedException();
        }

        public static Dictionary<string, CoCreator> OldestAgeForEachCompany(List<CoCreator> coCreators)
        {
            throw new NotImplementedException();
        }
    }
}
