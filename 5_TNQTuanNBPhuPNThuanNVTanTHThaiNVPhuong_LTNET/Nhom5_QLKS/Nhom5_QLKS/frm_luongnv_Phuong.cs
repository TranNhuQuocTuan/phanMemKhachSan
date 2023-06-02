using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Nhom5_QLKS
{
    public partial class frm_luongnv_Phuong : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["kn"].ConnectionString);
        public frm_luongnv_Phuong()
        {
            InitializeComponent();
        }
        public void load()
        {

            con.Close();
            con.Open();
            String sql3 = "select luong.phieuLuong, luong.maNV,nhanvien.hoTen, luong.soNgayLam, luong.Luong, chucvu.tenCV, chucvu.luongTheoCa1Ngay from luong, nhanvien, chucvu where luong.maNV = nhanvien.maNV and nhanvien.maCV = chucvu.maCV";
            SqlDataAdapter da = new SqlDataAdapter(sql3, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv_luong_phuong.DataSource = dt;
            tb_phieuluong.Text = "";


            SqlDataAdapter da1 = new SqlDataAdapter("select * from nhanvien", con);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            cb_idStaff_phuong.DataSource = dt1;
            cb_idStaff_phuong.DisplayMember = "maNV";
            cb_idStaff_phuong.ValueMember = "hoTen";
            // cb_idStaff_phuong.ValueMember = "maCV";
            tb_nameStaff_phuong.Text = "";
            cb_idCV_phuong.Text = "";

            SqlDataAdapter da3 = new SqlDataAdapter("select * from chucvu", con);
            DataTable dt2 = new DataTable();
            da3.Fill(dt2);
            cb_idCV_phuong.DataSource = dt2;
            cb_idCV_phuong.DisplayMember = "maCV";
            cb_idCV_phuong.ValueMember = "tenCV";
            tb_nameCV_phuong.Text = "";
            cb_idCV_phuong.Text = "";


            tb_luong_phuong.Enabled = false;
            tb_search_phuong.Text = "";

            tb_soNgayLam_phuong.Clear();
            tb_soNgayLam_phuong.Focus();


        }

        private void frm_luongnv_Phuong_Load(object sender, EventArgs e)
        {
            load();
            dgv_luong_phuong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void cb_idStaff_phuong_SelectedIndexChanged(object sender, EventArgs e)
        {

            tb_nameStaff_phuong.Text = cb_idStaff_phuong.SelectedValue.ToString();
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            if (tb_phieuluong.Text == "" || cb_idStaff_phuong.Text == "" || tb_nameStaff_phuong.Text == "" || tb_soNgayLam_phuong.Text == "" || cb_idCV_phuong.Text == "" || tb_nameCV_phuong.Text == "" || tb_luong_phuong.Text == "")
            {
                MessageBox.Show("Yêu cầu nhập đầy đủ thông tin!", "Thiếu thông tin", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                try

                {
                    SqlCommand cmd = new SqlCommand("insert into luong(phieuLuong,maNV,songaylam,Luong) values (@1,@2,@4,@5)", con);
                    cmd.Parameters.AddWithValue("@1", tb_phieuluong.Text);
                    cmd.Parameters.AddWithValue("@2", cb_idStaff_phuong.Text);
                    cmd.Parameters.AddWithValue("@4", tb_soNgayLam_phuong.Text);
                    cmd.Parameters.AddWithValue("@5", tb_luong_phuong.Text);
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Thêm thành công!", "Thêm", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                        load();
                    }
                }
                catch
                {
                    MessageBox.Show("Trùng phiếu lương, yêu cầu nhập lại!");
                }
            }


            tb_phieuluong.Focus();
        }

        private void dgv_luong_phuong_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int dongchon = dgv_luong_phuong.CurrentRow.Index;
                tb_phieuluong.Text = dgv_luong_phuong.Rows[dongchon].Cells["phieuLuong"].Value.ToString();
                tb_luong_phuong.Text = dgv_luong_phuong.Rows[dongchon].Cells["luongnv"].Value.ToString();
                cb_idStaff_phuong.Text = dgv_luong_phuong.Rows[dongchon].Cells["maNV"].Value.ToString();
                tb_soNgayLam_phuong.Text = dgv_luong_phuong.Rows[dongchon].Cells["soNgayLam"].Value.ToString();
            }
            catch
            {

            }
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            string sqll = " delete from Luong where phieuluong='" + tb_phieuluong.Text + "'";
            SqlCommand cmd = new SqlCommand(sqll, con);
            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Đã xóa thành công!!", "Xóa lương nhân viên", MessageBoxButtons.OKCancel);
            }
            load();
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            int dongchon = dgv_luong_phuong.CurrentRow.Index;
            try
            {
                SqlCommand cmd = new SqlCommand("update luong set phieuluong=@phieuluongmoi,maNV=@maNV,soNgayLam=@soNgayLam,Luong=@Luong where phieuluong=@phieuluongcu", con);
                cmd.Parameters.AddWithValue("@phieuluongmoi", tb_phieuluong.Text);
                cmd.Parameters.AddWithValue("@maNV", cb_idStaff_phuong.Text);
                cmd.Parameters.AddWithValue("@Luong", tb_luong_phuong.Text);
                cmd.Parameters.AddWithValue("@soNgayLam", tb_soNgayLam_phuong.Text);
                cmd.Parameters.AddWithValue("@phieuluongcu", dgv_luong_phuong.Rows[dongchon].Cells["phieuluong"].Value.ToString());
                cmd.ExecuteNonQuery();

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Đã sửa thành công!!", "Sửa thành công", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
                load();
            }
            catch
            {
                MessageBox.Show("Không được thay đổi mã chức vụ");
            }
        }
        public void clear()
        {
            tb_phieuluong.Text = "";
            tb_luong_phuong.Text = "";
            tb_nameCV_phuong.Text = "";
            tb_nameStaff_phuong.Text = "";
            tb_soNgayLam_phuong.Text = "";
            cb_idCV_phuong.Text = "";
            cb_idStaff_phuong.Text = "";
        }
        private void cb_idCV_phuong_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_nameCV_phuong.Text = cb_idCV_phuong.SelectedValue.ToString();
        }

        private void bt_search_phuong_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select phieuLuong,luong.maNV, nhanvien.hoTen, chucvu.tenCV, songaylam, Luong from luong, nhanvien, chucvu where luong.maNV = nhanvien.maNV and nhanvien.maCV = chucvu.maCV and hoTen LIKE N'%" + tb_search_phuong.Text + "%'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv_luong_phuong.DataSource = dt;
            cmd.ExecuteNonQuery();
            clear();
        }

        private void bt_quaylai_phuong_Click(object sender, EventArgs e)
        {
            load();
            clear();
        }

        private void tb_soNgayLam_phuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void bt_exit_phuong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private double luong()
        {
            String sql = "select luongTheoCa1Ngay from chucvu where maCV like'%" + cb_idCV_phuong.Text + "%'";
            SqlCommand cmd = new SqlCommand(sql, con);
            double tien = Convert.ToDouble(cmd.ExecuteScalar());
            return tien;
        }

        private void tb_soNgayLam_phuong_TextChanged(object sender, EventArgs e)
        {
            if (tb_soNgayLam_phuong.Text == "")
            {
                tb_luong_phuong.Text = "";
            }
            else
            {
                tb_luong_phuong.Text = (Convert.ToInt32(tb_soNgayLam_phuong.Text) * luong()).ToString();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            string sql = "select maCV from nhanvien where maNV = '" + cb_idStaff_phuong.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            cb_idCV_phuong.Text = cmd.ExecuteScalar().ToString();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            string sql2 = "select tenCV from chucvu where maCV='" + cb_idCV_phuong.Text + "'";
            SqlCommand cmd2 = new SqlCommand(sql2, con);
            tb_nameCV_phuong.Text = cmd2.ExecuteScalar().ToString();
        }

        private void tb_search_phuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (!(Char.IsLetter(e.KeyChar) || (e.KeyChar == 8) || Char.IsWhiteSpace(e.KeyChar)))
                    e.Handled = true;
            }
        }

        private void text_phuong_Click(object sender, EventArgs e)
        {

        }
    }
}
