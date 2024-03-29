using IShop.App.UserRegistration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace IShop.Storag
{
    internal class UserStorage : IUserStorage
    {
        private UserEntity _user;
        public void Save(UserEntity user)
        {
            _user = user;
        }
    }
}
