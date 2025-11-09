using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714240035
{
    // 1.Abstraction
    internal class Program
    {
        static void Main(string[] args)
        {
            // Abstraction :
            Console.WriteLine("--- Data Diri Pegawai (Abstraksi OOP) ---");

            Pengembang dev = new Pengembang("Budi Santoso", "DEV001", "C#");
            Manajer mgr = new Manajer("Ani Wijaya", "MGR005", 10);

            Console.WriteLine("\n[Data Pengembang]");
            dev.TampilkanDataDasar();
            Console.WriteLine($"Tugas: {dev.DapatkanTugas()}");

            Console.WriteLine("\n[Data Manajer]");
            mgr.TampilkanDataDasar();
            Console.WriteLine($"Tugas: {mgr.DapatkanTugas()}");


            //inheritance :

            Console.WriteLine("\n\n=== INHERITANCE: Data Kendaraan ===");

            Mobil mobil1 = new Mobil("Toyota Avanza", 2021, 5);
            Motor motor1 = new Motor("Honda Vario", 2019, true);

            Console.WriteLine("\n[Data Mobil]");
            mobil1.TampilkanInfo();
            Console.WriteLine($"Pajak Tahunan: Rp{mobil1.HitungPajak():N0}");

            Console.WriteLine("\n[Data Motor]");
            motor1.TampilkanInfo();
            Console.WriteLine($"Pajak Tahunan: Rp{motor1.HitungPajak():N0}");

            Console.WriteLine("\n===============================");
            Console.ReadLine();

            //Polymorphism :
            Console.WriteLine("=== Contoh Polymorphism di C# ===\n");

            // Membuat objek dari kelas dasar dan turunan
            Mahasiswa mhs1 = new Mahasiswa();
            Mahasiswa mhs2 = new MahasiswaOnline();
            Mahasiswa mhs3 = new MahasiswaOffline();

            // Menyimpan ke dalam array untuk menunjukkan polymorphism
            Mahasiswa[] daftarMahasiswa = { mhs1, mhs2, mhs3 };

            // Menjalankan metode Belajar() dari masing-masing objek
            foreach (Mahasiswa mhs in daftarMahasiswa)
            {
                mhs.Belajar();
            }

            Console.WriteLine("\nTekan tombol apa saja untuk keluar...");
            Console.ReadKey();

            // encapsulation :
            Buku buku1 = new Buku("Belajar C#", "Siti Rahma", 250, 75000);
            Buku buku2 = new Buku("", "", -10, -50000);

            // Menampilkan informasi buku
            buku1.TampilkanInfo();
            Console.WriteLine();
            buku2.TampilkanInfo();

            Console.ReadLine();


            // Constructor :
            Hewan hewan1 = new Hewan("Kiki", "Kucing", 2);
            Hewan hewan2 = new Hewan("Bobby", "Anjing", 3);

            Console.WriteLine("=== DATA HEWAN ===");
            hewan1.TampilkanInfo();

            Console.WriteLine("\n=== DATA HEWAN ===");
            hewan2.TampilkanInfo();

            Console.ReadLine();
        }
    }
}