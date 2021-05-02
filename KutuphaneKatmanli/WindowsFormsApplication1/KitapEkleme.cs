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
    public partial class KitapEkleme : Form
    {
        public KitapEkleme()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tb_kitapAd.Text=="") // Butona basıldığında herhangi bir bilgi boş bırakıldığında kullanıcıyı uyarıyorum. Eğer bilgiler tam ise kitabı veritabanına ekliyorum.
            {
                MessageBox.Show("Lütfen kitap adını Girin!");
            }
            else if (tb_kitapYazar.Text == "")
            {
                MessageBox.Show("Lütfen yazar adını Girin!");
            }
            else if (tb_kitBasYıl.Text=="")
            {
                MessageBox.Show("Lütfen baskı yılını Girin!");
            }
            else if (tb_kitSaySayi.Text == "")
            {
                MessageBox.Show("Lütfen sayfa sayısını Girin!");
            }
            else
            {
                string KitapAd = tb_kitapAd.Text.ToString(); // Kitabı eklemek için textboxlardaki bilgileri değşkenlere atıyorum.
                string KitapYazari = tb_kitapYazar.Text.ToString();
                string KitapBaskiYil = tb_kitBasYıl.Text.ToString();
                string KitSayfaSayi = tb_kitSaySayi.Text.ToString();

                KitaplarBLL kitaplarbll = new KitaplarBLL();

                try
                {
                    kitaplarbll.KitapEkle(KitapAd, KitapYazari, KitapBaskiYil, KitSayfaSayi);// Bu değişkenleri parametre olarak gönderiyorum.
                    MessageBox.Show("Kayıt Başarılı."); // Kitap eklendiğinde kullancıya mesaj verip bu formu kapatıyorum.
                    KitapIslemleri kitapislemleri = new KitapIslemleri();
                    kitapislemleri.Activate();
                    this.Hide();
                }
                catch (Exception)
                {
                    MessageBox.Show("Hata! Kitap Eklenemedi");
                }
                
            }

        }

        private void KitapEkleme_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void tb_kitapYazar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void tb_kitBasYıl_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tb_kitSaySayi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
