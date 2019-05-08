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
    public partial class DossierView : Form
    {
        public DossierView()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClientView ss = new ClientView();
            ss.Show();
        }

        private void DossierView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'personalFinanceDataSet.DOSSIER_DETAILS' table. You can move, or remove it, as needed.
            this.dOSSIER_DETAILSTableAdapter.Fill(this.personalFinanceDataSet.DOSSIER_DETAILS);

        }
    }
}
