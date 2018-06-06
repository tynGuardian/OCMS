using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using OCMS.MODEL;
using OCMS.Bussiness;
using NsExcel = Microsoft.Office.Interop.Excel;
using System.Diagnostics;
using System.Reflection;
using Microsoft.Win32;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using System.Data;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Text;

namespace OCMS.VIEW
{
    public partial class frmOMReport : Form
    {
        OMReportBusiness report = new OMReportBusiness();
        bool checkifExcelisInstalled;
        public frmOMReport()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.AppStarting;
            try
            {
                if (DTPTo.Value < DTPfrom.Value)
                {
                    MessageBox.Show("Invalid date range!", "OCMS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if(textBox1.Text == "")
                {
                    MessageBox.Show("Don't leave file path blank!", "OCMS",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
                else
                { 
                    int report_count;
                    OMReportBusiness _omReport = new OMReportBusiness();
                    List<OMReportModel> listOfEmployees = new List<OMReportModel>();
                    listOfEmployees = _omReport.getreport(DTPfrom.Text, DTPTo.Text).ToList();

                    report_count = _omReport.getreport(DTPfrom.Text, DTPTo.Text).Count;

                    if (checkifExcelisInstalled == true) //Check if the pc have Microsoft Excel Office
                    {
                        if (report_count > 0)
                        {
                            ListToExcel(listOfEmployees);
                            MessageBox.Show("You have successfully generate the report!", "OCMS",MessageBoxButtons.OK);
                        }
                        else
                        {
                            MessageBox.Show("No record found! Kindly choose another date range.", "OCMS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        if (report_count > 0)
                        {
                            CreateExcelDocument(listOfEmployees, textBox1.Text + "\\" + Properties.Settings.Default.Company + "_Clinic Operation utilization report from " + DTPfrom.Value.ToShortDateString().Replace((char)47, (char)45) + " to " + DTPTo.Value.ToShortDateString().Replace((char)47, (char)45) + "a.xlsx");
                            MessageBox.Show("Successfully Generate Report!", "OCMS", MessageBoxButtons.OK);
                        }
                        else
                        {
                            MessageBox.Show("No record found! Kindly choose another date range.", "OCMS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to display report!. Kindly coordinate this to you IT Department." + " ," + ex.Message, "OCMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Cursor.Current = Cursors.Default;
        }

        private void frmOMReport_Load(object sender, EventArgs e)
        {
            CheckExcel();
            DTPfrom.Text = DateTime.Now.ToString("MM/dd/yyyy");
            DTPTo.Text = DateTime.Now.ToString("MM/dd/yyyy");
        }
        private void ListToExcel(List<OMReportModel> list)
        {
            try
            {
                //start excel
                //NsExcel.ApplicationClass excapp = new Microsoft.Office.Interop.Excel.ApplicationClass();

                NsExcel.Application exapp = new NsExcel.Application();

                //if you want to make excel visible           

                exapp.Visible = false;

                //create a blank workbook
                var workbook = exapp.Workbooks.Add(NsExcel.XlWBATemplate.xlWBATWorksheet);
                
                //or open one - this is no pleasant, but yue're probably interested in the first parameter
                //string workbookPath = "D:/OMReportTemplate.xlsx";
                //string workbookPath = Application.StartupPath + "/OMReportTemplate.xlsx";

                //System.IO.File.Copy()
                string path = AppDomain.CurrentDomain.BaseDirectory.ToString() + "/OMReportTemplate.xlsx";

                string workbookPath = path;
                workbook = exapp.Workbooks.Open(workbookPath);
                
                //Not done yet. You have to work on a specific sheet - note the cast
                //You may not have any sheets at all. Then you have to add one with NsExcel.Worksheet.Add()
                var sheet = (NsExcel.Worksheet)workbook.Sheets[1]; //indexing starts from 1

                //do something usefull: you select now an individual cell
                var range = sheet.get_Range("A1", "A1");

                //now the list
                string cellName;
                int counter = 4;
                foreach (var item in list)
                {
                    cellName = "A" + counter.ToString();
                    range = sheet.get_Range(cellName, cellName);
                    range.Value2 = item.Employee_id;

                    cellName = "B" + counter.ToString();
                    range = sheet.get_Range(cellName, cellName);
                    range.Value2 = item.Employee_Name;

                    cellName = "C" + counter.ToString();
                    range = sheet.get_Range(cellName, cellName);
                    range.Value2 = item.Legal_Vehicle;

                    cellName = "D" + counter.ToString();
                    range = sheet.get_Range(cellName, cellName);
                    range.Value2 = "'" + item.created_date;

                    cellName = "E" + counter.ToString();
                    range = sheet.get_Range(cellName, cellName);
                    range.Value2 = "'" + Convert.ToDateTime(item.time_in).ToShortTimeString();

                    cellName = "F" + counter.ToString();
                    range = sheet.get_Range(cellName, cellName);
                    range.Value2 = "'" + Convert.ToDateTime(item.time_out).ToShortTimeString();

                    cellName = "G" + counter.ToString();
                    range = sheet.get_Range(cellName, cellName);
                    range.Value2 = item.Age;

                    cellName = "H" + counter.ToString();
                    range = sheet.get_Range(cellName, cellName);
                    range.Value2 = item.gender;

                    cellName = "I" + counter.ToString();
                    range = sheet.get_Range(cellName, cellName);
                    range.Value2 = item.complaint1;

                    cellName = "J" + counter.ToString();
                    range = sheet.get_Range(cellName, cellName);
                    range.Value2 = item.Medicine1;

                    cellName = "K" + counter.ToString();
                    range = sheet.get_Range(cellName, cellName);
                    range.Value2 = item.quantity1;

                    cellName = "L" + counter.ToString();
                    range = sheet.get_Range(cellName, cellName);
                    range.Value2 = item.complaint2;

                    cellName = "M" + counter.ToString();
                    range = sheet.get_Range(cellName, cellName);
                    range.Value2 = item.Medicine2;

                    cellName = "N" + counter.ToString();
                    range = sheet.get_Range(cellName, cellName);
                    range.Value2 = item.quantity2;

                    cellName = "O" + counter.ToString();
                    range = sheet.get_Range(cellName, cellName);
                    range.Value2 = item.complaint3;

                    cellName = "P" + counter.ToString();
                    range = sheet.get_Range(cellName, cellName);
                    range.Value2 = item.Medicine3;

                    cellName = "Q" + counter.ToString();
                    range = sheet.get_Range(cellName, cellName);
                    range.Value2 = item.quantity3;

                    cellName = "R" + counter.ToString();
                    range = sheet.get_Range(cellName, cellName);
                    range.Value2 = item.disposition;

                    cellName = "S" + counter.ToString();
                    range = sheet.get_Range(cellName, cellName);
                    range.Value2 = item.diagnosis;


                    ++counter;
                }
                workbook.SaveAs(textBox1.Text + "\\" + Properties.Settings.Default.Company + "_Clinic Operation utilization report from " + DTPfrom.Value.ToShortDateString().Replace((char)47, (char)45) + " to " + DTPTo.Value.ToShortDateString().Replace((char)47, (char)45),NsExcel.XlFileFormat.xlWorkbookNormal);

                exapp.Quit();
                exapp = null;
                GC.Collect();
                GC.WaitForPendingFinalizers();
                killExcel();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to display report! Kindly coordinate this to your IT Department." + " ," + ex.Message, "OCMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        static void ListToExcel(List<OMReportModel> lstEmps, string filePath)
        {
            using (SpreadsheetDocument spreedDoc = SpreadsheetDocument.Create(filePath, SpreadsheetDocumentType.Workbook))
            {
                WorkbookPart wbPart = spreedDoc.WorkbookPart;
                if (wbPart == null)
                {
                    wbPart = spreedDoc.AddWorkbookPart();
                    wbPart.Workbook = new Workbook();
                }
                spreedDoc.WorkbookPart.Workbook.Append(new BookViews(new WorkbookView()));

                string sheetName = "Sheet1";
                WorksheetPart worksheetPart = null;
                worksheetPart = wbPart.AddNewPart<WorksheetPart>();
                var sheetData = new SheetData();

                worksheetPart.Worksheet = new Worksheet(sheetData);

                if (wbPart.Workbook.Sheets == null)
                {
                    wbPart.Workbook.AppendChild<Sheets>(new Sheets());
                }

                var sheet = new Sheet()
                {
                    Id = wbPart.GetIdOfPart(worksheetPart),
                    SheetId = 1,
                    Name = sheetName
                };

                var workingSheet = ((WorksheetPart)wbPart.GetPartById(sheet.Id)).Worksheet;

                int rowindex = 0;
                foreach (var emp in lstEmps)
                {
                    Row row = new Row();
                    row.RowIndex = (UInt32)rowindex;

                    if (rowindex == 0) //Header 
                    {
                        row.AppendChild(AddCellWithText("Employee ID"));
                        row.AppendChild(AddCellWithText("Employee Name"));
                    }
                    else //Data 
                    {
                        row.AppendChild(AddCellWithText(emp.Employee_id));
                        row.AppendChild(AddCellWithText(emp.Employee_Name));
                    }

                    sheetData.AppendChild(row);
                    rowindex++;
                }

                wbPart.Workbook.Sheets.AppendChild(sheet);

                //Set Border 
                //wbPark
                worksheetPart.Worksheet.Save();
                wbPart.Workbook.Save();
                spreedDoc.Close();
            }
        }
        static Cell AddCellWithText(string text)
        {
            Cell c1 = new Cell();
            c1.DataType = CellValues.InlineString;

            InlineString inlineString = new InlineString();
            Text t = new Text();
            t.Text = text;
            inlineString.AppendChild(t);

            c1.AppendChild(inlineString);

            return c1;
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            textBox1.Text = folderBrowserDialog1.SelectedPath;
        }

        private void killExcel()
        {
            Process[] Processes;
            Processes = System.Diagnostics.

            Process.GetProcessesByName("EXCEL");

            foreach (System.Diagnostics.Process p in Processes)
            {
                if (p.MainWindowTitle.Trim() == "")
                    p.Kill();
            }

        }
        private void CheckExcel()
        {
            RegistryKey key = Registry.ClassesRoot;
            RegistryKey excelKey = key.OpenSubKey("Excel.Application");
            checkifExcelisInstalled = excelKey == null ? false : true;

        }
        public static bool CreateExcelDocument(DataSet ds, string excelFilename)
        {
            try
            {
                using (SpreadsheetDocument spreadsheet = SpreadsheetDocument.Create(excelFilename, SpreadsheetDocumentType.Workbook))
                {
                    WriteExcelFile(ds, spreadsheet);
                }
                Trace.WriteLine("Successfully created: " + excelFilename);
                return true;
            }
            catch (Exception ex)
            {
                Trace.WriteLine("Failed, exception thrown: " + ex.Message);
                return false;
            }
        }
        public static bool CreateExcelDocument<T>(List<T> list, string xlsxFilePath)
        {
            DataSet ds = new DataSet();
            ds.Tables.Add(ListToDataTable(list));
            using (SpreadsheetDocument spreadsheet = SpreadsheetDocument.Create(xlsxFilePath, SpreadsheetDocumentType.Workbook))
            {
                WriteExcelFile(ds, spreadsheet);
            }
            Trace.WriteLine("Successfully created: " + xlsxFilePath);
            return true;
        }
        public static DataTable ListToDataTable<T>(List<T> list)
        {
            DataTable dt = new DataTable();

            foreach (PropertyInfo info in typeof(T).GetProperties())
            {
                dt.Columns.Add(new DataColumn(info.Name, GetNullableType(info.PropertyType)));
            }
            foreach (T t in list)
            {
                DataRow row = dt.NewRow();
                foreach (PropertyInfo info in typeof(T).GetProperties())
                {
                    if (!IsNullableType(info.PropertyType))
                        row[info.Name] = info.GetValue(t, null);
                    else
                        row[info.Name] = (info.GetValue(t, null) ?? DBNull.Value);
                }
                dt.Rows.Add(row);
            }
            return dt;
        }
        
        private static void WriteExcelFile(DataSet ds, SpreadsheetDocument spreadsheet)
        {
            //  Create the Excel file contents.  This function is used when creating an Excel file either writing 
            //  to a file, or writing to a MemoryStream.
            spreadsheet.AddWorkbookPart();
            spreadsheet.WorkbookPart.Workbook = new DocumentFormat.OpenXml.Spreadsheet.Workbook();

            //  My thanks to James Miera for the following line of code (which prevents crashes in Excel 2010)
            spreadsheet.WorkbookPart.Workbook.Append(new BookViews(new WorkbookView()));

            //  If we don't add a "WorkbookStylesPart", OLEDB will refuse to connect to this .xlsx file !
            WorkbookStylesPart workbookStylesPart = spreadsheet.WorkbookPart.AddNewPart<WorkbookStylesPart>("rIdStyles");
            Stylesheet stylesheet = new Stylesheet();
            workbookStylesPart.Stylesheet = stylesheet;


            //  Loop through each of the DataTables in our DataSet, and create a new Excel Worksheet for each.
            uint worksheetNumber = 1;
            Sheets sheets = spreadsheet.WorkbookPart.Workbook.AppendChild<Sheets>(new Sheets());
            foreach (DataTable dt in ds.Tables)
            {
                //  For each worksheet you want to create
                string worksheetName = dt.TableName;

                //  Create worksheet part, and add it to the sheets collection in workbook
                WorksheetPart newWorksheetPart = spreadsheet.WorkbookPart.AddNewPart<WorksheetPart>();
                Sheet sheet = new Sheet() { Id = spreadsheet.WorkbookPart.GetIdOfPart(newWorksheetPart), SheetId = worksheetNumber, Name = worksheetName };

                // If you want to define the Column Widths for a Worksheet, you need to do this *before* appending the SheetData
                // http://social.msdn.microsoft.com/Forums/en-US/oxmlsdk/thread/1d93eca8-2949-4d12-8dd9-15cc24128b10/

                sheets.Append(sheet);

                //  Append this worksheet's data to our Workbook, using OpenXmlWriter, to prevent memory problems
                WriteDataTableToExcelWorksheet(dt, newWorksheetPart);

                worksheetNumber++;
            }

            spreadsheet.WorkbookPart.Workbook.Save();
        }
        private static Type GetNullableType(Type t)
        {
            Type returnType = t;
            if (t.IsGenericType && t.GetGenericTypeDefinition().Equals(typeof(Nullable<>)))
            {
                returnType = Nullable.GetUnderlyingType(t);
            }
            return returnType;
        }
        private static bool IsNullableType(Type type)
        {
            return (type == typeof(string) ||
                    type.IsArray ||
                    (type.IsGenericType &&
                     type.GetGenericTypeDefinition().Equals(typeof(Nullable<>))));
        }
        private static void WriteDataTableToExcelWorksheet(DataTable dt, WorksheetPart worksheetPart)
        {
            OpenXmlWriter writer = OpenXmlWriter.Create(worksheetPart, Encoding.ASCII);
            writer.WriteStartElement(new Worksheet());
            writer.WriteStartElement(new SheetData());

            string cellValue = "";
            string cellReference = "";

            //  Create a Header Row in our Excel file, containing one header for each Column of data in our DataTable.
            //
            //  We'll also create an array, showing which type each column of data is (Text or Numeric), so when we come to write the actual
            //  cells of data, we'll know if to write Text values or Numeric cell values.
            int numberOfColumns = dt.Columns.Count;
            bool[] IsIntegerColumn = new bool[numberOfColumns];
            bool[] IsFloatColumn = new bool[numberOfColumns];
            bool[] IsDateColumn = new bool[numberOfColumns];

            string[] excelColumnNames = new string[numberOfColumns];
            for (int n = 0; n < numberOfColumns; n++)
                excelColumnNames[n] = GetExcelColumnName(n);

            //
            //  Create the Header row in our Excel Worksheet
            //
            uint rowIndex = 1;

            writer.WriteStartElement(new Row { RowIndex = rowIndex });
            for (int colInx = 0; colInx < numberOfColumns; colInx++)
            {
                DataColumn col = dt.Columns[colInx];
                AppendHeaderTextCell(excelColumnNames[colInx] + "1", col.ColumnName, writer);
                IsIntegerColumn[colInx] = (col.DataType.FullName.StartsWith("System.Int"));
                IsFloatColumn[colInx] = (col.DataType.FullName == "System.Decimal") || (col.DataType.FullName == "System.Double") || (col.DataType.FullName == "System.Single");
                IsDateColumn[colInx] = (col.DataType.FullName == "System.DateTime");

            }
            writer.WriteEndElement();   //  End of header "Row"

            //
            //  Now, step through each row of data in our DataTable...
            //
            double cellFloatValue = 0;
            CultureInfo ci = new CultureInfo("en-US");
            foreach (DataRow dr in dt.Rows)
            {
                // ...create a new row, and append a set of this row's data to it.
                ++rowIndex;

                writer.WriteStartElement(new Row { RowIndex = rowIndex });

                for (int colInx = 0; colInx < numberOfColumns; colInx++)
                {
                    cellValue = dr.ItemArray[colInx].ToString();
                    cellValue = ReplaceHexadecimalSymbols(cellValue);
                    cellReference = excelColumnNames[colInx] + rowIndex.ToString();

                    // Create cell with data
                    if (IsIntegerColumn[colInx] || IsFloatColumn[colInx])
                    {
                        //  For numeric cells without any decimal places.
                        //  If this numeric value is NULL, then don't write anything to the Excel file.
                        cellFloatValue = 0;
                        if (double.TryParse(cellValue, out cellFloatValue))
                        {
                            cellValue = cellFloatValue.ToString(ci);
                            AppendNumericCell(cellReference, cellValue, writer);
                        }
                    }
                    else if (IsDateColumn[colInx])
                    {
                        //  This is a date value.
                        DateTime dateValue;
                        if (DateTime.TryParse(cellValue, out dateValue))
                        {
                            AppendDateCell(cellReference, dateValue, writer);
                        }
                        else
                        {
                            //  This should only happen if we have a DataColumn of type "DateTime", but this particular value is null/blank.
                            AppendTextCell(cellReference, cellValue, writer);
                        }
                    }
                    else
                    {
                        //  For text cells, just write the input data straight out to the Excel file.
                        AppendTextCell(cellReference, cellValue, writer);
                    }
                }
                writer.WriteEndElement(); //  End of Row
            }
            writer.WriteEndElement(); //  End of SheetData
            writer.WriteEndElement(); //  End of worksheet

            writer.Close();
        }
        public static string GetExcelColumnName(int columnIndex)
        {
            //  eg  (0) should return "A"
            //      (1) should return "B"
            //      (25) should return "Z"
            //      (26) should return "AA"
            //      (27) should return "AB"
            //      ..etc..
            char firstChar;
            char secondChar;
            char thirdChar;

            if (columnIndex < 26)
            {
                return ((char)('A' + columnIndex)).ToString();
            }

            if (columnIndex < 702)
            {
                firstChar = (char)('A' + (columnIndex / 26) - 1);
                secondChar = (char)('A' + (columnIndex % 26));

                return string.Format("{0}{1}", firstChar, secondChar);
            }

            int firstInt = columnIndex / 676;
            int secondInt = (columnIndex % 676) / 26;
            if (secondInt == 0)
            {
                secondInt = 26;
                firstInt = firstInt - 1;
            }
            int thirdInt = (columnIndex % 26);

            firstChar = (char)('A' + firstInt - 1);
            secondChar = (char)('A' + secondInt - 1);
            thirdChar = (char)('A' + thirdInt);

            return string.Format("{0}{1}{2}", firstChar, secondChar, thirdChar);
        }
        private static void AppendTextCell(string cellReference, string cellStringValue, OpenXmlWriter writer)
        {
            //  Add a new "text" Cell to our Row 

#if DATA_CONTAINS_FORMULAE
            //  If this item of data looks like a formula, let's store it in the Excel file as a formula rather than a string.
            if (cellStringValue.StartsWith("="))
            {
                AppendFormulaCell(cellReference, cellStringValue, writer);
                return;
            }
#endif

            //  Add a new Excel Cell to our Row 
            writer.WriteElement(new Cell
            {
                CellValue = new CellValue(cellStringValue),
                CellReference = cellReference,
                DataType = CellValues.String
            });
        }

        private static void AppendDateCell(string cellReference, DateTime dateTimeValue, OpenXmlWriter writer)
        {
            //  Add a new "datetime" Excel Cell to our Row.
            //
            string cellStringValue = dateTimeValue.ToShortDateString();

            writer.WriteElement(new Cell
            {
                CellValue = new CellValue(cellStringValue),
                CellReference = cellReference,
                DataType = CellValues.String
            });
        }

        private static void AppendFormulaCell(string cellReference, string cellStringValue, OpenXmlWriter writer)
        {
            //  Add a new "formula" Excel Cell to our Row 
            writer.WriteElement(new Cell
            {
                CellFormula = new CellFormula(cellStringValue),
                CellReference = cellReference,
                DataType = CellValues.Number
            });
        }

        private static void AppendNumericCell(string cellReference, string cellStringValue, OpenXmlWriter writer)
        {
            //  Add a new numeric Excel Cell to our Row.
            writer.WriteElement(new Cell
            {
                CellValue = new CellValue(cellStringValue),
                CellReference = cellReference,
                DataType = CellValues.Number
            });
        }
        private static void AppendHeaderTextCell(string cellReference, string cellStringValue, OpenXmlWriter writer)
        {
            //  Add a new "text" Cell to the first row in our Excel worksheet
            //  We set these cells to use "Style # 3", so they have a gray background color & white text.
            writer.WriteElement(new Cell
            {
                CellValue = new CellValue(cellStringValue),
                CellReference = cellReference,
                DataType = CellValues.String
            });
        }
        private static string ReplaceHexadecimalSymbols(string txt)
        {
            string r = "[\x00-\x08\x0B\x0C\x0E-\x1F\x26]";
            return Regex.Replace(txt, r, "", RegexOptions.Compiled);
        }
    }
}
