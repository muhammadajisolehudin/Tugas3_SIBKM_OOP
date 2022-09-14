using System;
using System.Collections.Generic;
using System.Text;

namespace Tugas3_SIBKM_OOP.abstraction
{
    public interface identitas
    {
        public void isi_data(string nama, string nip, string jabatan, char jenis_kelamin, int jam_kerja, int jam_lembur);
    }
}
