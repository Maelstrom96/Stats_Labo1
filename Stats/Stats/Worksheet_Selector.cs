using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stats
{
    public partial class Worksheet_Selector : Form
    {
        public Worksheet_Selector(List<DataTable> list)
        {
            InitializeComponent();

            BindingSource SBind0 = new BindingSource();
            SBind0.DataSource = list[0];

            dataGridView1.DataSource = list[0];
            dataGridView1.DataSource = SBind0;

            BindingSource SBind1 = new BindingSource();
            SBind1.DataSource = list[1];
            dataGridView2.DataSource = list[1];
            dataGridView2.DataSource = SBind1;
        }
    }
}
