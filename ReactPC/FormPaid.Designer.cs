namespace ReactPC
{
    partial class FormPaid
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPaid));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxStatusPaid = new System.Windows.Forms.TextBox();
            this.iconPictureBoxClear = new FontAwesome.Sharp.IconPictureBox();
            this.btnPaid = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCash = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.textBoxSerial = new System.Windows.Forms.TextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.znak = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxClear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.znak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxStatusPaid);
            this.groupBox1.Controls.Add(this.iconPictureBoxClear);
            this.groupBox1.Controls.Add(this.btnPaid);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxCash);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxTotal);
            this.groupBox1.Controls.Add(this.textBoxSerial);
            this.groupBox1.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(46)))), ((int)(((byte)(204)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 386);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(505, 226);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Данные о платеже";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(46)))), ((int)(((byte)(204)))));
            this.label2.Location = new System.Drawing.Point(199, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "Статус оплаты";
            // 
            // textBoxStatusPaid
            // 
            this.textBoxStatusPaid.Enabled = false;
            this.textBoxStatusPaid.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStatusPaid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxStatusPaid.Location = new System.Drawing.Point(203, 74);
            this.textBoxStatusPaid.Multiline = true;
            this.textBoxStatusPaid.Name = "textBoxStatusPaid";
            this.textBoxStatusPaid.Size = new System.Drawing.Size(140, 31);
            this.textBoxStatusPaid.TabIndex = 10;
            // 
            // iconPictureBoxClear
            // 
            this.iconPictureBoxClear.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBoxClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconPictureBoxClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(60)))), ((int)(((byte)(247)))));
            this.iconPictureBoxClear.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.iconPictureBoxClear.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(60)))), ((int)(((byte)(247)))));
            this.iconPictureBoxClear.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBoxClear.IconSize = 40;
            this.iconPictureBoxClear.Location = new System.Drawing.Point(459, 155);
            this.iconPictureBoxClear.Name = "iconPictureBoxClear";
            this.iconPictureBoxClear.Size = new System.Drawing.Size(40, 41);
            this.iconPictureBoxClear.TabIndex = 9;
            this.iconPictureBoxClear.TabStop = false;
            this.iconPictureBoxClear.Click += new System.EventHandler(this.iconPictureBoxClear_Click);
            // 
            // btnPaid
            // 
            this.btnPaid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPaid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaid.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPaid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(60)))), ((int)(((byte)(247)))));
            this.btnPaid.Location = new System.Drawing.Point(360, 155);
            this.btnPaid.Name = "btnPaid";
            this.btnPaid.Size = new System.Drawing.Size(93, 41);
            this.btnPaid.TabIndex = 8;
            this.btnPaid.Text = "Оплатить";
            this.btnPaid.UseVisualStyleBackColor = true;
            this.btnPaid.Click += new System.EventHandler(this.btnPaid_Click);
            this.btnPaid.MouseEnter += new System.EventHandler(this.btnPaid_MouseEnter);
            this.btnPaid.MouseLeave += new System.EventHandler(this.btnPaid_MouseLeave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(46)))), ((int)(((byte)(204)))));
            this.label4.Location = new System.Drawing.Point(199, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Оплата";
            // 
            // textBoxCash
            // 
            this.textBoxCash.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCash.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxCash.Location = new System.Drawing.Point(203, 165);
            this.textBoxCash.Multiline = true;
            this.textBoxCash.Name = "textBoxCash";
            this.textBoxCash.Size = new System.Drawing.Size(137, 31);
            this.textBoxCash.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(46)))), ((int)(((byte)(204)))));
            this.label3.Location = new System.Drawing.Point(6, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Цена к оплате";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(46)))), ((int)(((byte)(204)))));
            this.label1.Location = new System.Drawing.Point(6, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Серийный номер";
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxTotal.Location = new System.Drawing.Point(10, 165);
            this.textBoxTotal.Multiline = true;
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.Size = new System.Drawing.Size(140, 31);
            this.textBoxTotal.TabIndex = 1;
            // 
            // textBoxSerial
            // 
            this.textBoxSerial.Enabled = false;
            this.textBoxSerial.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSerial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxSerial.Location = new System.Drawing.Point(10, 74);
            this.textBoxSerial.Multiline = true;
            this.textBoxSerial.Name = "textBoxSerial";
            this.textBoxSerial.Size = new System.Drawing.Size(140, 31);
            this.textBoxSerial.TabIndex = 0;
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
            this.printPreviewDialog1.ShowIcon = false;
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // znak
            // 
            this.znak.Image = global::ReactPC.Properties.Resources.чек_печать;
            this.znak.Location = new System.Drawing.Point(910, 402);
            this.znak.Name = "znak";
            this.znak.Size = new System.Drawing.Size(156, 142);
            this.znak.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.znak.TabIndex = 3;
            this.znak.TabStop = false;
            this.znak.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ReactPC.Properties.Resources.calc;
            this.pictureBox1.Location = new System.Drawing.Point(635, 371);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(254, 241);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeight = 30;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(923, 367);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick_1);
            // 
            // FormPaid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(948, 624);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.znak);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPaid";
            this.Text = "Оплата заказа";
            this.Load += new System.EventHandler(this.FormPaid_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxClear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.znak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.TextBox textBoxSerial;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxCash;
        private System.Windows.Forms.Button btnPaid;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxClear;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.PictureBox znak;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxStatusPaid;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}