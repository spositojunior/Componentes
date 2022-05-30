namespace Sposito
{
    public partial class F_LinkedLabel : Form
    {
        public F_LinkedLabel()
        {
            InitializeComponent();
            ll_multiplosLink.Links.Add(0,6,"www.google.com.br");
            ll_multiplosLink.Links.Add(9, 5, "www.youtube.com/cfbcursos");
            ll_multiplosLink.Links.Add(17, 7, "www.youtube.com");

            ll_multiplosLink.Links[2].Enabled = false;
        }

        private void ll_canal_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("C:/Program Files (x86)/Microsoft/Edge/Application/msedge.exe", "http://youtube.com/cfbcursos");
            LinkLabel ll = (LinkLabel)sender;
            ll.LinkVisited = true;
        }

        private void ll_calculadora_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void ll_multiplosLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("C:/Program Files (x86)/Microsoft/Edge/Application/msedge.exe",e.Link.LinkData.ToString());
            e.Link.Visited = true;
        }
    }
}
