using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using KutuphaneKatmanli.DAL; // KutuphaneKatmanli.DAL sınıfını çağırıyoruz.

namespace KutuphaneKatmanli.BLL
{
    public class OdunclerBLL
    {
        private OdunclerDAL odunclerdal;

        public OdunclerBLL() // Constructor oluşturdum.
        {
            odunclerdal = new OdunclerDAL(); // OdunclerDAL sınıfından nesne türettim.
        }

        public DataTable OduncListele() // Datatable türünde method yazdım.
        {
            
            return odunclerdal.OduncListele(); // Çağırıldıgı zaman sunum katmanına referans verdiğimiz için methodu return edecek.
        }

        public DataTable OduncListele2(string uyeNo) // Datatable türünde method yazdım.
        {
            
            return odunclerdal.OduncListele2(uyeNo); // Çağırıldıgı zaman sunum katmanına referans verdiğimiz için methodu return edecek.
        }

        public DataTable OduncListele3(string kitapNo) // Datatable türünde method yazdım.
        {
            
            return odunclerdal.OduncListele3(kitapNo); // Çağırıldıgı zaman sunum katmanına referans verdiğimiz için methodu return edecek.
        }

        public DataTable OduncListele4() // Datatable türünde method yazdım.
        {
            
            return odunclerdal.OduncListele4(); // Çağırıldıgı zaman sunum katmanına referans verdiğimiz için methodu return edecek.
        }

        public DataTable OduncListele5() // Datatable türünde method yazdım.
        {

            return odunclerdal.OduncListele5(); // Çağırıldıgı zaman sunum katmanına referans verdiğimiz için methodu return edecek.
        }

        // Sunum katmanından gelen parametreleri DAL'a gönderiyorum.
        public void OduncEkle(string UyeNo, string KitapNo, string OduncAlmaTarih, string OduncTeslimTarih, string OduncNot, string TeslimEdildi)
        {
            odunclerdal.OduncEkle(UyeNo, KitapNo, OduncAlmaTarih, OduncTeslimTarih, OduncNot, TeslimEdildi);
        }

        // Sunum katmanından gelen parametreleri DAL'a gönderiyorum.
        public void OduncGuncelle(string OduncNo, string UyeNo, string KitapNo, string OduncAlmaTarih, string OduncTeslimTarih, string OduncIslemTarih,string OduncNot, string TeslimEdildi)
        {
            odunclerdal.OduncGuncelle(OduncNo, UyeNo, KitapNo, OduncAlmaTarih, OduncTeslimTarih, OduncIslemTarih, OduncNot, TeslimEdildi);
        }

    }
}
