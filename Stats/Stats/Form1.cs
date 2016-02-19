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
        Excel.Application xlApp = new Excel.Application();
        List<List<string>> Data;
        List<string> Header = new List<string>();

        public Main()
        {
            InitializeComponent();
            Init();
            if (xlApp == null)
            {
                MessageBox.Show("Excel n'est pas installé!! Fermeture.");
                return;
            }
        }

        public static void IncrementProgress()
        {
            
        }

        private void Init()
        {
            RB_Different.Enabled = false;
            RB_Fixe.Enabled = false;
            RB_Simple.Enabled = false;
            RB_Syst.Enabled = false;
            NUD_Nbechantillon.Enabled = false;
            TXB_SaveFile.Enabled = false;
            TXB_SavePath.Enabled = false;
            num_Taille.Enabled = false;
            CB_Copy.Enabled = false;
            BTN_Save.Enabled = false;
            BTN_Start.Enabled = false;
            num_TailleMax.Visible = false;
            num_TailleMin.Visible = false;
        }

        //Ouverture du fichier et ecriture de l'endroit où le fichier est enregistrer dans la text box suivante.
        public void BTN_Open_Click(object sender, EventArgs e)
        {
            try
            {
                TXB_OpenPath.Text = Utils.GetFilePath();

                // Enable button
                RB_Simple.Enabled = true;
                RB_Syst.Enabled = true;
            }
            catch (Exception ex)
            {
                switch (ex.Message)
                {
                    case "CANCELED":
                        TXB_OpenPath.Text = "";
                        Init();
                        break;
                    default:
                        MessageBox.Show(ex.Message);
                        break;
                }
            }
        }

        private void RB_Click(object sender, EventArgs e)
        {
            if (sender == RB_Simple)
            {


                // Enable next buttons
                RB_Different.Enabled = true;
                RB_Fixe.Enabled = true;
            }
            if (sender == RB_Syst)
            {


                // Enable next buttons
                RB_Different.Enabled = true;
                RB_Fixe.Enabled = true;
            }
            if (sender == RB_Fixe)
            {
                MinMaxVisible(false);
                num_Taille.Enabled = true;
                NUD_Nbechantillon.Enabled = true;
                CB_Copy.Enabled = true;
                BTN_Save.Enabled = true;
                TXB_SaveFile.Enabled = true;
            }
            if (sender == RB_Different)
            {
                MinMaxVisible();
                NUD_Nbechantillon.Enabled = true;
                CB_Copy.Enabled = true;
                BTN_Save.Enabled = true;
                TXB_SaveFile.Enabled = true;
            }
        }

        private void MinMaxVisible(bool Visible = true)
        {
            lb_Max.Visible = Visible;
            lb_Min.Visible = Visible;
            num_TailleMax.Visible = Visible;
            num_TailleMin.Visible = Visible;

            lb_Taille.Visible = !Visible;
            num_Taille.Visible = !Visible;
        }

        //Ouverture de l'endroit pour sauvegarder le/les fichiers a l'endroit specifié.
        private void BTN_Save_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();
            if (result == DialogResult.OK)
            {
                TXB_SavePath.Text = fbd.SelectedPath;   //Endroit de sauvegarde afficher dans la text box
                BTN_Start.Enabled = true;
            }
            else
            {
                TXB_SavePath.Text = string.Empty;
                BTN_Start.Enabled = false;
            }
        }

        private void BTN_Start_Click(object sender, EventArgs e)
        {
            try
            {
                // Exceptions 
                if (NUD_Nbechantillon.Value < 1) throw new Exception("La nombre d'échantillon est invalide.");
                if (num_TailleMax.Value <= num_TailleMin.Value && RB_Different.Checked) throw new Exception("La taille minimal ne peut dépasser la taille maximal.");
                if (TXB_SaveFile.Text.Trim().Equals(String.Empty)) throw new Exception("Le nom du fichier ne peut être nul.");

                Cursor.Current = Cursors.WaitCursor;

                Data = Utils.ReadPopulation(xlApp, TXB_OpenPath.Text, Header);
                Random rnd = new Random();

                if (RB_Simple.Checked)
                {
                    if (RB_Fixe.Checked)
                    {
                        for (int i = 1; i <= NUD_Nbechantillon.Value; i++)
                        {
                            List<List<string>> echantillon = Utils.GetEchantillonAleatoire(Data, (int)num_Taille.Value);
                            string NomFichier = TXB_SaveFile.Text;

                            if (NUD_Nbechantillon.Value > 1) NomFichier += "-" + i;

                            if (CB_Copy.Checked) Utils.WriteEchantillon(xlApp, NomFichier, TXB_SavePath.Text, Header, echantillon, Data);
                            else Utils.WriteEchantillon(xlApp, NomFichier, TXB_SavePath.Text, Header, echantillon, null);
                        }
                    }
                    else
                    {
                        for (int i = 1; i <= NUD_Nbechantillon.Value; i++)
                        {
                            List<List<string>> echantillon = Utils.GetEchantillonAleatoire(Data, rnd.Next((int)num_TailleMin.Value, (int)num_TailleMax.Value));
                            string NomFichier = TXB_SaveFile.Text;

                            if (NUD_Nbechantillon.Value > 1) NomFichier += "-" + i;

                            if (CB_Copy.Checked) Utils.WriteEchantillon(xlApp, NomFichier, TXB_SavePath.Text, Header, echantillon, Data);
                            else Utils.WriteEchantillon(xlApp, NomFichier, TXB_SavePath.Text, Header, echantillon, null);
                        }
                    }
                }
                else
                {
                    if (RB_Fixe.Checked)
                    {
                        for (int i = 1; i <= NUD_Nbechantillon.Value; i++)
                        {
                            List<List<string>> echantillon = Utils.GetEchantillonSystematique(Data, (int)num_Taille.Value);
                            string NomFichier = TXB_SaveFile.Text;

                            if (NUD_Nbechantillon.Value > 1) NomFichier += "-" + i;

                            if (CB_Copy.Checked) Utils.WriteEchantillon(xlApp, NomFichier, TXB_SavePath.Text, Header, echantillon, Data);
                            else Utils.WriteEchantillon(xlApp, NomFichier, TXB_SavePath.Text, Header, echantillon, null);
                        }
                    }
                    else
                    {
                        for (int i = 1; i <= NUD_Nbechantillon.Value; i++)
                        {
                            List<List<string>> echantillon = Utils.GetEchantillonSystematique(Data, rnd.Next((int)num_TailleMin.Value, (int)num_TailleMax.Value));
                            string NomFichier = TXB_SaveFile.Text;

                            if (NUD_Nbechantillon.Value > 1) NomFichier += "-" + i;

                            if (CB_Copy.Checked) Utils.WriteEchantillon(xlApp, NomFichier, TXB_SavePath.Text, Header, echantillon, Data);
                            else Utils.WriteEchantillon(xlApp, NomFichier, TXB_SavePath.Text, Header, echantillon, null);
                        }
                    }
                }

                Cursor.Current = Cursors.Default;

                MessageBox.Show("Opération terminée.");
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            /*
            _saveFile = TXB_SaveFile.Text;  //Nom du fichier a enregistrer
            nbTaille = int.Parse(TXB_Taille.Text.ToString());   //Taile de l'echantillonage
            nbFiles = int.Parse(NUD_Nbechantillon.Value.ToString());    //Nombre de fichiers a creer
            OpenFile(_originalFile);
            this.Close();
             */
        }

        //Ouverture du fichier original et d'un nouveau fichier pour l'ecriture
        private void OpenFile(String oriFile)
        {
            /*
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
            */
        }

        //Ecriture dans le nouveau fichier
        public void WriteFile(int rCnt, int cCnt, String str)
        {
            //xlWorkSheetSave.Cells[rCnt, cCnt] = str;
        }

        //Enregistrement du/des nouveau(x) fichier(s)
        public void SaveFile(int i)
        {
            /*
            //Enregistrement du nouveau fichier
            xlWorkBookSave.SaveAs(_savePath + @"\" + _saveFile + " - " + i + " - " + nbTaille, Excel.XlFileFormat.xlWorkbookDefault);
            xlWorkBookSave.Close(true, _savePath + @"\" + _saveFile + " - " + i + " - " + nbTaille, misValue);
            
            //Release du nouveau fichier
            releaseObject(xlWorkSheetSave);
            releaseObject(xlWorkBookSave);
            */
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

        private void NUD_Nbechantillon_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void lb_Min_Click(object sender, EventArgs e)
        {

        }

        private void lb_Max_Click(object sender, EventArgs e)
        {

        } 
    }
}



//http://csharp.net-informations.com/excel/csharp-read-excel.htm
