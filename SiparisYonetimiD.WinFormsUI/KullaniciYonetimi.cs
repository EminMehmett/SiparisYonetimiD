using SiparisYonetimiD.Business.Managers;
using System;
using System.Windows.Forms;

namespace SiparisYonetimiD.WinFormsUI
{
    public partial class KullaniciYonetimi : Form
    {
        public KullaniciYonetimi()
        {
            InitializeComponent();
        }
        UserManager manager = new UserManager();
        private void KullaniciYonetimi_Load(object sender, EventArgs e)
        {
            dgvKullanicilar.DataSource = manager.GetAll();
        }
    }
}
