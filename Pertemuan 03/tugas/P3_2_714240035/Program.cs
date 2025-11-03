using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_2_714240035
{
    internal class Program
    {
        static void Main()
        {
            char ulang = 'Y';
            while (ulang == 'Y')
            {
                Console.Clear();
                Console.WriteLine("=== MENU PERSEGI PANJANG ===");
                Console.WriteLine("1. Hitung Luas Persegi Panjang");
                Console.WriteLine("2. Hitung Keliling Persegi Panjang");
                Console.WriteLine("3. Keluar");
                Console.Write("Pilih (1-3): ");
                int pilih = int.Parse(Console.ReadLine());

                if (pilih == 1)
                {
                    Console.Write("Masukkan Panjang: ");
                    double p = double.Parse(Console.ReadLine());
                    Console.Write("Masukkan Lebar: ");
                    double l = double.Parse(Console.ReadLine());
                    Console.WriteLine("Luas Persegi Panjang = " + (p * l));
                }
                else if (pilih == 2)
                {
                    Console.Write("Masukkan Panjang: ");
                    double p = double.Parse(Console.ReadLine());
                    Console.Write("Masukkan Lebar: ");
                    double l = double.Parse(Console.ReadLine());
                    Console.WriteLine("Keliling Persegi panjang = " + (2 * (p + l)));
                }
                else if (pilih == 3)
                {
                    Console.WriteLine("Program selesai.");
                    Console.WriteLine("Terima kasih!");
                    break;
                }
                else
                {
                    Console.WriteLine("Menu tidak valid!");
                }

                Console.Write("\nIngin mengulang kembali (Y/T)? ");
                ulang = Char.ToUpper(Console.ReadKey().KeyChar);
                Console.WriteLine();

                if (ulang == 'T')
                {
                    Console.WriteLine("Terima kasih!");
                    Console.WriteLine("Press any key to continue . . .");
                    Console.ReadKey();
                    break;
                }
            }
        }
    }
}
