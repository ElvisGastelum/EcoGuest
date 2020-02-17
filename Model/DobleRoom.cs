using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    [Serializable]
    public class DobleRoom: Room
    {
        public DobleRoom(List<Client> listaDeClientes)
        {
            Tipo = "Doble";
            Estado = "Libre";
            Espacio = "Mediano";
            Sala = "No";
            Comedor = "Si";
            Cama = "2 Matrimoniales";
            Baño = "Baño estandar";
            VistaAlMar = "No";
        }

        public DobleRoom()
        {
        }
    }
}
