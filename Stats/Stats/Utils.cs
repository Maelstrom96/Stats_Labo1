using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Stats
{
    static class Utils
    {
        public static List<List<string>> GetEchantillonAleatoire(List<List<string>> population, int tailleEchantillon)
        {
            List<List<string>> Echantillon = new List<List<string>>();
            List<List<string>> pop = new List<List<string>>(population);
            Random rnd = new Random();

            // Erreurs
            if (pop.Count == 0) throw new Exception("La population est vide.");
            if (pop.Count < tailleEchantillon) throw new Exception("La taille d'échantillon demandé est plus grand que la population.");

            for (int i = 0; i < tailleEchantillon; i++)
            {
                int tmpIndex = rnd.Next(pop.Count - 1);
                Echantillon.Add(pop[tmpIndex]);
                pop.RemoveAt(tmpIndex);
            }

            return Echantillon;
        }

        public static List<List<string>> GetEchantillonSystematique(List<List<string>> population, int tailleEchantillon)
        {
            int pas = (int)Math.Round((double)population.Count/tailleEchantillon);
            List<List<string>> Echantillon = new List<List<string>>();
            List<List<string>> pop = new List<List<string>>(population);
            Random rnd = new Random();
            int origin = rnd.Next(pop.Count - 1);
            int start;

            // Erreurs
            if (pop.Count == 0) throw new Exception("La population est vide.");
            if (pop.Count < tailleEchantillon) throw new Exception("La taille d'échantillon demandé est plus grand que la population.");

            // Go to first data
            for (start = origin; start >= 0; start -= pas) ;
            start += pas;
            for (int i = start ; i < pop.Count; i = i + pas )
            {
                Echantillon.Add(pop.ElementAt(i));
            }

            return Echantillon;
        }

        public static List<List<string>> ReadPopulation(Excel.Application app, string filepath, List<string> header)
        {
            List<List<string>> population = new List<List<string>>();
            Excel.Workbook xlWorkBook = app.Workbooks.Open(filepath, 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
            Excel.Worksheet xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            Excel.Range range = xlWorkSheet.UsedRange;

            // Add header
            for (int i = 1; i <= range.Columns.Count; i++)
                header.Add((string)(range.Cells[1, i] as Excel.Range).Text);

            // Add data
            for (int y = 2; y <= range.Rows.Count; y++)
            { 
                population.Add(new List<string>());
                for (int x = 1; x <= range.Columns.Count; x++)
                    population.ElementAt(y - 2).Add((string)(range.Cells[y, x] as Excel.Range).Text);
            }
                    

            return population;
        }

        //TODO : Vérifier la gestion du garbage
        public static void WriteEchantillon(Excel.Application app, string filename, string filepath, List<string> header, List<List<string>> echantillon, List<List<string>> population = null)
        {
            Excel.Workbook xlWorkBook;
            Excel.Worksheet sheet2 = null;
            Excel.Worksheet sheet1 = null;

            xlWorkBook = app.Workbooks.Add(System.Reflection.Missing.Value);
            sheet1 = WriteWorkSheet((Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1), "Échantillon", header, echantillon);

            if (population != null)
            {
                sheet2 = WriteWorkSheet(xlWorkBook.Worksheets.Add(After: sheet1), "Population utilisée", header, population);
            }
            xlWorkBook.SaveAs(filepath + @"\" + filename + ".xlsx", Excel.XlFileFormat.xlOpenXMLWorkbook);

            xlWorkBook.Close(true, null, null);

            // Nettoyage
            releaseObject(sheet1);
            releaseObject(sheet2);
            releaseObject(xlWorkBook);
        }

        private static Excel.Worksheet WriteWorkSheet(Excel.Worksheet _xlWorkSheet, string name, List<string> header, List<List<string>> data)
        {
            _xlWorkSheet.Name = name;

            // Ecrire l'entête
            for (int i = 1; i <= header.Count; i++)
                _xlWorkSheet.Cells[1, i] = header.ElementAt(i - 1);

            // Ecrire les données
            for (int y = 2; y < data.Count + 2; y++)
                for (int x = 1; x <= data[y - 2].Count; x++)
                    _xlWorkSheet.Cells[y, x] = data[y - 2][x - 1];

            return _xlWorkSheet;
        }

        public static void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
            }
            finally
            {
                GC.Collect();
            }
        } 

        public static string GetFilePath()
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
            if (of.ShowDialog() == DialogResult.OK)
            {
                return of.FileName;
            }
            else throw new Exception("CANCELED");
        }
    }
}
