using DAL.Context;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class SV_DAL
    {
        private DBQLSV db;
        private static SV_DAL _instance;
        public static SV_DAL Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SV_DAL();
                }
                return _instance;
            }
            private set { }
        }
        private SV_DAL()
        {
            db = new DBQLSV();
        }
        public List<SV> GetAllSV()
        {
            return db.SVs.ToList();
        }   
        public List<SV> GetSVByCondition(string MaHP, string NameOrMSSV)
        {
            if (MaHP.Equals("0"))
            {
                return db.SVs.Where(p =>( p.MSSV.Contains(NameOrMSSV) || p.NameSV.Contains(NameOrMSSV))).ToList();
            }else if (NameOrMSSV.Equals(""))
            {
                return db.SVs.Where(p => p.LopHocPhan.MaHP == MaHP).ToList();
            }
            else
            {
                return db.SVs.Where(p => p.LopHocPhan.MaHP == MaHP && (p.MSSV.Contains(NameOrMSSV) || p.NameSV.Contains(NameOrMSSV))).ToList();
            }
        }
        public SV GetSVByMSSVAndLHP (string MSSV, string LHP)
        {
            return db.SVs.Where(p => p.MSSV == MSSV && p.LopHocPhan.NameHP == LHP).FirstOrDefault();
        }
        public List<string> GetLSH()
        {
            List<string> list = new List<string>();
            list = db.SVs.Select(p => p.LSH).Distinct().ToList();
            return list;
        }
        public void AddSV(SV sv)
        {
            db.SVs.Add(sv);
            db.SaveChanges();
        }
        public void UpdateSV(SV sv, string mssv, string LHP)
        {
            SV s = db.SVs.Where(p => p.MSSV == mssv && p.LopHocPhan.NameHP == LHP).FirstOrDefault();
            s.NameSV = sv.NameSV;
            s.LSH = sv.LSH;
            s.Gender = sv.Gender;
            s.DiemBT = sv.DiemBT;
            s.DiemGK = sv.DiemGK;
            s.DiemCK = sv.DiemCK;
            s.NgayThi = sv.NgayThi;
            s.MaHP = sv.MaHP;
            db.SaveChanges();
        }
        public void DeleteSV(string mssv, string LHP)
        {
            SV s = db.SVs.Where(p => p.MSSV == mssv && p.LopHocPhan.NameHP == LHP).FirstOrDefault();
            db.SVs.Remove(s);
            db.SaveChanges();
        }
    }
}
