/*	Add to Main:	*/

var notesStore = new NotesStore();
int noOfLines = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < noOfLines; i++)
{
    try
    {
        //  Input Structure
        //  MethodName state {name}
        string[] inputLine = Console.ReadLine().Trim().Split(' ');
        if (inputLine[0] == "AddNote")
        {
            notesStore.AddNote(inputLine[1], inputLine[2]);
        }
        else if (inputLine[0] == "GetNotes")
        {
            var notes = notesStore.GetNotes(inputLine[1]);
            notesStore.DisplayNotes(notes);
        }
        else
        {
            throw new Exception("Method name not recognized");
        }
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
}