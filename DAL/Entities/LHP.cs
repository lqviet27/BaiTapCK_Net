using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    [Table("LopHocPhan")]
    public class LHP
    {
        public LHP()
        {
            this.SVs = new HashSet<SV>();
        }
        [Key]
        [Required]
        public string MaHP { get; set; }
        public string NameHP { get; set; }
        public virtual ICollection<SV> SVs { get; set; }
    }
}
