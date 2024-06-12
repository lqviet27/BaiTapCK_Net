using DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    [Table("SinhVien")]
    public class SV
    {
        [Key]
        [Column(Order = 0)]
        [Required]
        public string MSSV { get; set; }
        public string NameSV { get; set; }
        public string LSH {  get; set; }
        public bool Gender {  get; set; } // true: nam, false:nu
        public double DiemBT { get; set; }
        public double DiemGK { get; set; }

        public double DiemCK { get; set; }
        public DateTime NgayThi { get; set; }
        [Key]
        [Column(Order = 1)]
        public string MaHP { get; set; }

        // navigation property
        [ForeignKey("MaHP")]
        public virtual LHP LopHocPhan { get; set; }
    }
}
