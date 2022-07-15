namespace ReactPC
{
    partial class FormNewOrders
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxid = new System.Windows.Forms.TextBox();
            this.btnDiagnostic = new FontAwesome.Sharp.IconButton();
            this.label_role = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Snow;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(924, 493);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // textBoxid
            // 
            this.textBoxid.Location = new System.Drawing.Point(832, 594);
            this.textBoxid.Name = "textBoxid";
            this.textBoxid.Size = new System.Drawing.Size(100, 20);
            this.textBoxid.TabIndex = 2;
            this.textBoxid.Visible = false;
            // 
            // btnDiagnostic
            // 
            this.btnDiagnostic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(60)))), ((int)(((byte)(247)))));
            this.btnDiagnostic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDiagnostic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiagnostic.Font = new System.Drawing.Font("Quicksand", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiagnostic.ForeColor = System.Drawing.Color.Snow;
            this.btnDiagnostic.IconChar = FontAwesome.Sharp.IconChar.Handshake;
            this.btnDiagnostic.IconColor = System.Drawing.Color.Snow;
            this.btnDiagnostic.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnDiagnostic.Location = new System.Drawing.Point(303, 523);
            this.btnDiagnostic.Name = "btnDiagnostic";
            this.btnDiagnostic.Size = new System.Drawing.Size(254, 68);
            this.btnDiagnostic.TabIndex = 1;
            this.btnDiagnostic.Text = "Взять заказ";
            this.btnDiagnostic.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDiagnostic.UseVisualStyleBackColor = false;
            this.btnDiagnostic.Click += new System.EventHandler(this.btnDiagnostic_Click);
            // 
            // label_role
            // 
            this.label_role.AutoSize = true;
            this.label_role.Location = new System.Drawing.Point(829, 578);
            this.label_role.Name = "label_role";
            this.label_role.Size = new System.Drawing.Size(52, 13);
            this.label_role.TabIndex = 3;
            this.label_role.Text = "label_role";
            this.label_role.Visible = false;
            // 
            // FormNewOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 624);
            this.Controls.Add(this.label_role);
            this.Controls.Add(this.textBoxid);
            this.Controls.Add(this.btnDiagnostic);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormNewOrders";
            this.Text = "Новые заказы";
            this.Load += new System.EventHandler(this.FormNewOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private FontAwesome.Sharp.IconButton btnDiagnostic;
        private System.Windows.Forms.TextBox textBoxid;
        private System.Windows.Forms.Label label_role;
    }
}