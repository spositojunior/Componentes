namespace Sposito
{
    public partial class F_ProgressBar : Form
    {
        public F_ProgressBar()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (progressBar1.Value != progressBar1.Maximum) progressBar1.Value++;
            else MessageBox.Show("Já esta no maximo.");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if(progressBar1.Value!=progressBar1.Minimum) progressBar1.Value--;
            else MessageBox.Show("Já esta no minimo.");
        }
        private void button3_Click(object sender, EventArgs e)
        {
            progressBar1.Value=progressBar1.Minimum;
        }
    }
}
