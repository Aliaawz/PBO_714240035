using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714240035
{
    internal class Inheritance
    {
    }
    public class MenuMakanan
    {
        // Properti (data) yang diwariskan oleh semua menu
        public string NamaMenu { get; set; }
        public double HargaDasar { get; set; }

        // Konstruktor untuk kelas dasar
        public MenuMakanan(string nama, double harga)
        {
            NamaMenu = nama;
            HargaDasar = harga;
        }

        // Metode (perilaku) yang diwariskan
        public virtual void TampilkanDetail()
        {
            Console.WriteLine($"--- {NamaMenu} ---");
            Console.WriteLine($"Harga: Rp{HargaDasar:N0}"); // :N0 untuk format ribuan
        }

        // Metode yang dapat di-override (diubah implementasinya)
        public virtual double HitungHargaAkhir()
        {
            // Secara default, harga akhir sama dengan harga dasar
            return HargaDasar;
        }
    }

    // 2. Kelas Turunan Pertama: NasiGoreng
    // Menggunakan ":" untuk menunjukkan pewarisan dari MenuMakanan
    public class NasiGoreng : MenuMakanan
    {
        public bool PakaiTelur { get; set; }

        // Konstruktor memanggil konstruktor kelas dasar menggunakan 'base()'
        public NasiGoreng(string nama, double harga, bool pakaiTelur)
            : base(nama, harga)
        {
            PakaiTelur = pakaiTelur;
        }

        // Override: Mengubah implementasi TampilkanDetail() dari kelas dasar
        public override void TampilkanDetail()
        {
            // Memanggil TampilkanDetail() dari kelas dasar untuk menampilkan nama & harga
            base.TampilkanDetail();
            string statusTelur = PakaiTelur ? "Ya" : "Tidak";
            Console.WriteLine($"Tambahan Telur: {statusTelur}");
        }

        // Override: Mengubah implementasi HitungHargaAkhir()
        public override double HitungHargaAkhir()
        {
            double hargaAkhir = base.HitungHargaAkhir(); // Ambil harga dasar

            // Tambahkan biaya jika pakai telur
            if (PakaiTelur)
            {
                hargaAkhir += 3000;
            }
            return hargaAkhir;
        }
    }

    // 3. Kelas Turunan Kedua: SopBuntut
    public class SopBuntut : MenuMakanan
    {
        public string JenisDaging { get; set; } // Contoh: "Sapi Premium"

        public SopBuntut(string nama, double harga, string jenis)
            : base(nama, harga)
        {
            JenisDaging = jenis;
        }

        // Override TampilkanDetail()
        public override void TampilkanDetail()
        {
            base.TampilkanDetail();
            Console.WriteLine($"Jenis Daging: {JenisDaging}");
        }
    }
}
