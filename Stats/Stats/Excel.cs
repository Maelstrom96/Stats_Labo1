using NPOI.XSSF.UserModel;
using NPOI.SS.UserModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stats
{
    public class Excel
    {
        // Chemin d'accès au fichier principal
        private string statsPath;
        // Le fichier excel
        private XSSFWorkbook statsWorkbook;

        public Excel() : this(FileDialog()) {}

        public Excel(string path)
        {
            // Initialisation
            statsPath = path;

            Open(path);
        }

        public void Open(string path)
        {
            // Variables
            List<DataTable> dataTables = new List<DataTable>();

            try
            {
                // Ouverture du fichier
                using (FileStream file = new FileStream(path, FileMode.Open, FileAccess.Read))
                {
                    statsWorkbook = new XSSFWorkbook(file);
                }

                if (statsWorkbook.NumberOfSheets > 1)
                {
                    for (int i = 0; i < statsWorkbook.NumberOfSheets; i++)
                    {
                        DataTable dt = new DataTable();
                        ISheet sheet = statsWorkbook.GetSheetAt(i);
                        System.Collections.IEnumerator rows = sheet.GetRowEnumerator();

                        if (sheet.LastRowNum != 0)
                        {
                            IRow headerRow = sheet.GetRow(0);
                            int cellCount = headerRow.LastCellNum;

                            for (int j = 0; j < cellCount; j++)
                            {
                                ICell cell = headerRow.GetCell(j);
                                dt.Columns.Add(cell.ToString());
                            }

                            for (int k = (sheet.FirstRowNum + 1); k <= sheet.LastRowNum; k++)
                            {
                                IRow row = sheet.GetRow(k);
                                DataRow dataRow = dt.NewRow();
                                if (row == null)
                                {
                                    break;
                                }
                                for (int j = row.FirstCellNum; j < cellCount; j++)
                                {
                                    if (row.GetCell(j) != null)
                                        dataRow[j] = row.GetCell(j).ToString();
                                }

                                dt.Rows.Add(dataRow);
                            }
                        }

                        dataTables.Add(dt);
                    }
                    Worksheet_Selector WSform = new Worksheet_Selector(dataTables);
                    WSform.ShowDialog();
                }
            }
            catch (Exception e)
            {
                //TODO
            }
        }

        private static string FileDialog()
        {
            OpenFileDialog of = new OpenFileDialog();

            // Propriété de FileDialog
            of.Filter = "Excel Files|*.xlsx";
            of.Multiselect = false;

            if (of.ShowDialog() == DialogResult.OK)
            {
                return of.FileName;
            }
            throw new Exception("USER_ABORT");
        }
    }
}
