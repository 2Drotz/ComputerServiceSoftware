namespace ReactPC
{
    partial class ForgetPass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgetPass));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_mail = new System.Windows.Forms.TextBox();
            this.textBox_code = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelcode = new System.Windows.Forms.Label();
            this.btnChangePass = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.labelpass = new System.Windows.Forms.Label();
            this.textBox_newpass = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMailTo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelLog = new System.Windows.Forms.Label();
            this.PictureBoxUnvis = new FontAwesome.Sharp.IconPictureBox();
            this.PictureBoxVis = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxUnvis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxVis)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Quicksand", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(46)))), ((int)(((byte)(204)))));
            this.label1.Location = new System.Drawing.Point(26, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Восстановление";
            // 
            // textBox_mail
            // 
            this.textBox_mail.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox_mail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_mail.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_mail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(46)))), ((int)(((byte)(204)))));
            this.textBox_mail.Location = new System.Drawing.Point(34, 182);
            this.textBox_mail.Multiline = true;
            this.textBox_mail.Name = "textBox_mail";
            this.textBox_mail.Size = new System.Drawing.Size(216, 28);
            this.textBox_mail.TabIndex = 1;
            // 
            // textBox_code
            // 
            this.textBox_code.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox_code.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_code.Enabled = false;
            this.textBox_code.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_code.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(46)))), ((int)(((byte)(204)))));
            this.textBox_code.Location = new System.Drawing.Point(34, 276);
            this.textBox_code.Multiline = true;
            this.textBox_code.Name = "textBox_code";
            this.textBox_code.Size = new System.Drawing.Size(216, 28);
            this.textBox_code.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Quicksand", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(46)))), ((int)(((byte)(204)))));
            this.label2.Location = new System.Drawing.Point(31, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Почта";
            // 
            // labelcode
            // 
            this.labelcode.AutoSize = true;
            this.labelcode.Enabled = false;
            this.labelcode.Font = new System.Drawing.Font("Quicksand", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(46)))), ((int)(((byte)(204)))));
            this.labelcode.Location = new System.Drawing.Point(31, 256);
            this.labelcode.Name = "labelcode";
            this.labelcode.Size = new System.Drawing.Size(35, 19);
            this.labelcode.TabIndex = 4;
            this.labelcode.Text = "Код";
            // 
            // btnChangePass
            // 
            this.btnChangePass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(46)))), ((int)(((byte)(204)))));
            this.btnChangePass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePass.Font = new System.Drawing.Font("Quicksand", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePass.ForeColor = System.Drawing.Color.Snow;
            this.btnChangePass.Location = new System.Drawing.Point(35, 433);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Size = new System.Drawing.Size(216, 35);
            this.btnChangePass.TabIndex = 5;
            this.btnChangePass.Text = "Изменить";
            this.btnChangePass.UseVisualStyleBackColor = false;
            this.btnChangePass.Click += new System.EventHandler(this.btnChangePass_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Snow;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Quicksand", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(46)))), ((int)(((byte)(204)))));
            this.btnClear.Location = new System.Drawing.Point(35, 474);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(216, 35);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.Snow;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnExit.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(46)))), ((int)(((byte)(204)))));
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 25;
            this.btnExit.Location = new System.Drawing.Point(262, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(26, 25);
            this.btnExit.TabIndex = 11;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.MouseEnter += new System.EventHandler(this.btnExit_MouseEnter);
            this.btnExit.MouseLeave += new System.EventHandler(this.btnExit_MouseLeave);
            // 
            // labelpass
            // 
            this.labelpass.AutoSize = true;
            this.labelpass.Enabled = false;
            this.labelpass.Font = new System.Drawing.Font("Quicksand", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(46)))), ((int)(((byte)(204)))));
            this.labelpass.Location = new System.Drawing.Point(31, 317);
            this.labelpass.Name = "labelpass";
            this.labelpass.Size = new System.Drawing.Size(108, 19);
            this.labelpass.TabIndex = 13;
            this.labelpass.Text = "Новый пароль";
            // 
            // textBox_newpass
            // 
            this.textBox_newpass.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox_newpass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_newpass.Enabled = false;
            this.textBox_newpass.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_newpass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(46)))), ((int)(((byte)(204)))));
            this.textBox_newpass.Location = new System.Drawing.Point(34, 337);
            this.textBox_newpass.Multiline = true;
            this.textBox_newpass.Name = "textBox_newpass";
            this.textBox_newpass.Size = new System.Drawing.Size(216, 28);
            this.textBox_newpass.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ReactPC.Properties.Resources.rocket;
            this.pictureBox1.Location = new System.Drawing.Point(154, 122);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // btnMailTo
            // 
            this.btnMailTo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMailTo.Font = new System.Drawing.Font("Quicksand", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMailTo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(46)))), ((int)(((byte)(204)))));
            this.btnMailTo.Location = new System.Drawing.Point(35, 215);
            this.btnMailTo.Name = "btnMailTo";
            this.btnMailTo.Size = new System.Drawing.Size(215, 38);
            this.btnMailTo.TabIndex = 18;
            this.btnMailTo.Text = "Отправить код";
            this.btnMailTo.UseVisualStyleBackColor = true;
            this.btnMailTo.Click += new System.EventHandler(this.btnMailTo_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Quicksand", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(46)))), ((int)(((byte)(204)))));
            this.label4.Location = new System.Drawing.Point(28, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 40);
            this.label4.TabIndex = 19;
            this.label4.Text = "пароля";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.DarkGray;
            this.label5.Location = new System.Drawing.Point(69, 529);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Восстановили пароль?";
            // 
            // labelLog
            // 
            this.labelLog.AutoSize = true;
            this.labelLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelLog.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(46)))), ((int)(((byte)(204)))));
            this.labelLog.Location = new System.Drawing.Point(98, 546);
            this.labelLog.Name = "labelLog";
            this.labelLog.Size = new System.Drawing.Size(90, 17);
            this.labelLog.TabIndex = 20;
            this.labelLog.Text = "Авторизация";
            this.labelLog.Click += new System.EventHandler(this.labelLog_Click);
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
            this.PictureBoxUnvis.Location = new System.Drawing.Point(121, 371);
            this.PictureBoxUnvis.Name = "PictureBoxUnvis";
            this.PictureBoxUnvis.Size = new System.Drawing.Size(37, 38);
            this.PictureBoxUnvis.TabIndex = 23;
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
            this.PictureBoxVis.Location = new System.Drawing.Point(121, 371);
            this.PictureBoxVis.Name = "PictureBoxVis";
            this.PictureBoxVis.Size = new System.Drawing.Size(37, 38);
            this.PictureBoxVis.TabIndex = 22;
            this.PictureBoxVis.TabStop = false;
            this.PictureBoxVis.Click += new System.EventHandler(this.PictureBoxVis_Click);
            // 
            // ForgetPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(289, 588);
            this.Controls.Add(this.PictureBoxUnvis);
            this.Controls.Add(this.PictureBoxVis);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelLog);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnMailTo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelpass);
            this.Controls.Add(this.textBox_newpass);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnChangePass);
            this.Controls.Add(this.labelcode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_code);
            this.Controls.Add(this.textBox_mail);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(83)))), ((int)(((byte)(116)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ForgetPass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.Load += new System.EventHandler(this.ForgetPass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxUnvis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxVis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_mail;
        private System.Windows.Forms.TextBox textBox_code;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelcode;
        private System.Windows.Forms.Button btnChangePass;
        private System.Windows.Forms.Button btnClear;
        private FontAwesome.Sharp.IconButton btnExit;
        private System.Windows.Forms.Label labelpass;
        private System.Windows.Forms.TextBox textBox_newpass;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnMailTo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelLog;
        private FontAwesome.Sharp.IconPictureBox PictureBoxUnvis;
        private FontAwesome.Sharp.IconPictureBox PictureBoxVis;
    }
}