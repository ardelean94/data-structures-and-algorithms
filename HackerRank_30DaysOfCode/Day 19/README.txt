/******In order to EXECUTE - Add the following lines in Program.cs > Main method:******/

int n = Int32.Parse(Console.ReadLine());
var myCalculator = new HackerRank_30DaysOfCode.Day_19.Calculator();
int sum = myCalculator.DivisorSum(n);
Console.WriteLine("I implemented: AdvancedArithmetic\n" + sum);