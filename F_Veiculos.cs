namespace Sposito
{
    public partial class F_Veiculos : Form
    {
        F_Principal fp;
        public F_Veiculos(string v, F_Principal f)
        {
            InitializeComponent();
            tb_listaVeiculos.Text = v;

            fp = f;
            fp.num = 10;
        }

        private void F_Veiculos_FormClosed(object sender, FormClosedEventArgs e)
        {
            fp.tb_listaVeiculos.Text = tb_listaVeiculos.Text;

        }
    }
}
