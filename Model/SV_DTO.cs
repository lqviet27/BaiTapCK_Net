using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class SV_DTO // data transfer object
    {
        public string MSSV { get; set; }
        public string Name { get; set; }
        public string LSH { get; set; }
        public string LHP { get; set; }
        public double DiemBT { get; set; }
        public double DiemGK { get; set; }
        public double DiemCK { get; set; }
        public double TongKet { get; set; }
        public DateTime NgayThi { get; set; }
    }
}
