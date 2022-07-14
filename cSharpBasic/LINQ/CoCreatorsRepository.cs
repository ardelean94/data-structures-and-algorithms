using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.cSharpBasic.LINQ
{
    class CoCreatorsRepository
    {
        public List<CoCreator> GetCoCreators()
        {
            return new List<CoCreator>
            {
                new CoCreator {FirstName = "Lise", LastName = "Morris", Age = 24, Company = "ReadyForAction"},
                new CoCreator {FirstName = "May", LastName = "Miky", Age = 64, Company = "EldersOfEarth"},
                new CoCreator {FirstName = "Jom", LastName = "Gold", Age = 44, Company = "ReadyForAction"},
                new CoCreator {FirstName = "Blige", LastName = "Gligor", Age = 15, Company = "ReadyForAction"},
                new CoCreator {FirstName = "Stonson", LastName = "Samantha", Age = 30, Company = "WisdomKeepers"},
                new CoCreator {FirstName = "Yeru", LastName = "Ole", Age = 74, Company = "ReadyForAction"},
                new CoCreator {FirstName = "Bernard", LastName = "Yugo", Age = 20, Company = "EldersOfEarth"},
                new CoCreator {FirstName = "Iancu", LastName = "Miraela", Age = 29, Company = "ReadyForAction"},
                new CoCreator {FirstName = "Lob", LastName = "Aron", Age = 48, Company = "WisdomKeepers"},
                new CoCreator {FirstName = "Culpu", LastName = "Biky", Age = 65, Company = "WisdomKeepers"},
                new CoCreator {FirstName = "Myor", LastName = "Kurgo", Age = 120, Company = "EldersOfEarth"}
            };
        }
    }
}
