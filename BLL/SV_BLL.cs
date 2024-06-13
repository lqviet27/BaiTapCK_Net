using DAL;
using DAL.Repository;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                    TongKet = p.DiemBT * 0.2 + p.DiemGK * 0.2 + p.DiemCK * 0.3,
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
                    TongKet = p.DiemBT * 0.2 + p.DiemGK * 0.2 + p.DiemCK * 0.3,
                    NgayThi = p.NgayThi
                }).ToList();
            }
            return list;
        }
        public SV GetSVByMSSV(string mssv, string lhp)
        {
            return SV_DAL.Instance.GetSVByMSSVAndLHP(mssv, lhp);
        }
        public List<string> GetLSH()
        {
            return SV_DAL.Instance.GetLSH();
        }
        public void AddSV(SV sv)
        {
            SV_DAL.Instance.AddSV(sv);
        }
        public void UpdateSV(SV sv, string mssv, string LHP)
        {
            SV_DAL.Instance.UpdateSV(sv, mssv, LHP);
        }
        public void DeleteSV(string mssv, string LHP)
        {
            SV_DAL.Instance.DeleteSV(mssv, LHP);
        }
        public List<SV_DTO> Sort(string MaHP, string NameOrMSSV, string condition)
        {
            List<SV_DTO> svDTO = SearchSV(MaHP, NameOrMSSV).ToList();
            switch (condition)
            {
                case "MSSV":
                    svDTO = svDTO.OrderBy(p => p.MSSV).ToList();
                    break;
                case "Học phần":
                    svDTO = svDTO.OrderBy(p => p.LHP).ToList();
                    break;
                case "Tên sinh viên":
                    svDTO = svDTO.OrderBy(p => p.Name).ToList();
                    break;
                case "Lớp sinh hoạt":
                    svDTO = svDTO.OrderBy(p => p.LSH).ToList();
                    break;
                case "Điểm bài tập":
                    svDTO = svDTO.OrderBy(p => p.DiemBT).ToList();
                    break;
                case "Điểm giữa kỳ":
                    svDTO = svDTO.OrderBy(p => p.DiemGK).ToList();
                    break;
                case "Điểm cuối kỳ":
                    svDTO = svDTO.OrderBy(p => p.DiemCK).ToList();
                    break;
                case "Điểm tổng kết":
                    svDTO = svDTO.OrderBy(p => p.TongKet).ToList();
                    break;
                case "Ngày thi":
                    svDTO = svDTO.OrderBy(p => p.NgayThi).ToList();
                    break;
            }
            return svDTO;
        }

    }
}
    