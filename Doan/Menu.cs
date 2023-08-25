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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle= FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_body.Controls.Add(childForm);
            panel_body.Tag= childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TimKiem());
            lbl_tieude.Text = btn_timkiem.Text;
        }
        private void btn_dongxe_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DongXe());
            lbl_tieude.Text = btn_dongxe.Text;
        }
        private void btn_datxe_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DatXe());
            lbl_tieude.Text = btn_datxe.Text;
        }
        private void btn_hopdong_Click(object sender, EventArgs e)
        {
            OpenChildForm(new HopDong());
            lbl_tieude.Text = btn_hopdong.Text;
        }
        private void btn_danhgia_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ThongTinKhachHang());
            lbl_tieude.Text = btn_danhgia.Text;
        }


    }
}
