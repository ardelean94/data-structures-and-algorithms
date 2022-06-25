/******In order to EXECUTE - Add the following lines in Program.cs > Main method:******/

//  Day 11 2D Array
List<List<int>> arr = new List<List<int>>();

for (int i = 0; i < 3; i++)
{
    arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
}
Console.WriteLine(ArrayHourGlass.GetMaxSumHourGlass(arr));