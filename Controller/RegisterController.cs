using System.Collections.Generic;
using Model;

namespace Controller
{
    public class RegisterController
    {
        public void NewClient(Client client)
        {
            List<Client> list = GetClients();
            list.Add(client);
            Writer.Save(list, Directory.Clients);
        }

        private List<Client> GetClients()
        {
            return Reader.Load<List<Client>>(Directory.Clients);
        }
    }
}