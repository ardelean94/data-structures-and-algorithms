In order to EXECUTE - Add the following lines in Program.cs > Main method:

int n = Convert.ToInt32(Console.ReadLine().Trim());
        
int m = 10;
for(int i = 1; i <= m; i++){
    Console.WriteLine($"{n} x {i} = {n*i}");
}