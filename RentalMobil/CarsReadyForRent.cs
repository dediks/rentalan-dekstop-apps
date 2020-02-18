using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalMobil
{
    public class CarsReadyForRent
    {
        public string nama { get; set; }
        public string status { get; set; }
        public string alamat { get; set; }
        public string vendor { get; set; }
        public string bagasi { get; set; }

        public string transmisi { get; set; }
        public string deskripsi { get; set; }
        public byte[] image { get; set; }
        public int id_mobil { get; set; }
        public decimal harga_sewa { get; set; }
    }
}
