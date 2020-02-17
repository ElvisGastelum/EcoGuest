using System.ComponentModel;
using Model;

namespace Controller
{
    public class ClientModificationController
    {
        private SearchController searchController;
        public ClientModificationController()
        {
            searchController = new SearchController();
        }

        public void ModificationClient(Client client, BindingList<Client> list, int index)
        {
            list.RemoveAt(index);
            list.Insert(index, client);
            searchController.SetList(list);
        }

    }
}