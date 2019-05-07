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
    public partial class NewDossierForm : Form
    {
        public NewDossierForm()
        {
            InitializeComponent();
        }

        private void bt_newClient_Click(object sender, EventArgs e)
        {
            NewClientForm newclientform = new NewClientForm();
            newclientform.Show();
        }
    }
}
