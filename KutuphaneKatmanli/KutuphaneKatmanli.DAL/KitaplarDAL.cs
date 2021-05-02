using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb; // Access veritabanını kullanmak için kütüphane ekledim.

namespace KutuphaneKatmanli.DAL
{
    public class KitaplarDAL
    {
        private Baglanti baglanti;

        public KitaplarDAL() // Constructor oluşturdum.
        {
            baglanti = new Baglanti(); // Bağlantı sınıfından yeni bir nesne türettim.
        }

        public DataTable KitapListele() // DataTable türünde bir method yazdım.
        {
            OleDbCommand cmd = baglanti.GetAccessCommand(); // Yeni bir cmd nesnesi türettim ve sorgudan gelen verileri datatable'a attım.

            cmd.CommandText = string.Format("Select * from Kitaplar"); // Kitaplar tablosundaki verileri listeleyecek olan sql sorgusunu yazdım.

            DataTable dt = new DataTable(); // Bir datatable nesnesi türettim.

            dt.Load(cmd.ExecuteReader()); // Veritabanından gelen verileri datatable'a attım.

            return dt; // Method çağırıldığında bu dt nesnesini döndürecek.
        }

        // Bool türünde bir fonksiyon yazdım. Kitap eklerken eğer aynı isimde bir kitap varsa hata verecek yoksa başarılı bir şekilde kitabı veritabanına ekleyecek. 
        public bool KitapEkle(string KitapAd, string KitapYazari, string KitapBaskiYil, string KitSayfaSayi) 
        {
            OleDbCommand cmd = baglanti.GetAccessCommand(); // Komut nesnesi türettim.

            cmd.CommandText = string.Format("Select * from Kitaplar Where KitapAd ='{0}'", KitapAd); // Gelen parametrelerden KitapNo sorgusu yapıyorum.

            OleDbDataReader dr = cmd.ExecuteReader(); // KitapNo sorguluyor.

            if (dr.Read())
            {
                return true; // Eğer sorgu sonucunda veri bulunursa kayıt yaptırmayıp true döndürüyorum.
            }
            else
            {
                dr.Close(); // Datareader'ı kapatıyorum.

                // Eğer KitapNo kayıtlı değilse veritabanına kitabı ekliyorum.
                string cmdText = string.Format("Insert into Kitaplar (KitapAd,KitapYazari,KitapBaskiYil,KitSayfaSayi) values ('{0}','{1}','{2}','{3}')", KitapAd, KitapYazari, KitapBaskiYil, KitSayfaSayi);
                cmd.CommandText = cmdText;
                cmd.ExecuteNonQuery();
                return false;
            }
        }

        // Kitap bilgilerini güncellemek için fonksiyon yazdım.
        public void KitapGuncelle(string KitapNo, string KitapAd, string KitapYazari, string KitapBaskiYil, string KitSayfaSayi) //Güncelleme için fonksiyon yazdım.
        {
            OleDbCommand cmd = baglanti.GetAccessCommand(); // Komut nesnesi türettim.

            string text = string.Format("Update Kitaplar Set KitapAd='{1}',KitapYazari='{2}',KitapBaskiYil='{3}',KitSayfaSayi='{4}' Where KitapNo={0}",
                KitapNo, KitapAd, KitapYazari, KitapBaskiYil, KitSayfaSayi); // Güncelleme için sql sorgusunu yazdım.

            cmd.CommandText = text;

            cmd.ExecuteNonQuery(); // Komutu execute ediyorum.
        }

        public void KitapSil(string KitapNo) // Kitap silmek için fonksiyon yazdım.
        {
            OleDbCommand cmd = baglanti.GetAccessCommand(); // Komut nesnesi türettim.

            cmd.CommandText = string.Format("Delete From Kitaplar Where KitapNo={0}", KitapNo); // Girilen KitapNo'ya göre kitap bilgilerini silen sql sorgusunu yazdım.

            cmd.ExecuteNonQuery(); // Komutu execute ettim.
        }

    }
}
