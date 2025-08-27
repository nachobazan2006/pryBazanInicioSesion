namespace pryBazanInicioSesion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 ventanaform1 = new Form1();   
            ventanaform1.ShowDialog();  
        }
    }
}
