using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    [Serializable]
    public class SimpleRoom: Room
    {
        public SimpleRoom(List<Client> listaDeClientes)
        {
            Tipo = "Sencilla";
            Estado = "Libre";
            Espacio = "Chico";
            Sala = "No";
            Comedor = "Si";
            Cama = "1 Matrimonial";
            Baño = "Baño estandar";
            VistaAlMar = "No";
        }

        public SimpleRoom()
        {
        }
    }
}
