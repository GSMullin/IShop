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
            //BtnCloseFormRegistration.ForeColor = Color.Blue;
            this.Close();
        }

        private void BtnCreateAccaount_Click(object sender, EventArgs e)
        {
            IUserStorage storage = new UserStorage(); //Объявили хранилище данных
            UserEntity userEntity = new UserEntity(storage); //Объявили саму бизнес-логику пользователя
            UserRegistrationInput input = new UserRegistrationInput(); //Объявили параметры для регистрации
            userEntity.Registration(input); //Вызов у бизнес логики метод регистрации
            userEntity.Save(); //Вызов у бизнес логики метод сохранения
        }
    }
}
