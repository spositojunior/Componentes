namespace Sposito
{
    public partial class F_ListView : Form
    {
        public F_ListView()
        {
            InitializeComponent();
        }

        private void limpar()
        {
            tb_id.Clear();
            tb_produto.Clear();
            tb_qtde.Clear();
            tb_preco.Clear();
            tb_id.Focus();
        }
        private void obter()
        {
            tb_id.Text = lv_produtos.SelectedItems[0].SubItems[0].Text;
            tb_produto.Text = lv_produtos.SelectedItems[0].SubItems[1].Text;
            tb_qtde.Text = lv_produtos.SelectedItems[0].SubItems[2].Text;
            tb_preco.Text = lv_produtos.SelectedItems[0].SubItems[3].Text;
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            if (tb_id.Text == "")
            {
                MessageBox.Show("ID não pode ser vazio");
                tb_id.Focus();
                return;
            }
            string[] pr = new string[4];
            pr[0] = tb_id.Text;
            pr[1] = tb_produto.Text;
            pr[2] = tb_qtde.Text;
            pr[3] = tb_preco.Text;

            ListViewItem l = new ListViewItem(pr);
            lv_produtos.Items.Add(l);
            limpar();
        }
        private void btn_remover_Click(object sender, EventArgs e)
        {
            lv_produtos.Items.RemoveAt(lv_produtos.SelectedIndices[0]);
        }
        private void btn_obter_Click(object sender, EventArgs e)
        {
            tb_id.Text = lv_produtos.SelectedItems[0].SubItems[0].Text;
            tb_produto.Text = lv_produtos.SelectedItems[0].SubItems[1].Text;
            tb_qtde.Text = lv_produtos.SelectedItems[0].SubItems[2].Text;
            tb_preco.Text = lv_produtos.SelectedItems[0].SubItems[3].Text;
        }

        private void tb_qtde_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void tb_preco_KeyPress(object sender, KeyPressEventArgs e)
        {
            //aceita apenas uma virgula
            int singlecomma = tb_preco.Text.ToCharArray().Count(c => c == ',');
            int doublechar = tb_preco.Text.IndexOf(',');
            if(doublechar < 0)
            {
                doublechar = 9;
            }
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 44 || (tb_preco.TextLength > doublechar + 2 && e.KeyChar != 8) || (singlecomma > 0 && ch == 44))
            {
                e.Handled = true;
            }
        }

        private void lv_produtos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lv_produtos.SelectedItems.Count > 0)
            {
                obter();
            }
        }
    }
}
