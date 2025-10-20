using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryBazanInicioSesion
{
    public partial class frmPrograma : Form
    {
        public frmPrograma()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        
        private void btnAceptar_Click(object sender, EventArgs e)
        {
           string Usuario = txtUsuario.Text;
           string Contraseña = txtContraseña.Text;
            if (Usuario == DatosUsuario.Usuario && Contraseña == DatosUsuario.Contraseña)
              {
                MessageBox.Show("¡Inicio de sesión exitoso!", "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);
              }
              else
              {
                MessageBox.Show("Usuario o contraseña incorrectos. Intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
