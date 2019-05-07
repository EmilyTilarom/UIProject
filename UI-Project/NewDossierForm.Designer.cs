namespace UI_Project
{
    partial class NewDossierForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewDossierForm));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_year = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.num_balance = new System.Windows.Forms.NumericUpDown();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.bt_save = new System.Windows.Forms.Button();
            this.bt_newClient = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.num_balance)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "James Smith",
            "John Paul",
            "Elizabeth Blight",
            "Caroline Samuels"});
            this.comboBox1.Location = new System.Drawing.Point(87, 17);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Client";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Year";
            // 
            // tb_year
            // 
            this.tb_year.Location = new System.Drawing.Point(87, 49);
            this.tb_year.Mask = "0000";
            this.tb_year.Name = "tb_year";
            this.tb_year.Size = new System.Drawing.Size(47, 20);
            this.tb_year.TabIndex = 4;
            this.tb_year.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Min. Balance";
            // 
            // num_balance
            // 
            this.num_balance.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.num_balance.Location = new System.Drawing.Point(87, 81);
            this.num_balance.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.num_balance.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.num_balance.Name = "num_balance";
            this.num_balance.Size = new System.Drawing.Size(120, 20);
            this.num_balance.TabIndex = 7;
            // 
            // bt_cancel
            // 
            this.bt_cancel.Image = global::UI_Project.Properties.Resources.cancel;
            this.bt_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_cancel.Location = new System.Drawing.Point(139, 117);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(68, 25);
            this.bt_cancel.TabIndex = 9;
            this.bt_cancel.Text = "Cancel";
            this.bt_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_cancel.UseVisualStyleBackColor = true;
            // 
            // bt_save
            // 
            this.bt_save.Image = ((System.Drawing.Image)(resources.GetObject("bt_save.Image")));
            this.bt_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_save.Location = new System.Drawing.Point(213, 117);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(68, 25);
            this.bt_save.TabIndex = 8;
            this.bt_save.Text = "Save";
            this.bt_save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_save.UseVisualStyleBackColor = true;
            // 
            // bt_newClient
            // 
            this.bt_newClient.Image = ((System.Drawing.Image)(resources.GetObject("bt_newClient.Image")));
            this.bt_newClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_newClient.Location = new System.Drawing.Point(214, 14);
            this.bt_newClient.Name = "bt_newClient";
            this.bt_newClient.Size = new System.Drawing.Size(58, 25);
            this.bt_newClient.TabIndex = 2;
            this.bt_newClient.Text = "New";
            this.bt_newClient.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_newClient.UseVisualStyleBackColor = true;
            this.bt_newClient.Click += new System.EventHandler(this.bt_newClient_Click);
            // 
            // NewDossierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 155);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.bt_save);
            this.Controls.Add(this.num_balance);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_year);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bt_newClient);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "NewDossierForm";
            this.Text = "New Dossier Form";
            ((System.ComponentModel.ISupportInitialize)(this.num_balance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_newClient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox tb_year;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown num_balance;
        private System.Windows.Forms.Button bt_save;
        private System.Windows.Forms.Button bt_cancel;
    }
}