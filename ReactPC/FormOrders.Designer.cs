namespace ReactPC
{
    partial class FormOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrders));
            this.comboBoxClient = new System.Windows.Forms.ComboBox();
            this.richTextBoxProblem = new System.Windows.Forms.RichTextBox();
            this.textBoxSerial = new System.Windows.Forms.TextBox();
            this.comboBoxModel = new System.Windows.Forms.ComboBox();
            this.dateTo = new System.Windows.Forms.DateTimePicker();
            this.buttonNewOrder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.iconPictureBoxClear = new FontAwesome.Sharp.IconPictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.textBoxPoisk = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxClear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxClient
            // 
            this.comboBoxClient.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxClient.FormattingEnabled = true;
            this.comboBoxClient.Location = new System.Drawing.Point(36, 172);
            this.comboBoxClient.Name = "comboBoxClient";
            this.comboBoxClient.Size = new System.Drawing.Size(146, 25);
            this.comboBoxClient.TabIndex = 2;
            // 
            // richTextBoxProblem
            // 
            this.richTextBoxProblem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.richTextBoxProblem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxProblem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxProblem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.richTextBoxProblem.Location = new System.Drawing.Point(36, 286);
            this.richTextBoxProblem.Name = "richTextBoxProblem";
            this.richTextBoxProblem.Size = new System.Drawing.Size(313, 130);
            this.richTextBoxProblem.TabIndex = 3;
            this.richTextBoxProblem.Text = "";
            // 
            // textBoxSerial
            // 
            this.textBoxSerial.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBoxSerial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSerial.Enabled = false;
            this.textBoxSerial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSerial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(46)))), ((int)(((byte)(204)))));
            this.textBoxSerial.Location = new System.Drawing.Point(36, 449);
            this.textBoxSerial.Multiline = true;
            this.textBoxSerial.Name = "textBoxSerial";
            this.textBoxSerial.Size = new System.Drawing.Size(313, 33);
            this.textBoxSerial.TabIndex = 4;
            this.textBoxSerial.Text = "4000";
            // 
            // comboBoxModel
            // 
            this.comboBoxModel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxModel.FormattingEnabled = true;
            this.comboBoxModel.Location = new System.Drawing.Point(206, 234);
            this.comboBoxModel.Name = "comboBoxModel";
            this.comboBoxModel.Size = new System.Drawing.Size(143, 25);
            this.comboBoxModel.TabIndex = 5;
            // 
            // dateTo
            // 
            this.dateTo.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTo.Location = new System.Drawing.Point(36, 234);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(146, 21);
            this.dateTo.TabIndex = 6;
            // 
            // buttonNewOrder
            // 
            this.buttonNewOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(60)))), ((int)(((byte)(247)))));
            this.buttonNewOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNewOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNewOrder.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNewOrder.ForeColor = System.Drawing.Color.White;
            this.buttonNewOrder.Location = new System.Drawing.Point(36, 493);
            this.buttonNewOrder.Name = "buttonNewOrder";
            this.buttonNewOrder.Size = new System.Drawing.Size(146, 47);
            this.buttonNewOrder.TabIndex = 7;
            this.buttonNewOrder.Text = "Записать";
            this.buttonNewOrder.UseVisualStyleBackColor = false;
            this.buttonNewOrder.Click += new System.EventHandler(this.buttonNewOrder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(46)))), ((int)(((byte)(204)))));
            this.label1.Location = new System.Drawing.Point(32, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Клиент";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(46)))), ((int)(((byte)(204)))));
            this.label2.Location = new System.Drawing.Point(32, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "Дата приемы";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(46)))), ((int)(((byte)(204)))));
            this.label3.Location = new System.Drawing.Point(32, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "Описание проблемы";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(46)))), ((int)(((byte)(204)))));
            this.label4.Location = new System.Drawing.Point(32, 424);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "Серийный номер";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(46)))), ((int)(((byte)(204)))));
            this.label5.Location = new System.Drawing.Point(202, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 21);
            this.label5.TabIndex = 12;
            this.label5.Text = "Модель";
            // 
            // comboBoxType
            // 
            this.comboBoxType.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(206, 171);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(143, 25);
            this.comboBoxType.TabIndex = 13;
            this.comboBoxType.SelectionChangeCommitted += new System.EventHandler(this.comboBoxType_SelectionChangeCommitted);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(46)))), ((int)(((byte)(204)))));
            this.label6.Location = new System.Drawing.Point(202, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 21);
            this.label6.TabIndex = 14;
            this.label6.Text = "Тип";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(60)))), ((int)(((byte)(247)))));
            this.label7.Location = new System.Drawing.Point(150, 582);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(562, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "После нажатия на кнопку \"ЗАПИСАТЬ\" будет произведена печать Акта приема";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // iconPictureBoxClear
            // 
            this.iconPictureBoxClear.BackColor = System.Drawing.Color.Snow;
            this.iconPictureBoxClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconPictureBoxClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(60)))), ((int)(((byte)(247)))));
            this.iconPictureBoxClear.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.iconPictureBoxClear.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(60)))), ((int)(((byte)(247)))));
            this.iconPictureBoxClear.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBoxClear.IconSize = 47;
            this.iconPictureBoxClear.Location = new System.Drawing.Point(298, 493);
            this.iconPictureBoxClear.Name = "iconPictureBoxClear";
            this.iconPictureBoxClear.Size = new System.Drawing.Size(51, 47);
            this.iconPictureBoxClear.TabIndex = 15;
            this.iconPictureBoxClear.TabStop = false;
            this.iconPictureBoxClear.Click += new System.EventHandler(this.iconPictureBoxClear_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ReactPC.Properties.Resources.client_orders;
            this.pictureBox2.Location = new System.Drawing.Point(385, 35);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(551, 505);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ReactPC.Properties.Resources.чек_печать;
            this.pictureBox1.Location = new System.Drawing.Point(686, 427);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(380, 602);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Приемщик:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(451, 602);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(33, 13);
            this.lblUsername.TabIndex = 18;
            this.lblUsername.Text = "name";
            // 
            // textBoxPoisk
            // 
            this.textBoxPoisk.Location = new System.Drawing.Point(36, 73);
            this.textBoxPoisk.Multiline = true;
            this.textBoxPoisk.Name = "textBoxPoisk";
            this.textBoxPoisk.Size = new System.Drawing.Size(313, 26);
            this.textBoxPoisk.TabIndex = 19;
            this.textBoxPoisk.TextChanged += new System.EventHandler(this.textBoxPoisk_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(46)))), ((int)(((byte)(204)))));
            this.label9.Location = new System.Drawing.Point(32, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(161, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "Поиск в базе клиента";
            // 
            // FormOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(948, 624);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxPoisk);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.iconPictureBoxClear);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonNewOrder);
            this.Controls.Add(this.dateTo);
            this.Controls.Add(this.comboBoxModel);
            this.Controls.Add(this.textBoxSerial);
            this.Controls.Add(this.richTextBoxProblem);
            this.Controls.Add(this.comboBoxClient);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormOrders";
            this.Text = "Заявки";
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxClear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox comboBoxClient;
        private System.Windows.Forms.RichTextBox richTextBoxProblem;
        private System.Windows.Forms.TextBox textBoxSerial;
        private System.Windows.Forms.ComboBox comboBoxModel;
        private System.Windows.Forms.DateTimePicker dateTo;
        private System.Windows.Forms.Button buttonNewOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label label6;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxClear;
        private System.Windows.Forms.Label label7;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox textBoxPoisk;
        private System.Windows.Forms.Label label9;
    }
}