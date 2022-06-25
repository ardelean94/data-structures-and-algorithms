/******In order to EXECUTE - Add the following lines in Program.cs > Main method:******/

int n = Convert.ToInt32(Console.ReadLine().Trim());
List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
Console.WriteLine(GetReversedArray(arr));


/******Add this method outside the Main method******/

private static StringBuilder GetReversedArray(List<int> array)
{
    array.Reverse();
    var arr = array.ToArray();
    var output = new StringBuilder();

    for (int i = 0; i < arr.Length; i++)
        output.Append(arr[i] + " ");

    return output;
}