using BLL;
using DAL.Context;
using Model;
using System;
using System.Collections;
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
            List<CBBItem> list = LHP_BLL.Instance.GetLHP();
            list.Add(new CBBItem { Value = "0", Text = "All" });
            cbb_hp.Items.AddRange(list.ToArray());
            cbb_sort.Items.AddRange(new String[] { 
                "MSSV",
                "Học phần",
                "Tên sinh viên",
                "Lớp sinh hoạt",
                "Điểm bài tập",
                "Điểm giữa kỳ",
                "Điểm cuối kỳ",
                "Điểm tổng kết",
                "Ngày thi"
            });
        }


        private void btn_search_Click(object sender, EventArgs e)
        {
            string MaHP = ((CBBItem)cbb_hp.SelectedItem).Value;
            string NameOrMSSV = txt_search.Text;
            dataGridView1.DataSource = SV_BLL.Instance.SearchSV(MaHP, NameOrMSSV);
        }
        public void refresh()
        {
            cbb_hp.SelectedIndex = LHP_BLL.Instance.GetLHP().Count ;
            txt_search.Text = "";
            dataGridView1.DataSource = SV_BLL.Instance.SearchSV("0", "");
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            DetailForm detailForm = new DetailForm();
            detailForm.d += refresh;
            detailForm.ShowDialog();
            
            //refresh();
        }

        private void btn_up_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                string mssv = dataGridView1.SelectedRows[0].Cells["mssv"].Value.ToString();
                string lhp = dataGridView1.SelectedRows[0].Cells["LHP"].Value.ToString();
                //MessageBox.Show(mssv + " " + lhp);
                DetailForm detailForm = new DetailForm(mssv,lhp);
                detailForm.d += refresh;
                detailForm.ShowDialog();

            }
            else
            {
                MessageBox.Show("Chọn 1 dòng để sửa");
            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach(DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    SV_BLL.Instance.DeleteSV(row.Cells["mssv"].Value.ToString(), row.Cells["LHP"].Value.ToString());
                }
            }
            else
            {
                MessageBox.Show("Chọn 1 dòng để xóa");
            }
            refresh();
        }

        private void bnt_sort_Click(object sender, EventArgs e)
        {
            string condition = cbb_sort.SelectedItem.ToString();
            string MaHP = ((CBBItem)cbb_hp.SelectedItem).Value;
            string NameOrMSSV = txt_search.Text;
            dataGridView1.DataSource = SV_BLL.Instance.Sort(MaHP, NameOrMSSV, condition);
        }
    }
}
