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
/*
 **************************************** TODO LIST
 * TYPE ECHANTILLON (SIMPLE / SYSTEMATIQUE)
 * ECHANTILLON FIXE OU DIFFERENTE
 * */

namespace Stats
{
    public partial class Main : Form
    {

        private String _originalFile;
        private String _savePath;
        private String _saveFile;
        private int nbTaille;
        private int nbFiles;

        Excel.Range range;
        Excel.Application xlApp = new Excel.Application();
        Excel.Workbook xlWorkBook;
        Excel.Worksheet xlWorkSheet;
        Excel.Workbook xlWorkBookSave;
        Excel.Worksheet xlWorkSheetSave;
        object misValue = System.Reflection.Missing.Value;
        
        
        
        public Main()
        {
            InitializeComponent();
            if (xlApp == null)
            {
                MessageBox.Show("Excel is not properly installed!!");
                return;
            }
        }

        //Ouverture du fichier et ecriture de l'endroit où le fichier est enregistrer dans la text box suivante.
        private void BTN_Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
            if(of.ShowDialog() == DialogResult.OK)
            {
                TXB_OpenPath.Text = of.FileName;    //Endroit du fichier source dans la text box
                _originalFile = of.FileName;    //Endroit du fichier de sauvegarde
            }
        }

        //Ouverture de l'endroit pour sauvegarder le/les fichiers a l'endroit specifié.
        private void BTN_Save_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();
            if (result == DialogResult.OK)
            {
                TXB_SavePath.Text = fbd.SelectedPath;   //Endroit de sauvegarde afficher dans la text box
                _savePath = fbd.SelectedPath;   //Endroit de sauvegarde
            }
        }

        private void BTN_Start_Click(object sender, EventArgs e)
        {
            _saveFile = TXB_SaveFile.Text;  //Nom du fichier a enregistrer
            nbTaille = int.Parse(TXB_Taille.Text.ToString());   //Taile de l'echantillonage
            nbFiles = int.Parse(NUD_Nbechantillon.Value.ToString());    //Nombre de fichiers a creer
            OpenFile(_originalFile);
            this.Close();
        }

        //Ouverture du fichier original et d'un nouveau fichier pour l'ecriture
        private void OpenFile(String oriFile)
        {
            string str;
            int rCnt = 0;
            int cCnt = 0;

            //Ouverture du fichier original
            xlWorkBook = xlApp.Workbooks.Open(oriFile, 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            range = xlWorkSheet.UsedRange;

            //Ecriture du fichier original dans la 1ere feuille avec l'echantillonage
            for (int i = 1; i < nbFiles + 1; ++i)
            {
                //Ouverture du fichier de l'enregistrement
                xlWorkBookSave = xlApp.Workbooks.Add(misValue);
                xlWorkSheetSave = (Excel.Worksheet)xlWorkBookSave.Worksheets.get_Item(1);
                xlWorkSheetSave.Name = "Echantillon";

                //Ecriture de la premiere ligne dans chaque fichier
                for (int j = 1; j <= range.Columns.Count; ++j)
                {
                    str = (string)(range.Cells[1, j] as Excel.Range).Text;
                    WriteFile(1, j, str);
                }

                    //*********************************TODO ECHANTILLONAGE ************************************************
                    //BLOC DE RANDOM POUR LECHANTILLON SIMPLE
                    //Simple = random rows sans remise
                    //Systematique = 1-4-7-10 ...
                    //Pour l'instant cest un random ben basic ****************A MODIFIER **********************************
                    for (rCnt = 2; rCnt <= nbTaille + 1; rCnt++)
                    {
                        Random random = new Random();
                        int row = random.Next(2, range.Rows.Count);

                        for (cCnt = 1; cCnt <= range.Columns.Count; cCnt++)
                        {
                            str = (string)(range.Cells[row, cCnt] as Excel.Range).Text;
                            WriteFile(rCnt, cCnt, str);
                        }
                    }


                //Ecriture du fichier original dans la 2e feuille
                if (CB_Copy.Checked)
                {
                    xlWorkSheetSave = (Excel.Worksheet)xlWorkBookSave.Worksheets.Add(After: xlWorkBookSave.Sheets[xlWorkBookSave.Sheets.Count]);
                    xlWorkSheetSave.Name = "Original";
                    
                    for (rCnt = 1; rCnt <= range.Rows.Count; rCnt++)
                    {
                        for (cCnt = 1; cCnt <= range.Columns.Count; cCnt++)
                        {
                            str = (string)(range.Cells[rCnt, cCnt] as Excel.Range).Text;
                            WriteFile(rCnt, cCnt, str);
                        }
                    }
                }
                SaveFile(i);
            }

            //Release de l'application et du fichier d'origine
            xlWorkBook.Close(true, oriFile, misValue);
            xlApp.Quit();
            releaseObject(xlWorkSheet);
            releaseObject(xlWorkBook);
            releaseObject(xlApp);
            MessageBox.Show("Fichier enregistré à " + _savePath + @"\" + _saveFile);
        }

        //Ecriture dans le nouveau fichier
        public void WriteFile(int rCnt, int cCnt, String str)
        {
            xlWorkSheetSave.Cells[rCnt, cCnt] = str;
        }

        //Enregistrement du/des nouveau(x) fichier(s)
        public void SaveFile(int i)
        {
            //Enregistrement du nouveau fichier
            xlWorkBookSave.SaveAs(_savePath + @"\" + _saveFile + " - " + i + " - " + nbTaille, Excel.XlFileFormat.xlWorkbookDefault);
            xlWorkBookSave.Close(true, _savePath + @"\" + _saveFile + " - " + i + " - " + nbTaille, misValue);
            
            //Release du nouveau fichier
            releaseObject(xlWorkSheetSave);
            releaseObject(xlWorkBookSave);
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
