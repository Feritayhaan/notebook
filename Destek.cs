using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteBook2
{
    public partial class Destek : Form
    {
        public Destek()
        {
            InitializeComponent();
        }

        private void LblSoyisim_Click(object sender, EventArgs e)
        {

        }

        private void Btngonder_Click(object sender, EventArgs e)
        {
            String ad=txtAd.Text;
            String soyisim=TxtSoyad.Text;
            string email=txtEmail.Text;
            string mesaj=Txtmesaj.Text;

            if (string.IsNullOrEmpty(ad) || string.IsNullOrEmpty(soyisim) || string.IsNullOrEmpty(email)|| string.IsNullOrEmpty(mesaj))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
            try
            {
                // SMTP Ayarları
                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587); // Gmail SMTP sunucusu ve portu
                smtp.Credentials = new NetworkCredential("notbookfya@gmail.com", "jfcc vxac ghub sims"); // Kendi e-posta ve şifrenizi girin
                smtp.EnableSsl = true;

                // E-posta Mesajı
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(txtEmail.Text); // Gönderen e-posta
                mail.To.Add("ferityilmazayhan1@gmail.com"); // Hedef e-posta
                mail.Subject = "Destek Talebi - " + ad;
                mail.Body = $"Ad: {ad}\nSoyisim: {soyisim}\nE-posta: {email}\nMesaj: {mesaj}";

                // E-posta gönder
                smtp.Send(mail);
                MessageBox.Show("Mesajınız gönderildi. Teşekkürler!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Alanları temizle
                txtAd.Clear();
                TxtSoyad.Clear();
                txtEmail.Clear();
                Txtmesaj.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Mesaj gönderilirken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return;
        }
        private void Destek_Load(object sender, EventArgs e)
        {

        }
    }
}
