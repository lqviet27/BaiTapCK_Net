using DAL.Context;
using DAL.Entities;
using Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class LHP_DAL
    {
        private DBQLSV db;
        private static LHP_DAL _instance;
        public static LHP_DAL Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new LHP_DAL();
                }
                return _instance;
            }
            private set { }
        }
        private LHP_DAL()
        {
            db = new DBQLSV();
        }
        public List<LHP> GetAllLHP()
        {
            return db.LHPs.ToList();
        } 

    }
}
