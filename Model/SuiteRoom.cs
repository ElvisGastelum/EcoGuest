using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    [Serializable]
    public class SuiteRoom: Room
    {
        public SuiteRoom(List<IClient> listaDeClientes)
        {
            Tipo = "Suite";
            Estado = "Libre";
            Espacio = "Grande";
            Sala = "Si";
            Comedor = "Si";
            Cama = "1 King Size";
            Baño = "Baño con tina";
            VistaAlMar = "Si";
        }

        public SuiteRoom()
        {
        }
    }
}
