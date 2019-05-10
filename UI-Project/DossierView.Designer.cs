namespace UI_Project
{
    partial class DossierView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DossierView));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDossierNumber = new System.Windows.Forms.TextBox();
            this.textBoxClient = new System.Windows.Forms.TextBox();
            this.textBoxOverUnder = new System.Windows.Forms.TextBox();
            this.checkBoxIncome = new System.Windows.Forms.CheckBox();
            this.checkBoxExpenses = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.bt_save = new System.Windows.Forms.Button();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Document = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dosier Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Year";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Over / Under";
            // 
            // textBoxDossierNumber
            // 
            this.textBoxDossierNumber.Location = new System.Drawing.Point(131, 29);
            this.textBoxDossierNumber.Name = "textBoxDossierNumber";
            this.textBoxDossierNumber.ReadOnly = true;
            this.textBoxDossierNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxDossierNumber.TabIndex = 3;
            // 
            // textBoxClient
            // 
            this.textBoxClient.Location = new System.Drawing.Point(131, 60);
            this.textBoxClient.Name = "textBoxClient";
            this.textBoxClient.ReadOnly = true;
            this.textBoxClient.Size = new System.Drawing.Size(100, 20);
            this.textBoxClient.TabIndex = 4;
            // 
            // textBoxOverUnder
            // 
            this.textBoxOverUnder.Location = new System.Drawing.Point(131, 114);
            this.textBoxOverUnder.Name = "textBoxOverUnder";
            this.textBoxOverUnder.ReadOnly = true;
            this.textBoxOverUnder.Size = new System.Drawing.Size(100, 20);
            this.textBoxOverUnder.TabIndex = 5;
            // 
            // checkBoxIncome
            // 
            this.checkBoxIncome.AutoSize = true;
            this.checkBoxIncome.Location = new System.Drawing.Point(40, 168);
            this.checkBoxIncome.Name = "checkBoxIncome";
            this.checkBoxIncome.Size = new System.Drawing.Size(61, 17);
            this.checkBoxIncome.TabIndex = 6;
            this.checkBoxIncome.Text = "Income";
            this.checkBoxIncome.UseVisualStyleBackColor = true;
            // 
            // checkBoxExpenses
            // 
            this.checkBoxExpenses.AutoSize = true;
            this.checkBoxExpenses.Location = new System.Drawing.Point(159, 168);
            this.checkBoxExpenses.Name = "checkBoxExpenses";
            this.checkBoxExpenses.Size = new System.Drawing.Size(72, 17);
            this.checkBoxExpenses.TabIndex = 7;
            this.checkBoxExpenses.Text = "Expenses";
            this.checkBoxExpenses.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.Type,
            this.Description,
            this.Document,
            this.Amount});
            this.dataGridView1.Location = new System.Drawing.Point(27, 212);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 161);
            this.dataGridView1.TabIndex = 8;
            // 
            // bt_cancel
            // 
            this.bt_cancel.Image = global::UI_Project.Properties.Resources.cancel;
            this.bt_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_cancel.Location = new System.Drawing.Point(50, 404);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(68, 25);
            this.bt_cancel.TabIndex = 10;
            this.bt_cancel.Text = "Cancel";
            this.bt_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_cancel.UseVisualStyleBackColor = true;
            // 
            // bt_save
            // 
            this.bt_save.Image = ((System.Drawing.Image)(resources.GetObject("bt_save.Image")));
            this.bt_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_save.Location = new System.Drawing.Point(453, 404);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(68, 25);
            this.bt_save.TabIndex = 11;
            this.bt_save.Text = "Save";
            this.bt_save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_save.UseVisualStyleBackColor = true;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            // 
            // Document
            // 
            this.Document.HeaderText = "Document";
            this.Document.Name = "Document";
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(376, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 39);
            this.label4.TabIndex = 12;
            this.label4.Text = "Status";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(131, 86);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Client";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(237, 85);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(39, 23);
            this.button2.TabIndex = 27;
            this.button2.Text = "View";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DossierView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bt_save);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.checkBoxExpenses);
            this.Controls.Add(this.checkBoxIncome);
            this.Controls.Add(this.textBoxOverUnder);
            this.Controls.Add(this.textBoxClient);
            this.Controls.Add(this.textBoxDossierNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DossierView";
            this.Text = "Dossier View";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDossierNumber;
        private System.Windows.Forms.TextBox textBoxClient;
        private System.Windows.Forms.TextBox textBoxOverUnder;
        private System.Windows.Forms.CheckBox checkBoxIncome;
        private System.Windows.Forms.CheckBox checkBoxExpenses;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bt_cancel;
        private System.Windows.Forms.Button bt_save;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Document;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
    }
}