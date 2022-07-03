using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.ReferenceType_ValueType
{
    class Person
    {
        private HairColor hairColor = HairColor.Black;

        public HairColor HairColor
        {
            get
            {
                return hairColor;
            }
            set
            {
                hairColor = value;
            }
        }

        public Person() { }
    }
}
