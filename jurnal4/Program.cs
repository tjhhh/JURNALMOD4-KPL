// See https://aka.ms/new-console-template for more information
using jurnal4;
using Microsoft.VisualBasic;

class Program
{
    static void Main()
    {
        KodeProduk kodeProduk = new KodeProduk();

        Console.Write("Masukkan nama Barang: ");
        string namaBarang = Console.ReadLine();

        Console.WriteLine("Kode Produk: " + kodeProduk.getKodeProduk(namaBarang));

        FanLaptop fan = new FanLaptop();

        Console.WriteLine(fan);
        Console.WriteLine("MODE: (BALANCE/QUIET/PERFORMANCE/TURBO)");
        while (true)
        {
            Console.Write("Masukkan perintah: ");
            string perintah = Console.ReadLine();

            if (perintah.ToLower() == "quiet")
                fan.FanQuiet();
            else if (perintah.ToLower() == "turbo")
                fan.FanTurbo();
            else if(perintah.ToLower() == "performance")
                fan.FanPerformanced();
            else if(perintah.ToLower() == "balance")
                fan.FanBalanced();
            else if (perintah.ToLower() == "keluar")
                break;
            else
                Console.WriteLine("Perintah tidak dikenali!");
        }


    }
}
