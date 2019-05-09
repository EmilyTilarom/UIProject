using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

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

        public string constring = "Data Source=DESKTOP-JIHVB1Q\\MSSQLSERVER01;Initial Catalog = PersonalFinance; Integrated Security = True";
        private void button2_Click(object sender, EventArgs e)
        {
            var table = radioButton1.Checked ? "client" : "dossier";
            var column = comboBox1.SelectedItem;
            var search = textBox1.Text;
            var columnIntern = "";
            StringBuilder sb = new StringBuilder();

            switch (column)
            {
                case "EGN":
                    {
                        sb.AppendFormat("CLIENT_EGN like '%{0}%'", search);
                        break;
                    }
                case "Year":
                    {
                        //columnIntern = "CLIENT_";
                        break;
                    }
                case "Client Name":
                    {
                        sb.AppendFormat("CLIENT_NAME like '%{0}%'", search);
                        break;
                    }
                case "Dossier No":
                    {   
                        columnIntern = "DOSSIER_NO";
                        break;
                    }
                default:
                    {
                        break;
                    }
            }

            this.cLIENTBindingSource.Filter = sb.ToString();
            this.cLIENTTableAdapter.Fill(this.personalFinanceDataSet.CLIENT);

            //DBQueries dbq = new DBQueries();
            //PersonalFinanceDataSet.CLIENTDataTable dd = personalFinanceDataSet.CLIENT;
            //this.cLIENTTableAdapter.Fill(this.personalFinanceDataSet.CLIENT);
            //this.cLIENTTableAdapter.FillBy(personalFinanceDataSet.CLIENT, columnIntern, textBox1.Text);
            //this.cLIENTTableAdapter.GetDataBySearch(columnIntern, textBox1.Text);
            //this.cLIENTTableAdapter.GetDataBySearch(columnIntern);
            //DataTable dt = this.cLIENTTableAdapter.FillDataFromSearch(this.personalFinanceDataSet.CLIENT, columnIntern);
            /*
            DataTable dt = DBQueries.SelectAllFromTableWithValue(columnIntern, search);
            if (dt.Rows.Count > 0)
            {
                //this.cLIENTTableAdapter.Fill(new PersonalFinanceDataSet.CLIENTDataTable(dt));
                ClientView cv = new ClientView(dt);
            }
            */




                /*

                SqlConnection con = new SqlConnection(constring);
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    //string q = "SELECT FROM " + table + " WHERE " + column +" LIKE " + textBox1.Text;
                    string q = "INSERT INTO Login(name, password) VALUES ('abc', '123')";

                    SqlCommand cmd = new SqlCommand(q, con);
                    cmd.ExecuteNonQuery();
                }
                */
            }

        private void Search_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'personalFinanceDataSet.CLIENT' table. You can move, or remove it, as needed.
            this.cLIENTTableAdapter.Fill(this.personalFinanceDataSet.CLIENT);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.cLIENTTableAdapter.FillBy(this.personalFinanceDataSet.CLIENT, rowToolStripTextBox.Text, valueToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}