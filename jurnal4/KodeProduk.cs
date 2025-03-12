using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jurnal4
{
    class KodeProduk
    {


        private Dictionary<string, string> kodeProduk = new Dictionary<string, string> {
        {"Laptop", "E100"},
        {"Smartphone", "E101"},
        {"Tablet", "E102"},
        {"Headset", "E103"},
        {"Keyboard", "E104"},
        {"Mouse", "E105"},
        {"Printer", "E106"},
        {"Monitor", "E1007"},
        {"Smartwatch", "E108"},
        {"Kamera", "E109"}
        
    };

        public string getKodeProduk(string namaProduk)
        {
            return kodeProduk.ContainsKey(namaProduk) ? kodeProduk[namaProduk] : "Kode Produk Tidak Ditemukan";
        }
    }
}
