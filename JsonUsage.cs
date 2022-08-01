// Requires NuGet Package: Newtonsoft.Json

// Write to a Json File
public static void UpdateFile()
{
    using (StreamWriter sw = File.CreateText(/* Directory */))
    {
        string SerializedJson = JsonConvert.SerializeObject(/* Note */, Formatting.Indented);
        sw.WriteLine(SerializedJson);
        sw.Close();
    }
}

// Read From Json File
List<InputString> ContentList = new List<InputString>();
string JsonFile = File.ReadAllText(/* Directory */);
ContentList = JsonConvert.DeserializeObject<List<InputString>>(JsonFile);
if(ContentList.Count() > 0)
{
    Console.WriteLine(ContentList.Count() + " were Found");
}
else
{
    Console.WriteLine("No Notes Were Found...");
}

class InputString
{
    public static string X { get; set; }
    public static string Y { get; set; }
}