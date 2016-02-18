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

        }

    }
}
