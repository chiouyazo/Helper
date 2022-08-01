// Returns All Lines of a File To a String Array
string[] Lines = File.ReadAllLines(/* Directory */);

// Writes to A New File Using a FileStream, Also it Replaces the File, if it Already Exists
using (FileStream fs = File.Create(/* Directory + File */))
{
    Byte[] info = new UTF8Encoding(true).GetBytes(/* Content For File */);
    fs.Write(info, 0, info.Length);
}

// Writes to a Already Existing File, with a StreamWriter
using (StreamWriter sw = File.AppendText(/* Directory */))
{
    sw.WriteLine(/* File Contents */);
}