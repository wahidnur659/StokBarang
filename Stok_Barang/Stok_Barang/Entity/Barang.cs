using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stok_Barang.Entity
{
    public class Barang
    {
        public int idBarang {  get; set; }
        public string namaBarang { get; set; }
        public int harga { get; set; }
        public int jumlah { get; set; }
        public DateTime tanggalMasuk { get; set; }
    }
}
