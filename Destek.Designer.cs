namespace NoteBook2
{
    partial class Destek
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblAd = new System.Windows.Forms.Label();
            this.LblSoyisim = new System.Windows.Forms.Label();
            this.LblEmail = new System.Windows.Forms.Label();
            this.LblMesaj = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.TxtSoyad = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.Txtmesaj = new System.Windows.Forms.RichTextBox();
            this.Btngonder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblAd
            // 
            this.LblAd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblAd.Location = new System.Drawing.Point(97, 68);
            this.LblAd.Name = "LblAd";
            this.LblAd.Size = new System.Drawing.Size(54, 27);
            this.LblAd.TabIndex = 0;
            this.LblAd.Text = "İsim:";
            // 
            // LblSoyisim
            // 
            this.LblSoyisim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblSoyisim.Location = new System.Drawing.Point(60, 101);
            this.LblSoyisim.Name = "LblSoyisim";
            this.LblSoyisim.Size = new System.Drawing.Size(91, 27);
            this.LblSoyisim.TabIndex = 1;
            this.LblSoyisim.Text = "Soyisim:";
            this.LblSoyisim.Click += new System.EventHandler(this.LblSoyisim_Click);
            // 
            // LblEmail
            // 
            this.LblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblEmail.Location = new System.Drawing.Point(80, 138);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(71, 29);
            this.LblEmail.TabIndex = 2;
            this.LblEmail.Text = "Email:";
            // 
            // LblMesaj
            // 
            this.LblMesaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblMesaj.Location = new System.Drawing.Point(45, 167);
            this.LblMesaj.Name = "LblMesaj";
            this.LblMesaj.Size = new System.Drawing.Size(106, 37);
            this.LblMesaj.TabIndex = 3;
            this.LblMesaj.Text = "Mesajınız:";
            // 
            // txtAd
            // 
            this.txtAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAd.Location = new System.Drawing.Point(147, 68);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(316, 30);
            this.txtAd.TabIndex = 4;
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSoyad.Location = new System.Drawing.Point(147, 101);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Size = new System.Drawing.Size(316, 30);
            this.TxtSoyad.TabIndex = 5;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEmail.Location = new System.Drawing.Point(147, 137);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(316, 30);
            this.txtEmail.TabIndex = 6;
            // 
            // Txtmesaj
            // 
            this.Txtmesaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txtmesaj.Location = new System.Drawing.Point(147, 173);
            this.Txtmesaj.Name = "Txtmesaj";
            this.Txtmesaj.Size = new System.Drawing.Size(316, 257);
            this.Txtmesaj.TabIndex = 8;
            this.Txtmesaj.Text = "";
            // 
            // Btngonder
            // 
            this.Btngonder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btngonder.Location = new System.Drawing.Point(366, 434);
            this.Btngonder.Name = "Btngonder";
            this.Btngonder.Size = new System.Drawing.Size(97, 39);
            this.Btngonder.TabIndex = 10;
            this.Btngonder.Text = "Gönder";
            this.Btngonder.UseVisualStyleBackColor = true;
            this.Btngonder.Click += new System.EventHandler(this.Btngonder_Click);
            // 
            // Destek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 564);
            this.Controls.Add(this.Btngonder);
            this.Controls.Add(this.Txtmesaj);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.TxtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.LblMesaj);
            this.Controls.Add(this.LblEmail);
            this.Controls.Add(this.LblAd);
            this.Controls.Add(this.LblSoyisim);
            this.Name = "Destek";
            this.Text = "Destek";
            this.Load += new System.EventHandler(this.Destek_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblSoyisim;
        private System.Windows.Forms.Label LblAd;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.Label LblMesaj;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox TxtSoyad;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.RichTextBox Txtmesaj;
        private System.Windows.Forms.Button Btngonder;
    }
}