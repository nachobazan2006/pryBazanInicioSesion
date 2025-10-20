using System.Security.Cryptography.X509Certificates;

namespace pryBazanInicioSesion
{
    public struct DatosUsuario
    {
        public static string Usuario;
        public static string Contraseña;
    }
    public partial class frmInicioSesion : Form
    {
        public frmInicioSesion()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtContraseña.Text != txtContraseñaConfirmada.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden. Por favor, intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if ( txtUsuario .Text == "" || txtContraseña.Text == "" )
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            DatosUsuario.Usuario = txtUsuario.Text;
            DatosUsuario.Contraseña = txtContraseña.Text;

            frmPrograma ventanaform2 = new frmPrograma();   
            ventanaform2.ShowDialog();  
        }
    }
}
