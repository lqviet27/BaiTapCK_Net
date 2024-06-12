using BLL;
using DAL.Context;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            loadCBB();
        }

        private void loadCBB()
        {
            cbb_hp.DataSource = LHP_BLL.Instance.GetLHP();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string MaHP = ((CBBItem)cbb_hp.SelectedItem).Value;
            string NameOrMSSV = txt_search.Text;
            dataGridView1.DataSource = SV_BLL.Instance.SearchSV(MaHP, NameOrMSSV);
        }


    }
}
