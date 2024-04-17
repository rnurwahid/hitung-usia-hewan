//18. Mengitung usia hewan dalam usia manusia
using System;

public class HitungUsiaHewan
{
    public static void Main(string[] args)
    {
        Console.WriteLine("===KONVERSI USIA HEWAN KEDALAM USIA MANUSIA===");
        Console.WriteLine("Jenis Hewan:");
        Console.WriteLine("1. Anjing");
        Console.WriteLine("2. Kucing");
        Console.WriteLine("3. Kelinci");
        Console.WriteLine("4. Burung");
        Console.WriteLine("5. Hamster");

        Console.Write("Masukkan jenis hewan (1/2/3/4/5): ");
        int jenisHewan = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(">>Masukkan usia hewan dalam tahun!");
        Console.WriteLine(">>Jika belum mencapai 1 tahun, tuliskan bulan dibelakang koma. ex: 0.11 (untuk usia 11 bulan)");
        Console.WriteLine(">>khusus untuk usia 10 bulan dituliskan menjadi 0.101");
        Console.WriteLine(">>khusus untuk Hamster tuliskan usia dalam bulan");
        Console.Write("Masukkan usia hewan : ");
        double usiaHewan = Convert.ToDouble(Console.ReadLine());

        double usiaManusia = 0;
        string nama;

        switch (jenisHewan)
        {
            case 1: // Anjing
                nama = "Anjing";
                usiaManusia = HitungUsiaKompleks(usiaHewan, 15, 9, 5);
                break;

            case 2: // Kucing
                nama = "Kucing";
                usiaManusia = HitungUsiaKompleks(usiaHewan, 15, 9, 4);
                break;

            case 3: // Kelinci
                nama = "Kelinci";
                if (usiaHewan < 1)
                {
                    usiaManusia = usiaHewan * 3; // pada 4 bulan pertama kelinci, tiap bulan setara 3 tahun usia manusia
                }
                else
                {
                    usiaManusia = ((usiaHewan - 1) * 6) + 20; // setelah 1 tahun, usia kelinci setara 6 tahun usia manusia tiap bertambah 1 tahun usia Kelinci
                }
                break;

            case 4: // Burung
                nama = "Burung";
                usiaManusia = usiaHewan * 5.3; // satu tahun usia burung secara umum setara dengan 5,3 tahun usia manusia
                break;

            case 5: // Hamster
                nama = "Hamster";
                usiaManusia = usiaHewan * 2.9; // secara kasar bertambah usia 1 bulan hamster setara dengan 2,9 tahun usia manusia
                break;

            default:
                Console.WriteLine("Jenis hewan tidak valid! Silahkan pilih 1/2/3/4/5");
                return;
        }

        if (jenisHewan == 5)
        {
            Console.WriteLine($"Konversi {usiaHewan} bulan usia {nama} setara dengan {usiaManusia} tahun usia manusia.");
        }
        else
        {
            Console.WriteLine($"Konversi {usiaHewan} tahun usia {nama} setara dengan {usiaManusia} tahun usia manusia.");
        }
    }

    private static double HitungUsiaKompleks(double usiaKompleks, double tahunPertama, double tahunKedua, double tahunSeterusnya)
    {
        double usiaManusia = 0;
        if (usiaKompleks <= 1)
        {
            usiaManusia = tahunPertama;
        }
        else if (usiaKompleks > 1 && usiaKompleks <= 2)
        {
            usiaManusia = tahunPertama + tahunKedua;
        }
        else
        {
            usiaManusia = ((usiaKompleks - 2) * tahunSeterusnya) + (tahunPertama + tahunKedua);
        }
        return usiaManusia;
    }
}