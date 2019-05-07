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
            this.bt_newClient = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.personalFinanceDataSet = new UI_Project.PersonalFinanceDataSet();
            this.cLIENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cLIENTTableAdapter = new UI_Project.PersonalFinanceDataSetTableAdapters.CLIENTTableAdapter();
            this.tableAdapterManager = new UI_Project.PersonalFinanceDataSetTableAdapters.TableAdapterManager();
            this.cLIENTBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.cLIENTBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cLIENTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLIENTEGNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLIENTNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLIENTSURNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLIENTLASTNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLIENTEMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLIENTPHONEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalFinanceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTBindingNavigator)).BeginInit();
            this.cLIENTBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(64, 25);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(64, 21);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Client";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(303, 25);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(77, 21);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Dossier";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(64, 144);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(317, 22);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 86);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Type of Search";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(201, 82);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(180, 24);
            this.comboBox1.TabIndex = 4;
            // 
            // bt_newClient
            // 
            this.bt_newClient.Image = ((System.Drawing.Image)(resources.GetObject("bt_newClient.Image")));
            this.bt_newClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_newClient.Location = new System.Drawing.Point(412, 198);
            this.bt_newClient.Margin = new System.Windows.Forms.Padding(4);
            this.bt_newClient.Name = "bt_newClient";
            this.bt_newClient.Size = new System.Drawing.Size(77, 31);
            this.bt_newClient.TabIndex = 7;
            this.bt_newClient.Text = "New";
            this.bt_newClient.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_newClient.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(412, 140);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 31);
            this.button1.TabIndex = 8;
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cLIENTIDDataGridViewTextBoxColumn,
            this.cLIENTEGNDataGridViewTextBoxColumn,
            this.cLIENTNAMEDataGridViewTextBoxColumn,
            this.cLIENTSURNAMEDataGridViewTextBoxColumn,
            this.cLIENTLASTNAMEDataGridViewTextBoxColumn,
            this.cLIENTEMAILDataGridViewTextBoxColumn,
            this.cLIENTPHONEDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cLIENTBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(41, 237);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(448, 217);
            this.dataGridView1.TabIndex = 9;
            // 
            // personalFinanceDataSet
            // 
            this.personalFinanceDataSet.DataSetName = "PersonalFinanceDataSet";
            this.personalFinanceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // cLIENTBindingNavigator
            // 
            this.cLIENTBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cLIENTBindingNavigator.BindingSource = this.cLIENTBindingSource;
            this.cLIENTBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cLIENTBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.cLIENTBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cLIENTBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.cLIENTBindingNavigatorSaveItem});
            this.cLIENTBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.cLIENTBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cLIENTBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cLIENTBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cLIENTBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cLIENTBindingNavigator.Name = "cLIENTBindingNavigator";
            this.cLIENTBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cLIENTBindingNavigator.Size = new System.Drawing.Size(531, 27);
            this.cLIENTBindingNavigator.TabIndex = 10;
            this.cLIENTBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 20);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // cLIENTBindingNavigatorSaveItem
            // 
            this.cLIENTBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cLIENTBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cLIENTBindingNavigatorSaveItem.Image")));
            this.cLIENTBindingNavigatorSaveItem.Name = "cLIENTBindingNavigatorSaveItem";
            this.cLIENTBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.cLIENTBindingNavigatorSaveItem.Text = "Save Data";
            this.cLIENTBindingNavigatorSaveItem.Click += new System.EventHandler(this.cLIENTBindingNavigatorSaveItem_Click);
            // 
            // cLIENTIDDataGridViewTextBoxColumn
            // 
            this.cLIENTIDDataGridViewTextBoxColumn.DataPropertyName = "CLIENT_ID";
            this.cLIENTIDDataGridViewTextBoxColumn.HeaderText = "CLIENT_ID";
            this.cLIENTIDDataGridViewTextBoxColumn.Name = "cLIENTIDDataGridViewTextBoxColumn";
            this.cLIENTIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cLIENTEGNDataGridViewTextBoxColumn
            // 
            this.cLIENTEGNDataGridViewTextBoxColumn.DataPropertyName = "CLIENT_EGN";
            this.cLIENTEGNDataGridViewTextBoxColumn.HeaderText = "CLIENT_EGN";
            this.cLIENTEGNDataGridViewTextBoxColumn.Name = "cLIENTEGNDataGridViewTextBoxColumn";
            // 
            // cLIENTNAMEDataGridViewTextBoxColumn
            // 
            this.cLIENTNAMEDataGridViewTextBoxColumn.DataPropertyName = "CLIENT_NAME";
            this.cLIENTNAMEDataGridViewTextBoxColumn.HeaderText = "CLIENT_NAME";
            this.cLIENTNAMEDataGridViewTextBoxColumn.Name = "cLIENTNAMEDataGridViewTextBoxColumn";
            // 
            // cLIENTSURNAMEDataGridViewTextBoxColumn
            // 
            this.cLIENTSURNAMEDataGridViewTextBoxColumn.DataPropertyName = "CLIENT_SURNAME";
            this.cLIENTSURNAMEDataGridViewTextBoxColumn.HeaderText = "CLIENT_SURNAME";
            this.cLIENTSURNAMEDataGridViewTextBoxColumn.Name = "cLIENTSURNAMEDataGridViewTextBoxColumn";
            // 
            // cLIENTLASTNAMEDataGridViewTextBoxColumn
            // 
            this.cLIENTLASTNAMEDataGridViewTextBoxColumn.DataPropertyName = "CLIENT_LASTNAME";
            this.cLIENTLASTNAMEDataGridViewTextBoxColumn.HeaderText = "CLIENT_LASTNAME";
            this.cLIENTLASTNAMEDataGridViewTextBoxColumn.Name = "cLIENTLASTNAMEDataGridViewTextBoxColumn";
            // 
            // cLIENTEMAILDataGridViewTextBoxColumn
            // 
            this.cLIENTEMAILDataGridViewTextBoxColumn.DataPropertyName = "CLIENT_EMAIL";
            this.cLIENTEMAILDataGridViewTextBoxColumn.HeaderText = "CLIENT_EMAIL";
            this.cLIENTEMAILDataGridViewTextBoxColumn.Name = "cLIENTEMAILDataGridViewTextBoxColumn";
            // 
            // cLIENTPHONEDataGridViewTextBoxColumn
            // 
            this.cLIENTPHONEDataGridViewTextBoxColumn.DataPropertyName = "CLIENT_PHONE";
            this.cLIENTPHONEDataGridViewTextBoxColumn.HeaderText = "CLIENT_PHONE";
            this.cLIENTPHONEDataGridViewTextBoxColumn.Name = "cLIENTPHONEDataGridViewTextBoxColumn";
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 497);
            this.Controls.Add(this.cLIENTBindingNavigator);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bt_newClient);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Search";
            this.Text = "Search";
            this.Load += new System.EventHandler(this.Search_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalFinanceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTBindingNavigator)).EndInit();
            this.cLIENTBindingNavigator.ResumeLayout(false);
            this.cLIENTBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button bt_newClient;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private PersonalFinanceDataSet personalFinanceDataSet;
        private System.Windows.Forms.BindingSource cLIENTBindingSource;
        private PersonalFinanceDataSetTableAdapters.CLIENTTableAdapter cLIENTTableAdapter;
        private PersonalFinanceDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator cLIENTBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton cLIENTBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLIENTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLIENTEGNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLIENTNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLIENTSURNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLIENTLASTNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLIENTEMAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLIENTPHONEDataGridViewTextBoxColumn;
    }
}