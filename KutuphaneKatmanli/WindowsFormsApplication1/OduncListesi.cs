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
    public partial class OduncListesi : Form
    {
        public OduncListesi()
        {
            InitializeComponent();
        }

        private void OduncListesi_Activated(object sender, EventArgs e)
        {
            UyelerBLL uyelerbll = new UyelerBLL();
            dataGridView1.DataSource = uyelerbll.UyeListele(); // Form aktive edildiğinde datagridview1'de üyeleri listeliyorum.

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            dataGridView1.ReadOnly = true;
            dataGridView2.ReadOnly = true;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CurrentRow.Selected = true; // Datagridview1'de bir hüvre seçildiğinde tüm satırı seçiyorum.
            string uyeNo = dataGridView1.CurrentRow.Cells[0].Value.ToString(); // Seçilen üyenin üyeNo'sunu değişkene atıyorum.

            OdunclerBLL odunclerbll = new OdunclerBLL();
            dataGridView2.DataSource = odunclerbll.OduncListele2(uyeNo); // Değişkeni parametre göndererek seçilen üyenin ödünç geçmişini datagridview2'de listeliyorum.

            for (int i = 0; i < dataGridView2.Rows.Count - 1; i++) // dataGridView2'de teslim tarihi geçmiş veya 2 gün kalmış ödünçleri renklendiriyorum.
            {
                TimeSpan fark = Convert.ToDateTime(dataGridView2.Rows[i].Cells[4].Value.ToString()) - Convert.ToDateTime(DateTime.Now.ToShortDateString());
                double farkgun = fark.TotalDays;

                if (farkgun < 3 && farkgun >= 0) dataGridView2.Rows[i].DefaultCellStyle.BackColor = Color.Yellow; // Teslim tarihine 3 günden az kalmış ödünçleri sarı ile
                else if (farkgun < 0) dataGridView2.Rows[i].DefaultCellStyle.BackColor = Color.Red; // Teslim tarihi geçmiş ödünçleri kırmızı ile gösteriyorum.

                if (dataGridView2.Rows[i].Cells[7].Value.ToString() == "Evet")
                {
                    dataGridView2.Rows[i].DefaultCellStyle.BackColor = Color.Green; // Teslim edilmiş ödünçleri yeşil ile gösteriyorum.
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OduncIslemleri oduncislemleri = new OduncIslemleri(); // Butona basıldığında Ödünç İşlmeleri formuna gidilecek.
            oduncislemleri.Show();
            this.Hide();
        }

        private void OduncListesi_FormClosing(object sender, FormClosingEventArgs e)
        {
            OduncIslemleri oduncislemleri = new OduncIslemleri(); // Form kapatıdığında Ödünç İşlemleri formuna gidilecek.
            oduncislemleri.Show();
        }
    }
}
