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
    public partial class KitapGecmisi : Form
    {
        public KitapGecmisi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OduncIslemleri oduncislemleri = new OduncIslemleri(); // Butona basıldığında Ödünç İşlemleri formuna geçiş yapıyorum.
            oduncislemleri.Show();
            this.Hide();
        }

        private void KitapGecmisi_Activated(object sender, EventArgs e)
        {
            KitaplarBLL kitaplarbll = new KitaplarBLL();
            dataGridView1.DataSource = kitaplarbll.KitapListele(); // Form aktif edildğinde datagridview1'de kitapları listeliyorum.

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            dataGridView1.ReadOnly = true;
            dataGridView2.ReadOnly = true;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CurrentRow.Selected = true; // Datagridview1'de bir hücre seçildiğinde bütün satırı seçiyorum.
            string kitapNo = dataGridView1.CurrentRow.Cells[0].Value.ToString(); // Seçilen kitabın kitapNo değerini değişkene atıyorum.

            OdunclerBLL odunclerbll = new OdunclerBLL();
            dataGridView2.DataSource = odunclerbll.OduncListele3(kitapNo); // Değişkeni parametre yollayarak seçilen kitabın ödünç geçmişini datagridview2'de listeliyorum.

            for (int i = 0; i < dataGridView2.Rows.Count - 1; i++) // dataGridView2'de teslim tarihi geçmiş veya 2 gün kalmış ödünçleri renklendiriyorum.
            {
                TimeSpan fark = Convert.ToDateTime(dataGridView2.Rows[i].Cells[4].Value.ToString()) - Convert.ToDateTime(DateTime.Now.ToShortDateString());
                double farkgun = fark.TotalDays;

                if (farkgun < 3 && farkgun >= 0) dataGridView2.Rows[i].DefaultCellStyle.BackColor = Color.Yellow; // Teslim tarihine 3 günden az kalmış ödünçleri sarı ile
                else if (farkgun < 0) dataGridView2.Rows[i].DefaultCellStyle.BackColor = Color.Red; // Teslim tarihi geçmiş ödünçleri kırmızı ile gösteriyorum.

                if (dataGridView2.Rows[i].Cells[7].Value.ToString() == "Evet")
                {
                    dataGridView2.Rows[i].DefaultCellStyle.BackColor = Color.Green; // Kitap teslim edildiyse yeşil ile gösteriyorum.
                }
            }
        }

        private void KitapGecmisi_FormClosing(object sender, FormClosingEventArgs e)
        {
            OduncIslemleri oduncislemleri = new OduncIslemleri(); // Form kapatıldığında ödünç işlemleri formuna geçiş yapıyorum.
            oduncislemleri.Show();
        }
    }
}
