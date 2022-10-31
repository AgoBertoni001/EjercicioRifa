using System.Net;
using System.IO;

namespace Rifa
{
    public partial class FormRifa : Form
    {
        
        public FormRifa()
        {
            InitializeComponent();
        }

        private void FormRifa_Load(object sender, EventArgs e)
        {
            btnGuardar.Enabled = false;
        }
        private void tboxNombrePersona_TextChanged(object sender, EventArgs e)
        {
            HabilitarBtnGuardar();
        }

        private void tboxApellidoPersona_TextChanged(object sender, EventArgs e)
        {
            HabilitarBtnGuardar();
        }

        private void tboxNumRifaElegido_TextChanged(object sender, EventArgs e)
        {
            HabilitarBtnGuardar();
        }

        private void HabilitarBtnGuardar()
        {
            if (tboxNombrePersona.Text!="" && tboxApellidoPersona.Text!="" && tboxNumRifaElegido.Text!="")
            {
                btnGuardar.Enabled = true;
            }
            else
            {
                btnGuardar.Enabled = false;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            string nombre = tboxNombrePersona.Text;
            string apellido = tboxApellidoPersona.Text;
            int numRifa = int.Parse(tboxNumRifaElegido.Text);
            string hora = DateTime.Now.ToString("HH:mm:ss");
            string fecha = DateTime.Now.ToShortDateString();

            try
            {
                if (Rifa.ElNumeroEstaDisponible(numRifa))
                {
                    AgregarAListaRifa(nombre, apellido, numRifa, fecha, hora);
                    AgregarDatosATxt();
                    MostrarMensajeExito(nombre, apellido, numRifa, hora, fecha);
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

        public static void MostrarMensajeExito(string nombre, string apellido, int numRifa, string hora, string fecha)
        {
            MessageBox.Show($"Se ha guardado el {numRifa} al usuario {nombre} {apellido}.\nHora:{hora} Fecha:{fecha}");
        }

        public static void AgregarAListaRifa(string nombre, string apellido, int numRifa, string fecha, string hora)
        {
            Rifa.listaRifa.Add(new Rifa()
            {
                Nombre = nombre,
                Apellido = apellido,
                NumeroElegido = numRifa,
                Fecha = fecha,
                Hora = hora
            });

        }

        public static void AgregarDatosATxt()
        {
            try
            {
                StreamWriter sw = new StreamWriter("C:\\Users\\Agostina\\OneDrive - UTN San Francisco\\1.FACULTAD\\2022\\8.Construccion de software\\Programacion\\NumerosEntregados.txt");

                for (int i = 0; i < Rifa.listaRifa.Count; i++)
                {
                    sw.WriteLine($"{Rifa.listaRifa[i]}");
                }
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }

        public static void MostrarMensajeError()
        {
            MessageBox.Show($"No se ha podido registrar el numero de rifa. Ingrese otro numero y complete todos los campos.");
        }
    }

        
}
