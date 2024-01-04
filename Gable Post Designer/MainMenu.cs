using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Gable_Post_Designer
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void trial_btn_Click(object sender, EventArgs e)
        {
            DataReader dr = new DataReader();
            dr.ReadExcelCell("C:\\Users\\Billy\\source\\repos\\Gable Post Designer\\Gable Post Designer\\Member Info\\UB Sections.xls", 1 , 1);
        }
        private void YourForm_Load(object sender, EventArgs e)
        {
            // Assuming the Excel file path is stored in a variable named excelFilePath
            PopulateComboBoxFromExcel("C:\\Users\\Billy\\source\\repos\\Gable Post Designer\\Gable Post Designer\\Member Info\\UB Sections.xls", 1);
        }

        private void PopulateComboBoxFromExcel(string filePath, int column)
        {
            // Create a new application.
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(filePath);
            Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Excel.Range xlRange = xlWorksheet.UsedRange;

            try
            {
                // Assuming you have a ComboBox named comboBox1 on your form
                comboBox1.Items.Clear();  // Clear existing items

                // Get the number of rows in the column
                int rowCount = xlRange.Rows.Count;

                // Loop through the rows in the specified column and add them to the ComboBox
                for (int i = 1; i <= rowCount; i++)
                {
                    Excel.Range cell = xlRange.Cells[i, column];
                    if (cell != null && cell.Value2 != null)
                        comboBox1.Items.Add(cell.Value2.ToString());
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions, e.g., file not found, COM exceptions, etc.
                Console.WriteLine($"Error populating ComboBox: {ex.Message}");
            }
            finally
            {
                // Cleanup
                GC.Collect();
                GC.WaitForPendingFinalizers();
                Marshal.ReleaseComObject(xlRange);
                Marshal.ReleaseComObject(xlWorksheet);

                // Close and release
                xlWorkbook.Close();
                Marshal.ReleaseComObject(xlWorkbook);

                // Quit and release
                xlApp.Quit();
                Marshal.ReleaseComObject(xlApp);
            }
        }
    }
}
