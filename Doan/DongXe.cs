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
    public partial class DongXe : Form
    {
        public DongXe()
        {
            InitializeComponent();
        }
        SqlConnection aris = new SqlConnection(@"Data Source=Aris;Initial Catalog=QL_ThueXe;Integrated Security=True");

        private void btn_capnhap_Click(object sender, EventArgs e)
        {
            string tenxe, hang, namsx, loaixe,dongco,hopso;
            tenxe = txt_tenxe.Text;
            hang = txt_hang.Text;
            namsx = txt_namsx.Text;
            loaixe = txt_loaixe.Text;
            dongco = txt_dongco.Text;
            hopso = txt_hopso.Text;

            try
            {
                aris.Open();
                string insertQuery = "INSERT INTO DongXe_Hethong (tenxe, hang, namsx, loaixe, dongco, hopso) VALUES (@tenxe, @hang, @namsx, @loaixe, @dongco, @hopso)";

                using (SqlCommand command = new SqlCommand(insertQuery, aris))
                {
                    command.Parameters.AddWithValue("@tenxe", tenxe);
                    command.Parameters.AddWithValue("@hang", hang);
                    command.Parameters.AddWithValue("@loaixe", loaixe);
                    command.Parameters.AddWithValue("@namsx", namsx);
                    command.Parameters.AddWithValue("@dongco", dongco);
                    command.Parameters.AddWithValue("@hopso", hopso);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Cập nhập thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Cập nhập thất bại.");
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
