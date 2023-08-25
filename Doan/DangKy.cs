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
    public partial class DangKy : Form
    {
        public DangKy()
        {
            InitializeComponent();
        }

        SqlConnection aris = new SqlConnection(@"Data Source=Aris;Initial Catalog=QL_ThueXe;Integrated Security=True");

        private void btn_dangki_Click(object sender, EventArgs e)
        {
            string taikhoan, matkhau, sdt, email;
            taikhoan = txt_taikhoan.Text;
            matkhau = txt_matkhau.Text;
            sdt = txt_sdt.Text;
            email = txt_email.Text;

            try
            {
                aris.Open();
                string insertQuery = "INSERT INTO Login_Hethong (taikhoan, matkhau, sdt, email) VALUES (@taikhoan, @matkhau, @sdt, @email)";

                using (SqlCommand command = new SqlCommand(insertQuery, aris))
                {
                    command.Parameters.AddWithValue("@taikhoan", taikhoan);
                    command.Parameters.AddWithValue("@matkhau", matkhau);
                    command.Parameters.AddWithValue("@sdt", sdt);
                    command.Parameters.AddWithValue("@email", email);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Đăng ký thành công!");
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Đăng ký thất bại.");
                        this.Hide();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                aris.Close();
            }
        }

    }
}
