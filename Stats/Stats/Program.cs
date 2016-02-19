using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Stats
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            /*
            Excel.Application xlApp = new Excel.Application();
            List<string> Header = new List<string>();
            List<List<string>> population = Utils.ReadPopulation(xlApp, Utils.GetFilePath(), Header);
            List<List<string>> echantillon = Utils.GetEchantillonAleatoire(population, 25);
            List<List<string>> echantillon2 = Utils.GetEchantillonSystematique(population, 30);
            Utils.WriteEchantillon(xlApp, "test", @"C:\Users\alexandre-jacques\Desktop", Header, echantillon, population);
            */

            Application.Run(new Main());
        }
    }
}
