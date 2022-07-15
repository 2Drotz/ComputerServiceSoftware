using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using System.Net;
using System.Net.Mail;
using MaterialSkin.Controls;
using System.Data.SqlClient;

namespace ReactPC
{
    public partial class ForgetPass : Form
    {
        DBConnect database = new DBConnect();
        public ForgetPass()
        {
            InitializeComponent();
        }
        Random random = new Random();
        private int code;
        private void Mail()
        {

            code = random.Next(111111, 999999);
            const string pass = "lfqwijpaxmsxpkag";


            MailMessage message = new MailMessage();
            SmtpClient smtp = new SmtpClient();

            message.From = new MailAddress("yndx-mandrindima@yandex.ru");


            message.To.Add(new MailAddress(textBox_mail.Text));
            message.Subject = "Изменение пароля";
            message.Body = "Добрый день, вы отправили запрос на изменение пароля\nКод для восстановления (никому не сообщайте) \n" + code + "\nСпасибо вам за обращение!";

            smtp.Port = 587;
            smtp.Host = "smtp.yandex.ru";
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential("yndx-mandrindima@yandex.ru", pass);
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Send(message);
            MessageBox.Show("Код успешно отправлен на почту " + textBox_mail.Text);


        }

        private void checkMail()
        { //  метод почты зарегестрированныз аккаунтов

            var mail_user = textBox_mail.Text;

            string queryCheck = $"select mail_user from users where mail_user = '{mail_user}'";
            SqlCommand command = new SqlCommand(queryCheck, database.getConnection());

            SqlDataAdapter adapter = new SqlDataAdapter(); // объекты класса
            DataTable dtable = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(dtable);
            if (dtable.Rows.Count != 1)
            {
                MessageBox.Show("Данная почта не зарегестрирована в ReactPC", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            { 
                Mail();
                btnMailTo.Text = "Отправить код повторно";
                textBox_newpass.Enabled = true;
                labelpass.Enabled = true;
                textBox_code.Enabled = true;
                labelcode.Enabled = true;
            }
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            if (code.ToString() == textBox_code.Text)
            {
                Update();
                MessageBox.Show("Успешно, пароль изменен", "Восстановление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("Вы ввели неверный код", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnMailTo_Click(object sender, EventArgs e)
        {
            if (textBox_mail.Text == "")
            {
                MessageBox.Show("Введите почту для восстановления пароля!", "Восстановление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (textBox_mail.Text.Contains("@gmail.com") || textBox_mail.Text.Contains("@yandex.ru") || textBox_mail.Text.Contains("@mail.ru")) 
            {
                checkMail();
            }
            else
            {
                MessageBox.Show("Неверный формат почты", "Восстановление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Update()
        {
            database.openConnection();
            var new_pass = md5.hashPassword(textBox_newpass.Text);
            var mail_user = textBox_mail.Text;

            var changeQuery3 = $"update users set password_user = '{new_pass}' where mail_user = '{mail_user}'";
            var command3 = new SqlCommand(changeQuery3, database.getConnection());
            command3.ExecuteNonQuery();
            database.closeConnection();
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox_code.Text = "";
            textBox_mail.Text = "";
            textBox_newpass.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void labelLog_Click(object sender, EventArgs e)
        {
            Sign frmSign = new Sign();
            this.Hide();
            frmSign.ShowDialog();
            this.Show();
        }

        private void ForgetPass_Load(object sender, EventArgs e)
        {
            textBox_newpass.PasswordChar = '•';
        }

        private void PictureBoxUnvis_Click(object sender, EventArgs e)
        {
            textBox_newpass.UseSystemPasswordChar = true;
            PictureBoxUnvis.Visible = false;
            PictureBoxVis.Visible = true;
        }

        private void PictureBoxVis_Click(object sender, EventArgs e)
        {
            textBox_newpass.UseSystemPasswordChar = false;
            PictureBoxUnvis.Visible = true;
            PictureBoxVis.Visible = false;
        }

    }

}

