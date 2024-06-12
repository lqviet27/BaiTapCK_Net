using DAL.Repository;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class SV_BLL
    {
        private static SV_BLL _instance;
        public static SV_BLL Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SV_BLL();
                }
                return _instance;
            }
            private set { }
        }

        public List<SV_DTO> SearchSV(string MaHP, string NameOrMSSV)
        {
            List<SV_DTO> list = new List<SV_DTO>();
            if(MaHP.Equals("0") && NameOrMSSV.Equals(""))
            {
                list = SV_DAL.Instance.GetAllSV().Select(p => new SV_DTO
                {
                    MSSV = p.MSSV,
                    Name = p.NameSV,
                    LSH = p.LSH,
                    LHP = p.LopHocPhan.NameHP,
                    DiemBT = p.DiemBT,
                    DiemGK = p.DiemGK,
                    DiemCK = p.DiemCK,
                    TongKet = p.DiemBT*0.2 + p.DiemGK*0.3 + p.DiemCK*0.5,
                    NgayThi = p.NgayThi
                }).ToList();
            }
            else
            {
                list = SV_DAL.Instance.GetSVByCondition(MaHP,NameOrMSSV).Select(p => new SV_DTO
                {
                    MSSV = p.MSSV,
                    Name = p.NameSV,
                    LSH = p.LSH,
                    LHP = p.LopHocPhan.NameHP,
                    DiemBT = p.DiemBT,
                    DiemGK = p.DiemGK,
                    DiemCK = p.DiemCK,
                    TongKet = p.DiemBT * 0.2 + p.DiemGK * 0.3 + p.DiemCK * 0.5,
                    NgayThi = p.NgayThi
                }).ToList();
            }
            return list;
        }
    }
}
    