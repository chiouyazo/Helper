
DriveInfo[] allDrives = DriveInfo.GetDrives();

if (allDrives[0].IsReady)
{
    label16.Text = allDrives[0].Name;
    label20.Text = allDrives[0].DriveFormat.ToString();
}
else
{
    label17.Text = "Drive Not Ready or Found!";
    label19.Text = "";
}