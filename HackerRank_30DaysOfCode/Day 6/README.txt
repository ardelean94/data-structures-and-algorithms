/******In order to EXECUTE - Add the following lines in Program.cs > Main method:******/

/* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
int noOfStrings = Convert.ToInt32(Console.ReadLine());
string[] inputs = new string[noOfStrings];
        
for(int i = 0; i < noOfStrings; i++)
{
    inputs[i] = Console.ReadLine();
}

// print on a single line
for (int i = 0; i < inputs.Length; i++)
{
    GetIndexedCharacters(inputs[i]);
}


/******Add this method outside the Main method******/

private static void GetIndexedCharacters(string input)
{
    var evenIndices = new StringBuilder();
    var oddIndices = new StringBuilder();

    char[] inputCharacters = input.ToArray();
    for (int i = 0; i < inputCharacters.Length; i++)
    {
        if (i % 2 == 0)
            evenIndices.Append(inputCharacters[i]);
        else
            oddIndices.Append(inputCharacters[i]);
    }

    Console.WriteLine(evenIndices + " " + oddIndices);
}