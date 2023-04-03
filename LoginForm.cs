using KONTROL.Properties;
using System.Collections.Specialized;
using System.Net;
using System.Text;

namespace KONTROL
{
    public partial class LoginForm : Form
    {
        NameValueCollection dataToSend = new();
        public LoginForm()
        {
            InitializeComponent();

            usernameBox.Text = Settings.Default["Username"].ToString();
            passwordBox.Text = Settings.Default["Password"].ToString();

            if (usernameBox.Text?.Length >= 1)
                rememCheck.Checked = true;
            else if (usernameBox.Text?.Length <= 0)
                rememCheck.Checked = false;

            this.ActiveControl = buttonContinueLogin; // убираем фокус с usernameBox и кидаем на кнопку

            ToolTip ttsp = new ToolTip();
            ttsp.SetToolTip(showPassword, "Показать пароль");

            ToolTip tthp = new ToolTip();
            tthp.SetToolTip(hidePassword, "Скрыть пароль");
        }

        void rememCheck_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default["Username"] = usernameBox.Text;
            Settings.Default["Password"] = passwordBox.Text;
            Settings.Default.Save();

            if (rememCheck.Checked == false)
            {
                Settings.Default.Reset();
            }
        }

        void buttonContinueLogin_Click(object sender, EventArgs e)
        {
            dataToSend["username"] = usernameBox.Text;
            dataToSend["password"] = passwordBox.Text;

            try
            {
                // Using освобождает поток как только он заканчиавает инструкцию 
                using (WebClient client = new())
                {
                    string GetData = Encoding.UTF8.GetString(client.UploadValues(@"http://localhost/login.php", dataToSend));

                    if (GetData == "nodata")
                        MessageBox.Show("нет базы данных");
                    else if (GetData == "wrongpass")
                        MessageBox.Show("Неверный пароль");
                    else if (GetData == "loginnotfound")
                        MessageBox.Show("Пользователь не найден");
                    else if (GetData == "OK")
                    {
                        ChoiceForm cf = new();
                        cf.ShowDialog();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Сервер недоступен", "Ошибка");
            }
        }

        void regLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistrationForm rf = new();
            rf.ShowDialog();
        }

        private void showPassword_Click(object sender, EventArgs e)
        {
            if (passwordBox.UseSystemPasswordChar == true)
            {
                passwordBox.UseSystemPasswordChar = false;
                showPassword.Visible = false;
                hidePassword.Visible = true;
            }
        }

        private void hidePassword_Click(object sender, EventArgs e)
        {
            if (passwordBox.UseSystemPasswordChar == false)
            {
                passwordBox.UseSystemPasswordChar = true;
                hidePassword.Visible = false;
                showPassword.Visible = true;
            }
        }
    }
}
