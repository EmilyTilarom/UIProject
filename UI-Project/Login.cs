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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (useTxt.Text == "user" && pasTxt.Text == "password")
            {
                MessageBox.Show("You have successfully logged in!");
                //NewPage ss = new NewPage();
                //ss.Show();
                //this.Hide();

            }
            else if (useTxt.Text == "")
            {
                MessageBox.Show("Please, enter valid username!");
                useTxt.Clear();
                pasTxt.Clear();


            }
            else if (pasTxt.Text == "")
            {
                MessageBox.Show("Please, enter valid password!");
                useTxt.Clear();
                pasTxt.Clear();

            }
            else
            {
                MessageBox.Show("Invalid username AND/OR password!");
                useTxt.Clear();
                pasTxt.Clear();
            }



        }

        private void login_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'personalFinanceDataSet.LOGIN' table. You can move, or remove it, as needed.
            this.lOGINTableAdapter.Fill(this.personalFinanceDataSet.LOGIN);

        }
    }
}
