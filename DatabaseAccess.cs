// Using Dapper, Get a List of strings returned from a Database in MSSQL 

public List<string> GetExample()
{
    try
    {
        using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(AlterNativeconnection()))
        {
            List<InputString> output = connection.Query<string>($"select Example FROM ExampleDB").ToList();
            return output;
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
        return null;
    }
}

// Just a Connection String

public static string AlterNativeconnection()
{
    return "Server=ExampleServer; Database=ExampleDB; User ID=ExampleUserName; Password=ExamplePassword;";
}

// Insert a New Entry into Database
public void CreateEntry(string InputX, string InputY)
{
    try
    {
        using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(AlterNativeconnection()))
        {
            List<InputString> Inputlist = new List<InputString>();

            Inputlist.Add(new InputString { X = InputX, Y = InputY });

            connection.Execute($"insert into /* Table Name */ (X, Y) values ('{X}', '{Y}')");
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}
// Update a Entry
public void UpdateEntry(string InputX, string InputY, string IDtoIdentify)
{
    using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(AlterNativeconnection()))
    {
        try
        {
            connection.Execute($"UPDATE /* Table Name */ SET X = '{InputX}', Y = '{InputY}' from /* DBName */ where ID = '{IDtoIdentify}'");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}

// Delete a Entry
public void DeleteEntry(string IDtoIdentify)
{
    using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(AlterNativeconnection()))
    {
        try
        {
            connection.Execute($"DELETE FROM /* Table Name */ Where ID = '{IDtoIdentify}'");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}

class InputString
{
    public static string X { get; set; }
    public static string Y { get; set; }
}