namespace FitAnneKaloriSayaci.UI
{
    public partial class Hosgeldin : Form
    {
        public Hosgeldin()
        {
            InitializeComponent();
        }

        private void btnDevam_Click(object sender, EventArgs e)
        {
            GirisEkrani girisEkrani = new GirisEkrani();
            girisEkrani.Show();
            this.Hide();
        }
    }
}