using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms._30DaysOfCode.Day_8
{
    public class DictionariesAndMaps
    {
        public static void ReadFromConsole()
        {
            Dictionary<string, int> phoneBook = new Dictionary<string, int>();
            List<string> foundRecords = new List<string>();

            int noOfRecords = Convert.ToInt32(Console.ReadLine().Trim());

            for (int i = 0; i < noOfRecords; i++)
            {
                var record = Console.ReadLine().TrimEnd().Split(' ');
                AddToDB(record, ref phoneBook);
            }

            string recordKey = Console.ReadLine();
            do
            {
                CreateFoundRecordsDB(recordKey.TrimEnd().ToLower(), phoneBook, ref foundRecords);

                recordKey = Console.ReadLine();
            }
            while (!string.IsNullOrEmpty(recordKey));

            DisplayFoundRecords(foundRecords);
        }

        public static void ReadFromFile()
        {
            Dictionary<string, int> phoneBook = new Dictionary<string, int>();
            List<string> foundRecords = new List<string>();

            string inputPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.GetDirectories("30DaysOfCode")[0].ToString(), "Day 8", "input.txt");

            using (StreamReader reader = File.OpenText(inputPath))
            {
                int noOfRecords = Convert.ToInt32(reader.ReadLine());

                for (int i = 0; i < noOfRecords; i++)
                {
                    var record = reader.ReadLine().TrimEnd().Split(' ');
                    AddToDB(record, ref phoneBook);
                }

                string recordKey = string.Empty;
                while ((recordKey = reader.ReadLine()) != null)
                {
                    CreateFoundRecordsDB(recordKey.TrimEnd().ToLower(), phoneBook, ref foundRecords);
                }

                WriteFoundRecordsToFile(foundRecords);
            }

            Console.WriteLine("Success");
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
            string outputPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.GetDirectories("30DaysOfCode")[0].ToString(), "Day 8", "output.txt");
            using StreamWriter file = new StreamWriter(outputPath);

            foreach (var record in foundRecords)
                file.WriteLine(record);
        }
    }
}
