// Gets All Drives, and can then be Used in a Array

DriveInfo[] allDrives = DriveInfo.GetDrives();

if (allDrives[0].IsReady)
{
    Console.WriteLine(allDrives[0].Name);
    Console.WriteLine(allDrives[0].DriveFormat.ToString());
}
else
{
    Console.WriteLine("Drive Not Ready or Found!");
}