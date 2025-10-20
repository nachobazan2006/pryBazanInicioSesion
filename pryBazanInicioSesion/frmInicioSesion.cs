namespace pryBazanInicioSesion
{
    public partial class frmInicioSesion : Form
    {
        public frmInicioSesion()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            frmPrograma ventanaform2 = new frmPrograma();   
            ventanaform2.ShowDialog();  
        }
    }
}
