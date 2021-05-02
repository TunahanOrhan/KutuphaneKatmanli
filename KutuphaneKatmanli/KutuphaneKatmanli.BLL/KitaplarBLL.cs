using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using KutuphaneKatmanli.DAL; // KutuphaneKatmanli.DAL sınıfını çağırıyoruz.

namespace KutuphaneKatmanli.BLL
{
    public class KitaplarBLL
    {
        private KitaplarDAL kitaplardal;

        public KitaplarBLL() // Constructor oluşturdum.
        {
            kitaplardal = new KitaplarDAL(); // KitaplarDAL sınıfından nesne türettim.
        }


        public DataTable KitapListele() // Datatable türünde method yazdım.
        {
            
            return kitaplardal.KitapListele(); // Çağırıldıgı zaman sunum katmanına referans verdiğimiz için methodu return edecek.
        }

        // Sunum katmanından gelen parametreleri DAL'a gönderiyorum.
        public bool KitapEkle(string KitapAd, string KitapYazari, string KitapBaskiYil, string KitSayfaSayi)
        {
            
            if (kitaplardal.KitapEkle(KitapAd, KitapYazari, KitapBaskiYil, KitSayfaSayi))
            {
                return false; // Eğer kayıt başarılı olursa false değer dönecek.
            }
            
            else
            {
                return true; // Eğer kayıt başarısız olursa true değer dönecek.
            }
        }

        // Sunum katmanından gelen parametreleri DAL'a gönderiyorum.
        public void KitapGuncelle(string KitapNo, string KitapAd, string KitapYazari, string KitapBaskiYil, string KitSayfaSayi)
        {
            kitaplardal.KitapGuncelle(KitapNo, KitapAd, KitapYazari, KitapBaskiYil, KitSayfaSayi);
        }

        // Sunum katmanından gelen parametreleri DAL'a gönderiyorum.
        public void KitapSil(string KitapNo)
        {
            kitaplardal.KitapSil(KitapNo);
        }

    }
}
