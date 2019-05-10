using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_Project
{
    public partial class NewClientForm : Form
    {
        public NewClientForm()
        {
            InitializeComponent();
        }

        private bool Name_Validation(object sender, CancelEventArgs e)
        {
            string[] names = tb_clientName.Text.Split(new char[] { ' ', ',', ';', '.' });
            if (names.Length < 3)
            {
                errorName.SetError(tb_clientName, "Please fill in the email field.");
                return false;
            }
            errorName.SetError(tb_clientName, "");
            return true;
        }

        private bool EGN_Validation(object sender, CancelEventArgs e)
        {
            string s_EGN = tb_clientEGN.Text;
            if (s_EGN.Length != 10)
            {
                errorEGN.SetError(tb_clientEGN, "An EGN should have 10 digits.");
                return false;
            }
            double control = char.GetNumericValue(s_EGN[9]);
            double sum = char.GetNumericValue(s_EGN[0]) * 2
                + char.GetNumericValue(s_EGN[1]) * 4
                + char.GetNumericValue(s_EGN[2]) * 8
                + char.GetNumericValue(s_EGN[3]) * 5
                + char.GetNumericValue(s_EGN[4]) * 10
                + char.GetNumericValue(s_EGN[5]) * 9
                + char.GetNumericValue(s_EGN[6]) * 7
                + char.GetNumericValue(s_EGN[7]) * 3
                + char.GetNumericValue(s_EGN[8]) * 6;
            double remainder = sum % 11;
            if (remainder < 10 && control != remainder || remainder >= 10 && control != 0)
            {
                errorEGN.SetError(tb_clientEGN, "The EGN is not valid according to the control digit.");
                return false;
            }
            errorEGN.SetError(tb_clientEGN, "");
            return true;
        }
        
        private bool Email_Validation(object sender, CancelEventArgs e)
        {
            if (tb_clientEmail.Text=="")
            {
                errorEmail.SetError(tb_clientEmail, "Please fill in the email field.");
                return false;
            }
            Regex regex = new Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
            Match match = regex.Match(tb_clientEmail.Text);
            if (!match.Success)
            {
                errorEmail.SetError(tb_clientEmail, "Incorrect format for email field.");
                return false;
            }
            errorEmail.SetError(tb_clientEmail, "");
            return true;
        }

        private bool ResAddress_Validation(object sender, CancelEventArgs e)
        {
            bool valid = true;
            valid = tb_resLine1.Text != "" && valid;
            valid = tb_resCity.Text != "" && valid;
            valid = tb_resCountry.Text != "" && valid;
            valid = tb_resZIP.Text.Length >= 4 && valid;
            return valid;
        }

        private bool MailAddress_Validation(object sender, CancelEventArgs e)
        {
            if (radioAddress.Checked)
            {
                return true;
            }
            bool valid = true;
            valid = tb_mailLine1.Text != "" && valid;
            valid = tb_mailCity.Text != "" && valid;
            valid = tb_mailCountry.Text != "" && valid;
            valid = tb_mailZIP.Text.Length >= 4 && valid;
            return valid;
        }

        private void ResAddress_Clear()
        {
            tb_resLine1.Clear();
            tb_resLine2.Clear();
            tb_resCity.Clear();
            tb_resState.Clear();
            tb_resCountry.Clear();
            tb_resZIP.Clear();
        }

        private void MailAddress_Clear()
        {
            tb_mailLine1.Clear();
            tb_mailLine2.Clear();
            tb_mailCity.Clear();
            tb_mailState.Clear();
            tb_mailCountry.Clear();
            tb_mailZIP.Clear();
        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            //test input values
            bool allFieldsValid = true;
            allFieldsValid = Name_Validation(null, null) && allFieldsValid;
            allFieldsValid = EGN_Validation(null, null) && allFieldsValid;
            allFieldsValid = Email_Validation(null, null) && allFieldsValid;
            allFieldsValid = (tb_clientPhone.Text.Length == 14) && allFieldsValid;
            allFieldsValid = ResAddress_Validation(null, null) && allFieldsValid;
            allFieldsValid = MailAddress_Validation(null, null) && allFieldsValid;
            if (!allFieldsValid)
            {
                MessageBox.Show("Some required fields are missing or invalid.", "", MessageBoxButtons.OK);
                return;
            }

            //save data
            string[] names = tb_clientName.Text.Split(new char[] { ' ', ',', ';', '.' });
            MessageBox.Show("Client added to database.", "", MessageBoxButtons.OK);
            //TO-DO: check client not existing
            //TO-DO: save client to database
            //TO-DO: user should specify reporting year
            //TO-DO: create new dossier for client

            //prepare for new client
            tb_clientName.Clear();
            tb_clientEGN.Clear();
            tb_clientEmail.Clear();
            tb_clientPhone.Clear();
            ResAddress_Clear();
            MailAddress_Clear();
        }

        private void radioAddress_CheckedChanged(object sender, EventArgs e)
        {
            if (radioAddress.Checked)
            {
                //deactivate mailing address fields
                tb_mailLine1.Enabled = false;
                tb_mailLine2.Enabled = false;
                tb_mailCity.Enabled = false;
                tb_mailState.Enabled = false;
                tb_mailCountry.Enabled = false;
                tb_mailZIP.Enabled = false;
            }
            else
            {
                //activate mailing address fields
                tb_mailLine1.Enabled = true;
                tb_mailLine2.Enabled = true;
                tb_mailCity.Enabled = true;
                tb_mailState.Enabled = true;
                tb_mailCountry.Enabled = true;
                tb_mailZIP.Enabled = true;
            }
        }
    }

    class MyRequiredFieldException : Exception
    {
        public MyRequiredFieldException(string message) : base(message)
        {
        }
    }
}
