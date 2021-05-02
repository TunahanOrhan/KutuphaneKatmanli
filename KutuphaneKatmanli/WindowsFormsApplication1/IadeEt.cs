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
    public partial class IadeEt : Form
    {
        public IadeEt()
        {
            InitializeComponent();
        }

        private void IadeEt_Activated(object sender, EventArgs e)
        {
            OdunclerBLL odunclerbll = new OdunclerBLL();
            dataGridView1.DataSource = odunclerbll.OduncListele5(); // Form açıldığında datagridview1'de Ödünç tablosundan gelen verileri listeliyorum.

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            dataGridView1.ReadOnly = true; //

            dateTimePicker1.Value = DateTime.Now; // Datetimepicker1 değerini bilgisayarın tarihi olarak ayarlıyorum.

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++) // dataGridView1'de teslim tarihi geçmiş veya 2 gün kalmış ödünçleri renklendiriyorum.
            {
                TimeSpan fark = Convert.ToDateTime(dataGridView1.Rows[i].Cells[4].Value.ToString()) - Convert.ToDateTime(DateTime.Now.ToShortDateString());
                double farkgun = fark.TotalDays;
                
                if (farkgun < 3 && farkgun >= 0) dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Yellow; // Teslim tarihine 3 günden az kalmış ödünçleri sarı ile
                else if (farkgun < 0) dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red; // Teslim tarihi geçmiş ödünçleri kırmızı ile gösteriyorum.
                
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CurrentRow.Selected = true; // datagridview1'de bir hücre seçildiğinde bütün satırı seçili hale getiriyorum.

            string uyeNo = dataGridView1.CurrentRow.Cells[1].Value.ToString(); //uyeNo ve kitapNo değerlerini değişkenlere atıyorum.
            string kitapNo = dataGridView1.CurrentRow.Cells[2].Value.ToString();

            groupBox1.Visible = true; // Bu groupboxlarda üyenin kitabın ve ödenmesi gereken cezanın bilgileri gösterilecek.
            groupBox2.Visible = true;
            groupBox3.Visible = true;

            dateTimePicker1.Value = DateTime.Now; // Datetimepicker1 değerini bilgisayarın tarihi olarak ayarlıyorum.

           UyelerBLL uyelerbll = new UyelerBLL();
           dataGridView2.DataSource = uyelerbll.UyeListele(); // Visible özelliğini false yaptığım datagridview2'de üyeleri listeliyorum. Bu sayede seçilen 
            // ödüncün üye bilgilerini textboxlara aktaracağım.

           KitaplarBLL kitaplarbll = new KitaplarBLL();
           dataGridView3.DataSource = kitaplarbll.KitapListele(); //Visible özelliğini false yaptığım datagridview3'de kitapları listeliyorum. Bu sayede seçilen 
            // ödüncün kitap bilgilerini textboxlara aktaracağım.
           

            for (int i = 0; i < dataGridView2.Rows.Count - 1; i++) // Seçilen ödüncün üye bilgilerini datagridview2'den çekerek textboxlara aktarıyorum.
            {
                if (dataGridView2.Rows[i].Cells[0].Value.ToString() == uyeNo)
                {
                    
                    dataGridView2.Rows[i].Selected = true;

                    string uyeAd = dataGridView2.Rows[i].Cells[1].Value.ToString();
                    string uyeSoyad = dataGridView2.Rows[i].Cells[2].Value.ToString();
                    string uyeTel = dataGridView2.Rows[i].Cells[3].Value.ToString();
                    string uyeMail = dataGridView2.Rows[i].Cells[4].Value.ToString();
                    string uyeAdres = dataGridView2.Rows[i].Cells[5].Value.ToString();
                    string uyeTc = dataGridView2.Rows[i].Cells[6].Value.ToString();

                    textBox1.Text = uyeNo;
                    textBox2.Text = uyeAd;
                    textBox3.Text = uyeSoyad;
                    maskedTextBox2.Text = uyeTel;
                    textBox5.Text = uyeMail;
                    textBox6.Text = uyeAdres;
                    maskedTextBox1.Text = uyeTc;
                    
                }
                
            }


            for (int i = 0; i < dataGridView3.Rows.Count - 1; i++) // Seçilen ödüncün kitap bilgilerini datagridview3'den çekerek textboxlara aktarıyorum.
            {
                if (dataGridView3.Rows[i].Cells[0].Value.ToString() == kitapNo)
                {
                    
                    dataGridView3.Rows[i].Selected = true;

                    string kitapAd = dataGridView3.Rows[i].Cells[1].Value.ToString();
                    string kitapYazar = dataGridView3.Rows[i].Cells[2].Value.ToString();
                    string kitapBaskiYil = dataGridView3.Rows[i].Cells[3].Value.ToString();
                    string KitapSayfaSayi = dataGridView3.Rows[i].Cells[4].Value.ToString();
                    

                    textBox4.Text = kitapNo;
                    textBox7.Text = kitapAd;
                    textBox8.Text = kitapYazar;
                    textBox9.Text = kitapBaskiYil;
                    textBox10.Text = KitapSayfaSayi;

                }

            }
            
            TimeSpan fark = Convert.ToDateTime(DateTime.Now.ToShortDateString()) - Convert.ToDateTime(dataGridView1.CurrentRow.Cells[4].Value.ToString());
            double farkgun = fark.TotalDays;
            


            if (farkgun <= 0) // Eğer kitabın teslim tarihi geçmediyse ödenmesi gereken cezayı '0', geçtiyse gün başına 1 TL olarak gösteriyorum.
            {
                textBox11.Text = "0";
            }
            else
            {
                textBox11.Text = Math.Ceiling(farkgun).ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OduncIslemleri oduncislemleri = new OduncIslemleri(); // Butona basıldığında ödünç işlemleri formuna geçiş sağlıyorum.
            oduncislemleri.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // İade et butonuna basıldığında ödünç verilerini değişkenlere atıyorum.
            string oduncNo = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string uyeNo = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            string kitapNo = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            string alimTarih = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            string teslimTarih = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            string islemTarih = dateTimePicker1.Value.ToString();
            string not = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            string teslim = "Evet"; // Teslim edildi verisini 'Evet' olarak değiştiriyorum.

            OdunclerBLL odunclerbll = new OdunclerBLL();


            odunclerbll.OduncGuncelle(oduncNo, uyeNo, kitapNo, alimTarih, teslimTarih, islemTarih, not, teslim); // Veritabanında ödünç bilgilerini güncelliyorum.
                MessageBox.Show("İade Başarılı.");
                textBox1.Text = ""; // Textboxları temizliyorum.
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";
                textBox9.Text = "";
                textBox10.Text = "";
                textBox11.Text = "";
                maskedTextBox1.Text = "";
                maskedTextBox2.Text = "";
                
                dataGridView1.DataSource = odunclerbll.OduncListele5(); // datagridview1'de güncel ödünçler tablosunu gösteriyorum.

                dataGridView1.ReadOnly = true;

                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++) // dataGridView1'de teslim tarihi geçmiş veya 2 gün kalmış ödünçleri renklendiriyorum.
                {
                    TimeSpan fark = Convert.ToDateTime(dataGridView1.Rows[i].Cells[4].Value.ToString()) - Convert.ToDateTime(DateTime.Now.ToShortDateString());
                    double farkgun = fark.TotalDays;

                    if (farkgun < 3 && farkgun >= 0) dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Yellow; // Teslim tarihine 3 günden az kalmış ödünçleri sarı ile
                    else if (farkgun < 0) dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red; // Teslim tarihi geçmiş ödünçleri kırmızı ile gösteriyorum.
     
                }
           
        }

        private void IadeEt_FormClosing(object sender, FormClosingEventArgs e)
        {
            OduncIslemleri oduncislemleri = new OduncIslemleri(); // Form kapatıldığında ödünç işlemleri formuna geçiş yapıyorum.
            oduncislemleri.Show();    
        }

        private void IadeEt_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
