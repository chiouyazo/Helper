// Quickly Open a DB Connection with a Given Timeout, to see if the server is Online/Reachable

public static bool connectSuccess = false;
public static void QuickOpen(this IDbConnection conn, int timeout)
{
    // We'll use a Stopwatch here for simplicity. A comparison to a stored DateTime.Now value could also be used
    Stopwatch sw = new Stopwatch();

    // Try to open the connection, if anything goes wrong, make sure we set connectSuccess = false
    Thread t = new Thread(delegate ()
    {
        try
        {
            sw.Start();
            conn.Open();
            connectSuccess = true;
        }
        catch { }
    });
    // Make sure it's marked as a background thread so it'll get cleaned up automatically
    t.IsBackground = true;
    t.Start();

    // Keep trying to join the thread until we either succeed or the timeout value has been exceeded
    while (timeout > sw.ElapsedMilliseconds)
    {
        if (t.Join(1))
        {
            break;
        }
    }
}