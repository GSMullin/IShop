using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IShop.App.UserRegistration
{
    internal class UserEntity
    {
        public UserEntity(IUserStorage storage)
        {
            _storage = storage;
        }


        private IUserStorage _storage;

        //Пользователю понятно в каком поле проблема?
        //Как избавится от раздувания if(но не от кол-ва проверок)?
        //В пароле должен быть спец символ?
        //Как показать пользователю сразу все ошибки?

        public RegistrationResult Registration(UserRegistrationInput dataInput)
        {
            
            RegistrationResult result = new RegistrationResult();
            result.RegistrationSucces();

            bool isCorrectLoginLenght = dataInput.Login.Length > 3 & dataInput.Login.Length < 8;
            if (isCorrectLoginLenght==false)
            {
                result.RegistrationError("Логин Неверное кол-во символов");
            }

            bool isCorrectPasswordLenght = dataInput.Password.Length > 5 & dataInput.Password.Length < 10;
            if (isCorrectPasswordLenght == false)
            {
                result.RegistrationError("Пароль Неверное кол-во символов");
            }

            return result;
        }

        public void Save()
        {
            _storage.Save(this);
        }
    }
}
