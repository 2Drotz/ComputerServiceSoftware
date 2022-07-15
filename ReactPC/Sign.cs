using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ReactPC
{
    public partial class Sign : Form
    {
        
        DBConnect database = new DBConnect();
        public Sign()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Sign_Load(object sender, EventArgs e)
        {
            textBox_pass.PasswordChar = '•';
            PictureBoxVis.Visible = false;
            textBox_log.MaxLength = 50;
            textBox_log.MaxLength = 50;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {


            if (textBox_log.Text == "" || textBox_pass.Text == "")
            {
                MessageBox.Show("Данные не введены!", "Авторизация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var loginUser = textBox_log.Text;// переменные дял запроса и сранения с тексбокс
                var passUser = md5.hashPassword(textBox_pass.Text);
                string _role = "";
                SqlDataAdapter adapter = new SqlDataAdapter(); // объекты класса
                DataTable dtable = new DataTable();

                string queryLogin = $"select id_user, login_user, password_user, admin_user, role  from users INNER JOIN role ON(users.id_role = role.id_role)" +
                    $" where login_user = '{loginUser}' and password_user = '{passUser}'"; // sql запрос

                SqlCommand command = new SqlCommand(queryLogin, database.getConnection());

                adapter.SelectCommand = command;
                adapter.Fill(dtable);
                database.openConnection();
                SqlDataReader reader = command.ExecuteReader();

                if (dtable.Rows.Count == 1)
                {
                    reader.Read();
                    _role = reader["role"].ToString();
                    //MessageBox.Show(reader["role_user"].ToString());
                    if (_role == "Инженер")
                    {
                        var user = new checkAdmin(dtable.Rows[0].ItemArray[1].ToString(), Convert.ToBoolean(dtable.Rows[0].ItemArray[3]));
                        MessageBox.Show("Вы успешно вошли в систему!" + " " + loginUser + "", "Авторизация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FormMaster fm = new FormMaster(user);
                        this.Hide();
                        fm.ShowDialog();
                        this.Show();
                    }
                    else
                    {
                        var user = new checkAdmin(dtable.Rows[0].ItemArray[1].ToString(), Convert.ToBoolean(dtable.Rows[0].ItemArray[3]));

                        MessageBox.Show("Вы успешно вошли в систему!", "Авторизация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FormMainMenu frmMain = new FormMainMenu(user);
                        this.Hide();
                        frmMain.ShowDialog();
                        this.Show();
                    }
                }

                else
                {
                    textBox_pass.Text = "";
                    MessageBox.Show("Что то не так, проверьте правильность логина и пароля!");
                }
                database.closeConnection();
            }
        }


        private void PictureBoxUnvis_Click(object sender, EventArgs e)
        {
            textBox_pass.UseSystemPasswordChar = true;
            PictureBoxUnvis.Visible = false;
            PictureBoxVis.Visible=true;
        }

        private void PictureBoxVis_Click(object sender, EventArgs e)
        {
            textBox_pass.UseSystemPasswordChar = false;
            PictureBoxUnvis.Visible = true;
            PictureBoxVis.Visible = false;
        }

        private void PictureBoxClear_Click(object sender, EventArgs e)
        {
            textBox_pass.Text = "";
            textBox_log.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox_pass.Text = "";
            textBox_log.Text = "";
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            ForgetPass frmReg = new ForgetPass();
            this.Hide();
            frmReg.ShowDialog();
            this.Show();
        }
        public static Color color1 = Color.FromArgb(6, 46, 204);
        private void btnExit_MouseEnter(object sender, EventArgs e)
        {
            btnExit.IconColor = Color.FromArgb(235, 83, 83);
            btnExit.BackColor = Color.Snow;
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            btnExit.IconColor = color1;
        }

        private void btnExit_MouseHover(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.Transparent;
        }

        private void textBox_pass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnLogin_Click(sender, e);
        }
    }
}
