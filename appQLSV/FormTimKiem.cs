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

namespace appQLSV
{
    public partial class FormTimKiem : Form
    {
        public FormTimKiem()
        {
            InitializeComponent();
        }
        private void FormTimKiem_Load(object sender, EventArgs e)
        {
        }
        public RadioButton selectedRadio()
        {
            if (radioNam.Checked == true)
            {
                return radioNam;
            }
            else if (radioNu.Checked == true)
            {
                return radioNu;
            }
            else
            {
                return null;
            }
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = Connection.getSqlConnection())
            {
                conn.Open();
                string query = "Select * From SinhVien Where 1=1";
                if (!string.IsNullOrEmpty(txtMaSV.Text))
                {
                    query += $" AND MaSV LIKE N'{txtMaSV.Text}'";
                }
                if (!string.IsNullOrEmpty(cbbNoiSinh.Text))
                {
                    query += $" AND NoiSinh LIKE N'{cbbNoiSinh.Text}'";
                }
                if (selectedRadio() != null)
                {
                    query += $" AND GioiTinh = N'{selectedRadio().Text}'";
                }
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dgvSinhVien.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy kết quả nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvSinhVien.DataSource = null;
                    radioNam.Checked = false;
                    radioNu.Checked = false;
                }
                conn.Close();
            }
        }
    }
}
