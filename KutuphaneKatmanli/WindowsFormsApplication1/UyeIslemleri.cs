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
    public partial class UyeIslemleri : Form
    {
        public UyeIslemleri()
        {
            InitializeComponent();
        }

        private void UyeIslemleri_Load(object sender, EventArgs e)
        {
            UyelerBLL uyelerbll = new UyelerBLL();
            dataGridView1.DataSource = uyelerbll.UyeListele(); // Form yüklendiğinde datagridview1'de üyeleri listeliyorum.
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UyeEkleme uyeekleme = new UyeEkleme(); // Butona basıldığında Üye Ekleme formuna geçiş yapıyorum.
            uyeekleme.Show();
        }

        private void UyeIslemleri_Activated(object sender, EventArgs e)
        {
                UyelerBLL uyelerbll = new UyelerBLL();
                dataGridView1.DataSource = uyelerbll.UyeListele(); // Form aktif edildiğinde datagridview1'de üyeleri listeliyorum.
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridView1.ReadOnly = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string uyeNoSil = mtb_uyeSil.Text.ToString(); // Butona basıldığında textboxtaki numarayı değişkene atıyorum.
            UyelerBLL uyelerbll = new UyelerBLL();

            try
            {
                uyelerbll.UyeSil(uyeNoSil); // Değişkeni parametre olarak gönderiyorum.
                MessageBox.Show("Üye Silindi."); // Üye veritabanından silinirse kullanıcıya mesaj veriyorum.
                dataGridView1.DataSource = uyelerbll.UyeListele(); // Güncel üye listesini datagridview1'de gösteriyorum.
                tb_uyeNo.Text = ""; // Textboxların içeriğini temizliyorum.
                tb_uyeAd.Text = "";
                tb_uyeSoyad.Text = "";
                mtb_uyeTel.Text = "";
                tb_uyeMail.Text = "";
                tb_uyeAdres.Text = "";
                mtb_uyeTc.Text = "";
                mtb_uyeSil.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Hata! Üye Silinemedi."); // Üye silinemezse kullanıcıya hata mesajı veriyorum.
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CurrentRow.Selected = true; // Datagridview1'de bir hücre seçildiğinde tüm satırı seçiyorum.
            tb_uyeNo.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString(); // Satırdaki verileri textboxlara yazdırıyorum.
            tb_uyeAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            tb_uyeSoyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            mtb_uyeTel.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            tb_uyeMail.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            tb_uyeAdres.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            mtb_uyeTc.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string uyeNo = tb_uyeNo.Text.ToString(); // Butona basıldığında textboxlardaki verileri değişkenlere atıyorum.
            string uyeAd = tb_uyeAd.Text.ToString();
            string uyeSoyad = tb_uyeSoyad.Text.ToString();
            string uyeTel = mtb_uyeTel.Text.ToString();
            string uyeMail = tb_uyeMail.Text.ToString();
            string uyeAdres = tb_uyeAdres.Text.ToString();
            string uyeTc = mtb_uyeTc.Text.ToString();

            UyelerBLL uyeguncelle = new UyelerBLL();

            try
            {
                uyeguncelle.UyeGuncelle(uyeNo, uyeAd, uyeSoyad, uyeTel, uyeMail, uyeAdres, uyeTc); // Değişkenleri parametre olarak gönderiyorum.
                MessageBox.Show("Güncelleme Başarılı."); // Üye bilgilerini güncelleme başarılı ise kullanıcıya mesaj veriyorum. 
                UyelerBLL uyebll = new UyelerBLL();
                dataGridView1.DataSource = uyebll.UyeListele(); // Güncel üye listesini datagridview1'de gösteriyorum.
                tb_uyeNo.Text = ""; // Textboxların içeriğini temizliyorum.
                tb_uyeAd.Text = "";
                tb_uyeSoyad.Text = "";
                mtb_uyeTel.Text = "";
                tb_uyeMail.Text = "";
                tb_uyeAdres.Text = "";
                mtb_uyeTc.Text = "";
                mtb_uyeSil.Text = "";
                
            }
            catch (Exception)
            {
                MessageBox.Show("Hata Güncelleme Yapılamadı!"); // Üye bilgilerini güncelleme başarılı değilse kullanıcıya hata mesajı veriyorum.
                
            }
        }

        


        private void button4_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(); // Butona basıldığında Form1'e geçiş yapıyorum.
            form1.Show();
            this.Hide();
        }

        private void UyeIslemleri_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 form1 = new Form1(); // Form kapatıldığında Form1'e geçiş yapıyorum.
            form1.Show();
        }

        private void tb_uyeAd_KeyPress(object sender, KeyPressEventArgs e) // Textboxlara sadece harf veya rakam girilmesini istediğim için keyPress özelliğine bu kodu ekledim.
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void tb_uyeSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void mtb_uyeTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void mtb_uyeTc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void mtb_uyeSil_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
