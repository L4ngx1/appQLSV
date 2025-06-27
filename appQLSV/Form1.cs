using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appQLSV
{
    public partial class FormQLSV : Form
    {
        public FormQLSV()
        {
            InitializeComponent();
        }
        private void FormQLSV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLSinhVienDataSet.SinhVien' table. You can move, or remove it, as needed.
            this.sinhVienTableAdapter.Fill(this.qLSinhVienDataSet.SinhVien);
            dateNgaySinh.Value = new DateTime(2000,1,1);
            txtHoTen.Clear();
            txtMaSV.Clear();
            cbbNoiSinh.SelectedIndex = 0;
            radioNam.Checked = true;
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
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtHoTen.Text) || string.IsNullOrEmpty(txtMaSV.Text) || string.IsNullOrEmpty(cbbNoiSinh.Text)) {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }
            using (SqlConnection conn = Connection.getSqlConnection())
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM SinhVien WHERE MaSV = @MaSV";
                SqlCommand sqlCommand = new SqlCommand(query, conn);
                sqlCommand.Parameters.AddWithValue("@MaSV", txtMaSV.Text);
                int row = (int)sqlCommand.ExecuteScalar();
                if (row > 0){
                    MessageBox.Show("Ma Sinh Vien da ton tai!");
                    return;
                }
            }
            using (SqlConnection conn = Connection.getSqlConnection())
            {
                conn.Open();
                string query = "INSERT INTO SinhVien(MaSV, HoTen, NgaySinh, GioiTinh, NoiSinh) VALUES(@MaSV, @HoTen, @NgaySinh, @GioiTinh, @NoiSinh)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaSV",txtMaSV.Text);
                cmd.Parameters.AddWithValue("@HoTen", txtHoTen.Text);
                cmd.Parameters.AddWithValue("@NgaySinh", dateNgaySinh.Value);
                cmd.Parameters.AddWithValue("@GioiTinh", selectedRadio().Text);
                cmd.Parameters.AddWithValue("@NoiSinh", cbbNoiSinh.Text);
                int afffetedRows = cmd.ExecuteNonQuery();
                if (afffetedRows > 0)
                {
                    MessageBox.Show("Them sinh vien thanh cong!");
                }
                else
                {
                    MessageBox.Show("Them sinh vien khong thanh cong!");
                }
            }
            FormQLSV_Load(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DataGridViewRow currentRow = dgvSinhVien.CurrentRow;
            if (string.IsNullOrEmpty(txtHoTen.Text) || string.IsNullOrEmpty(txtMaSV.Text) || string.IsNullOrEmpty(cbbNoiSinh.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }
            if (currentRow.Cells[0].Value.ToString() != txtMaSV.Text)
            {
                using (SqlConnection conn = Connection.getSqlConnection())
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM SinhVien WHERE MaSV = @MaSV";
                    SqlCommand sqlCommand = new SqlCommand(query, conn);
                    sqlCommand.Parameters.AddWithValue("@MaSV", txtMaSV.Text);
                    int count = (int)sqlCommand.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("Ma Sinh Vien da ton tai!");
                        return;
                    }
                }
            }
            if(currentRow == null)
            {
                MessageBox.Show("Can chon 1 dong de sua!");
                return;
            }
            using (SqlConnection conn = Connection.getSqlConnection())
            {
                conn.Open();
                string query = "UPDATE SinhVien SET MaSV = @newMaSV, HoTen = @HoTen, NgaySinh = @NgaySinh, GioiTinh = @GioiTinh, NoiSinh = @NoiSinh WHERE MaSV = @oldMaSV";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@newMaSV", txtMaSV.Text);
                cmd.Parameters.AddWithValue("@oldMaSV", currentRow.Cells[0].Value);
                cmd.Parameters.AddWithValue("@HoTen", txtHoTen.Text);
                cmd.Parameters.AddWithValue("@NgaySinh", dateNgaySinh.Value);
                cmd.Parameters.AddWithValue("@GioiTinh", selectedRadio().Text);
                cmd.Parameters.AddWithValue("@NoiSinh", cbbNoiSinh.Text);
                int afffetedRows = cmd.ExecuteNonQuery();
                if (afffetedRows > 0)
                {
                    MessageBox.Show("Sua sinh vien thanh cong!");
                }
                else
                {
                    MessageBox.Show("Sua sinh vien khong thanh cong!");
                }
            }
            FormQLSV_Load(sender, e);
        }

        private void dgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow currentRow = dgvSinhVien.CurrentRow;
            txtMaSV.Text = currentRow.Cells[0].Value.ToString();
            txtHoTen.Text = currentRow.Cells[1].Value.ToString();
            dateNgaySinh.Value = Convert.ToDateTime(currentRow.Cells[2].Value);
            cbbNoiSinh.Text = currentRow.Cells[4].Value.ToString();
            if (currentRow.Cells[3].Value.ToString() == "Nam")
            {
                radioNam.Checked = true;
            }
            else if (currentRow.Cells[3].Value.ToString() == "Nữ")
            {
                radioNu.Checked = true;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DataGridViewRow currentRow = dgvSinhVien.CurrentRow;
            if (currentRow == null)
            {
                MessageBox.Show("Can chon 1 dong de xoa!");
                return;
            }
            if (DialogResult.No == MessageBox.Show($"Ban co chac muon xoa sinh vien {currentRow.Cells[0].Value.ToString()}", "Xac nhan xoa", MessageBoxButtons.YesNo, MessageBoxIcon.Information))
            {
                return;
            }
            using (SqlConnection conn = Connection.getSqlConnection())
            {
                conn.Open();
                string query = "DELETE FROM SinhVien WHERE MaSV = @MaSV";
                SqlCommand sqlCommand = new SqlCommand(query, conn);
                sqlCommand.Parameters.AddWithValue("@MaSV", txtMaSV.Text);
                int afffetedRows = sqlCommand.ExecuteNonQuery();
                if (afffetedRows > 0)
                {
                    MessageBox.Show("Xoa sinh vien thanh cong!");
                }
                else
                {
                    MessageBox.Show("Xoa sinh vien khong thanh cong!");
                }
            }
            FormQLSV_Load(sender, e);
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            Form form = new FormTimKiem();
            form.ShowDialog();
        }
    }
}
