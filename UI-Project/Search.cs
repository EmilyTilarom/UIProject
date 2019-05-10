using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_Project
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                NewClientForm ss = new NewClientForm();
                ss.Show();
            }
            else
            {
                NewDossierForm newss = new NewDossierForm();
                newss.Show();
            }
        }
    }
}
