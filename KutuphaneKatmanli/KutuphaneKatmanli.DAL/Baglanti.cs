using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb; // Access veritabanını kullanmak için kütüphane ekledim.

namespace KutuphaneKatmanli.DAL
{
    public class Baglanti
    {
        private readonly string _connectionString; // Sadece okunabilir bir string değişken tanımladım.

        public Baglanti() // Constructor tanımladım.
        {   // String değiişkene accesss veritabanı adresini verdim.
            _connectionString = "Provider=Microsoft.ACE.OLEDB.16.0;Data Source=C:\\Users\\Tuna\\Desktop\\KutuphaneKatmanli\\KatmanliKutuphane.accdb";
        }

        private OleDbConnection GetAccessConnection() // Bağlantıyı return eden bir method yazdım.
        {
            OleDbConnection conn = new OleDbConnection(_connectionString); // Yeni bir accessDB connection nesnesi türettim.

            if (conn.State == System.Data.ConnectionState.Open) // Veritabanını güncellemek için fonksiyon her çağırıldığında kapatıp açıyorum.
            {
                conn.Close();
                conn.Open();
            }
            else
            {
                conn.Open();
            }
            // Methodu çağırdığımız zaman bize bağlantıyı döndürecek.
            return conn;

        }

        public OleDbCommand GetAccessCommand() // Komutlar için method yazdım.
        {
            OleDbCommand cmd = new OleDbCommand(); // Komut için bir nesne türettim.

            cmd.Connection = GetAccessConnection(); // Komut nesnesini veritabanı ile ilişkilendirdim.

            return cmd; // Method çağırıldığında geriye döndürüyorum.
        }



    }
}
