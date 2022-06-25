In order to EXECUTE - Add the following lines in Program.cs > Main method:

int i = 4;
double d = 4.0;
string s = "HackerRank ";

        
// Declare second integer, double, and String variables.
int i2;
double d2;
string s2;

// Read and save an integer, double, and String to your variables.
i2 = int.Parse(Console.ReadLine());
d2 = double.Parse(Console.ReadLine());
s2 = Console.ReadLine();

// Print the sum of both integer variables on a new line.
Console.WriteLine(i2 + i);
// Print the sum of the double variables on a new line.
Console.WriteLine(string.Format("{0:0.0}", d2 + d));
// Concatenate and print the String variables on a new line
// The 's' variable above should be printed first.
Console.WriteLine(s + s2);