In order to EXECUTE - Add the following lines in Program.cs > Main method:

int T=int.Parse(Console.In.ReadLine());
for (int i = 0; i < T; i++) {
    int age=int.Parse(Console.In.ReadLine());
    Person p=new Person(age);
        p.AmIOld();
        for (int j = 0; j < 3; j++) {
            p.YearPasses();
        }
        p.AmIOld();
        Console.WriteLine();
}