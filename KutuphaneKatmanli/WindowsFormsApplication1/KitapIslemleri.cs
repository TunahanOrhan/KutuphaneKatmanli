using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KutuphaneKatmanli.BLL; // KutuphaneKatmanli.BLL sınıfını çağırıyoruz.

namespace WindowsFormsApplication1
{
    public partial class KitapIslemleri : Form
    {
        public KitapIslemleri()
        {
            InitializeComponent();
        }

        private void KitapIslemleri_Load(object sender, EventArgs e)
        {
            KitaplarBLL kitaplarbll = new KitaplarBLL();
            dataGridView1.DataSource = kitaplarbll.KitapListele(); // Form yüklendiğinde datagridview1'de kitapları listeliyorum.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kitapNo = tb_kitapNo.Text.ToString(); // Butona basıldığında textboxlara girilen verileri değişkenlere atıyorum.
            string kitapAd = tb_kitapAd.Text.ToString();
            string kitapYazar = tb_kitapYazar.Text.ToString();
            string kitapBaskiYil = tb_kitapBaskiYil.Text.ToString();
            string kitapSaySayi = tb_KitapSaySayi.Text.ToString();

            KitaplarBLL kitapguncelle = new KitaplarBLL();

            try
            {
                kitapguncelle.KitapGuncelle(kitapNo, kitapAd, kitapYazar, kitapBaskiYil, kitapSaySayi); // Değişkenleri parametre olarak gönderiyorum.
                MessageBox.Show("Güncelleme Başarılı."); // Kitap bilgilerini güncelleme işlemi başarılı ise kullancıya mesaj veriyorum.
                KitaplarBLL kitaplarbll = new KitaplarBLL();
                dataGridView1.DataSource = kitaplarbll.KitapListele(); // Güncel bilgileri datagridview1'de listeliyorum.
                tb_kitapNo.Text = ""; // Textboxların içeriğini temizliyorum.
                tb_kitapAd.Text = "";
                tb_kitapYazar.Text = "";
                tb_kitapBaskiYil.Text = "";
                tb_KitapSaySayi.Text = "";
                tb_kitapSil.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Hata Güncelleme Yapılamadı!"); // Güncelleme başarısız olursa kullanıcıya hata mesajı veriyorum.
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CurrentRow.Selected = true; // Datagridview1'de bir hücre seçildiğinde bütün satırı seçiyorum.
            tb_kitapNo.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString(); // Verileri textboxlara yazdırıyorum.
            tb_kitapAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            tb_kitapYazar.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            tb_kitapBaskiYil.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            tb_KitapSaySayi.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(); // Butona tıklandığında Form1'e geçiş yapıyorum.
            form1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KitapEkleme kitapekleme = new KitapEkleme(); // Butona tıklandığında kitap ekleme bilgilerinin girileceği formu açıyorum.
            kitapekleme.Show();
        }

        private void KitapIslemleri_Activated(object sender, EventArgs e)
        {
            KitaplarBLL kitaplarbll = new KitaplarBLL();
            dataGridView1.DataSource = kitaplarbll.KitapListele(); // Form yüklendiğinde datagridview1'de kitapları listeliyorum.
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.ReadOnly = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string kitapNoSil = tb_kitapSil.Text.ToString(); // Butona basıldığında silinmek istenen kitabın numarasını değişkene atıyorum.
            KitaplarBLL kitaplarbll = new KitaplarBLL();

            try
            {
                kitaplarbll.KitapSil(kitapNoSil); // Değişkeni parametre olarak gönderiyorum.
                MessageBox.Show("Kitap Silindi"); // Kitap veritabanından başarılı bir şekilde silinirse kullanıcıya mesaj veriyorum.
                dataGridView1.DataSource = kitaplarbll.KitapListele(); // Güncel listeyi datagridview1'de listeliyorum.
                tb_kitapNo.Text = ""; // Textboxların içeriğini temizliyorum.
                tb_kitapAd.Text = "";
                tb_kitapYazar.Text = "";
                tb_kitapBaskiYil.Text = "";
                tb_KitapSaySayi.Text = "";
                tb_kitapSil.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Hata! Kitap Silinemedi."); // Kitap silme işlemi başarısız olursa kullanıcıya hata mesajı veriyorum.
            }
        }

        private void KitapIslemleri_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 form1 = new Form1(); // Form kapatıldığında form1'e geçiş yapıyorum.
            form1.Show();
        }

        private void tb_kitapYazar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void tb_kitapBaskiYil_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tb_KitapSaySayi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tb_kitapSil_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
