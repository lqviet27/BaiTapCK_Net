using DAL.Repository;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class LHP_BLL
    {
        private static LHP_BLL _instance;
        public static LHP_BLL Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new LHP_BLL();
                }
                return _instance;
            }
            private set { }
        }
        public List<CBBItem> GetLHP()
        {
            List<CBBItem> list = new List<CBBItem>();
            list = LHP_DAL.Instance.GetAllLHP().Select(p => new CBBItem
            {
                Value = p.MaHP,
                Text = p.NameHP
            }).ToList();
            list.Add(new CBBItem { Value = "0", Text = "All" });
            return list;
        }
    }
}
