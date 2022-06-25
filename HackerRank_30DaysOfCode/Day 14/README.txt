/******In order to EXECUTE - Add the following lines in Program.cs > Main method:******/

Convert.ToInt32(Console.ReadLine());

int[] a = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

Difference d = new Difference(a);

d.ComputeDifference();

Console.Write(d.maximumDifference);