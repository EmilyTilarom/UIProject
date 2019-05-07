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

        private void button1_Click(object sender, EventArgs e)
        {
            var table = radioButton1.Checked ? "client" : "dossier";
            var column = comboBox1.SelectedText;
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(column + " like '%{0}%'",textBox1.Text);
            this.cLIENTBindingSource.Filter = sb.ToString();
            //this.cLIENTTableAdapter.Fill(this.cLIE);


            switch (table)
            {
                case "client":
                    {

                        break;
                    }
                case "dossier":
                    {
                        break;
                    }
                default:
                    {
                        Console.WriteLine("rip");
                        break;
                    }
            }
        }

        private void cLIENTBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cLIENTBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.personalFinanceDataSet);

        }

        private void Search_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'personalFinanceDataSet.CLIENT' table. You can move, or remove it, as needed.
            this.cLIENTTableAdapter.Fill(this.personalFinanceDataSet.CLIENT);

        }
    }
}
