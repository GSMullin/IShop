using IShop.App.UserRegistration;
using IShop.Storag;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IShop.Client
{
    public partial class FormRegistration : Form
    {
        public FormRegistration()
        {
            InitializeComponent();
        }

        private void BtnCloseFormRegistration_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCreateAccaount_Click(object sender, EventArgs e)
        { 
            IUserStorage storage = new UserStorage(); //Объявили хранилище данных
            UserEntity userEntity = new UserEntity(storage); //Объявили саму бизнес-логику пользователя
            UserRegistrationInput input = new UserRegistrationInput(); //Объявили параметры для регистрации
            input.Login = this.RegistryLoginField.Text;
            input.Password = this.RegistryPassField.Text;
            /*try
            {
                userEntity.Registration(input); //Вызов у бизнес логики метод регистрации
                userEntity.Save(); //Вызов у бизнес логики метод сохранения
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                ex.Message,
                "Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
            }*/
            RegistrationResult result = userEntity.Registration(input);
            if (result.IsSucces == false)
            {
                MessageBox.Show(
               result.Message,
               "Ошибка",
               MessageBoxButtons.OK,
               MessageBoxIcon.Error,
               MessageBoxDefaultButton.Button1,
               MessageBoxOptions.DefaultDesktopOnly);
                return;
            }
            userEntity.Save(); //Вызов у бизнес логики метод сохранения
            Close();
        }

    }
}
