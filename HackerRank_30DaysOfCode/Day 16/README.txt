/******In order to EXECUTE - Add the following lines in Program.cs > Main method:******/
// In order to get the output as per requirements the logic is implemented in Main()

string S = Console.ReadLine();
//AAConvert.ToInt(S);
try
{
    Console.WriteLine(int.Parse(S));
}
catch (System.Exception ex)
{
    Console.WriteLine("Bad String");
}