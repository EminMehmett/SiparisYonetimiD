using SiparisYonetimiD.Business.Managers;
using SiparisYonetimiD.Entities;
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
        void Temizle()
        {
            txtAdi.Text = string.Empty;
            txtSoyadi.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtTelefon.Text = string.Empty;
            txtKullaniciAdi.Text = string.Empty;
            txtSifre.Text = string.Empty;
            chbDurum.Checked = false;
            chbAdmin.Checked = false;
            btnGuncelle.Enabled = false;
            btnSil.Enabled = false;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Name = txtAdi.Text;
            user.Surname = txtSoyadi.Text;
            user.Email = txtEmail.Text;
            user.Phone = txtTelefon.Text;
            user.Username = txtKullaniciAdi.Text;
            user.Password = txtSifre.Text;
            user.IsActive = chbDurum.Checked;
            user.IsAdmin = chbAdmin.Checked;

            var sonuc = manager.Add(user);

            if (sonuc > 0)
            {
                Temizle();
                dgvKullanicilar.DataSource = manager.GetAll();
                MessageBox.Show("Kayıt Eklendi!");
            }
            else MessageBox.Show("Kayıt Başarısız!");
        }

        private void dgvKullanicilar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dgvKullanicilar.CurrentRow.Cells[0].Value);

                User kayit = manager.Find(id);

                txtAdi.Text = kayit.Name;
                txtSoyadi.Text = kayit.Surname;
                txtEmail.Text = kayit.Email;
                txtTelefon.Text = kayit.Phone;
                txtKullaniciAdi.Text = kayit.Username;
                txtSifre.Text = kayit.Password;
                chbDurum.Checked = kayit.IsActive;
                chbAdmin.Checked = kayit.IsAdmin;

                btnGuncelle.Enabled = true;
                btnSil.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Hata Oluştu!");
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvKullanicilar.CurrentRow.Cells[0].Value);

            User user = manager.Find(id);

            user.Name = txtAdi.Text;
            user.Surname = txtSoyadi.Text;
            user.Email = txtEmail.Text;
            user.Phone = txtTelefon.Text;
            user.Username = txtKullaniciAdi.Text;
            user.Password = txtSifre.Text;
            user.IsActive = chbDurum.Checked;
            user.IsAdmin = chbAdmin.Checked;

            var sonuc = manager.Update(user);

            if (sonuc > 0)
            {
                Temizle();
                dgvKullanicilar.DataSource = manager.GetAll();
                MessageBox.Show("Kayıt Güncellendi!");
            }
            else MessageBox.Show("Kayıt Başarısız!");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dgvKullanicilar.CurrentRow.Cells[0].Value);

                User kayit = manager.Find(id);

                int sonuc = manager.Remove(kayit);
                if (sonuc > 0)
                {
                    Temizle();
                    dgvKullanicilar.DataSource = manager.GetAll();
                    MessageBox.Show("Kayıt Silindi!");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Hata Oluştu!");
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            dgvKullanicilar.DataSource = manager.GetAll(txtAra.Text);
        }
    }
}
