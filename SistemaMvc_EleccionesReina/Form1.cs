using SistemaEleccionReina.Datos;

namespace SistemaMvc_EleccionesReina
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Conexion conexion = new Conexion();
            bool resultado = conexion.ProbarConexion();

            MessageBox.Show(resultado ? "Conectado correctamente" : "Error de conexión");
        }

    }
}
