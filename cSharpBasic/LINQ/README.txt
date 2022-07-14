/*Copy-Paste in Main method:*/

int countOfEmployees = int.Parse(Console.ReadLine());

var employees = new List<Employee>();

for (int i = 0; i < countOfEmployees; i++)
{
    string str = Console.ReadLine();
    string[] strArr = str.Split(' ');
    employees.Add(new Employee
    {
        FirstName = strArr[0],
        LastName = strArr[1],
        Company = strArr[2],
        Age = int.Parse(strArr[3])
    });
}

foreach (var emp in AverageAgeForEachCompany(employees))
{
    Console.WriteLine($"The average age for company {emp.Key} is {emp.Value}");
}

foreach (var emp in CountOfEmployeesForEachCompany(employees))
{
    Console.WriteLine($"The count of employees for company {emp.Key} is {emp.Value}");
}

foreach (var emp in OldestAgeForEachCompany(employees))
{
    Console.WriteLine($"The oldest employee of company {emp.Key} is {emp.Value.FirstName} {emp.Value.LastName} having age {emp.Value.Age}");
}

/*  Call AverageAgeForEachCompany  in Main */
var coCreators = new CoCreatorsRepository().GetCoCreators();
var averageAgePerCompany = CompanyAc.AverageAgeForEachCompany(coCreators);

foreach(KeyValuePair<string, int> keyValue in averageAgePerCompany)
{
    Console.WriteLine(keyValue.Key + " " + keyValue.Value);
}



/*  Some examples   */
//  LINQ Query Operators
var youngerCoCreators =
    from c in coCreators
    where c.Age < 50
    orderby c.Company
    select c;

//  LINQ Extension Methods
var youngCoCreators = coCreators
    .Where(coCreator => coCreator.Age < 50)
    .GroupBy(c => c.Company)
    .Select(c => new { Company = c.Key });