namespace Sposito
{
    public partial class F_MaskedTextBox : Form
    {
        public F_MaskedTextBox()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                maskedTextBox1.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            }
            else
            {
                maskedTextBox1.TextMaskFormat = MaskFormat.IncludeLiterals;
            }
            string msg = maskedTextBox1.Text;
            MessageBox.Show(msg);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                mtb_senha.PasswordChar = default;
            }
            else
            {
                mtb_senha.PasswordChar = '×';
            }
        }
    }
}
