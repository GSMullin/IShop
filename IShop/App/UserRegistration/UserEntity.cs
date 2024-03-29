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


        public RegistrationResult Registration(UserRegistrationInput dataInput)
        {
            RegistrationResult result = new RegistrationResult();

            bool isCorrectLoginLenght = dataInput.Login.Length > 3 & dataInput.Login.Length < 8;
            if (isCorrectLoginLenght==false)
            {
                result.RegistrationError("Неверное кол-во символов");
            }

            result.RegistrationSucces();
            return result;
        }

        public void Save()
        {
            _storage.Save(this);
        }
    }
}
