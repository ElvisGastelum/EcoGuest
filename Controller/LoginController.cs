using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;
using Model;

namespace Controller
{
    public class LoginController
    {
        public LoginController()
        {

        }

        private List<Administrator> GetAdministrators()
        {
            return Reader.Load<List<Administrator>>(Directory.Administrators);
        }

        public bool Login(string user, string password)
        {
            password = Encrypt.GetSHA256(password);

            if (isCorrectCredencials(user, password))
            {
                MessageBox.Show("Hola, " + user, "Login");
                return true;

            }
            
            MessageBox.Show("Usuario y contraseña incorrectos", "Login");
            return false;
        }

        private bool isCorrectUserAndPassword(string user, string pass, Administrator admin)
        {
            return admin.Username.Equals(user) && admin.Password.Equals(pass); 
        }

        private bool isCorrectCredencials(string user, string password)
        {
            foreach (var administrator in GetAdministrators())
            {
                if (isCorrectUserAndPassword(user, password, administrator))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
