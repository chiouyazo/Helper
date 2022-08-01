// Removes the Border And Buttons of a Window, so it can be custom made

public const int WM_NCLBUTTONDOWN = 0xA1;
public const int HT_CAPTION = 0x2;
[System.Runtime.InteropServices.DllImport("user32.dll")]
public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
[System.Runtime.InteropServices.DllImport("user32.dll")]
public static extern bool ReleaseCapture();

// If you are Using Winforms, you can use the MouseDown Event on a Object, so the window can be dragged arround
private void /* Object Name */ (object sender, MouseEventArgs e)
{
    /* Object Name */.BackColor = Color.DarkGray;
    if (e.Button == MouseButtons.Left)
    {
        ReleaseCapture();
        SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
    }
}