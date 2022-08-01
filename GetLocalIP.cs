// Simply Gets Your Local IP

string localIP;
using (Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, 0))
{
    socket.Connect("8.8.8.8", 65530);
    IPEndPoint endPoint = socket.LocalEndPoint as IPEndPoint;
    localIP = endPoint.Address.ToString();
}