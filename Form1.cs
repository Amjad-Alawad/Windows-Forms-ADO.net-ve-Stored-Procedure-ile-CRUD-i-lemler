using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace uyggulama
{
    public partial class Form1 : Form
    {
        public Form1(EventHandler btnEklepr_Click = null)
        {
            InitializeComponent();

        }

        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-6GG4RRLM;Initial Catalog=UrunDB;Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {
            UrunListesi();
            KategoriListele();
            TedarikciListele();
        }

        private void UrunListesi()
        {
            SqlDataAdapter adp = new SqlDataAdapter(
            "SELECT u.UrunID, u.UrunAdi, u.BirimFiyat, t.TedarikciAdi, k.KategoriAdi " +
            "FROM Urunler u " +
            "JOIN Tedarikciler t ON u.TedarikciID = t.TedarikciID " +
            "JOIN Kategoriler k ON u.KategoriID = k.KategoriID", baglanti);
            DataTable dt = new DataTable();
            adp.Fill(dt);

            dataGridView1.DataSource = dt;


        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string adi = txtUrunAdi.Text.Trim();
            decimal fiyat = txtBirimFiyat.Value;


            object tedarikciID = listTedarikci.SelectedValue;
            object kategoriID = listKategori.SelectedValue;

            if (string.IsNullOrEmpty(adi) || tedarikciID == null || kategoriID == null)
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.");
                return;
            }

            SqlCommand komut = new SqlCommand(
                "INSERT INTO Urunler (UrunAdi, BirimFiyat, TedarikciID, KategoriID) " +
                "VALUES (@adi, @fiyat, @tedarikci, @kategori)", baglanti);

            komut.Parameters.AddWithValue("@adi", adi);
            komut.Parameters.AddWithValue("@fiyat", fiyat);
            komut.Parameters.AddWithValue("@tedarikci", tedarikciID);
            komut.Parameters.AddWithValue("@kategori", kategoriID);

            try
            {
                baglanti.Open();
                int etkilenen = komut.ExecuteNonQuery();

                if (etkilenen > 0)
                {
                    MessageBox.Show("Kayıt başarıyla eklendi.");
                    UrunListesi();
                }
                else if (fiyat > 100)
                {
                    MessageBox.Show("Birim fiyatı 100 den küçük olmalı");
                }
                else
                {
                    MessageBox.Show("Kayıt eklenemedi.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void KategoriListele()
        {
            SqlDataAdapter adp = new SqlDataAdapter("SELECT KategoriID, KategoriAdi FROM Kategoriler", baglanti);
            DataTable dt = new DataTable();
            adp.Fill(dt);

            listKategori.DataSource = dt;
            listKategori.DisplayMember = "KategoriAdi";
            listKategori.ValueMember = "KategoriID";
        }

        private void TedarikciListele()
        {
            SqlDataAdapter adp = new SqlDataAdapter("SELECT TedarikciID, TedarikciAdi FROM Tedarikciler", baglanti);
            DataTable dt = new DataTable();
            adp.Fill(dt);

            listTedarikci.DataSource = dt;
            listTedarikci.DisplayMember = "TedarikciAdi";
            listTedarikci.ValueMember = "TedarikciID";
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silmek istediğiniz ürünü seçin.");
                return;
            }


            int urunID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["UrunID"].Value);


            DialogResult sonuc = MessageBox.Show("Bu ürünü silmek istediğinize emin misiniz?", "Ürün Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);


            if (sonuc == DialogResult.No)
            {

                return;
            }


            try
            {
                SqlCommand komut = new SqlCommand("DELETE FROM Urunler WHERE UrunID = @id", baglanti);
                komut.Parameters.AddWithValue("@id", urunID);

                baglanti.Open();
                int etkilenen = komut.ExecuteNonQuery();

                if (etkilenen > 0)
                {
                    MessageBox.Show("Ürün başarıyla silindi.");
                    UrunListesi();
                }
                else
                {
                    MessageBox.Show("Silme işlemi başarısız.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }

        }

        private void btnAra_Click_1(object sender, EventArgs e)
        {

            string aranan = txtUrunAdi.Text.Trim();

            if (string.IsNullOrEmpty(aranan))
            {
                MessageBox.Show("Lütfen aramak istediğiniz ürün adını giriniz.");
                return;
            }

            SqlDataAdapter da = new SqlDataAdapter(
                "SELECT u.UrunID, u.UrunAdi, u.BirimFiyat, t.TedarikciAdi, k.KategoriAdi " +
                "FROM Urunler u " +
                "JOIN Tedarikciler t ON u.TedarikciID = t.TedarikciID " +
                "JOIN Kategoriler k ON u.KategoriID = k.KategoriID " +
                "WHERE u.UrunAdi LIKE @aranan", baglanti);

            da.SelectCommand.Parameters.AddWithValue("@aranan", "%" + aranan + "%");

            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;


        }
        private void btnEklepr_Click(object sender, EventArgs e)
        {
            string adi = txtUrunAdi.Text.Trim();
            decimal fiyat = txtBirimFiyat.Value;

            object tedarikciID = listTedarikci.SelectedValue;
            object kategoriID = listKategori.SelectedValue;

            if (string.IsNullOrEmpty(adi) || tedarikciID == null || kategoriID == null)
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.");
                return;
            }
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("dbo.Kayıt_Ekle", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@UrunAdi", adi);
                komut.Parameters.AddWithValue("@BirimFiyat", fiyat);
                komut.Parameters.AddWithValue("@TedarikciID", tedarikciID);
                komut.Parameters.AddWithValue("@KategoriID", kategoriID);
                komut.ExecuteNonQuery();

                MessageBox.Show("Kayıt eklendi");
            }
            catch (Exception ex)
            {

                MessageBox.Show("hata oluştu" + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }

        }

        private void btnSilpr_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUrunSil.Text))
            {
                MessageBox.Show("Lütfen silinecek ürün ID'sini giriniz.");
                return;
            }

            if (!int.TryParse(txtUrunSil.Text, out int urunID))
            {
                MessageBox.Show("Geçerli bir ürün ID giriniz.");
                return;
            }

            try
            {
                SqlCommand komut = new SqlCommand("dbo.Kayıt_Silme", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@UrunID", urunID);

                baglanti.Open();
                int sonuc = komut.ExecuteNonQuery();
                baglanti.Close();

                if (sonuc > 0)
                {
                    MessageBox.Show("Ürün başarıyla silindi.");
                }
                else
                {
                    MessageBox.Show("Belirtilen ID ile eşleşen bir ürün bulunamadı.");
                }
            }
            catch (Exception ex)
            {
                baglanti.Close();
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            // Ürün ID textbox adı burada 'txtUrunID' olarak varsayıyorum
            if (!int.TryParse(txtUrunSil.Text, out int urunID))
            {
                MessageBox.Show("Geçerli bir Ürün ID giriniz.");
                return;
            }

            string urunAdi = txtUrunAdi.Text.Trim();
            decimal birimFiyat = txtBirimFiyat.Value;
            object tedarikciID = listTedarikci.SelectedValue;
            object kategoriID = listKategori.SelectedValue;

            if (string.IsNullOrEmpty(urunAdi) || tedarikciID == null || kategoriID == null)
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.");
                return;
            }

            try
            {

                using (SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-6GG4RRLM;Initial Catalog=UrunDB;Integrated Security=True"))
                {
                    using (SqlCommand komut = new SqlCommand("dbo.Kayıt_Guncelle", baglanti))
                    {
                        komut.CommandType = CommandType.StoredProcedure;

                        komut.Parameters.AddWithValue("@UrunID", urunID);
                        komut.Parameters.AddWithValue("@UrunAdi", urunAdi);
                        komut.Parameters.AddWithValue("@BirimFiyat", birimFiyat);
                        komut.Parameters.AddWithValue("@TedarikciID", Convert.ToInt32(tedarikciID));
                        komut.Parameters.AddWithValue("@KategoriID", Convert.ToInt32(kategoriID));

                        baglanti.Open();
                        int sonuc = komut.ExecuteNonQuery();

                        if (sonuc > 0)
                        {
                            MessageBox.Show("Kayıt başarıyla güncellendi.");
                        }
                        else
                        {
                            MessageBox.Show("Kayıt güncellenemedi. ID bulunamadı.");
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtUrunSil.Text, out int urunID))
            {
                MessageBox.Show("Lütfen geçerli bir ürün ID giriniz.");
                return;
            }

            try
            {
                SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-6GG4RRLM;Initial Catalog=UrunDB;Integrated Security=True");
                SqlCommand komut = new SqlCommand("dbo.Urun_Arama", baglanti);
                SqlDataAdapter da = new SqlDataAdapter(komut);
                {
                    komut.CommandType = CommandType.StoredProcedure;
                    komut.Parameters.AddWithValue("@UrunID", urunID);

                    DataTable dt = new DataTable();
                    da.Fill(dt);  

                    if (dt.Rows.Count > 0)
                    {
                        dataGridView1.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("Bu ID ile eşleşen ürün bulunamadı.");
                        dataGridView1.DataSource = null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }
    }
}
        

    


