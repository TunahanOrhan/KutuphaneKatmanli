using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb; // Access veritabanını kullanmak için kütüphane ekledim.

namespace KutuphaneKatmanli.DAL
{
    public class OdunclerDAL
    {

        private Baglanti baglanti;

        public OdunclerDAL() // Constructor oluşturdum.
        {
            baglanti = new Baglanti(); // Bağlantı sınıfından yeni bir nesne türettim.
        }

        // Ödünçler tablosundaki bütün verileri göstermek için bir method yazdım.
        public DataTable OduncListele()
        {
            OleDbCommand cmd = baglanti.GetAccessCommand(); //Yeni bir cmd nesnesi türettim ve sorgudan gelen verileri datatable'a attım.

            cmd.CommandText = string.Format("Select * from Oduncler"); // Ödünçler tablosundaki verileri listeleyecek olan sql sorgusunu yazdım.

            DataTable dt = new DataTable(); // Bir datatable nesnesi türettim.

            dt.Load(cmd.ExecuteReader()); // Veritabanından gelen verileri datatable'a attım.

            return dt; // Method çağırıldığında bu dt nesnesini döndürecek.
        }

        // Üyelerin kitap kullanım geçmişini göstermek için method yazdım.
        public DataTable OduncListele2(string uyeNo)
        {
            OleDbCommand cmd = baglanti.GetAccessCommand(); // Yeni bir cmd nesnesi türettim ve sorgudan gelen verileri datatable'a attım.

            cmd.CommandText = string.Format("Select * from Oduncler where UyeNo='{0}'",uyeNo); // Ödünçler tablosundan sadece istenilen üyenin verilerini listeleyecek olan sql sorgusunu yazdım.

            DataTable dt = new DataTable(); // Bir datatable nesnesi türettim.

            dt.Load(cmd.ExecuteReader()); // Veritabanından gelen verileri datatable'a attım.

            return dt;// Method çağırıldığında bu dt nesnesini döndürecek.
        }

        // Kitapların kullanım geçmişini göstermek için bir method yazdım.
        public DataTable OduncListele3(string kitapNo) 
        {
            OleDbCommand cmd = baglanti.GetAccessCommand(); // Yeni bir cmd nesnesi türettim ve sorgudan gelen verileri datatable'a attım.

            cmd.CommandText = string.Format("Select * from Oduncler where KitapNo='{0}'", kitapNo); // Ödünçler tablosundan sadece istenilen kitabın verilerini listeleyecek olan sql sorgusunu yazdım.

            DataTable dt = new DataTable(); // Bir datatable nesnesi türettim.

            dt.Load(cmd.ExecuteReader()); // Veritabanından gelen verileri datatable'a attım.

            return dt;// Method çağırıldığında bu dt nesnesini döndürecek.
        }

        // Grafikte kullanabilmek için ödünçler tablosunda hala iade edilmemiş kullanımda olan kitapları listelemek için bir method yazdım.
        public DataTable OduncListele4()
        {
            OleDbCommand cmd = baglanti.GetAccessCommand(); // Yeni bir cmd nesnesi türettim ve sorgudan gelen verileri datatable'a attım.

            cmd.CommandText = string.Format("Select Distinct KitapNo from Oduncler where TeslimEdildi = \"Hayır\" "); // Ödünçler tablosundan kullanımda olan kitapların numaralarını listeleyecek olan sql sorgusunu yazdım.

            DataTable dt = new DataTable(); // Bir datatable nesnesi türettim.

            dt.Load(cmd.ExecuteReader()); // Veritabanından gelen verileri datatable'a attım.

            return dt; // Method çağırıldığında bu dt nesnesini döndürecek.
        }

        // İade bölümünde sadece iade edilmemiş olan kitapları görmek için bir method yazdım.
        public DataTable OduncListele5()
        {
            OleDbCommand cmd = baglanti.GetAccessCommand(); // Yeni bir cmd nesnesi türettim ve sorgudan gelen verileri datatable'a attım.

            cmd.CommandText = string.Format("Select * from Oduncler where TeslimEdildi = \"Hayır\" "); // Ödünçler tablosundan kullanımda olan kitapları listeleyecek olan sql sorgusunu yazdım.

            DataTable dt = new DataTable(); // Bir datatable nesnesi türettim.

            dt.Load(cmd.ExecuteReader()); // Veritabanından gelen verileri datatable'a attım.

            return dt; // Method çağırıldığında bu dt nesnesini döndürecek.
        }

        // Ödünç alma işlemini gerçekleştirmek için bir method yazdım.
        public void OduncEkle(string UyeNo, string KitapNo, string OduncAlmaTarih, string OduncTeslimTarih, string OduncNot, string TeslimEdildi) //
        {
            OleDbCommand cmd = baglanti.GetAccessCommand(); // Komut nesnesi türettim.

            // Ödünç alma işlemi yapıldığında ödünçler tablosuna verileri ekleyen kodu yazdım. 
            string cmdText = string.Format("Insert into Oduncler (UyeNo,KitapNo,OduncAlmaTarih,OduncTeslimTarih,OduncNot,TeslimEdildi) values ('{0}','{1}','{2}','{3}','{4}','{5}')", UyeNo, KitapNo, OduncAlmaTarih, OduncTeslimTarih, OduncNot, TeslimEdildi);
            cmd.CommandText = cmdText;
            cmd.ExecuteNonQuery();
        }
        
        // İade işlemini gerçekleştirmek için bir method yazdım. İade işlemi yapıldığında teslim edildi bilgileri güncellenecek ve ödünç bilgileri hala veritabanında saklanacak.
        public void OduncGuncelle(string OduncNo, string UyeNo, string KitapNo, string OduncAlmaTarih, string OduncTeslimTarih, string OduncIslemTarih, string OduncNot, string TeslimEdildi) //Güncelleme için fonksiyon yazdım.
        {
            OleDbCommand cmd = baglanti.GetAccessCommand(); // Komut nesnesi türettim.

            string text = string.Format("Update Oduncler Set UyeNo='{1}',KitapNo='{2}',OduncAlmaTarih='{3}',OduncTeslimTarih='{4}',OduncIslemTarih='{5}',OduncNot='{6}', TeslimEdildi='{7}' Where OduncNo={0}",
                OduncNo, UyeNo, KitapNo, OduncAlmaTarih, OduncTeslimTarih, OduncIslemTarih, OduncNot, TeslimEdildi); // Güncelleme için sql sorgusunu yazdım.

            cmd.CommandText = text;

            cmd.ExecuteNonQuery(); // Komutu execute ediyorum.
        } 

    }
}
