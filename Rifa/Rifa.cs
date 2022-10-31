using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Rifa
{
    public class Rifa
    {
        public static List<Rifa> listaRifa = new List<Rifa>()
        {
            new Rifa{Nombre="Agostina",Apellido="Bertoni",NumeroElegido=4,Fecha="28-10-2022",Hora="16:15:06"},
            new Rifa{Nombre="Martina",Apellido="Boeto",NumeroElegido=17,Fecha="28-10-2022",Hora="16:17:16"},
            new Rifa{Nombre="Florencia",Apellido="Geneyer",NumeroElegido=14,Fecha="28-10-2022",Hora="17:05:24"}
        };

        public string Nombre { get; set; } = String.Empty;
        public string Apellido { get; set; } = String.Empty;
        public int NumeroElegido { get; set; }
        public string Hora { get; set; } = String.Empty;   
        public string Fecha { get; set; } = String.Empty;

        
        public static bool ElNumeroEstaDisponible(int numRifa)
        {
            bool disponible = true;
            for(int i = 0; i < listaRifa.Count; i++)
            {
                if (numRifa == listaRifa[i].NumeroElegido)
                {
                    disponible= false;
                }
            }
            return disponible;
        }

        public override string ToString()
        {
            return String.Format($"\n {NumeroElegido} --> Comprado por:{Nombre.ToUpper()[0] + Nombre.Substring(1)} {Apellido.ToUpper()[0] + Apellido.Substring(1)}\n\t Fecha: {Fecha} Hora: {Hora}\n");
        }

    }

}
