// See https://aka.ms/new-console-template for more information
using jurnal4;

class Program
{
    static void Main()
    {
        KodeProduk kodeProduk = new KodeProduk();

        Console.Write("Masukkan nama Barang: ");
        string namaBarang = Console.ReadLine();

        Console.WriteLine("Kode Produk: " + kodeProduk.getKodeProduk(namaBarang));
       

        
    }
}
