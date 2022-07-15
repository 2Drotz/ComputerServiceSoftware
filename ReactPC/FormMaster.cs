using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.Data.SqlClient;

namespace ReactPC
{
    public partial class FormMaster : Form
    {
        DBConnect database = new DBConnect();
        private readonly checkAdmin _user;

        //поля
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        public FormMaster(checkAdmin user)
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(8, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            //форма
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            _user = user;
        }

        private void FormMaster_Load(object sender, EventArgs e)
        {
            lblUsername.Text = $"{_user.Login}: {_user.Status}";
            labelName();
            labelOrders();
            labelRepair();
            labelSumRepair();
        }

        private void labelOrders()
        {

            string countUser = $"select COUNT(*)  FROM orders WHERE id_status = 1";
            SqlCommand command = new SqlCommand(countUser, database.getConnection());

            database.openConnection();
            SqlDataReader read = command.ExecuteReader();

            while (read.Read())
            {
                lblOrders.Text = read[""].ToString();
            }
            read.Close();

        }
        private void labelRepair()
        {
            string countUser = $"select COUNT(*)  FROM orders WHERE id_status != 5 and id_status != 4 and id_status != 1";
            SqlCommand command = new SqlCommand(countUser, database.getConnection());

            database.openConnection();
            SqlDataReader read = command.ExecuteReader();

            while (read.Read())
            {
                lblrepair.Text = read[""].ToString();
            }
            read.Close();
        }
        private void labelSumRepair()
        {
            string countUser = $"SELECT SUM(cost) FROM orders WHERE date_from BETWEEN DATEADD(D, -7, GETDATE()) AND GETDATE()";
            SqlCommand command = new SqlCommand(countUser, database.getConnection());

            database.openConnection();
            SqlDataReader read = command.ExecuteReader();

            while (read.Read())
            {
                labelCostRepair.Text = read[""].ToString();
            }
            read.Close();
        }

        //Структура цветов
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(255, 128, 0);
            public static Color color6 = Color.FromArgb(24, 161, 251);

        }

        //Методы
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(6, 46, 204);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Current Child Form Icon
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = Color.FromArgb(13, 60, 247);
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(13, 60, 247);
                currentBtn.ForeColor = Color.Snow;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Snow;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.Text = childForm.Text;
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.FromArgb(13, 60, 247);
            lblTitleChildForm.Text = "Главная";
        }

        //Events
        //Reset

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            Reset();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            OpenChildForm(new FormSetting(_user));
        }

        private void btnNewOrders_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            OpenChildForm(new FormNewOrders(_user));
        }
        private void btnRepair_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            OpenChildForm(new FormRepair(_user));
        }
        private void btnFauld_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            OpenChildForm(new FormFault());
        }
        private void btnTypesJobs_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            OpenChildForm(new FormJobs());
        }
        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы хотите закрыть ReactPC?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void labelName()
        {
            var nameuser = lblUsername.Text;
            string nameUser = $"SELECT CONCAT(name_user, ' ' , surname_user) AS userss FROM users WHERE login_user  = '{_user.Login}'";
            SqlCommand command = new SqlCommand(nameUser, database.getConnection());

            database.openConnection();
            SqlDataReader read = command.ExecuteReader();

            while (read.Read())
            {
                labelNameUser.Text = read["userss"].ToString();
            }
            read.Close();

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Выйти с этого аккаунта?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Sign frmSign = new Sign();
                this.Hide();
                frmSign.ShowDialog();
                this.Show();
            }
        }

        private void btnExit_MouseEnter(object sender, EventArgs e)
        {
            btnExit.IconColor = Color.FromArgb(235, 83, 83);
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            btnExit.IconColor = Color.FromArgb(13, 60, 247);
        }
    }
}
