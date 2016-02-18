using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Run();
            //Application.Run(new Main());
        }

        static void Run()
        {
            try
            {
                Excel file = new Excel();
            }
            catch (Exception e)
            {
                //TODO
            }
        }
    }
}
