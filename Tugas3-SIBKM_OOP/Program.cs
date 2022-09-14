using System;
using Tugas3_SIBKM_OOP.models;

namespace Tugas3_SIBKM_OOP
{
    class Program_penggajianKaryawan
    {
        

        static void Main(string[] args)
        {
            Console.WriteLine("CONTOH PROGRAM PENGGAJIAN" + Environment.NewLine);

            Karyawan c = new Karyawan();
            Karyawan c2 = new Karyawan();

            c.isi_data("usman", "12345", "manager", 'L', 172);
            c.perhitungan_gaji();

            Console.WriteLine();
            c2.isi_data("Rudi", "11123", "staf", 'L', 172, 6);
            c2.perhitungan_gaji();

        }
    }
}
