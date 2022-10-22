using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rifa
{
    public class Usuario
    {
        public static List<Usuario> listaUsuario = new List<Usuario>();

        public string Nombre { get; set; } = String.Empty;
        public string Apellido { get; set; } = String.Empty;
        public int NumeroElegido { get; set; }

        
        public static bool ElNumeroEstaDisponible(int numRifa)
        {
            bool disponible = true;
            for(int i = 0; i < listaUsuario.Count; i++)
            {
                if (numRifa == listaUsuario[i].NumeroElegido)
                {
                    MessageBox.Show("El numero no está disponible");
                    disponible= false;
                }
                else {
                    MessageBox.Show("El numero está disponible");
                }
            }
            return disponible;
        }
    }

}
