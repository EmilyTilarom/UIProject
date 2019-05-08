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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pasTxt = new System.Windows.Forms.TextBox();
            this.loginPas = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.useTxt = new System.Windows.Forms.TextBox();
            this.loginUser = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pasTxt);
            this.panel1.Controls.Add(this.loginPas);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.useTxt);
            this.panel1.Controls.Add(this.loginUser);
            this.panel1.Location = new System.Drawing.Point(375, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(271, 245);
            this.panel1.TabIndex = 5;
            // 
            // pasTxt
            // 
            this.pasTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pasTxt.Location = new System.Drawing.Point(135, 91);
            this.pasTxt.Name = "pasTxt";
            this.pasTxt.PasswordChar = '*';
            this.pasTxt.Size = new System.Drawing.Size(100, 22);
            this.pasTxt.TabIndex = 1;
            // 
            // loginPas
            // 
            this.loginPas.AutoSize = true;
            this.loginPas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginPas.Location = new System.Drawing.Point(13, 97);
            this.loginPas.Name = "loginPas";
            this.loginPas.Size = new System.Drawing.Size(116, 16);
            this.loginPas.TabIndex = 10;
            this.loginPas.Text = "Enter Password";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(77, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // useTxt
            // 
            this.useTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.useTxt.Location = new System.Drawing.Point(138, 30);
            this.useTxt.Name = "useTxt";
            this.useTxt.Size = new System.Drawing.Size(100, 22);
            this.useTxt.TabIndex = 0;
            // 
            // loginUser
            // 
            this.loginUser.AutoSize = true;
            this.loginUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginUser.Location = new System.Drawing.Point(13, 30);
            this.loginUser.Name = "loginUser";
            this.loginUser.Size = new System.Drawing.Size(119, 16);
            this.loginUser.TabIndex = 5;
            this.loginUser.Text = "Enter Username";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(33, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(280, 245);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(701, 338);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Login";
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
    }
}

