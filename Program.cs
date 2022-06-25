using DataStructuresAndAlgorithms.Arrays;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;
using System.IO;

namespace DataStructuresAndAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayDemo numbers = new ArrayDemo(3);
            //int[] array1 = { 30, 500, 11, 49 };
            //int[] array2 = { 0, 11, 30, 12 };
            //numbers.Print();
            //numbers.Insert(10);
            //numbers.Insert(20);
            //numbers.Insert(30);
            //numbers.Insert(40);           
            //numbers.Insert(50);

            //numbers.Insert(500);
            //System.Console.WriteLine("the index of the element is " +  numbers.IndexOf(20).ToString());
            //numbers.Print();
            //numbers.RemoveAt(2);
            //System.Console.WriteLine("Removing item...");
            //numbers.Print();
            //System.Console.WriteLine("Inserting item...");
            //System.Console.WriteLine("Maximum element is " + numbers.Max());

            //System.Console.WriteLine("Reversing the array...");
            //int[] reversedArray = numbers.Reverse();
            //for(int i = 0; i < reversedArray.Length; i++)
            //    System.Console.WriteLine(reversedArray[i]);

            //System.Console.WriteLine("intersecting the arrays...");
            //int[] intersect = ArrayDemo.Intersect(array1, array2);
            //for(int i = 0; i < intersect.Length; i++)
            //    System.Console.WriteLine(intersect[i]);

            //numbers.InsertAt(12, 1);
            //numbers.Print();

            ////    Day 4
            ////ReadLine() - returns a string
            //Console.WriteLine("Your favorite time of the day is: \n");
            //string value = Console.ReadLine();
            //Console.WriteLine("\nAwesome time of the day is " + value);

            ////Read() - returns the ASCII code of the single character input
            //Console.WriteLine("The character is: \n");
            //int value = Console.Read();
            //Console.WriteLine("\nIts ASCII Code is " + value.ToString());

            ////ReadKey() - obtains the next character or function key pressed by the user
            //Console.WriteLine("Press any key and it will be displayed on the screen:\n");
            //ConsoleKeyInfo key = Console.ReadKey();
            //Console.WriteLine(key.Key);

            ////    Day 5

            //var person = new Person(-2);
            ////person.YearPasses();
            //person.AmIOld();

            //int T = int.Parse(Console.In.ReadLine());
            //for (int i = 0; i < T; i++)
            //{
            //    int age = int.Parse(Console.In.ReadLine());
            //    Person p = new Person(age);
            //    p.AmIOld();
            //    for (int j = 0; j < 3; j++)
            //    {
            //        p.YearPasses();
            //    }
            //    p.AmIOld();
            //    Console.WriteLine();
            //}

            ////   Day 6
            //Console.WriteLine("How many test cases would you like to test?\n");
            //int noOfStrings = Convert.ToInt32(Console.ReadLine());
            //string[] inputs = new string[noOfStrings];

            //for(int i = 0; i < noOfStrings; i++)
            //{
            //    inputs[i] = Console.ReadLine();
            //}

            //// print on a single line
            //for (int i = 0; i < inputs.Length; i++)
            //{
            //    GetIndexedCharacters(inputs[i]);
            //}

            ////  Day 7
            //int n = Convert.ToInt32(Console.ReadLine().Trim());
            //List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
            //Console.WriteLine(GetReversedArray(arr));

            ////  Day 8 - Dictionaries & Maps
            //Dictionary<string, int> phoneBook = new Dictionary<string, int>();
            //List<string> foundRecords = new List<string>();

            ////  1. Read from console input
            //int noOfRecords = Convert.ToInt32(Console.ReadLine().Trim());

            //for (int i = 0; i < noOfRecords; i++)
            //{
            //    var record = Console.ReadLine().TrimEnd().Split(' ');
            //    AddToDB(record, ref phoneBook);
            //}

            //string recordKey = Console.ReadLine();
            //do
            //{
            //    CreateFoundRecordsDB(recordKey.TrimEnd().ToLower(), phoneBook, ref foundRecords);

            //    recordKey = Console.ReadLine();
            //}
            //while (!string.IsNullOrEmpty(recordKey));

            //DisplayFoundRecords(foundRecords);



            ////  2. Read from file
            //string inputPath = @"C:\Users\Alex\Desktop\input.txt";

            //using (StreamReader reader = File.OpenText(inputPath))
            //{
            //    int noOfRecords = Convert.ToInt32(reader.ReadLine());

            //    for (int i = 0; i < noOfRecords; i++)
            //    {
            //        var record = reader.ReadLine().TrimEnd().Split(' ');
            //        AddToDB(record, ref phoneBook);
            //    }

            //    string recordKey = string.Empty;
            //    while ((recordKey = reader.ReadLine()) != null)
            //    {
            //        CreateFoundRecordsDB(recordKey.TrimEnd().ToLower(), phoneBook, ref foundRecords);
            //    }

            //    WriteFoundRecordsToFile(foundRecords);
            //}

            ////  Day 9 Recursion
            //int number = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(factorial(number));

            ////  Day 10 Binary Numbers
            //int n = Convert.ToInt32(Console.ReadLine().Trim());
            //Console.WriteLine(GetMaximumConsecutivesOne(n));

            //  Day 11 2D Array
            //List<List<int>> arr = new List<List<int>>();

            //for (int i = 0; i < 3; i++)
            //{
            //    arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            //}
            //Console.WriteLine(GetMaxSumHourGlass(arr));

            //  Day 12 Inheritance
            string[] inputs = Console.ReadLine().Split();
            string firstName = inputs[0];
            string lastName = inputs[1];
            int id = Convert.ToInt32(inputs[2]);
            int numScores = Convert.ToInt32(Console.ReadLine());
            inputs = Console.ReadLine().Split();
            int[] scores = new int[numScores];
            for (int i = 0; i < numScores; i++)
            {
                scores[i] = Convert.ToInt32(inputs[i]);
            }

            Student s = new Student(firstName, lastName, id, scores);
            s.printPerson();
            Console.WriteLine("Grade: " + s.Calculate() + "\n");
        }

        private static int GetMaxSumHourGlass(List<List<int>> arr)
        {
            int max = 0;
            int rowStartIteration = 0;
            int colStartIteration = 0;

            int[,] pattern = InitPattern();
            int[,] hourglass = GetHourGlass(arr, pattern);
            int hourglassSum = GetSumHourglass(hourglass);

            if (hourglassSum > max)
                max = hourglassSum;

            return max;
            
        }

        private static int[,] GetHourGlass(List<List<int>> array, int[,] pattern)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if(!((i == 1 && j == 0) || (i == 1 && j == 2)))
                    {
                        pattern[i, j] = array[i][j];
                    }
                }
            }

            return pattern;
        }

        private static int GetSumHourglass(int[,] array)
        {
            int sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    sum += array[i, j];
                }
            }

            return sum;
        }

        private static int[,] InitPattern()
        {
            int[,] pattern = new int[3, 3];
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    pattern[i, j] = 0;

            return pattern;
        }

        private static int GetMaximumConsecutivesOne(int n)
        {
            if (n < 1)
                return 0;

            int sum = 0;
            int max = 0;
            var binaryNumber = ToBinaryBase(n);
            while (binaryNumber.Count != 0)
            {
                int bit = binaryNumber.Pop();
                if (bit == 1)
                {
                    sum++;
                }
                else
                {
                    if(sum > max)
                        max = sum;
                    sum = 0;
                }

                //  check last element
                if (binaryNumber.Count == 0 && sum > max)
                    max = sum;
            }

            return max;
        }

        private static Stack<int> ToBinaryBase(int n)
        {
            var binaryOutput = new Stack<int>();
            int number = n;
            while(number != 0)
            {
                int remainder = number % 2;
                binaryOutput.Push(remainder);
                number /= 2;
            }

            return binaryOutput;
        }

        private static int factorial(int n)
        {
            if (n > 1)
                return n * factorial(n - 1);

            if (n == 1)
                return n;

            return n;
        }

        private static void AddToDB(string[] record, ref Dictionary<string, int> phoneBook)
        {
            if (!phoneBook.ContainsKey(record[0].ToLower()) && record.Length == 2)
                phoneBook.Add(record[0].ToLower(), Convert.ToInt32(record[1]));
        }

        private static void CreateFoundRecordsDB(string key, Dictionary<string, int> database, ref List<string> foundRecords)
        {
            if (database.ContainsKey(key))
                foundRecords.Add(key + "=" + database[key].ToString());
            else
                foundRecords.Add("Not found");
        }

        private static void DisplayFoundRecords(List<string> foundRecords)
        {
            foreach (var record in foundRecords)
                Console.WriteLine(record);
        }

        private static void WriteFoundRecordsToFile(List<string> foundRecords)
        {
            string outputPath = @"C:\Users\Alex\Desktop\output.txt";
            using StreamWriter file = new StreamWriter(outputPath);

            foreach (var record in foundRecords)
                file.WriteLine(record);
        }

        private static void GetIndexedCharacters(string input)
        {
            var evenIndices = new StringBuilder();
            var oddIndices = new StringBuilder();

            char[] inputCharacters = input.ToArray();
            for (int i = 0; i < inputCharacters.Length; i++)
            {
                if (i % 2 == 0)
                    evenIndices.Append(inputCharacters[i]);
                else
                    oddIndices.Append(inputCharacters[i]);
            }

            Console.WriteLine(evenIndices + " " + oddIndices);
        }

        private static StringBuilder GetReversedArray(List<int> array)
        {
            array.Reverse();
            var arr = array.ToArray();
            var output = new StringBuilder();

            for (int i = 0; i < arr.Length; i++)
                output.Append(arr[i] + " ");

            return output;
        }
    }
}
