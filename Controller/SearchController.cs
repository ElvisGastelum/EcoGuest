using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Model;

namespace Controller
{
    public class SearchController
    {
        public BindingList<Client> GetList()
        {
            return Reader.Load<BindingList<Client>>(Directory.Clients);
        }

        public void SetList(BindingList<Client> list)
        {
            Writer.Save(list, Directory.Clients);
        }

        public BindingList<Client> SearchClientsByName(BindingList<Client> refList, string name, BindingList<Client> sourceList)
        {
            var resultList = new BindingList<Client>();
            foreach (var client in sourceList)
            {
                if (client.Nombre.ToLower().Contains(name.ToLower()))
                {
                    resultList.Add(client);
                }
            }
            refList.Clear();
            foreach (var client in resultList)
            {
                refList.Add(client);
            }

            return resultList;
        }
    }
}