using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714240035
{
    internal class Abstraction
    {
    }
    // ======== ABSTRACTION ========
    public abstract class Pegawai
    {
        protected string Nama;
        protected string ID;

        public Pegawai(string nama, string id)
        {
            Nama = nama;
            ID = id;
        }

        public void TampilkanDataDasar()
        {
            Console.WriteLine($"Nama: {Nama}");
            Console.WriteLine($"ID: {ID}");
        }

        public abstract string DapatkanTugas();
    }

    public class Pengembang : Pegawai
    {
        private string BahasaPemrograman;

        public Pengembang(string nama, string id, string bahasa) : base(nama, id)
        {
            BahasaPemrograman = bahasa;
        }

        public override string DapatkanTugas()
        {
            return $"Mengembangkan aplikasi menggunakan {BahasaPemrograman}.";
        }
    }

    public class Manajer : Pegawai
    {
        private int JumlahTim;

        public Manajer(string nama, string id, int jumlahTim) : base(nama, id)
        {
            JumlahTim = jumlahTim;
        }

        public override string DapatkanTugas()
        {
            return $"Mengelola {JumlahTim} orang dan membuat laporan proyek.";
        }
    }
}