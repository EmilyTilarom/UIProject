namespace UI_Project
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pasTxt = new System.Windows.Forms.TextBox();
            this.lOGINBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personalFinanceDataSet = new UI_Project.PersonalFinanceDataSet();
            this.loginPas = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.useTxt = new System.Windows.Forms.TextBox();
            this.loginUser = new System.Windows.Forms.Label();
            this.lOGINTableAdapter = new UI_Project.PersonalFinanceDataSetTableAdapters.LOGINTableAdapter();
            this.tableAdapterManager = new UI_Project.PersonalFinanceDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lOGINBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalFinanceDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(44, 79);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(373, 302);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pasTxt);
            this.panel1.Controls.Add(this.loginPas);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.useTxt);
            this.panel1.Controls.Add(this.loginUser);
            this.panel1.Location = new System.Drawing.Point(500, 79);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(361, 302);
            this.panel1.TabIndex = 5;
            // 
            // pasTxt
            // 
            this.pasTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lOGINBindingSource, "password", true));
            this.pasTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pasTxt.Location = new System.Drawing.Point(180, 112);
            this.pasTxt.Margin = new System.Windows.Forms.Padding(4);
            this.pasTxt.Name = "pasTxt";
            this.pasTxt.PasswordChar = '*';
            this.pasTxt.Size = new System.Drawing.Size(132, 26);
            this.pasTxt.TabIndex = 11;
            // 
            // lOGINBindingSource
            // 
            this.lOGINBindingSource.DataMember = "LOGIN";
            this.lOGINBindingSource.DataSource = this.personalFinanceDataSet;
            // 
            // personalFinanceDataSet
            // 
            this.personalFinanceDataSet.DataSetName = "PersonalFinanceDataSet";
            this.personalFinanceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loginPas
            // 
            this.loginPas.AutoSize = true;
            this.loginPas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginPas.Location = new System.Drawing.Point(17, 119);
            this.loginPas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.loginPas.Name = "loginPas";
            this.loginPas.Size = new System.Drawing.Size(142, 20);
            this.loginPas.TabIndex = 10;
            this.loginPas.Text = "Enter Password";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(103, 208);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 48);
            this.button1.TabIndex = 9;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // useTxt
            // 
            this.useTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lOGINBindingSource, "name", true));
            this.useTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.useTxt.Location = new System.Drawing.Point(184, 37);
            this.useTxt.Margin = new System.Windows.Forms.Padding(4);
            this.useTxt.Name = "useTxt";
            this.useTxt.Size = new System.Drawing.Size(132, 26);
            this.useTxt.TabIndex = 7;
            // 
            // loginUser
            // 
            this.loginUser.AutoSize = true;
            this.loginUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginUser.Location = new System.Drawing.Point(17, 37);
            this.loginUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.loginUser.Name = "loginUser";
            this.loginUser.Size = new System.Drawing.Size(145, 20);
            this.loginUser.TabIndex = 5;
            this.loginUser.Text = "Enter Username";
            // 
            // lOGINTableAdapter
            // 
            this.lOGINTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ADDRESSTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CLIENTTableAdapter = null;
            this.tableAdapterManager.DOSSIER_DETAILSTableAdapter = null;
            this.tableAdapterManager.DOSSIERTableAdapter = null;
            this.tableAdapterManager.INCOME_EXPNECETableAdapter = null;
            this.tableAdapterManager.LOGINTableAdapter = this.lOGINTableAdapter;
            this.tableAdapterManager.UpdateOrder = UI_Project.PersonalFinanceDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(935, 416);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lOGINBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalFinanceDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox pasTxt;
        private System.Windows.Forms.Label loginPas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox useTxt;
        private System.Windows.Forms.Label loginUser;
        private UI_Project.PersonalFinanceDataSet personalFinanceDataSet;
        private System.Windows.Forms.BindingSource lOGINBindingSource;
        private UI_Project.PersonalFinanceDataSetTableAdapters.LOGINTableAdapter lOGINTableAdapter;
        private UI_Project.PersonalFinanceDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}

