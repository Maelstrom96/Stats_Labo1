using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;


namespace Stats
{
    public partial class Main : Form
    {

        private String _originalFile;
        private String _savePath;
        private String _saveFile;

        public Main()
        {
            InitializeComponent();
        }

        //Ouverture du fichier et ecriture de l'endroit où le fichier est enregistrer dans la text box suivante.
        private void BTN_Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
            if(of.ShowDialog() == DialogResult.OK)
            {
                TXB_OpenPath.Text = of.FileName;
                _originalFile = of.FileName;
            }
        }

        //Ouverture de l'endroit pour sauvegarder le/les fichiers a l'endroit specifié.
        private void BTN_Save_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();
            if (result == DialogResult.OK)
            {
                TXB_SavePath.Text = fbd.SelectedPath;
                _savePath = fbd.SelectedPath;
            }
        }

        private void BTN_Start_Click(object sender, EventArgs e)
        {
            _saveFile = TXB_SaveFile.Text;
            OpenFile(_originalFile);
        }

        private void OpenFile(String oriFile)
        {
            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            Excel.Range range;

            string str;
            int rCnt = 0;
            int cCnt = 0;

            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Open(oriFile, 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            range = xlWorkSheet.UsedRange;

            for (rCnt = 1; rCnt <= range.Rows.Count; rCnt++)
            {
                for (cCnt = 1; cCnt <= range.Columns.Count; cCnt++)
                {
                    str = (string)(range.Cells[rCnt, cCnt] as Excel.Range).Text;
                    WriteFile(rCnt, cCnt, str);
                }
            }

            xlWorkBook.Close(true, null, null);
            xlApp.Quit();

            releaseObject(xlWorkSheet);
            releaseObject(xlWorkBook);
            releaseObject(xlApp);
        }

        public void WriteFile(int rCnt, int cCnt, String str)
        {
            Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();

            if (xlApp == null)
            {
                MessageBox.Show("Excel is not properly installed!!");
                return;
            }


            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            xlWorkSheet.Cells[rCnt, cCnt] = str;

            xlWorkBook.SaveAs(_savePath + @"\" + _saveFile, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();

            releaseObject(xlWorkSheet);
            releaseObject(xlWorkBook);
            releaseObject(xlApp);

            MessageBox.Show("Fichier enregistré à " + _savePath + @"\" + _saveFile);
        }


        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Unable to release the Object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        } 

    }
}



//http://csharp.net-informations.com/excel/csharp-read-excel.htm
