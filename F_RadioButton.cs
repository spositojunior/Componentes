namespace Sposito
{
    public partial class F_RadioButton : Form
    {
        public F_RadioButton()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string txt;
            txt = groupBox1.Controls.OfType<RadioButton>().SingleOrDefault(RadioButton => RadioButton.Checked).Text;
            MessageBox.Show(txt);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string txt = "";
            foreach(RadioButton rb in groupBox1.Controls)
            {
                if (rb.Checked)
                {
                    txt = rb.Text;
                }
            }
            textBox1.Text = txt;
            MessageBox.Show(txt);
        }
    }
}
