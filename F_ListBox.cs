namespace Sposito
{
    public partial class F_ListBox : Form
    {
        List<string> carros = new List<string>();
        public F_ListBox()
        {
            InitializeComponent();

            carros.Add("HRV");
            carros.Add("Golf");
            carros.Add("Focus");

            lb_carros.DataSource = carros;
        }
        private void atualizaLB(ListBox lb,List<string>l)
        {
            lb.DataSource = null;
            lb.DataSource = l;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (tb_carro.Text == "")
            {
                MessageBox.Show("Digite um carro");
                tb_carro.Focus();
            }
            else
            {
                carros.Add(tb_carro.Text);
                tb_carro.Clear();
                atualizaLB(lb_carros,carros);
            }
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            carros.RemoveAt(lb_carros.SelectedIndex);
            atualizaLB(lb_carros, carros);
        }

        private void btn_oter_Click(object sender, EventArgs e)
        {
            tb_carro.Text = carros[lb_carros.SelectedIndex];
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            carros.Clear();
            atualizaLB(lb_carros, carros);
        }
    }
}
