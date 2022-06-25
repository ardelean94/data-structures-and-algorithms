using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms
{
    class Person
    {
        private int age;
        public int Age 
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }

        public Person(int initialAge)
        {
            if (initialAge > 0) 
                age = initialAge;
            else
            {
                age = 0;
                Console.WriteLine("Age is not valid, setting age to 0..");
            }  
        }

        public void YearPasses() => age++;

        public void AmIOld()
        {
            //if (age <= 0)
            //    return;
            if(age >= 0 && age < 13)
                Console.WriteLine("You are young");
            else if(age >= 13 && age < 18)
                Console.WriteLine("You are a teenager");
            else
                Console.WriteLine("You are old.");
        }
    }
}