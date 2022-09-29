using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proje_Hastane
{
    public partial class FrmSekreterDetay : Form
    {
        public FrmSekreterDetay()
        {
            InitializeComponent();
        }

        public string TCnumara;

        sqlbaglantisi bgl = new sqlbaglantisi();
        
        private void FrmSekreterDetay_Load(object sender, EventArgs e)
        {
            lblTC.Text = TCnumara;

            // Ad Soyad
            SqlCommand komut1 = new SqlCommand("Select SekreterAdSoyad From Tbl_Sekreter Where SekreterTC=@p1", bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1", lblTC.Text);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                lblAdSoyad.Text = dr1[0].ToString();
            }

            bgl.baglanti().Close();

            // Branşları DataGrid'e Aktarma

            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select * From Tbl_Branslar", bgl.baglanti());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;

            // Doktorları DataGrid'e Aktarma

            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select (DoktorAd + ' ' + DoktorSoyad) as 'Doktorlar' , DoktorBrans From Tbl_Doktorlar", bgl.baglanti());
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;

            // Branşları comboBox'a Aktarma

            SqlCommand komut2 = new SqlCommand("Select BransAd From Tbl_Branslar", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmbBrans.Items.Add(dr2[0]);
            }

            bgl.baglanti().Close();

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komutkaydet = new SqlCommand("insert into Tbl_Randevular (RandevuTarih, RandevuSaat, RandevuBrans, RandevuDoktor) values (@r1, @r2, @r3, @r4)", bgl.baglanti());
            komutkaydet.Parameters.AddWithValue("@r1", mskTarih.Text);
            komutkaydet.Parameters.AddWithValue("@r2", mskSaat.Text);
            komutkaydet.Parameters.AddWithValue("@r3", cmbBrans.Text);
            komutkaydet.Parameters.AddWithValue("@r4", cmbDoktor.Text);

            komutkaydet.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu Oluşturuldu");
        }

        private void cmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDoktor.Items.Clear();

            SqlCommand komut = new SqlCommand("Select DoktorAd, DoktorSoyad From Tbl_Doktorlar Where DoktorBrans=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", cmbBrans.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbDoktor.Items.Add(dr[0] + " " + dr[1]);
            }

            bgl.baglanti().Close();

        }

        private void rchDuyuru_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDuyuruOlustur_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Duyurular (Duyuru) values (@d1)", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", rchDuyuru.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Duyuru Oluşturuldu");
        }

        private void btnDoktorPanel_Click(object sender, EventArgs e)
        {
            FrmDoktorPaneli frmDoktorPaneli = new FrmDoktorPaneli();
            frmDoktorPaneli.Show();
        }

        private void btnBransPanel_Click(object sender, EventArgs e)
        {
            FrmBrans frmBrans = new FrmBrans();
            frmBrans.Show();
        }

        private void btnListe_Click(object sender, EventArgs e)
        {
            FrmRandevuListesi frmRandevuListesi = new FrmRandevuListesi();
            frmRandevuListesi.Show();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

        }

        private void btnDuyurular_Click(object sender, EventArgs e)
        {
            FrmDuyurular frmDuyurular = new FrmDuyurular();
            frmDuyurular.Show();
        }
    }
}
