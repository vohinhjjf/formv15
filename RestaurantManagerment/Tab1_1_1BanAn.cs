using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
using DAO;
using System.Threading;

namespace RestaurantManagerment
{
    public partial class Tab1_1_1BanAn : UserControl
    {
        public Tab1_1_1BanAn()
        {
            InitializeComponent();
            this.Controls.Add(this.flpSoDoBan);
        }

        List<BanAn_DTO> tableList;
        private void LoadBanAn()
        {
            tableList = BanAn_DAO.LayBanAn();
            for (int i = 0; i < tableList.Count; i++)
            {
                Button btn = new Button() { Width = BanAn_DAO.tableWidth, Height = BanAn_DAO.tableHeight };
                btn.Image = Properties.Resources.icons8_tableware_48px;
                btn.ImageAlign = ContentAlignment.BottomCenter;

                btn.Text = Environment.NewLine + tableList[i].TenBan;
                btn.Font = new Font("Arial", 11, FontStyle.Bold);
                btn.TextAlign = ContentAlignment.TopCenter;
                btn.Click += btn_Click;
                btn.Tag = tableList[i];
                switch (tableList[i].TrangThai)
                {
                    case "Trống":
                        btn.BackColor = Color.White;
                        break;
                    case "Có Người":
                        btn.BackColor = Color.Aqua;
                        break;
                }
                flpSoDoBan.Controls.Add(btn);
            }
        }
        
        private void btn_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as BanAn_DTO).IDBan ;
            Add(tableID);
            ShowMonAn(tableID);
            
        }
        public void ShowMonAn(int i)
        {
            monAn11.Visible = true;

        }
        private void Tab1_1_1BanAn_Load(object sender, EventArgs e)
        {
            
        }

        private void btnLoad_Click_1(object sender, EventArgs e)
        {
            flpSoDoBan.Controls.Clear();
            LoadBanAn();
        }

        private void btnMoBan_Click(object sender, EventArgs e)
        {
            LoadBanAn();
            btnMoBan.Enabled = false;
        }
        public void Add(int i)
        {
            mTBNgay.Clear();
            List<BanAn_DTO> tableList = BanAn_DAO.LayBanAn();
            txtBan.Text = tableList[i].TenBan;
            if (tableList[i].TrangThai == "Có Người")
            {
                mTBNgay.Text = tableList[i].Ngay;
            }
            else
            {
                mTBNgay.Text = "00/00/0000";
            }
            txtTT.Text = tableList[i].TrangThai;
        }
        
    }
}
