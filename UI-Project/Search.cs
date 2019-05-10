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

        string constring = @"Data Source=DESKTOP-JIHVB1Q\MSSQLSERVER01;Initial Catalog=PersonalFinance;Integrated Security=True";
        private void button2_Click(object sender, EventArgs e)
        {
            var table = radioButton1.Checked ? "client" : "dossier";
            var column = comboBox1.SelectedItem;
            var search = textBox1.Text;

            switch (table)
            {
                case "client":
                    {
                        switch (column)
                        {
                            case "EGN":
                                {
                                    this.cLIENTTableAdapter.FillByEGN(personalFinanceDataSet.CLIENT, search);
                                    break;
                                }
                            case "email":
                                {
                                    this.cLIENTTableAdapter.FillByEmail(personalFinanceDataSet.CLIENT, search);
                                    break;
                                }
                            case "phone":
                                {
                                    this.cLIENTTableAdapter.FillByPhone(personalFinanceDataSet.CLIENT, search);
                                    break;
                                }
                            case "name (1-3 parameters)":
                                {
                                    var names = search.Split(' ');
                                    if (names.Length == 1)
                                    {
                                        this.cLIENTTableAdapter.FillBySingleName(personalFinanceDataSet.CLIENT, names[0]);
                                    }
                                    else if(names.Length == 2)
                                    {
                                        this.cLIENTTableAdapter.FillByTwoNames(personalFinanceDataSet.CLIENT, names[0], names[1]);
                                    }
                                    else if (names.Length == 3)
                                    {
                                        this.cLIENTTableAdapter.FillByThreeNames(personalFinanceDataSet.CLIENT, names[0], names[1], names[2]);
                                    }
                                    else
                                    {
                                        this.cLIENTTableAdapter.FillByThreeNames(personalFinanceDataSet.CLIENT, names[0], names[1], names[2]);
                                    }

                                    break;
                                }
                            default:
                                {
                                    break;
                                }
                        }
                        break;
                    }
                case "dossier":
                    {
                        switch (column)
                        {
                            case "DossierNO":
                                {
                                    this.dOSSIERTableAdapter.FillByNo(personalFinanceDataSet.DOSSIER, Convert.ToDecimal(search));
                                    break;
                                }
                            case "client (only ONE parameter)":
                                {
                                    this.dOSSIERTableAdapter.FillByClient(personalFinanceDataSet.DOSSIER, search);
                                    break;
                                }
                            case "year":
                                {
                                    this.dOSSIERTableAdapter.FillByYear(personalFinanceDataSet.DOSSIER, Convert.ToDecimal(search));
                                    break;
                                }
                            case "status ('open' or 'closed'":
                                {
                                    string a = search.Equals("open") ? "o" : "c";
                                    this.dOSSIERTableAdapter.FillByStatus(personalFinanceDataSet.DOSSIER, search);
                                    break;
                                }
                            default:
                                {
                                    break;
                                }
                        }
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }

        private void Search_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'personalFinanceDataSet.DOSSIER' table. You can move, or remove it, as needed.
            this.dOSSIERTableAdapter.Fill(this.personalFinanceDataSet.DOSSIER);
            // TODO: This line of code loads data into the 'personalFinanceDataSet.CLIENT' table. You can move, or remove it, as needed.
            this.cLIENTTableAdapter.Fill(this.personalFinanceDataSet.CLIENT);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                dataGridView1.Visible = true;
                dataGridView2.Visible = false;
                comboBox1.Items.Clear();

                //client columns
                comboBox1.Items.Add("EGN");
                comboBox1.Items.Add("name (1-3 parameters)");
                comboBox1.Items.Add("email");
                comboBox1.Items.Add("phone");
            }
            else
            {
                dataGridView1.Visible = false;
                dataGridView2.Visible = true;
                comboBox1.Items.Clear();

                //dossier collumns
                comboBox1.Items.Add("DossierNO");
                comboBox1.Items.Add("client (only ONE parameter)");
                comboBox1.Items.Add("year");
                comboBox1.Items.Add("status");
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && dataGridView2.Columns[e.ColumnIndex].Name.Equals("Edit2"))
            {
                //Customers frm = new Customers(true, Convert.ToInt32(customersDataGridView.CurrentRow.Cells[0].Value));

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && dataGridView2.Columns[e.ColumnIndex].Name.Equals("Edit"))
            {

            }
        }
    }
}
