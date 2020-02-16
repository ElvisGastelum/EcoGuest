using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public interface IRoom
    {
        List<Client> GetClients();
        void SetClients(List<Client> listOfClients);
        void AddClient(Client client);
    }
}
