using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using KutuphaneKatmanli.DAL; // KutuphaneKatmanli.DAL sınıfını çağırıyoruz.

namespace KutuphaneKatmanli.BLL
{
    public class UyelerBLL
    {
        private UyelerDAL uyelerdal;

        public UyelerBLL() // Constructor oluşturdum.
        {
            uyelerdal = new UyelerDAL(); // UyelerDAL sınıfından nesne türettim.
        }

        // Sunum katmanından gelen parametreleri DAL'a gönderiyorum.
        public bool UyeEkle(string UyeAd, string UyeSoyad, string UyeTel, string UyeMail, string UyeAdres, string UyeTc)
        {
            
            if (uyelerdal.UyeEkle(UyeAd, UyeSoyad, UyeTel, UyeMail, UyeAdres, UyeTc))
            {
                return false; // Eğer kayıt başarılı olursa false değer dönecek.
            }
            else
            {
                return true; // Eğer kayıt başarısız olursa true değer dönecek.
            }
        }

        public DataTable UyeListele() // Datatable türünde method yazdım.
        {
            
            return uyelerdal.UyeListele(); // Çağırıldıgı zaman sunum katmanına referans verdiğimiz için methodu return edecek.
        }

        // Sunum katmanından gelen parametreleri DAL'a gönderiyorum.
        public void UyeGuncelle(string UyeNo, string UyeAd, string UyeSoyad, string UyeTel, string UyeMail, string UyeAdres, string UyeTc)
        {
            uyelerdal.UyeGuncelle(UyeNo, UyeAd, UyeSoyad, UyeTel, UyeMail, UyeAdres, UyeTc);
        }

        // Sunum katmanından gelen parametreleri DAL'a gönderiyorum.
        public void UyeSil(string UyeNo)
        {
            uyelerdal.UyeSil(UyeNo);
        }


    }
}
