/******In order to EXECUTE - Add the following lines in Program.cs > Main method:******/

ArrayDemo numbers = new ArrayDemo(3);
int[] array1 = { 30, 500, 11, 49 };
int[] array2 = { 0, 11, 30, 12 };
numbers.Print();
numbers.Insert(10);
numbers.Insert(20);
numbers.Insert(30);
numbers.Insert(40);
numbers.Insert(50);

numbers.Insert(500);
System.Console.WriteLine("the index of the element is " + numbers.IndexOf(20).ToString());
numbers.Print();
numbers.RemoveAt(2);
System.Console.WriteLine("Removing item...");
numbers.Print();
System.Console.WriteLine("Inserting item...");
System.Console.WriteLine("Maximum element is " + numbers.Max());

System.Console.WriteLine("Reversing the array...");
int[] reversedArray = numbers.Reverse();
for (int i = 0; i < reversedArray.Length; i++)
    System.Console.WriteLine(reversedArray[i]);

System.Console.WriteLine("intersecting the arrays...");
int[] intersect = ArrayDemo.Intersect(array1, array2);
for (int i = 0; i < intersect.Length; i++)
    System.Console.WriteLine(intersect[i]);

numbers.InsertAt(12, 1);
numbers.Print();