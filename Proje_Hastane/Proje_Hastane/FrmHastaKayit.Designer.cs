
namespace Proje_Hastane
{
    partial class FrmHastaKayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHastaKayit));
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.mskTC = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoyAd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mskTel = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnKayitYap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(135, 198);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(156, 31);
            this.txtSifre.TabIndex = 5;
            // 
            // mskTC
            // 
            this.mskTC.Location = new System.Drawing.Point(135, 124);
            this.mskTC.Mask = "00000000000";
            this.mskTC.Name = "mskTC";
            this.mskTC.Size = new System.Drawing.Size(156, 31);
            this.mskTC.TabIndex = 3;
            this.mskTC.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Şifre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "TC Kimlik No:";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(135, 49);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(156, 31);
            this.txtAd.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ad:";
            // 
            // txtSoyAd
            // 
            this.txtSoyAd.Location = new System.Drawing.Point(135, 86);
            this.txtSoyAd.Name = "txtSoyAd";
            this.txtSoyAd.Size = new System.Drawing.Size(156, 31);
            this.txtSoyAd.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "Soyad:";
            // 
            // mskTel
            // 
            this.mskTel.Location = new System.Drawing.Point(135, 161);
            this.mskTel.Mask = "(999) 000-0000";
            this.mskTel.Name = "mskTel";
            this.mskTel.Size = new System.Drawing.Size(156, 31);
            this.mskTel.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 23);
            this.label5.TabIndex = 13;
            this.label5.Text = "Telefon:";
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.FormattingEnabled = true;
            this.cmbCinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cmbCinsiyet.Location = new System.Drawing.Point(135, 235);
            this.cmbCinsiyet.Name = "cmbCinsiyet";
            this.cmbCinsiyet.Size = new System.Drawing.Size(156, 31);
            this.cmbCinsiyet.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 23);
            this.label6.TabIndex = 16;
            this.label6.Text = "Cinsiyet:";
            // 
            // btnKayitYap
            // 
            this.btnKayitYap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnKayitYap.Location = new System.Drawing.Point(135, 272);
            this.btnKayitYap.Name = "btnKayitYap";
            this.btnKayitYap.Size = new System.Drawing.Size(156, 30);
            this.btnKayitYap.TabIndex = 17;
            this.btnKayitYap.Text = "Kayıt Yap";
            this.btnKayitYap.UseVisualStyleBackColor = false;
            this.btnKayitYap.Click += new System.EventHandler(this.btnKayitYap_Click);
            // 
            // FrmHastaKayit
            // 
            this.AcceptButton = this.btnKayitYap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(366, 392);
            this.Controls.Add(this.btnKayitYap);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbCinsiyet);
            this.Controls.Add(this.mskTel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSoyAd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.mskTC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FrmHastaKayit";
            this.Text = "Hasta Kayıt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.MaskedTextBox mskTC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoyAd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mskTel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbCinsiyet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnKayitYap;
    }
}