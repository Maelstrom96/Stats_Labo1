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

namespace Stats
{
    public partial class Main : Form
    {

        private String originalPath;
        private String savePath;
        private String saveFile;


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
                originalPath = of.FileName;
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
            }
        }

        private void BTN_Start_Click(object sender, EventArgs e)
        {
            OpenFile(originalPath);
        }

        private void OpenFile(String oriPath)
        {

        }

    }
}
