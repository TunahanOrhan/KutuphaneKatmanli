using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb; // Access veritabanını kullanmak için kütüphane ekledim.

namespace KutuphaneKatmanli.DAL
{
    public class UyelerDAL
    {
        private Baglanti baglanti;

        public UyelerDAL() // Constructor oluşturdum.
        {
            baglanti = new Baglanti(); // Bağlantı sınıfından nesne türettim.
        }

        public DataTable UyeListele() // DataTable türünde bir method yazdım.
        {
            OleDbCommand cmd = baglanti.GetAccessCommand(); // Yeni bir cmd nesnesi türettim ve sorgudan gelen verileri datatable'a attım.

            cmd.CommandText = string.Format("Select * from Uyeler"); // Üyeler tablosundaki verileri listeleyecek olan sql sorgusunu yazdım.

            DataTable dt = new DataTable(); // Bir datatable nesnesi türettim.

            dt.Load(cmd.ExecuteReader()); // Veritabanından gelen verileri datatable'a attım.

            return dt; // Method çağırıldığında bu dt nesnesini döndürecek.
        }

        // Bool türünde bir fonksiyon yazdım. Üye eklerken eğer girilen Tc numarası ile aynı değerde kayıt varsa hata verecek yoksa başarılı bir şekilde üyeyi veritabanına ekleyecek.
        public bool UyeEkle(string UyeAd, string UyeSoyad, string UyeTel, string UyeMail, string UyeAdres, string UyeTc) //
        {
            OleDbCommand cmd = baglanti.GetAccessCommand(); // Komut nesnesi türettim.

            cmd.CommandText = string.Format("Select * from Uyeler where UyeTc={0}", UyeTc); // Gelen parametrelerden Tc no sorgusu yapıyorum.

            OleDbDataReader dr = cmd.ExecuteReader(); // Veriyi sorguluyor.

            if (dr.Read())
            {
                return true; // Eğer sorgu sonucunda veri bulunursa kayıt yaptırmayıp true döndürüyorum.
            }
            else
            {
                dr.Close(); // Datareader'ı kapatıyorum.

                // Eğer Tc no kayıtlı değilse veritabanına yeni üyeyi ekliyorum.
                string cmdText = string.Format("Insert into Uyeler (UyeAd,UyeSoyad,UyeTel,UyeMail,UyeAdres,UyeTc) values ('{0}','{1}','{2}','{3}','{4}','{5}')", UyeAd, UyeSoyad, UyeTel, UyeMail, UyeAdres, UyeTc);
                cmd.CommandText = cmdText;
                cmd.ExecuteNonQuery();
                return false;
            }
        }

        // Üye bilgilerini güncellemek için fonksiyon yazdım.
        public void UyeGuncelle(string UyeNo, string UyeAd, string UyeSoyad, string UyeTel, string UyeMail, string UyeAdres, string UyeTc) //Güncelleme için fonksiyon yazdım.
        {
            OleDbCommand cmd = baglanti.GetAccessCommand(); // Komut nesnesi türettim.

            string text = string.Format("Update Uyeler Set UyeAd='{1}',UyeSoyad='{2}',UyeTel='{3}',UyeMail='{4}',UyeAdres='{5}', UyeTc='{6}' Where UyeNo={0}",
                UyeNo, UyeAd, UyeSoyad, UyeTel, UyeMail, UyeAdres, UyeTc); // Güncelleme için sql sorgusunu yazdım.

            cmd.CommandText = text;

            cmd.ExecuteNonQuery(); // Komutu execute ediyorum.
        }

        // Üye silmek için fonksiyon yazdım.
        public void UyeSil(string UyeNo) 
        {
            OleDbCommand cmd = baglanti.GetAccessCommand(); // Komut nesnesi türettim.

            cmd.CommandText = string.Format("Delete From Uyeler Where UyeNo={0}", UyeNo); // Girilen ÜyeNo'ya göre üye bilgilerini silen sql sorgusunu yazdım.

            cmd.ExecuteNonQuery(); // Komutu execute ettim.
        }


        

    }
}
