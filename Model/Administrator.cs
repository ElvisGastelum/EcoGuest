using System;

namespace Model
{
    [Serializable]
    public class Administrator
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public Administrator(string username, string password, string email)
        {
            Username = username;
            Password = password;
            Email = email;
        }
        public Administrator()
        {
        }
    }
}