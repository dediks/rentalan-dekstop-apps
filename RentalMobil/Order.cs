using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalMobil
{
    static class Order
    {
        public static double total_price { get; set; }
        public static DateTime order_date { get; set; }
        public static int jumlah { get; set; }
        public static DateTime waktu_kembali { get; set; }
        public static DateTime waktu_ambil { get; set; }
    }
}
