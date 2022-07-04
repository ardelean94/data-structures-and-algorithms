/******In order to EXECUTE - Add the following lines in Program.cs > Main method:******/


HackerRank_30DaysOfCode.Day_22.Node root = null;
int T = Int32.Parse(Console.ReadLine());
while (T-- > 0)
{
    int data = Int32.Parse(Console.ReadLine());
    root = HackerRank_30DaysOfCode.Day_22.BinarySearchTree.Insert(root, data);
}
int height = HackerRank_30DaysOfCode.Day_22.BinarySearchTree.GetHeight(root);
Console.WriteLine(height);