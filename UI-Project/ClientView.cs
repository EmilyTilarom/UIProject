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
    public partial class ClientView : Form
    {
        public ClientView()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewClientForm ss = new NewClientForm();
            ss.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NewDossierForm ss = new NewDossierForm();
            ss.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NewClientForm ss = new NewClientForm();
            ss.Show();
        }

        private void ClientView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'personalFinanceDataSet.CLIENT' table. You can move, or remove it, as needed.
            this.cLIENTTableAdapter.Fill(this.personalFinanceDataSet.CLIENT);

        }
    }
}
