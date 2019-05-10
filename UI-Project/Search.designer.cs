namespace UI_Project
{
    partial class Search
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search));
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dOSSIERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personalFinanceDataSet = new UI_Project.PersonalFinanceDataSet();
            this.cLIENTEGNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLIENTNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLIENTSURNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLIENTLASTNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLIENTEMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLIENTPHONEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLIENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cLIENTTableAdapter = new UI_Project.PersonalFinanceDataSetTableAdapters.CLIENTTableAdapter();
            this.tableAdapterManager = new UI_Project.PersonalFinanceDataSetTableAdapters.TableAdapterManager();
            this.dOSSIERTableAdapter = new UI_Project.PersonalFinanceDataSetTableAdapters.DOSSIERTableAdapter();
            this.dOSSIERNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLIENTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOSSIERYEARDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOSSIERSTATUSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOSSIERMINBALANCEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit2 = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOSSIERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalFinanceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(219, 37);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(64, 21);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Client";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(305, 37);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(77, 21);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Dossier";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(219, 156);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(260, 22);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(215, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Type of Search";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "EGN",
            "Year",
            "Client Name",
            "Dossier No"});
            this.comboBox1.Location = new System.Drawing.Point(339, 94);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(197, 24);
            this.comboBox1.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cLIENTEGNDataGridViewTextBoxColumn,
            this.cLIENTNAMEDataGridViewTextBoxColumn,
            this.cLIENTSURNAMEDataGridViewTextBoxColumn,
            this.cLIENTLASTNAMEDataGridViewTextBoxColumn,
            this.cLIENTEMAILDataGridViewTextBoxColumn,
            this.cLIENTPHONEDataGridViewTextBoxColumn,
            this.Edit});
            this.dataGridView1.DataSource = this.cLIENTBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(41, 245);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(747, 201);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(487, 152);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(49, 31);
            this.button2.TabIndex = 11;
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(459, 37);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(77, 31);
            this.button3.TabIndex = 10;
            this.button3.Text = "New";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Edit
            // 
            this.Edit.HeaderText = "EDIT";
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dOSSIERNODataGridViewTextBoxColumn,
            this.cLIENTIDDataGridViewTextBoxColumn,
            this.dOSSIERYEARDataGridViewTextBoxColumn,
            this.dOSSIERSTATUSDataGridViewTextBoxColumn,
            this.dOSSIERMINBALANCEDataGridViewTextBoxColumn,
            this.Edit2});
            this.dataGridView2.DataSource = this.dOSSIERBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(41, 245);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(747, 201);
            this.dataGridView2.TabIndex = 12;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // dOSSIERBindingSource
            // 
            this.dOSSIERBindingSource.DataMember = "DOSSIER";
            this.dOSSIERBindingSource.DataSource = this.personalFinanceDataSet;
            // 
            // personalFinanceDataSet
            // 
            this.personalFinanceDataSet.DataSetName = "PersonalFinanceDataSet";
            this.personalFinanceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cLIENTEGNDataGridViewTextBoxColumn
            // 
            this.cLIENTEGNDataGridViewTextBoxColumn.DataPropertyName = "CLIENT_EGN";
            this.cLIENTEGNDataGridViewTextBoxColumn.HeaderText = "EGN";
            this.cLIENTEGNDataGridViewTextBoxColumn.Name = "cLIENTEGNDataGridViewTextBoxColumn";
            this.cLIENTEGNDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cLIENTNAMEDataGridViewTextBoxColumn
            // 
            this.cLIENTNAMEDataGridViewTextBoxColumn.DataPropertyName = "CLIENT_NAME";
            this.cLIENTNAMEDataGridViewTextBoxColumn.HeaderText = "NAME";
            this.cLIENTNAMEDataGridViewTextBoxColumn.Name = "cLIENTNAMEDataGridViewTextBoxColumn";
            this.cLIENTNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cLIENTSURNAMEDataGridViewTextBoxColumn
            // 
            this.cLIENTSURNAMEDataGridViewTextBoxColumn.DataPropertyName = "CLIENT_SURNAME";
            this.cLIENTSURNAMEDataGridViewTextBoxColumn.HeaderText = "SURNAME";
            this.cLIENTSURNAMEDataGridViewTextBoxColumn.Name = "cLIENTSURNAMEDataGridViewTextBoxColumn";
            this.cLIENTSURNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cLIENTLASTNAMEDataGridViewTextBoxColumn
            // 
            this.cLIENTLASTNAMEDataGridViewTextBoxColumn.DataPropertyName = "CLIENT_LASTNAME";
            this.cLIENTLASTNAMEDataGridViewTextBoxColumn.HeaderText = "LASTNAME";
            this.cLIENTLASTNAMEDataGridViewTextBoxColumn.Name = "cLIENTLASTNAMEDataGridViewTextBoxColumn";
            this.cLIENTLASTNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cLIENTEMAILDataGridViewTextBoxColumn
            // 
            this.cLIENTEMAILDataGridViewTextBoxColumn.DataPropertyName = "CLIENT_EMAIL";
            this.cLIENTEMAILDataGridViewTextBoxColumn.HeaderText = "EMAIL";
            this.cLIENTEMAILDataGridViewTextBoxColumn.Name = "cLIENTEMAILDataGridViewTextBoxColumn";
            this.cLIENTEMAILDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cLIENTPHONEDataGridViewTextBoxColumn
            // 
            this.cLIENTPHONEDataGridViewTextBoxColumn.DataPropertyName = "CLIENT_PHONE";
            this.cLIENTPHONEDataGridViewTextBoxColumn.HeaderText = "PHONE";
            this.cLIENTPHONEDataGridViewTextBoxColumn.Name = "cLIENTPHONEDataGridViewTextBoxColumn";
            this.cLIENTPHONEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cLIENTBindingSource
            // 
            this.cLIENTBindingSource.DataMember = "CLIENT";
            this.cLIENTBindingSource.DataSource = this.personalFinanceDataSet;
            // 
            // cLIENTTableAdapter
            // 
            this.cLIENTTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ADDRESSTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CLIENTTableAdapter = this.cLIENTTableAdapter;
            this.tableAdapterManager.DOSSIER_DETAILSTableAdapter = null;
            this.tableAdapterManager.DOSSIERTableAdapter = null;
            this.tableAdapterManager.INCOME_EXPNECETableAdapter = null;
            this.tableAdapterManager.LOGINTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = UI_Project.PersonalFinanceDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dOSSIERTableAdapter
            // 
            this.dOSSIERTableAdapter.ClearBeforeFill = true;
            // 
            // dOSSIERNODataGridViewTextBoxColumn
            // 
            this.dOSSIERNODataGridViewTextBoxColumn.DataPropertyName = "DOSSIER_NO";
            this.dOSSIERNODataGridViewTextBoxColumn.HeaderText = "DOSSIER_NO";
            this.dOSSIERNODataGridViewTextBoxColumn.Name = "dOSSIERNODataGridViewTextBoxColumn";
            this.dOSSIERNODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cLIENTIDDataGridViewTextBoxColumn
            // 
            this.cLIENTIDDataGridViewTextBoxColumn.DataPropertyName = "CLIENT_ID";
            this.cLIENTIDDataGridViewTextBoxColumn.HeaderText = "CLIENT_ID";
            this.cLIENTIDDataGridViewTextBoxColumn.Name = "cLIENTIDDataGridViewTextBoxColumn";
            this.cLIENTIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dOSSIERYEARDataGridViewTextBoxColumn
            // 
            this.dOSSIERYEARDataGridViewTextBoxColumn.DataPropertyName = "DOSSIER_YEAR";
            this.dOSSIERYEARDataGridViewTextBoxColumn.HeaderText = "YEAR";
            this.dOSSIERYEARDataGridViewTextBoxColumn.Name = "dOSSIERYEARDataGridViewTextBoxColumn";
            this.dOSSIERYEARDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dOSSIERSTATUSDataGridViewTextBoxColumn
            // 
            this.dOSSIERSTATUSDataGridViewTextBoxColumn.DataPropertyName = "DOSSIER_STATUS";
            this.dOSSIERSTATUSDataGridViewTextBoxColumn.HeaderText = "STATUS";
            this.dOSSIERSTATUSDataGridViewTextBoxColumn.Name = "dOSSIERSTATUSDataGridViewTextBoxColumn";
            this.dOSSIERSTATUSDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dOSSIERMINBALANCEDataGridViewTextBoxColumn
            // 
            this.dOSSIERMINBALANCEDataGridViewTextBoxColumn.DataPropertyName = "DOSSIER_MIN_BALANCE";
            this.dOSSIERMINBALANCEDataGridViewTextBoxColumn.HeaderText = "MIN_BALANCE";
            this.dOSSIERMINBALANCEDataGridViewTextBoxColumn.Name = "dOSSIERMINBALANCEDataGridViewTextBoxColumn";
            this.dOSSIERMINBALANCEDataGridViewTextBoxColumn.ReadOnly = true;
            this.dOSSIERMINBALANCEDataGridViewTextBoxColumn.Width = 130;
            // 
            // Edit2
            // 
            this.Edit2.HeaderText = "EDIT";
            this.Edit2.Name = "Edit2";
            this.Edit2.ReadOnly = true;
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 476);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Search";
            this.Text = "Search";
            this.Load += new System.EventHandler(this.Search_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOSSIERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalFinanceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private PersonalFinanceDataSet personalFinanceDataSet;
        private System.Windows.Forms.BindingSource cLIENTBindingSource;
        private PersonalFinanceDataSetTableAdapters.CLIENTTableAdapter cLIENTTableAdapter;
        private PersonalFinanceDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLIENTEGNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLIENTNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLIENTSURNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLIENTLASTNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLIENTEMAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLIENTPHONEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource dOSSIERBindingSource;
        private PersonalFinanceDataSetTableAdapters.DOSSIERTableAdapter dOSSIERTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOSSIERNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLIENTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOSSIERYEARDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOSSIERSTATUSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOSSIERMINBALANCEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Edit2;
    }
}