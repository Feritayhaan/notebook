using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteBook2
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
            // RichTextBox kontrolü oluşturulup form içine ekleniyor
            this._richTextBox1 = new RichTextBox();
            _richTextBox1.Dock = DockStyle.Fill; // RichTextBox, formun tamamını kaplayacak şekilde yerleştiriliyor
            this.Controls.Add(_richTextBox1);
        }

        private void resimEkleToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            // Kullanıcıdan bir resim dosyası seçmesini isteyen dosya açma iletişim kutusu oluşturuluyor
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.png;*.jpg;*.jpeg;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;
                if (File.Exists(imagePath))
                {
                    // Seçilen resmi Hexadecimal formatına dönüştür ve RTF formatında RichTextBox'a ekle
                    string hexImage = ConvertImageToHex(imagePath);
                    string rtfText = GenerateRTFWithImage(hexImage);
                    _richTextBox1.SelectedRtf = rtfText; // Ekleme yapılacak yere resmi ekler
                }
            }
        }

        private string ConvertImageToHex(string imagePath)
        {
            // Verilen resim dosyasını Hexadecimal string'e dönüştürür
            using (System.Drawing.Image image = System.Drawing.Image.FromFile(imagePath))
            {
                using (System.IO.MemoryStream memoryStream = new System.IO.MemoryStream())
                {
                    image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Png);
                    byte[] imageBytes = memoryStream.ToArray();
                    StringBuilder hex = new StringBuilder(imageBytes.Length * 2);
                    foreach (byte b in imageBytes)
                    {
                        hex.AppendFormat("{0:x2}", b);
                    }
                    return hex.ToString();
                }
            }
        }

        private string GenerateRTFWithImage(string hexImage)
        {
            // Hex string'ini RTF formatına çevirerek RichTextBox'a eklenebilir hale getirir
            return "{\\rtf1\\ansi\\ansicpg1252\\deff0\\nouicompat\\deflang1033" +
                   "{\\fonttbl{\\f0\\fnil\\fcharset0 Calibri;}}" +
                   "{\\colortbl ;\\red0\\green0\\blue0;}" +
                   "\\viewkind4\\uc1\\pard\\cf1\\f0\\fs20" +
                   "{\\pict\\pngblip\\picw320\\pich240\\picwgoal320\\pichgoal240 " + hexImage + "}}";
        }

        private void kesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Seçili metni keser
            _richTextBox1.Cut();
        }

        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Kullanıcıdan bir metin dosyası açmasını isteyen dosya açma iletişim kutusu oluşturuluyor
            OpenFileDialog ofn = new OpenFileDialog();
            ofn.Filter = "Metin Dosyaları|*.txt|Tüm Dosyalar|*.*";
            if (ofn.ShowDialog() == DialogResult.OK)
            {
                // Seçilen dosyanın içeriği RichTextBox'a yüklenir
                _richTextBox1.Text = File.ReadAllText(ofn.FileName);
            }
        }

        private void yeniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // RichTextBox içeriğini temizler
            _richTextBox1.Clear();
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Kullanıcıya metin dosyasını kaydetmesi için bir dosya kaydetme iletişim kutusu gösterir
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Metin Dosyaları|*.txt|Tüm Dosyalar|*.*";

            if (save.ShowDialog() == DialogResult.OK)
            {
                // RichTextBox içeriği belirtilen dosya yoluna kaydedilir
                File.WriteAllText(save.FileName, _richTextBox1.Text);
            }
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Uygulamayı kapatır
            Application.Exit();
        }

        private void kopyalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Seçili metni kopyalar
            _richTextBox1.Copy();
        }

        private void yapıştırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Panodaki metni RichTextBox'a yapıştırır
            _richTextBox1.Paste();
        }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Hakkında mesaj kutusu gösterir
            MessageBox.Show("Bu not defteri FYA tarafından yapılmıştır");
        }

        private void destekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Destek formunu gösterir
            Destek destekFormu = new Destek();
            destekFormu.ShowDialog();
        }

        private void saatTarihToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Geçerli saat ve tarihi RichTextBox'a ekler
            string saatdk = DateTime.Now.ToString(" dd/MM/yyyy HH:mm:ss");
            _richTextBox1.AppendText($"{saatdk}");
        }

        private void kırmızıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Seçili metni kırmızı renge boyar
            _richTextBox1.SelectionColor = Color.Red;
        }

        private void maviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Seçili metni mavi renge boyar
            _richTextBox1.SelectionColor = Color.Blue;
        }

        private void sarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // RichTextBox arka plan rengini siyah ve seçili metni sarı renge boyar
            _richTextBox1.BackColor = Color.Black;
            _richTextBox1.SelectionColor = Color.Yellow;
        }

        private void yeşilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Seçili metni yeşil renge boyar
            _richTextBox1.SelectionColor = Color.Green;
        }

        private void beyazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // RichTextBox arka plan rengini siyah ve seçili metni beyaz renge boyar
            _richTextBox1.BackColor = Color.Black;
            _richTextBox1.SelectionColor = Color.White;
        }

        private void siyahToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // RichTextBox arka plan rengini beyaz ve seçili metni siyah renge boyar
            _richTextBox1.BackColor = Color.White;
            _richTextBox1.SelectionColor = Color.Black;
        }

        private void düzenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Boş bırakıldı, gereksinimlere göre düzenlenebilir.
        }

        private void renkDeğiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Boş bırakıldı, gereksinimlere göre düzenlenebilir.
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            // Boş bırakıldı, gereksinimlere göre düzenlenebilir.
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            // Boş bırakıldı, gereksinimlere göre düzenlenebilir.
        }
    }
}
