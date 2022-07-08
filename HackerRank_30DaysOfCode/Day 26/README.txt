/******In order to EXECUTE - Add the following lines in Program.cs > Main method:******/

string[] returnedDate = Console.ReadLine().Trim().Split(' ');
string[] dueDate = Console.ReadLine().Trim().Split(' ');
Console.WriteLine(Store.GetFine(returnedDate, dueDate));