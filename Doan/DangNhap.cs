using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doan
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        SqlConnection aris = new SqlConnection(@"Data Source=Aris;Initial Catalog=QL_ThueXe;Integrated Security=True");

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            string taikhoan, matkhau;
            taikhoan = txt_taikhoan.Text;
            matkhau = txt_matkhau.Text;

            try
            {
                string querry = "SELECT * FROM Login_Hethong WHERE taikhoan = '" + txt_taikhoan.Text + "' AND matkhau = '" + txt_matkhau.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, aris);
                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    taikhoan = txt_taikhoan.Text;
                    matkhau = txt_matkhau.Text;

                    Menu form2 = new Menu();
                    form2.Show();
                    this.Hide();
                }

                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_taikhoan.Clear();
                    txt_matkhau.Clear();

                    txt_taikhoan.Focus();

                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                aris.Close();
            }
        }

        private void btn_dangki_Click(object sender, EventArgs e)
        {
            DangKy form4 = new DangKy();
            form4.Show();
        }

        private void btn_quenmatkhau_Click(object sender, EventArgs e)
        {
            QuenMatKhau form3 = new QuenMatKhau();
            form3.Show();
        }

    }
}
