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
    public partial class OduncAl : Form
    {
        public OduncAl()
        {
            InitializeComponent();
        }

        private void OduncAl_Activated(object sender, EventArgs e)
        {
            UyelerBLL uyelerbll = new UyelerBLL();
            dataGridView1.DataSource = uyelerbll.UyeListele(); // Form aktive edildiğinde datagridview1'de üyeleri listeliyorum.

            KitaplarBLL kitaplarbll = new KitaplarBLL(); 
            dataGridView2.DataSource = kitaplarbll.KitapListele(); // Form aktive edildiğinde datagridview2'de kitapları listeliyorum.

            OdunclerBLL odunclerbll = new OdunclerBLL();
            dataGridView3.DataSource = odunclerbll.OduncListele();  // Form aktive edildiğinde datagridview3'de ödünçleri listeliyorum.

            dateTimePicker1.Value = DateTime.Now; // datetimepicker1'in değerini bilgisaarın tarihi yapıyorum.
            dateTimePicker2.Value = dateTimePicker1.Value.AddMonths(1); // Ödünç alınan kitabın teslim tarihini 1 ay ileriye vermek için datetimepicker2'nin değerini datetimepicker1'den 1 ay ileri atıyorum.

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            dataGridView1.ReadOnly = true;
            dataGridView2.ReadOnly = true;
            dataGridView3.ReadOnly = true;

            for (int i = 0; i < dataGridView3.Rows.Count - 1; i++) // dataGridView3'de teslim tarihi geçmiş veya 2 gün kalmış ödünçleri renklendiriyorum.
            {
                TimeSpan fark = Convert.ToDateTime(dataGridView3.Rows[i].Cells[4].Value.ToString()) - Convert.ToDateTime(DateTime.Now.ToShortDateString());
                double farkgun = fark.TotalDays;

                if (farkgun < 3 && farkgun >= 0) dataGridView3.Rows[i].DefaultCellStyle.BackColor = Color.Yellow; // Teslim tarihine 3 günden az kalmış ödünçleri sarı ile
                else if (farkgun < 0) dataGridView3.Rows[i].DefaultCellStyle.BackColor = Color.Red; // Teslim tarihi geçmiş ödünçleri kırmızı ile gösteriyorum.

                if (dataGridView3.Rows[i].Cells[7].Value.ToString() == "Evet")
                {
                    dataGridView3.Rows[i].DefaultCellStyle.BackColor = Color.Green; // Teslim edilmiş ödünçleri yeşil ile gösteriyorum.
                }
            }
        }
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CurrentRow.Selected = true; // datagridview1'de bir hücre seçildiğinde tüm satırı seçiyorum. 
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString(); // Seçilen üyenin üyeNo'sunu textbox1'e atıyorum.
        }
        
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView2.CurrentRow.Selected = true; // datagridview2'de bir hücre seçildiğinde tüm satırı seçiyorum.
            textBox2.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString(); // Seçilen kitabın kitapNo'sunu textbox2'e atıyorum.
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Lütfen bir üye seçiniz!"); // Ödünç almak için butona basıldığında eğer bir üye seçilmediyse kullancıdan seçmesini istiyorum.
            }
            else if (textBox2.Text == "")     
                {
                    MessageBox.Show("Lütfen bir kitap seçiniz!"); // Ödünç almak için butona basıldığında eğer bir kitap seçilmediyse kullancıdan seçmesini istiyorum.
                }
                else
                {
                    string uyeNo = textBox1.Text.ToString(); // Kitap ve üye seçildiyse ödünç bilgilerini veritabanına göndermek için değişkenlere atıyorum. 
                    string kitapNo = textBox2.Text.ToString();
                    string alimTarih = dateTimePicker1.Value.ToString();
                    string teslimTarih = dateTimePicker2.Value.ToString();
                    string Not = textBox5.Text.ToString();
                    string teslimEdildi = "Hayır";


                    OdunclerBLL odunclerekle = new OdunclerBLL();

                    try
                    {
                        odunclerekle.OduncEkle(uyeNo, kitapNo, alimTarih, teslimTarih, Not, teslimEdildi); // Değişkenleri parametre olarak gönderiyorum.
                        MessageBox.Show("Ödünç Başarılı."); // Veritabanına ekleme başarılıysa kullancıya mesaj veriyorum.
                        OdunclerBLL odunclerbll = new OdunclerBLL();
                        dataGridView3.DataSource = odunclerbll.OduncListele(); // Güncel ödünç tablosunu datagridview3'te gösteriyorum.
                        textBox1.Text = ""; // Textboxların içeriğini temizliyorum.
                        textBox2.Text = "";
                        textBox5.Text = "";

                        for (int i = 0; i < dataGridView3.Rows.Count - 1; i++) // dataGridView3'de teslim tarihi geçmiş veya 2 gün kalmış ödünçleri renklendiriyorum.
                        {
                            TimeSpan fark = Convert.ToDateTime(dataGridView3.Rows[i].Cells[4].Value.ToString()) - Convert.ToDateTime(DateTime.Now.ToShortDateString());
                            double farkgun = fark.TotalDays;

                            if (farkgun < 3 && farkgun >= 0) dataGridView3.Rows[i].DefaultCellStyle.BackColor = Color.Yellow; // Teslim tarihine 3 günden az kalmış ödünçleri sarı ile
                            else if (farkgun < 0) dataGridView3.Rows[i].DefaultCellStyle.BackColor = Color.Red; // Teslim tarihi geçmiş ödünçleri kırmızı ile gösteriyorum.

                            if (dataGridView3.Rows[i].Cells[7].Value.ToString() == "Evet")
                            {
                                dataGridView3.Rows[i].DefaultCellStyle.BackColor = Color.Green; // Teslim edilmiş ödünçleri yeşil ile gösteriyorum.
                            }
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ödünç alırnırken bir hata oluştu!!!"); // Veritabanına ödünç ekleme başarısız ise kullanıcıya hata mesajı veriyorum.
                    }
                }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OduncIslemleri oduncislemleri = new OduncIslemleri(); // Butona basıldığında ödünç işlemleri formuna geçiş yapıyorum.
            oduncislemleri.Show();
            this.Hide();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CurrentRow.Selected = true; // Datagridview1'de bir hücre seçildiğinde tüm satırı seçiyorum.
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString(); // // Seçilen üyenin üyeNo'sunu textbox1'e atıyorum.
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView2.CurrentRow.Selected = true; // datagridview2'de bir hücre seçildiğinde tüm satırı seçiyorum.
            textBox2.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString(); // Seçilen kitabın kitapNo'sunu textbox2'e atıyorum.
        }

        private void OduncAl_FormClosing(object sender, FormClosingEventArgs e)
        {
            OduncIslemleri oduncislemleri = new OduncIslemleri(); // Form kapatıldığında ödünç işlemleri formuna geçiş yapıyorum.
            oduncislemleri.Show();
        }

        private void OduncAl_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

            for (int i = 0; i < dataGridView2.RowCount - 1; i++)
            {
                if (textBox1.Text == dataGridView2.Rows[i].Cells[0].Value)
                {
                    dataGridView2.Rows[i].Selected = true;
                }
            }
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {

        }
    }
}
