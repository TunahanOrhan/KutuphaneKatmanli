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
    public partial class UyeEkleme : Form
    {
        public UyeEkleme()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tb_uyeEkleAd.Text=="") // Butona basıldığında eğer eksi bilgi varsa kullanıcıya uyarı vererek bilgileri tamamlamasını istiyorum.
            {
                MessageBox.Show("Lütfen Üye adını Girin!");
            }
            else if (tb_uyeEkleSoyad.Text == "")
            {
                MessageBox.Show("Lütfen Üye Soyad Girin!");
            }
            else if (tb_uyeEkleTel.Text=="")
            {
                MessageBox.Show("Lütfen Üye telefon Girin!");
            }
            else if (tb_uyeEkleMail.Text=="")
            {
                MessageBox.Show("Lütfen Üye mail Girin!");
            }
            else if (tb_uyeEkleAdres.Text=="")
            {
                MessageBox.Show("Lütfen Üye adres Girin!");
            }
            else if (tb_uyeEkleTc.Text=="")
            {
                MessageBox.Show("Lütfen Üye tc Girin!");
            }else
            {
                string uyeAd = tb_uyeEkleAd.Text; // Eğer girilen bilgiler tam ise bu bilgileri değişkenlere atıyorum.
                string uyeSoyad = tb_uyeEkleSoyad.Text;
                string uyeTel = tb_uyeEkleTel.Text.ToString();
                string uyeMail = tb_uyeEkleMail.Text;
                string uyeAdres = tb_uyeEkleAdres.Text;
                string uyeTc = tb_uyeEkleTc.Text.ToString();

                UyelerBLL uyelerbll = new UyelerBLL();



                if (uyelerbll.UyeEkle(uyeAd, uyeSoyad, uyeTel, uyeMail, uyeAdres, uyeTc)) // Değişkenleri parametre olarak gönderiyorum.
                {
                    MessageBox.Show("Kayıt Başarılı"); // Eğer üye veritabanına eklendiyse kullanıcıya mesaj veriyorum.
                    UyeIslemleri uyeislemleri = new UyeIslemleri();
                    uyeislemleri.Activate(); // Üye İşlemleri formunu aktif ediyorum.
                    this.Hide(); // Bu formu kapatıyorum.
                }
                else
                {
                    MessageBox.Show("Girdiğiniz TC Kimlik numarası ile zaten bir kayıt mevcut."); // Girilen TcNo ile zaten bir kayır varsa kullanıcıya hata mesajı veriyorum.
                }

            }
        }

        private void UyeEkleme_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void tb_uyeEkleAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void tb_uyeEkleSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void tb_uyeEkleTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tb_uyeEkleTc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
