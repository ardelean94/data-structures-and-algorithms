using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms
{
    class Person2
    {
        protected string firstName;
        protected string lastName;
        protected int id;

        public Person2() { }
        public Person2(string firstName, string lastName, int identification)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.id = identification;
        }
        public void printPerson()
        {
            Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id);
        }
    }

    class Student : Person2
    {
        private int[] testScores;

        /*	
        *   Class Constructor
        *   
        *   Parameters: 
        *   firstName - A string denoting the Person's first name.
        *   lastName - A string denoting the Person's last name.
        *   id - An integer denoting the Person's ID number.
        *   scores - An array of integers denoting the Person's test scores.
        */
        // Write your constructor here
        public Student(string firstName, string lastName, int id, int[] scores)
            : base(firstName, lastName, id)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.id = id;
            this.testScores = scores;
        }
        /*	
        *   Method Name: Calculate
        *   Return: A character denoting the grade.
        */
        // Write your method here
        public char Calculate()
        {
            if (testScores.Length == 0)
                throw new NotImplementedException();

            int scoresSum = GetScoresSum();
            int average = scoresSum / testScores.Length;
            char letter = GetLetterBasedOnAverage(average);

            return letter;
        }

        private char GetLetterBasedOnAverage(int average)
        {
            if (average >= 90 && average <= 100)
                return 'O';
            else if (average >= 80 && average < 90)
                return 'E';
            else if (average >= 70 && average < 80)
                return 'A';
            else if (average >= 55 && average < 70)
                return 'P';
            else if (average >= 40 && average < 55)
                return 'D';
            else if (average < 40)
                return 'T';
            return ' ';
        }

        private int GetScoresSum()
        {
            int sum = 0;
            for (int i = 0; i < testScores.Length; i++)
            {
                sum += testScores[i];
            }

            return sum;
        }
    }
}
