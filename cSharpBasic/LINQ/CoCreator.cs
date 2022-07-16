using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.cSharpBasic
{
    public class CoCreator
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Company { get; set; }

        public override string ToString()
        {
            return FirstName + " " + LastName + " " + Age + " " + Company;
        }
    }
}
