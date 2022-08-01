// Export a List to a Excel File with a OpenFileDialog

public void ExportToExcel(List<InputString> ExampleList)
{
    try
    {
        // Make a SaveFileDialog to get the location and file name to save to Excel

        SaveFileDialog saveDialog = new SaveFileDialog();
        saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
        saveDialog.FilterIndex = 1;
        saveDialog.RestoreDirectory = true;

        // Open the savefileDialog to get the file name and location to save to Excel
        if (saveDialog.ShowDialog() == DialogResult.OK)
        {
            Microsoft.Office.Interop.Excel.Application xlApp;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            xlApp = new Microsoft.Office.Interop.Excel.Application();
            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            xlWorkSheet.Cells[1, 1] = "InputX";
            xlWorkSheet.Cells[1, 2] = "InputY";
            int i;
            for (i = 0; i < ExampleList.Count; i++)
            {
                xlWorkSheet.Cells[i + 2, 1] = InputString[i].InputX;
                xlWorkSheet.Cells[i + 2, 2] = InputString[i].InputY;

            }
            i++;
            int alteri = i;
            i++;

            xlWorkSheet.Columns.AutoFit();
            xlWorkBook.SaveAs(saveDialog.FileName);
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();

            // Clean Up
            GC.Collect();
            GC.WaitForPendingFinalizers();

            // Release COM Objects
            if (xlWorkSheet != null)
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkSheet);
            }
            if (xlWorkBook != null)
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkBook);
            }
            if (xlApp != null)
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(xlApp);
            }

            // Make a Form Where you can Choose if you want to open the Excel File or not
            DialogResult result = MessageBox.Show("Do you want to open the Excel File?", "Open Excel File", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                // Open the Excel File
                Process.Start(saveDialog.FileName);
            }
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}

class InputString
{
    public static string X { get; set; }
    public static string Y { get; set; }
}