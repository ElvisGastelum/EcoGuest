using System;
using System.Collections.Generic;

namespace Model
{
    [Serializable]
    public abstract class Room: IRoom
    {
        public string Tipo { get; set; }
        public string Estado { get; set; }
        public string Espacio { get; set; }
        public string Sala { get; set; }
        public string Comedor { get; set; }
        public string Cama { get; set; }
        public string Baño { get; set; }
        public string VistaAlMar { get; set; }
        private List<Client> listaDeClientes;

        public Room()
        {
        }

        public List<Client> GetClients()
        {
            return listaDeClientes;
        }

        public void SetClients(List<Client> listOfClients)
        {
            if (listOfClients != null)
            {
                this.listaDeClientes = listOfClients;
            }
        }

        public void AddClient(Client client)
        {
            if (client != null)
            {
                this.listaDeClientes.Add(client);
            }
        }
    }
}