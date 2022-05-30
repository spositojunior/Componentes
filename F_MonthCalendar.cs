namespace Sposito
{
    public partial class F_MonthCalendar : Form
    {
        public F_MonthCalendar()
        {
            InitializeComponent();
        }

        private void btn_pegarData_Click(object sender, EventArgs e)
        {
            textBox1.Text = monthCalendar1.SelectionStart.ToShortDateString();
            textBox2.Text = monthCalendar1.SelectionEnd.ToShortDateString();
            textBox3.Text = monthCalendar1.TodayDate.ToShortDateString();
        }
    }
}
