using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph; // Zedgraph sınıfını çağırıyoruz.
using KutuphaneKatmanli.BLL; // KutuphaneKatmanli.BLL sınıfını çağırıyoruz.

namespace WindowsFormsApplication1
{
    public partial class Grafik : Form
    {
        public Grafik()
        {
            InitializeComponent();
        }

        private void Grafik_Load(object sender, EventArgs e)
        {
            KitaplarBLL kitaplarbll = new KitaplarBLL();
            dataGridView1.DataSource = kitaplarbll.KitapListele(); // Form yüklendiğinde Visible özelliğini false yaptığım datagridview1'e bütün kitapları listeler.

            OdunclerBLL odunclerbll = new OdunclerBLL();
            dataGridView2.DataSource = odunclerbll.OduncListele4(); // Form yüklendiğinde Visible özelliğini false yaptığım datagridview2'e sadece o an kullanımda olan kitapları listeler.

            GraphPane myPane = zedGraphControl1.GraphPane; // Graphpane sınıfından myPane adında nesne türettim.
            
            myPane.Title.Text = "Kitap Kullanım Oranı"; // Oluşturulan grafiğin başlığını değiştirdim.
            myPane.XAxis.Title.IsVisible = false; // X ve Y ekseninin başlıklarını kaldırdım.
            myPane.YAxis.Title.IsVisible = false;
            
            string[] labels = { "Şuanda Kullanılmayan Kitap Sayısı", "Şuanda Kullanılan Kitap Sayısı", "Toplam Kitap Sayısı" }; // İstatistiklerini göstermek istediğim bilgileri bir diziye attım.
            double[] x = {dataGridView1.RowCount-dataGridView2.RowCount,dataGridView2.RowCount,dataGridView1.RowCount}; // İstatistikleri datagridviewlerden çekerek bir diziye attım.

                    
            BarItem myBar = myPane.AddBar("",x,null, Color.Green ); // İstatistikleri göstermek için kullanacağım yatay barları ekledim. 

            myPane.YAxis.Type = AxisType.Text; // Barların temsil ettiği bilgileri Y eksenine yazdırdım.
            myPane.YAxis.Scale.TextLabels = labels;

            myPane.BarSettings.Base = BarBase.Y; // Barları Y ekseninden başlattım.

           // myPane.Fill = new Fill(Color.FromArgb(250, 250, 255));

            myPane.XAxis.MajorGrid.IsZeroLine = true; 
            myPane.YAxis.MajorGrid.IsZeroLine = false; // Yatay eksen çizgisi kaldırdım.

           // myPane.XAxis.Scale.Min = 0;
            myPane.XAxis.Scale.Max = 60; // X ekseninindeki numaralandırmayı 60'a kadar gösterdim. 

           // myPane.YAxis.Scale.Min = 0;
            myPane.YAxis.Scale.Max = 4; // Y eksenindeki numaralandırmayı 4 parçaya böldüm.

            button3.PerformClick(); // Grafikte çıkan bir sorundan dolayı düzelmesi için yakınlaştırıp uzaklaştrırmak gerekiyordu. Bu sorunu visible özelliği false olan
            // iki buton ekledim. Butonlardan birine yakınlaştırma diğerine uzaklaştırma özelliği ekledim. Form yüklendiğinde butonlar çalışıyor ve
            // otomatik olarak sorunu düzeltiyor. Sorun grafik yazıları yerine oturmuyordu.
            button4.PerformClick();
            button3.Visible = false;
            button4.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GraphPane myPane = zedGraphControl1.GraphPane; // Butona basıldığında textbox1'deki metni grafiğin başlığı yapacak.
            myPane.Title.Text = textBox1.Text;
            zedGraphControl1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(); // Butona basıldığında Form1'e dönüş yapacak.
            form1.Show();
            this.Hide();
        }

        private void Grafik_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void Grafik_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 form1 = new Form1(); // Form kapatıldığında Form1'e dönüş yapacak.
            form1.Show();            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PointF centrePoint = new System.Drawing.PointF(); // Bu butona yakınlaştırma özelliği atadım. Çalıştığında grafiği 1.1 ölçek yakınlaştırıyor.
            GraphPane myPane = zedGraphControl1.GraphPane;
            zedGraphControl1.ZoomPane(myPane, 1.1, centrePoint, false);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PointF centrePoint = new System.Drawing.PointF(); // Bu butona uzaklaştırma özelliği atadım. Çalıştığında grafiği 0.9 ölçek uzaklaştırıyor.
            GraphPane myPane = zedGraphControl1.GraphPane;
            zedGraphControl1.ZoomPane(myPane, 0.9, centrePoint, false);
        }
    }
}
