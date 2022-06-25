In order to EXECUTE - Add the following lines in Program.cs > Main method:

int N = Convert.ToInt32(Console.ReadLine().Trim());
bool isWeird = IsWeird(N);
Console.WriteLine(isWeird ? "Weird" : "Not Weird");

/*****Add the following method outside the Main method*****/

private static bool IsWeird(int n)
{
    if(n % 2 != 0)
        return true;
            
    if(n % 2 == 0 && (n >= 2 && n <= 5))
        return false;
            
    if(n % 2 == 0 && (n >= 6 && n <= 20))
        return true;
        
    if(n % 2 == 0 && n > 20)
        return false;
        
    return false;
}