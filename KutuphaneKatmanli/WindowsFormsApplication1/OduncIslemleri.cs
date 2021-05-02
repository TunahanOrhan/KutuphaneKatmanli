using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class OduncIslemleri : Form
    {
        public OduncIslemleri()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OduncAl oduncal = new OduncAl(); // Butona basıldığında Ödünç Al formuna gidilecek.
            oduncal.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(); // Butona basıldığında Form1'e gidilecek.
            form1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IadeEt iadeEt = new IadeEt(); // Butona basıldığında İade Et formuna gidilecek.
            iadeEt.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OduncListesi odunclistesi = new OduncListesi(); // Butona basıldığında Ödünç Listesi formuna gidilecek.
            odunclistesi.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            KitapGecmisi kitapgecmisi = new KitapGecmisi(); // Butona basıldığında Kitap Geçmişi formuna gidilecek.
            kitapgecmisi.Show();
            this.Hide();
        }

        private void OduncIslemleri_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 form1 = new Form1(); // Form kapatıldığında Form1'e dönüş yapacak.
            form1.Show();
        }
    }
}
