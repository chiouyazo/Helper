// Get Contents From a Line, to a Other Line from a File

List<string> Content = new List<Content>();
List<InputString> Notes = new List<InputString>();

int NoteCount;

for (int i = 0; i < Content.Length; i++)
{
    List<string> localContent = new List<string>();
    if (Content[i].Contains("{{TITLE:"))
    {
        int BLine = (i + 1);
        Notes.Add(new Note { X = BLine, Y = ""});
    }
    else if (Content[i].Contains("END}}"))
    {
        Notes[NoteCount].Y = i;
        NoteCount++;    
    }
    else if (i != 0)
    {
        Notes[NoteCount].CONTENT.Add(Content[i]);
    }
}

class InputString
{
    public static string X { get; set; }
    public static string Y { get; set; }
}