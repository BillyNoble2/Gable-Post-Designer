using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace Gable_Post_Designer
{
    public class DataReader
    {
        public string ReadExcelCell(string filePath, int row, int column)
        {
            // Create a new application.
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(filePath);
            Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Excel.Range xlRange = xlWorksheet.UsedRange;

            string cellValue = "";  // Variable to store the cell value

            try
            {
                // Ensure the row and column are within the used range
                if (row <= xlRange.Rows.Count && column <= xlRange.Columns.Count)
                {
                    Excel.Range cell = xlRange.Cells[row, column];
                    if (cell != null && cell.Value2 != null)
                        cellValue = cell.Value2.ToString();
                }
                else
                {
                    // Handle the case when the specified cell is out of range
                    Console.WriteLine("Specified cell is out of range.");
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions, e.g., file not found, COM exceptions, etc.
                Console.WriteLine($"Error reading Excel cell: {ex.Message}");
            }
            finally
            {
                // Cleanup
                GC.Collect();
                GC.WaitForPendingFinalizers();
                //Marshal.ReleaseComObject(xlRange);
                //Marshal.ReleaseComObject(xlWorksheet);

                // Close and release
                xlWorkbook.Close();
                //Marshal.ReleaseComObject(xlWorkbook);

                // Quit and release
                xlApp.Quit();
                //Marshal.ReleaseComObject(xlApp);
            }

            return cellValue;
        }
        
    }
}
