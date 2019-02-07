namespace VeriYapılarıÖdev1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnOncelikGoster = new System.Windows.Forms.Button();
            this.btnKuyruk = new System.Windows.Forms.Button();
            this.btnArabaEkle = new System.Windows.Forms.Button();
            this.btnKıyasla = new System.Windows.Forms.Button();
            this.btnKazanc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOncelikGoster
            // 
            this.btnOncelikGoster.BackColor = System.Drawing.SystemColors.Info;
            this.btnOncelikGoster.Location = new System.Drawing.Point(116, 164);
            this.btnOncelikGoster.Name = "btnOncelikGoster";
            this.btnOncelikGoster.Size = new System.Drawing.Size(211, 51);
            this.btnOncelikGoster.TabIndex = 0;
            this.btnOncelikGoster.Text = "İşlem süresine göre öncelik kuyruğunu göster";
            this.btnOncelikGoster.UseVisualStyleBackColor = false;
            this.btnOncelikGoster.Visible = false;
            this.btnOncelikGoster.Click += new System.EventHandler(this.btnOncelikGoster_Click);
            // 
            // btnKuyruk
            // 
            this.btnKuyruk.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnKuyruk.Location = new System.Drawing.Point(125, 111);
            this.btnKuyruk.Name = "btnKuyruk";
            this.btnKuyruk.Size = new System.Drawing.Size(193, 38);
            this.btnKuyruk.TabIndex = 1;
            this.btnKuyruk.Text = "Basit kuyruğu göster";
            this.btnKuyruk.UseVisualStyleBackColor = false;
            this.btnKuyruk.Visible = false;
            this.btnKuyruk.Click += new System.EventHandler(this.btnKuyruk_Click);
            // 
            // btnArabaEkle
            // 
            this.btnArabaEkle.BackColor = System.Drawing.SystemColors.Info;
            this.btnArabaEkle.Location = new System.Drawing.Point(144, 57);
            this.btnArabaEkle.Name = "btnArabaEkle";
            this.btnArabaEkle.Size = new System.Drawing.Size(157, 39);
            this.btnArabaEkle.TabIndex = 2;
            this.btnArabaEkle.Text = "Araba Ekle";
            this.btnArabaEkle.UseVisualStyleBackColor = false;
            this.btnArabaEkle.Click += new System.EventHandler(this.btnArabaEkle_Click);
            // 
            // btnKıyasla
            // 
            this.btnKıyasla.BackColor = System.Drawing.Color.FloralWhite;
            this.btnKıyasla.Location = new System.Drawing.Point(144, 235);
            this.btnKıyasla.Name = "btnKıyasla";
            this.btnKıyasla.Size = new System.Drawing.Size(157, 42);
            this.btnKıyasla.TabIndex = 3;
            this.btnKıyasla.Text = "Kuyrukları kıyasla";
            this.btnKıyasla.UseVisualStyleBackColor = false;
            this.btnKıyasla.Visible = false;
            this.btnKıyasla.Click += new System.EventHandler(this.btnKıyasla_Click);
            // 
            // btnKazanc
            // 
            this.btnKazanc.BackColor = System.Drawing.Color.DarkCyan;
            this.btnKazanc.Location = new System.Drawing.Point(104, 283);
            this.btnKazanc.Name = "btnKazanc";
            this.btnKazanc.Size = new System.Drawing.Size(241, 57);
            this.btnKazanc.TabIndex = 4;
            this.btnKazanc.Text = "Ortalama işlem süresinin kuyrukta kazancı ve fark yüzdesi";
            this.btnKazanc.UseVisualStyleBackColor = false;
            this.btnKazanc.Visible = false;
            this.btnKazanc.Click += new System.EventHandler(this.btnKazanc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label1.Location = new System.Drawing.Point(141, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Lütfen önce araç giriniz:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(453, 362);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKazanc);
            this.Controls.Add(this.btnKıyasla);
            this.Controls.Add(this.btnArabaEkle);
            this.Controls.Add(this.btnKuyruk);
            this.Controls.Add(this.btnOncelikGoster);
            this.Name = "Form1";
            this.Text = "Kuyruk Gerçekleştirimi Tabanlı Otopark Benzetimi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOncelikGoster;
        private System.Windows.Forms.Button btnKuyruk;
        private System.Windows.Forms.Button btnArabaEkle;
        private System.Windows.Forms.Button btnKıyasla;
        private System.Windows.Forms.Button btnKazanc;
        private System.Windows.Forms.Label label1;
    }
}

