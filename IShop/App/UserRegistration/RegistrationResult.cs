using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IShop.App.UserRegistration
{
    internal class RegistrationResult
    {
        public bool IsSucces { get; private set; }
        public string Message { get; private set; } = "Ошибка не описана";

        public void RegistrationSucces () 
        {
            IsSucces = true;
        }

        public void RegistrationError(string messageError) 
        {
            IsSucces = false;
            Message = messageError;
        }
    }
}
