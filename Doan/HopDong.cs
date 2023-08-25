using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doan
{
    public partial class HopDong : Form
    {
        public HopDong()
        {
            InitializeComponent();
        }

        private void HopDong_Load(object sender, EventArgs e)
        {

        }

        private void txt_tenxe_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_XuatDuLieu_Click(object sender, EventArgs e)
        {
            string tenxe = txt_tenxe.Text;
            string hang = txt_hang.Text;
            string gia = txt_gia.Text;
            string thoigian = txt_thoigian.Text;
            string thanhtoan = txt_thanhtoan.Text;
            string dieukhoan = txt_dieukhoan.Text;

            if (!string.IsNullOrEmpty(tenxe))
            {
                string[] rowData = { tenxe, hang, gia, thoigian, thanhtoan, dieukhoan };
                ListViewItem item = new ListViewItem(rowData);
                listView.Items.Add(item);

                // Xóa nội dung trong các TextBox sau khi thêm vào ListView
                txt_tenxe.Text = string.Empty;
                txt_hang.Text = string.Empty;
                txt_gia.Text = string.Empty;
                txt_thoigian.Text = string.Empty;
                txt_thanhtoan.Text = string.Empty;
                txt_dieukhoan.Text = string.Empty;
            }
        }
    }
}
