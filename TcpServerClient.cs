// Simple TCP Listener that Listens for data on a new Thread, so it doesnt Block Off Anything, and then returns the received data to the sender.
// Should be Put into a Try, so it doesnt Stop the Program

public static int Port = 9060;
public static TcpListener listener = new TcpListener(System.Net.IPAddress.Any, Port);

listener.Start();
while(true)
{
    Console.WriteLine("Waiting for a connection.");
    TcpClient client = listener.AcceptTcpClient();
    Console.WriteLine("Client accepted.");
    NetworkStream stream = client.GetStream();
    StreamReader sr = new StreamReader(client.GetStream());
    StreamWriter sw = new StreamWriter(client.GetStream());
    try
    {
        byte[] buffer = new byte[1024];
        stream.Read(buffer, 0, buffer.Length);
        int recv = 0;
        foreach(byte b in buffer)
        {
            if(b != 0)
            {
                recv++;
            }
        }
        string request = Encoding.ASCII.GetString(buffer, 0, recv);
        Console.WriteLine("request received: " + request);
        sw.WriteLine(request);
        sw.Flush();
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
        sw.WriteLine(e.ToString());
    }
}

// Simple TCP Client that Can Send Data
// Should be put into a try, so it doesnt Stop the Program

TcpClient client = new TcpClient(/* Own Local IP, For Testing on Own PC, use e.g. 127.0.0.1 */, /* Port */);

string messageToSend = "Example Message";

int byteCount = Encoding.ASCII.GetByteCount(messageToSend + 1);
byte[] sendData = new byte[byteCount];
sendData = Encoding.ASCII.GetBytes(messageToSend);

NetworkStream stream = client.GetStream();
stream.Write(sendData, 0, sendData.Length);
Console.WriteLine("Sending Data to Server....\n");
StreamReader sr = new StreamReader(stream);
string response = sr.ReadLine();
Console.WriteLine($"Response: {response}");

stream.Close();
client.Close();