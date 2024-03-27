using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IShop.App.UserRegistration
{
    internal interface IUserStorage
    {
        public void Save(UserEntity user);        
        
    }
}
