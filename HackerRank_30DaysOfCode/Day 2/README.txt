In order to EXECUTE - Add the following lines in Program.cs > Main method:

double meal_cost = Convert.ToDouble(Console.ReadLine().Trim());

int tip_percent = Convert.ToInt32(Console.ReadLine().Trim());

int tax_percent = Convert.ToInt32(Console.ReadLine().Trim());

Result.Solve(meal_cost, tip_percent, tax_percent);