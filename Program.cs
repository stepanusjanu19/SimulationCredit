using System.Globalization;

class Program
{
    static void Main()
    {
        var culture = CultureInfo.CreateSpecificCulture("id-ID");
        Console.WriteLine("=== Simulasi Kredit IMS Finance ===");

        Console.Write("Masukkan Harga Mobil (OTR): ");
        decimal otr = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Masukkan DP (%) [misal: 20]: ");
        decimal dpPercent = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Masukkan Jangka Waktu (bulan): ");
        int tenor = Convert.ToInt32(Console.ReadLine());
        
        decimal dp = otr * dpPercent / 100;
        decimal pokokUtang = otr - dp;

        decimal bungaPersen;
        if (tenor <= 12)
            bungaPersen = 12;
        else if (tenor <= 24)
            bungaPersen = 14;
        else
            bungaPersen = 16.5m;

        decimal bunga = bungaPersen / 100;
        decimal angsuran = (pokokUtang + (pokokUtang * bunga)) / tenor;

        Console.WriteLine("\n=== Hasil Perhitungan ===");
        Console.WriteLine($"Harga Mobil (OTR): {otr.ToString("C", culture)}");
        Console.WriteLine($"DP ({dpPercent}%): {dp.ToString("C", culture)}");
        Console.WriteLine($"Pokok Utang: {pokokUtang.ToString("C", culture)}");
        Console.WriteLine($"Jangka Waktu: {tenor} bulan");
        Console.WriteLine($"Bunga: {bungaPersen}%");
        Console.WriteLine($"Angsuran per bulan: {angsuran.ToString("C", culture)}");

        Console.WriteLine("\n=== Selesai ===");
    }
}
