namespace UI_Project
{
    partial class NewClientForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_clientName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_clientEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_save = new System.Windows.Forms.Button();
            this.tb_clientEGN = new System.Windows.Forms.MaskedTextBox();
            this.tb_clientPhone = new System.Windows.Forms.MaskedTextBox();
            this.errorEGN = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorEmail = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorName = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_resZIP = new System.Windows.Forms.MaskedTextBox();
            this.tb_resState = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_resCountry = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_resCity = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_resLine2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_resLine1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tb_mailZIP = new System.Windows.Forms.MaskedTextBox();
            this.radioAddress = new System.Windows.Forms.RadioButton();
            this.tb_mailState = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_mailLine1 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_mailLine2 = new System.Windows.Forms.TextBox();
            this.tb_mailCountry = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tb_mailCity = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorEGN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorName)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Full Name";
            // 
            // tb_clientName
            // 
            this.tb_clientName.Location = new System.Drawing.Point(81, 28);
            this.tb_clientName.Name = "tb_clientName";
            this.tb_clientName.Size = new System.Drawing.Size(128, 20);
            this.tb_clientName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "EGN";
            // 
            // tb_clientEmail
            // 
            this.tb_clientEmail.Location = new System.Drawing.Point(81, 100);
            this.tb_clientEmail.Name = "tb_clientEmail";
            this.tb_clientEmail.Size = new System.Drawing.Size(128, 20);
            this.tb_clientEmail.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "E-mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Phone";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_save);
            this.groupBox1.Controls.Add(this.tb_clientEGN);
            this.groupBox1.Controls.Add(this.tb_clientPhone);
            this.groupBox1.Controls.Add(this.tb_clientName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb_clientEmail);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 210);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Client Data";
            // 
            // bt_save
            // 
            this.bt_save.Location = new System.Drawing.Point(142, 172);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(67, 23);
            this.bt_save.TabIndex = 8;
            this.bt_save.Text = "Save All";
            this.bt_save.UseVisualStyleBackColor = true;
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // tb_clientEGN
            // 
            this.tb_clientEGN.Location = new System.Drawing.Point(81, 64);
            this.tb_clientEGN.Mask = "0000000000";
            this.tb_clientEGN.Name = "tb_clientEGN";
            this.tb_clientEGN.Size = new System.Drawing.Size(128, 20);
            this.tb_clientEGN.TabIndex = 3;
            this.tb_clientEGN.ValidatingType = typeof(int);
            // 
            // tb_clientPhone
            // 
            this.tb_clientPhone.Culture = new System.Globalization.CultureInfo("bg-BG");
            this.tb_clientPhone.Location = new System.Drawing.Point(81, 136);
            this.tb_clientPhone.Mask = "(999) 000-0000";
            this.tb_clientPhone.Name = "tb_clientPhone";
            this.tb_clientPhone.Size = new System.Drawing.Size(128, 20);
            this.tb_clientPhone.TabIndex = 7;
            // 
            // errorEGN
            // 
            this.errorEGN.ContainerControl = this;
            // 
            // errorEmail
            // 
            this.errorEmail.ContainerControl = this;
            // 
            // errorName
            // 
            this.errorName.ContainerControl = this;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb_resZIP);
            this.groupBox2.Controls.Add(this.tb_resState);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.tb_resCountry);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.tb_resCity);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tb_resLine2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tb_resLine1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(268, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(225, 210);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Residential Address";
            // 
            // tb_resZIP
            // 
            this.tb_resZIP.Location = new System.Drawing.Point(111, 178);
            this.tb_resZIP.Mask = "00000";
            this.tb_resZIP.Name = "tb_resZIP";
            this.tb_resZIP.Size = new System.Drawing.Size(100, 20);
            this.tb_resZIP.TabIndex = 11;
            this.tb_resZIP.ValidatingType = typeof(int);
            // 
            // tb_resState
            // 
            this.tb_resState.Location = new System.Drawing.Point(111, 116);
            this.tb_resState.Name = "tb_resState";
            this.tb_resState.Size = new System.Drawing.Size(100, 20);
            this.tb_resState.TabIndex = 7;
            this.tb_resState.Text = "(Optional)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 119);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "State/Region";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 181);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Postal Code";
            // 
            // tb_resCountry
            // 
            this.tb_resCountry.Location = new System.Drawing.Point(111, 147);
            this.tb_resCountry.Name = "tb_resCountry";
            this.tb_resCountry.Size = new System.Drawing.Size(100, 20);
            this.tb_resCountry.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Country";
            // 
            // tb_resCity
            // 
            this.tb_resCity.Location = new System.Drawing.Point(111, 85);
            this.tb_resCity.Name = "tb_resCity";
            this.tb_resCity.Size = new System.Drawing.Size(100, 20);
            this.tb_resCity.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "City";
            // 
            // tb_resLine2
            // 
            this.tb_resLine2.Location = new System.Drawing.Point(111, 54);
            this.tb_resLine2.Name = "tb_resLine2";
            this.tb_resLine2.Size = new System.Drawing.Size(100, 20);
            this.tb_resLine2.TabIndex = 3;
            this.tb_resLine2.Text = "(Optional)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Street Address 2";
            // 
            // tb_resLine1
            // 
            this.tb_resLine1.Location = new System.Drawing.Point(111, 23);
            this.tb_resLine1.Name = "tb_resLine1";
            this.tb_resLine1.Size = new System.Drawing.Size(100, 20);
            this.tb_resLine1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Street Address 1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tb_mailZIP);
            this.groupBox3.Controls.Add(this.radioAddress);
            this.groupBox3.Controls.Add(this.tb_mailState);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.tb_mailLine1);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.tb_mailLine2);
            this.groupBox3.Controls.Add(this.tb_mailCountry);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.tb_mailCity);
            this.groupBox3.Location = new System.Drawing.Point(508, 28);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(225, 210);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mailing Address";
            // 
            // tb_mailZIP
            // 
            this.tb_mailZIP.Location = new System.Drawing.Point(105, 183);
            this.tb_mailZIP.Mask = "00000";
            this.tb_mailZIP.Name = "tb_mailZIP";
            this.tb_mailZIP.Size = new System.Drawing.Size(100, 20);
            this.tb_mailZIP.TabIndex = 12;
            this.tb_mailZIP.ValidatingType = typeof(int);
            // 
            // radioAddress
            // 
            this.radioAddress.AutoSize = true;
            this.radioAddress.Location = new System.Drawing.Point(11, 19);
            this.radioAddress.Name = "radioAddress";
            this.radioAddress.Size = new System.Drawing.Size(156, 17);
            this.radioAddress.TabIndex = 0;
            this.radioAddress.TabStop = true;
            this.radioAddress.Text = "Same as residential address";
            this.radioAddress.UseVisualStyleBackColor = true;
            this.radioAddress.CheckedChanged += new System.EventHandler(this.radioAddress_CheckedChanged);
            // 
            // tb_mailState
            // 
            this.tb_mailState.Location = new System.Drawing.Point(105, 127);
            this.tb_mailState.Name = "tb_mailState";
            this.tb_mailState.Size = new System.Drawing.Size(100, 20);
            this.tb_mailState.TabIndex = 8;
            this.tb_mailState.Text = "(Optional)";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 46);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(85, 13);
            this.label16.TabIndex = 1;
            this.label16.Text = "Street Address 1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 130);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "State/Region";
            // 
            // tb_mailLine1
            // 
            this.tb_mailLine1.Location = new System.Drawing.Point(105, 43);
            this.tb_mailLine1.Name = "tb_mailLine1";
            this.tb_mailLine1.Size = new System.Drawing.Size(100, 20);
            this.tb_mailLine1.TabIndex = 2;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 74);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(85, 13);
            this.label15.TabIndex = 3;
            this.label15.Text = "Street Address 2";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 186);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Postal Code";
            // 
            // tb_mailLine2
            // 
            this.tb_mailLine2.Location = new System.Drawing.Point(105, 71);
            this.tb_mailLine2.Name = "tb_mailLine2";
            this.tb_mailLine2.Size = new System.Drawing.Size(100, 20);
            this.tb_mailLine2.TabIndex = 4;
            this.tb_mailLine2.Text = "(Optional)";
            // 
            // tb_mailCountry
            // 
            this.tb_mailCountry.Location = new System.Drawing.Point(105, 155);
            this.tb_mailCountry.Name = "tb_mailCountry";
            this.tb_mailCountry.Size = new System.Drawing.Size(100, 20);
            this.tb_mailCountry.TabIndex = 10;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 102);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(24, 13);
            this.label14.TabIndex = 5;
            this.label14.Text = "City";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 158);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 13);
            this.label13.TabIndex = 9;
            this.label13.Text = "Country";
            // 
            // tb_mailCity
            // 
            this.tb_mailCity.Location = new System.Drawing.Point(105, 99);
            this.tb_mailCity.Name = "tb_mailCity";
            this.tb_mailCity.Size = new System.Drawing.Size(100, 20);
            this.tb_mailCity.TabIndex = 6;
            // 
            // NewClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 244);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "NewClientForm";
            this.Text = "New Client Registration";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorEGN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorName)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_clientName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_clientEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox tb_clientEGN;
        private System.Windows.Forms.MaskedTextBox tb_clientPhone;
        private System.Windows.Forms.ErrorProvider errorEGN;
        private System.Windows.Forms.Button bt_save;
        private System.Windows.Forms.ErrorProvider errorEmail;
        private System.Windows.Forms.ErrorProvider errorName;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_resCountry;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_resCity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_resLine2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_resLine1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_resState;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_mailState;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_mailLine1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tb_mailLine2;
        private System.Windows.Forms.TextBox tb_mailCountry;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tb_mailCity;
        private System.Windows.Forms.RadioButton radioAddress;
        private System.Windows.Forms.MaskedTextBox tb_resZIP;
        private System.Windows.Forms.MaskedTextBox tb_mailZIP;
    }
}

