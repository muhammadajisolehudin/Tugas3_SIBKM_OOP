using Tugas3_SIBKM_OOP.abstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tugas3_SIBKM_OOP.models
{
    //inhiritence, interface
    class Karyawan : perhitungan_gaji, identitas
    { 
        public String Nama, Nip, Jabatan;
        public char Jenis_Kelamin;
        public int jam_kerja, Jam_Lembur;
       

     
       //methode void
        public void isi_data(string nama, string nip, string jabatan, char jenis_kelamin, int jam_kerja, int jam_lembur)
        {
            this.Jabatan = jabatan;
            this.jam_kerja = jam_kerja;
            this.Jam_Lembur = jam_lembur;
            Console.WriteLine("Nama :" + nama + Environment.NewLine + "NIP :" + nip + Environment.NewLine + "Jabatan :" + jabatan + Environment.NewLine + "Jenis Kelamin :" + jenis_kelamin);
        }

        //polymorphsm-overloading
        public void isi_data(string nama, string nip, string jabatan, char jenis_kelamin, int jam_kerja)
        {
            this.Jabatan = jabatan;
            this.jam_kerja = jam_kerja;
            Console.WriteLine("Nama :" + nama + Environment.NewLine + "NIP :" + nip + Environment.NewLine + "Jabatan :" + jabatan + Environment.NewLine + "Jenis Kelamin :" + jenis_kelamin);
        }

        
        public void perhitungan_gaji()
        {
            Console.WriteLine("gaji pokok : "+hitung_gp(Jabatan, jam_kerja));
            Console.WriteLine("gaji Lembur : " + hitung_gl(Jam_Lembur));
        }
    }


}
