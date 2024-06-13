using BLL;
using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT_CK
{
    public partial class DetailForm : Form
    {
        public delegate void Mydel();
        public Mydel d { get; set; }
        private string _mssv;
        private string _lhp;
        public DetailForm(string msss = "", string lhp = "")
        {
            InitializeComponent();
            loadLSH();
            loadHP();
            _mssv = msss;
            _lhp = lhp;
            display();
            _lhp = lhp;
        }
        private void loadLSH()
        {
            cbb_lsh.Items.AddRange(SV_BLL.Instance.GetLSH().ToArray());
        }
        private void loadHP()
        {
            cbb_hp.Items.AddRange(LHP_BLL.Instance.GetLHP().ToArray());
        }

        public void display()
        {
            if (_mssv != "" && _lhp != "")
            {
                SV sv = SV_BLL.Instance.GetSVByMSSV(_mssv,_lhp);
                txt_mssv.Text = _mssv;
                txt_mssv.ReadOnly = true;
                //txt_mssv.Enabled = false;
                txt_name.Text = sv.NameSV;
                cbb_lsh.Text = sv.LSH;
                cbb_hp.Text = sv.LopHocPhan.NameHP;
                txt_diemTB.Text = sv.DiemBT.ToString();
                txt_diemGK.Text = sv.DiemGK.ToString();
                txt_diemCK.Text = sv.DiemCK.ToString();
                txt_tongket.Text = (sv.DiemBT * 0.2 + sv.DiemGK * 0.2 + sv.DiemCK * 0.3).ToString();
                txt_tongket.ReadOnly = true;
                //txt_tongket.Enabled = false;
                radioBtn_Male.Checked = sv.Gender;
                dateTimePicker1.Value = sv.NgayThi;
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            SV s = new SV
            {
                MSSV = txt_mssv.Text,
                NameSV = txt_name.Text,
                LSH = cbb_lsh.Text,
                Gender = radioBtn_Male.Checked,
                DiemBT = Convert.ToDouble(txt_diemTB.Text),
                DiemGK = Convert.ToDouble(txt_diemGK.Text),
                DiemCK = Convert.ToDouble(txt_diemCK.Text),
                NgayThi = dateTimePicker1.Value.Date,
                MaHP = ((CBBItem)cbb_hp.SelectedItem).Value
            };
            if (_mssv == "")
            {
                SV_BLL.Instance.AddSV(s);
            }
            else
            {
                SV_BLL.Instance.UpdateSV(s, _mssv, _lhp);   
            }
            d();
            this.Dispose();
        }
    }
}
