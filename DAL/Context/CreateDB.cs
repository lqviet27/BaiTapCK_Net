using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Context
{
    public class CreateDB : CreateDatabaseIfNotExists<DBQLSV>
    {
        protected override void Seed(DBQLSV context)
        {
            var lopHP1 = new LHP { MaHP = "CT001", NameHP = "Lich Su Dang Cong San Viet Nam" };
            var lopHP2 = new LHP { MaHP = "T001", NameHP = "Lap Trinh .Net" };
            var lopHP3 = new LHP { MaHP = "T002", NameHP = "Lap Trinh Java" };

            var sv1 = new SV { MSSV = "102220347", NameSV = "Le Quoc Viet", LSH = "22T_Nhat2", Gender = true, DiemBT = 10, DiemGK = 10, DiemCK = 10, NgayThi = new DateTime(2024, 06, 11), MaHP = "CT001" };
            var sv2 = new SV { MSSV = "102220348", NameSV = "Le Quoc Viet", LSH = "22T_Nhat2", Gender = true, DiemBT = 10, DiemGK = 10, DiemCK = 10, NgayThi = new DateTime(2024, 06, 15), MaHP = "T001" };

            context.LHPs.AddRange(new LHP[]
            {
                lopHP1,
                lopHP2,
                lopHP3
            });

            context.SVs.AddRange(new SV[]
            {
                 sv1,
                 sv2
            });
        }
    }
}
