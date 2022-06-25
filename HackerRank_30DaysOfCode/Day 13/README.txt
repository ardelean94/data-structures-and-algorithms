/******In order to EXECUTE - Add the following lines in Program.cs > Main method:******/

String title=Console.ReadLine();
String author=Console.ReadLine();
int price=Int32.Parse(Console.ReadLine());
Book new_novel=new MyBook(title,author,price);
new_novel.Display();