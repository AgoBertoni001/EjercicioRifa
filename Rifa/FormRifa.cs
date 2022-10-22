using System.Net;

namespace Rifa
{
    public partial class FormRifa : Form
    {
        
        public FormRifa()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            string nombre = tboxNombrePersona.Text;
            string apellido = tboxApellidoPersona.Text;
            int numRifa = int.Parse(tboxNumRifaElegido.Text);
        
            
            bool losDatosSonCorrectos = Validaciones(nombre,apellido,numRifa);

            try
            {
                if (losDatosSonCorrectos)
                {   
                    AgregarAListaUsuario(nombre, apellido, numRifa);
                    MostrarMensajeExito(nombre, apellido, numRifa);
                }
                else
                {
                    MostrarMensajeError();
                }
            }
            catch
            {
                MostrarMensajeError();
            }
            finally
            {
                tboxNombrePersona.Clear();
                tboxApellidoPersona.Clear();
                tboxNumRifaElegido.Clear();
            }
                
            

            
        }
        public static bool Validaciones(string nombre, string apellido, int numRifa)
        {
            bool elNombreEsValido=ElNombreEsValido(nombre);
            bool elApellidoEsValido=ElApellidoEsValido(apellido);
            bool elNumeroElegidoEsValido=ElNumeroElegidoEsValido(numRifa);
            bool elNumeroEstaDisponible = Usuario.ElNumeroEstaDisponible(numRifa);

            static bool ElNombreEsValido(string nombre)
            {
                bool esValido;
                if (nombre.Length == 0)
                {
                    esValido= false;
                }
                else
                {
                    esValido= true;
                }
                return esValido;
            }

            static bool ElApellidoEsValido(string apellido)
            {
                bool esValido;
                if (apellido.Length == 0)
                {
                    esValido= false;
                }
                else
                {
                    esValido= true;
                }
                return esValido;
            }

            static bool ElNumeroElegidoEsValido(int numRifa)
            {
                bool esValido;
                if (numRifa > 0 && numRifa < 999)
                {

                    esValido= true;
                }
                else
                {
                    esValido= false;
                }
                return esValido;
            }


            if (elNombreEsValido && elApellidoEsValido && elNumeroElegidoEsValido && elNumeroEstaDisponible)
            {
                return true;
            }
            else
            {
                return false;
            }

        
        }

        public static void MostrarMensajeExito(string nombre, string apellido, int numRifa)
        {
            MessageBox.Show($"Se ha guardado el {numRifa} al usuario {nombre} {apellido}.");
        }

        public static void AgregarAListaUsuario(string nombre, string apellido, int numRifa)
        {
            Usuario.listaUsuario.Add(new Usuario()
            {
                Nombre = nombre,
                Apellido = apellido,
                NumeroElegido = numRifa
            });

            

        }

        public static void MostrarMensajeError()
        {
            MessageBox.Show($"No se ha podido registrar el numero de rifa. Ingrese otro numero y complete todos los campos.");
        }
    }
        
}
