namespace ReactPC
{
    partial class Sign
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sign));
            this.textBox_log = new System.Windows.Forms.TextBox();
            this.textBox_pass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnReg = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnClear = new FontAwesome.Sharp.IconButton();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.PictureBoxClear = new FontAwesome.Sharp.IconPictureBox();
            this.btnLogin = new FontAwesome.Sharp.IconButton();
            this.PictureBoxUnvis = new FontAwesome.Sharp.IconPictureBox();
            this.PictureBoxVis = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxClear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxUnvis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxVis)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_log
            // 
            this.textBox_log.BackColor = System.Drawing.Color.LightGray;
            this.textBox_log.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_log.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_log.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(62)))), ((int)(((byte)(218)))));
            this.textBox_log.Location = new System.Drawing.Point(33, 129);
            this.textBox_log.Multiline = true;
            this.textBox_log.Name = "textBox_log";
            this.textBox_log.Size = new System.Drawing.Size(216, 32);
            this.textBox_log.TabIndex = 0;
            // 
            // textBox_pass
            // 
            this.textBox_pass.BackColor = System.Drawing.Color.LightGray;
            this.textBox_pass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_pass.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_pass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(62)))), ((int)(((byte)(218)))));
            this.textBox_pass.Location = new System.Drawing.Point(33, 189);
            this.textBox_pass.Multiline = true;
            this.textBox_pass.Name = "textBox_pass";
            this.textBox_pass.Size = new System.Drawing.Size(216, 32);
            this.textBox_pass.TabIndex = 1;
            this.textBox_pass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_pass_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Quicksand", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(46)))), ((int)(((byte)(204)))));
            this.label1.Location = new System.Drawing.Point(29, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 40);
            this.label1.TabIndex = 8;
            this.label1.Text = "Авторизация";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Quicksand", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(46)))), ((int)(((byte)(204)))));
            this.label2.Location = new System.Drawing.Point(29, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 23);
            this.label2.TabIndex = 13;
            this.label2.Text = "Пароль";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Quicksand", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(46)))), ((int)(((byte)(204)))));
            this.label3.Location = new System.Drawing.Point(29, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 23);
            this.label3.TabIndex = 14;
            this.label3.Text = "Логин";
            // 
            // btnReg
            // 
            this.btnReg.AutoSize = true;
            this.btnReg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReg.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(46)))), ((int)(((byte)(204)))));
            this.btnReg.Location = new System.Drawing.Point(96, 426);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(93, 17);
            this.btnReg.TabIndex = 15;
            this.btnReg.Text = "Восстановить";
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.DarkGray;
            this.label5.Location = new System.Drawing.Point(88, 407);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Забыли пароль?";
            // 
            // btnClear
            // 
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(46)))), ((int)(((byte)(204)))));
            this.btnClear.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnClear.IconColor = System.Drawing.Color.Black;
            this.btnClear.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClear.Location = new System.Drawing.Point(33, 334);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(216, 35);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.Transparent;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnExit.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(46)))), ((int)(((byte)(204)))));
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 25;
            this.btnExit.Location = new System.Drawing.Point(254, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(26, 25);
            this.btnExit.TabIndex = 10;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.MouseEnter += new System.EventHandler(this.btnExit_MouseEnter);
            this.btnExit.MouseLeave += new System.EventHandler(this.btnExit_MouseLeave);
            this.btnExit.MouseHover += new System.EventHandler(this.btnExit_MouseHover);
            // 
            // PictureBoxClear
            // 
            this.PictureBoxClear.BackColor = System.Drawing.Color.Snow;
            this.PictureBoxClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBoxClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(46)))), ((int)(((byte)(204)))));
            this.PictureBoxClear.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.PictureBoxClear.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(46)))), ((int)(((byte)(204)))));
            this.PictureBoxClear.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.PictureBoxClear.Location = new System.Drawing.Point(241, 447);
            this.PictureBoxClear.Name = "PictureBoxClear";
            this.PictureBoxClear.Size = new System.Drawing.Size(32, 32);
            this.PictureBoxClear.TabIndex = 9;
            this.PictureBoxClear.TabStop = false;
            this.PictureBoxClear.Click += new System.EventHandler(this.PictureBoxClear_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(46)))), ((int)(((byte)(204)))));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLogin.ForeColor = System.Drawing.Color.Snow;
            this.btnLogin.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnLogin.IconColor = System.Drawing.Color.Black;
            this.btnLogin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogin.Location = new System.Drawing.Point(33, 293);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(216, 35);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "Войти";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // PictureBoxUnvis
            // 
            this.PictureBoxUnvis.BackColor = System.Drawing.Color.Snow;
            this.PictureBoxUnvis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBoxUnvis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(46)))), ((int)(((byte)(204)))));
            this.PictureBoxUnvis.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            this.PictureBoxUnvis.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(46)))), ((int)(((byte)(204)))));
            this.PictureBoxUnvis.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.PictureBoxUnvis.IconSize = 37;
            this.PictureBoxUnvis.Location = new System.Drawing.Point(123, 238);
            this.PictureBoxUnvis.Name = "PictureBoxUnvis";
            this.PictureBoxUnvis.Size = new System.Drawing.Size(37, 38);
            this.PictureBoxUnvis.TabIndex = 6;
            this.PictureBoxUnvis.TabStop = false;
            this.PictureBoxUnvis.Click += new System.EventHandler(this.PictureBoxUnvis_Click);
            // 
            // PictureBoxVis
            // 
            this.PictureBoxVis.BackColor = System.Drawing.Color.Snow;
            this.PictureBoxVis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBoxVis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(46)))), ((int)(((byte)(204)))));
            this.PictureBoxVis.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.PictureBoxVis.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(46)))), ((int)(((byte)(204)))));
            this.PictureBoxVis.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.PictureBoxVis.IconSize = 37;
            this.PictureBoxVis.Location = new System.Drawing.Point(123, 238);
            this.PictureBoxVis.Name = "PictureBoxVis";
            this.PictureBoxVis.Size = new System.Drawing.Size(37, 38);
            this.PictureBoxVis.TabIndex = 5;
            this.PictureBoxVis.TabStop = false;
            this.PictureBoxVis.Click += new System.EventHandler(this.PictureBoxVis_Click);
            // 
            // Sign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(285, 491);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.PictureBoxClear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.PictureBoxUnvis);
            this.Controls.Add(this.PictureBoxVis);
            this.Controls.Add(this.textBox_pass);
            this.Controls.Add(this.textBox_log);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Sign";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign";
            this.Load += new System.EventHandler(this.Sign_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxClear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxUnvis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxVis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_log;
        private System.Windows.Forms.TextBox textBox_pass;
        private FontAwesome.Sharp.IconPictureBox PictureBoxVis;
        private FontAwesome.Sharp.IconPictureBox PictureBoxUnvis;
        private FontAwesome.Sharp.IconButton btnLogin;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconPictureBox PictureBoxClear;
        private FontAwesome.Sharp.IconButton btnExit;
        private FontAwesome.Sharp.IconButton btnClear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label btnReg;
        private System.Windows.Forms.Label label5;
    }
}