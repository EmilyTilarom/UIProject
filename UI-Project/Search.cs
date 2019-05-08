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
            var column = comboBox1.SelectedText;

            SqlConnection con = new SqlConnection(constring);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                //string q = "SELECT FROM " + table + " WHERE " + column +" LIKE " + textBox1.Text;
                string q = "INSERT INTO Login(name, password) VALUES ('abc', '123')";

                SqlCommand cmd = new SqlCommand(q, con);
                cmd.ExecuteNonQuery();
            }
        }
    }
}