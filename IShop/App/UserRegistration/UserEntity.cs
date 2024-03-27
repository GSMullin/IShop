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


        public void Registration(UserRegistrationInput dataInput)
        {
            bool isCorrectLoginLenght = dataInput.Login.Length > 3 & dataInput.Login.Length < 8;
            if (isCorrectLoginLenght==false)
            {
                throw new Exception("Неверное кол-во символов");
            }
        }

        public void Save()
        {
            _storage.Save(this);
        }
    }
}
