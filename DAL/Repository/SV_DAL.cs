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
                return db.SVs.Where(p =>( p.MSSV == NameOrMSSV || p.NameSV == NameOrMSSV)).ToList();
            }else if (NameOrMSSV.Equals(""))
            {
                return db.SVs.Where(p => p.LopHocPhan.MaHP == MaHP).ToList();
            }
            else
            {
                return db.SVs.Where(p => p.LopHocPhan.MaHP == MaHP && (p.MSSV == NameOrMSSV || p.NameSV == NameOrMSSV)).ToList();
            }
        }
    }
}
