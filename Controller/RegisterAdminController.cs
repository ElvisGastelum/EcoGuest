using Model;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Controller
{
    public class RegisterAdminController
    {
        private void SaveAdmin(Administrator administrator)
        {
            List<Administrator> list = GetAdministrators();
            administrator.Password = Encrypt.GetSHA256(administrator.Password);
            list.Add(administrator);
            Writer.Save(list, Directory.Administrators);
            
        }

        public bool SaveAdmin(string username, string password, string repitedPassword, string email)
        {
            if (password == repitedPassword)
            {
                SaveAdmin(
                    new Administrator(
                        username,
                        password,
                        email
                    )
                );
                return true;
            }
            return false;
        }

        private List<Administrator> GetAdministrators()
        {
            return Reader.Load<List<Administrator>>(Directory.Administrators);
        }
    }
}