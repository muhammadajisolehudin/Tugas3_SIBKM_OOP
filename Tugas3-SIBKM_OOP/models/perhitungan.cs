using System;
using System.Collections.Generic;
using System.Text;

namespace Tugas3_SIBKM_OOP.abstraction

{
    public class perhitungan_gaji
    {
        //encapsulation
        private int gaji_pokok, gaji_lembur;
      
        //methode non void/return
        public int hitung_gp(String j, int jk)
        {
            //decision
            if(j == "manager")
            {
                gaji_pokok = 35000;
                gaji_pokok = jk * gaji_pokok;
            } else if(j == "staf")
            {
                gaji_pokok = 25000;
                gaji_pokok = jk * gaji_pokok;
            }
            else
            {
                gaji_pokok = 20000;
                gaji_pokok = jk* gaji_pokok;
            }
            return gaji_pokok;
        }

        public int hitung_gl(int jl)
        {
            gaji_lembur = jl * 20000;
            return gaji_lembur;
        }
     
        
       
    }
}
