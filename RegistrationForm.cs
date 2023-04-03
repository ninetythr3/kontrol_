using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KONTROL
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
            this.ActiveControl = buttonContinueRegistration; // убираем фокус с usernameBox и кидаем на кнопку

        }

        void buttonContinueRegistration_Click(object sender, EventArgs e)
        {
            if (usernameRegBox.Text == "")
            {
                MessageBox.Show("Не заполнено поле \"Логин\"");
            }
            else if (passwordRegBox.Text == "")
            {
                MessageBox.Show("Не заполнено поле \"Пароль\"");
            }
            else
            {
                using (var client = new WebClient())
                {
                    var values = new NameValueCollection();
                    values["username"] = usernameRegBox.Text;
                    values["password"] = passwordRegBox.Text;
                    var response = client.UploadValues("http://localhost/registration.php", values);
                    var responseString = Encoding.Default.GetString(response);

                    if (responseString == "false")
                    {
                        // выводим сообщение о том, что логин занят
                        MessageBox.Show("Данный логин уже занят, пожалуйста, выберите другой логин.");
                    }
                    else if (responseString == "true")
                    {
                        // выводим сообщение о том, что данные пользователя успешно добавлены в базу данных
                        MessageBox.Show("Регистрация прошла успешно");
                    }
                    else
                    {
                        // выводим сообщение об ошибке
                        MessageBox.Show("Произошла ошибка при добавлении пользователя в базу данных");
                    }

                }

/*                DialogResult dialogResult = MessageBox.Show("Регистрация прошла успешно", "", MessageBoxButtons.OK);
                if (dialogResult == DialogResult.OK)
                {
                    Close();
                }*/
            }

        }
    }
}
