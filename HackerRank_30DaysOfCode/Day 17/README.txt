/******In order to EXECUTE - Add the following lines in Program.cs > Main method:******/

Calculator myCalculator = new Calculator();
int T = Int32.Parse(Console.ReadLine());
while (T-- > 0)
{
    string[] num = Console.ReadLine().Split();
    int n = int.Parse(num[0]);
    int p = int.Parse(num[1]);
    try
    {
        int ans = myCalculator.Power(n, p);
        Console.WriteLine(ans);
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
}