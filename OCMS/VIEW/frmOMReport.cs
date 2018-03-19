using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using OCMS.MODEL;
using OCMS.Bussiness;
using NsExcel = Microsoft.Office.Interop.Excel;
using System.Diagnostics;


namespace OCMS.VIEW
{
    public partial class frmOMReport : Form
    {
        OMReportBusiness report = new OMReportBusiness();
        public frmOMReport()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //report.getreport(DTPfrom.Text, DTPTo.Text);
            OMReportBusiness _omReport = new OMReportBusiness();
            if (_omReport.getreport(DTPfrom.Text, DTPTo.Text).ToList().Count > 0)
            {
                ListToExcel(_omReport.getreport(DTPfrom.Text, DTPTo.Text).ToList());
                MessageBox.Show("Successfully Generate Report!");
            }
            else
            {
                MessageBox.Show("No Record Found!");
            }
            
        }

        private void frmOMReport_Load(object sender, EventArgs e)
        {
            DTPfrom.Value = DateTime.Now;
            DTPTo.Value = DateTime.Now;

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
              
                string workbookPath = Application.StartupPath + "/OMReportTemplate.xlsx";
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
                    range.Value2 = "'" + item.created_date;

                    cellName = "D" + counter.ToString();
                    range = sheet.get_Range(cellName, cellName);
                    range.Value2 = "'" + item.time_in;

                    cellName = "E" + counter.ToString();
                    range = sheet.get_Range(cellName, cellName);
                    range.Value2 = "'" + item.time_out;

                    cellName = "F" + counter.ToString();
                    range = sheet.get_Range(cellName, cellName);
                    range.Value2 = item.Age;

                    cellName = "G" + counter.ToString();
                    range = sheet.get_Range(cellName, cellName);
                    range.Value2 = item.gender;

                    cellName = "H" + counter.ToString();
                    range = sheet.get_Range(cellName, cellName);
                    range.Value2 = item.complaint1;

                    cellName = "I" + counter.ToString();
                    range = sheet.get_Range(cellName, cellName);
                    range.Value2 = item.Medicine1;

                    cellName = "J" + counter.ToString();
                    range = sheet.get_Range(cellName, cellName);
                    range.Value2 = item.quantity1;

                    cellName = "K" + counter.ToString();
                    range = sheet.get_Range(cellName, cellName);
                    range.Value2 = item.complaint2;

                    cellName = "L" + counter.ToString();
                    range = sheet.get_Range(cellName, cellName);
                    range.Value2 = item.Medicine2;

                    cellName = "M" + counter.ToString();
                    range = sheet.get_Range(cellName, cellName);
                    range.Value2 = item.quantity2;

                    cellName = "N" + counter.ToString();
                    range = sheet.get_Range(cellName, cellName);
                    range.Value2 = item.complaint3;

                    cellName = "O" + counter.ToString();
                    range = sheet.get_Range(cellName, cellName);
                    range.Value2 = item.Medicine3;

                    cellName = "P" + counter.ToString();
                    range = sheet.get_Range(cellName, cellName);
                    range.Value2 = item.quantity3;

                    cellName = "Q" + counter.ToString();
                    range = sheet.get_Range(cellName, cellName);
                    range.Value2 = item.disposition;

                    cellName = "R" + counter.ToString();
                    range = sheet.get_Range(cellName, cellName);
                    range.Value2 = item.diagnosis;


                    ++counter;
                }
                workbook.SaveAs(textBox1.Text + "\\OM Report from " + DTPfrom.Value.ToShortDateString().Replace((char)47, (char)45) + " to " + DTPTo.Value.ToShortDateString().Replace((char)47, (char)45), "OCMS");

                exapp.Quit();
                exapp = null;
                GC.Collect();
                GC.WaitForPendingFinalizers();
                killExcel();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to display report!" + " ," + ex.Message, "OCMS");
                return;
            }
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
    }
}
