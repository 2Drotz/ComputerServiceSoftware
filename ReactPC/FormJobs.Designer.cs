namespace ReactPC
{
    partial class FormJobs
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.iconPictureBoxRefresh = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBoxClear = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBoxSearch = new FontAwesome.Sharp.IconPictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxClear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Quicksand", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(46)))), ((int)(((byte)(204)))));
            this.label1.Location = new System.Drawing.Point(401, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Каталог";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSearch.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSearch.Location = new System.Drawing.Point(211, 40);
            this.textBoxSearch.Multiline = true;
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(452, 32);
            this.textBoxSearch.TabIndex = 9;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(60)))), ((int)(((byte)(247)))));
            this.btnNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNew.ForeColor = System.Drawing.Color.Snow;
            this.btnNew.Location = new System.Drawing.Point(320, 561);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(124, 51);
            this.btnNew.TabIndex = 11;
            this.btnNew.Text = "Новый";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelete.ForeColor = System.Drawing.Color.Snow;
            this.btnDelete.Location = new System.Drawing.Point(460, 561);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(124, 51);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // iconPictureBoxRefresh
            // 
            this.iconPictureBoxRefresh.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBoxRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(60)))), ((int)(((byte)(247)))));
            this.iconPictureBoxRefresh.IconChar = FontAwesome.Sharp.IconChar.UndoAlt;
            this.iconPictureBoxRefresh.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(60)))), ((int)(((byte)(247)))));
            this.iconPictureBoxRefresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBoxRefresh.Location = new System.Drawing.Point(707, 40);
            this.iconPictureBoxRefresh.Name = "iconPictureBoxRefresh";
            this.iconPictureBoxRefresh.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBoxRefresh.TabIndex = 8;
            this.iconPictureBoxRefresh.TabStop = false;
            this.iconPictureBoxRefresh.Click += new System.EventHandler(this.iconPictureBoxRefresh_Click);
            // 
            // iconPictureBoxClear
            // 
            this.iconPictureBoxClear.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBoxClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(60)))), ((int)(((byte)(247)))));
            this.iconPictureBoxClear.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.iconPictureBoxClear.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(60)))), ((int)(((byte)(247)))));
            this.iconPictureBoxClear.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBoxClear.Location = new System.Drawing.Point(669, 40);
            this.iconPictureBoxClear.Name = "iconPictureBoxClear";
            this.iconPictureBoxClear.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBoxClear.TabIndex = 7;
            this.iconPictureBoxClear.TabStop = false;
            this.iconPictureBoxClear.Click += new System.EventHandler(this.iconPictureBoxClear_Click);
            // 
            // iconPictureBoxSearch
            // 
            this.iconPictureBoxSearch.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBoxSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(60)))), ((int)(((byte)(247)))));
            this.iconPictureBoxSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconPictureBoxSearch.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(60)))), ((int)(((byte)(247)))));
            this.iconPictureBoxSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBoxSearch.Location = new System.Drawing.Point(179, 40);
            this.iconPictureBoxSearch.Name = "iconPictureBoxSearch";
            this.iconPictureBoxSearch.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBoxSearch.TabIndex = 6;
            this.iconPictureBoxSearch.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ReactPC.Properties.Resources.line_blue;
            this.pictureBox1.Location = new System.Drawing.Point(712, 389);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 168);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 30;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(179, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(560, 476);
            this.dataGridView1.TabIndex = 13;
            // 
            // FormJobs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(948, 624);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.iconPictureBoxRefresh);
            this.Controls.Add(this.iconPictureBoxClear);
            this.Controls.Add(this.iconPictureBoxSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormJobs";
            this.Text = "Виды работ";
            this.Load += new System.EventHandler(this.FormJobs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxClear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSearch;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxRefresh;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxClear;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxSearch;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}