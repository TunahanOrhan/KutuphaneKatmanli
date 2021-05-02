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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UyeIslemleri uyeislemleri = new UyeIslemleri(); // Butona basıldığında uyeişlemleri sınıfından yeni nesne türetir.
            uyeislemleri.Show(); // Üye İşlemleri formunu açar ve form1'i saklar.
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KitapIslemleri kitapislemleri = new KitapIslemleri(); // Butona basıldığında kitapişlemleri sınıfından yeni nesne türetir.
            kitapislemleri.Show(); // Kitap İşlemleri formunu açar ve form1'i saklar.
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OduncIslemleri oduncislemleri = new OduncIslemleri(); // Butona basıldığında oduncislemleri sınıfından yeni nesne türetir.
            oduncislemleri.Show(); // Ödünç İşlemleri formunu açar ve form1'i saklar.
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Grafik grafik = new Grafik(); // Butona basıldığında grafik sınıfından yeni nesne türetir.
            grafik.Show(); // Grafik formunu açar ve form1'i saklar.
            this.Hide();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0); // Form1 kapatıldığında uygulamayı sonlandırır.
        }
    }
}
