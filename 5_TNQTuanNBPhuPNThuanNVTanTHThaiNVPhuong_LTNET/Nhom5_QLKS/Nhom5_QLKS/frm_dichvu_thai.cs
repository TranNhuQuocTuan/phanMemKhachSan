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
    public partial class frm_dichvu_thai : Form
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["kn"].ConnectionString);
        public frm_dichvu_thai()
        {
            InitializeComponent();
        }
        private void filldichvu()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            String sql = " select * from dichvu";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv_thai.DataSource = dt;
        }



        private void fillForm()
        {
            try
            {
                int choose = dgv_thai.CurrentRow.Index;
                if (choose >= -1)
                {
                    tb_madv_thai.Text = dgv_thai.Rows[choose].Cells["maDV"].Value.ToString();
                    tb_tendv_thai.Text = dgv_thai.Rows[choose].Cells["tenDV"].Value.ToString();
                    tb_giadv_thai.Text = dgv_thai.Rows[choose].Cells["giaDV"].Value.ToString();
                    tb_soluong_thai.Text = dgv_thai.Rows[choose].Cells["soLuong"].Value.ToString();
                    cb_loaidv_thai.Text = dgv_thai.Rows[choose].Cells["loaiDV"].Value.ToString();
                }
            }
            catch
            {
                MessageBox.Show("Không có dữ liệu");
            }

        }

        private void addDV()
        {
            try
            {
                String sql = " insert into dichvu (maDV,tenDV,giaDV,soLuong,loaiDV) values (@maDV,@tenDV,@giaDV,@soLuong,@loaiDV)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@maDV", tb_madv_thai.Text);
                cmd.Parameters.AddWithValue("@tenDV", tb_tendv_thai.Text);
                cmd.Parameters.AddWithValue("@giaDV", tb_giadv_thai.Text);
                cmd.Parameters.AddWithValue("@soLuong", tb_soluong_thai.Text);
                cmd.Parameters.AddWithValue("@loaiDV", cb_loaidv_thai.Text);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Thêm thành công");
                    filldichvu();
                }
            }
            catch
            {
                MessageBox.Show("Trùng mã dịch vụ");
            }

        }

        private void deleteDV()
        {
            try
            {
                String sql = " delete from dichvu where maDV ='" + tb_madv_thai.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Xóa thành công");
                }

            }
            catch
            {
                MessageBox.Show("Dịch vụ đang được sử dụng");
            }
            filldichvu();


        }

        private void updateDV()
        {
            try
            {
                int choose = dgv_thai.CurrentRow.Index;
                String sql = "update dichvu set tenDV=@tenDV,giaDV=@giaDV,soLuong=@soLuong,loaiDV=@loaiDV where maDV=@maDVcu";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@tenDV", tb_tendv_thai.Text);
                cmd.Parameters.AddWithValue("@giaDV", tb_giadv_thai.Text);
                cmd.Parameters.AddWithValue("@soLuong", tb_soluong_thai.Text);
                cmd.Parameters.AddWithValue("@loaiDV", cb_loaidv_thai.Text);
                cmd.Parameters.AddWithValue("@maDVcu", dgv_thai.Rows[choose].Cells["maDV"].Value.ToString());

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Sửa dịch vụ thành công");
                    filldichvu();
                }

            }
            catch
            {
                MessageBox.Show("Không thể sửa mã dịch vụ do dịch vụ đang được sử dụng");
            }


        }

        private void search()
        {
            if (rb_madv_thai.Checked == true && tb_search_thai.Text != "")
            {
                tb_search_thai.Enabled = true;
                SqlDataAdapter da = new SqlDataAdapter("select * from dichvu where maDV  like N'%" + tb_search_thai.Text + "%'", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv_thai.DataSource = dt;
            }
            else if (rb_tendv_thai.Checked == true && tb_search_thai.Text != "")
            {
                tb_search_thai.Enabled = true;
                SqlDataAdapter da = new SqlDataAdapter("select * from dichvu where tenDV  like N'%" + tb_search_thai.Text + "%'", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv_thai.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn phương thức tìm kiếm", "Thông báo");
            }
            if (dgv_thai.RowCount <= 1)
            {

                MessageBox.Show("Không có dịch vụ này", "Thông báo");
                filldichvu();
            }

        }


        private void frm_dichvu_thai_Load(object sender, EventArgs e)
        {
            filldichvu();
        }

        private void bt_them_thai_Click(object sender, EventArgs e)
        {
            String ma = tb_madv_thai.Text;
            String tendv = tb_tendv_thai.Text;
            String gdv = tb_giadv_thai.Text;
            String sl = tb_soluong_thai.Text;
            String pl = cb_loaidv_thai.Text;
            if (ma == "")
            {
                MessageBox.Show("Bạn Chưa Nhập Mã", "Thông Báo");
            }
            else if (tendv == "")
            {
                MessageBox.Show("Bạn Chưa Nhập Tên", "Thông Báo");

            }
            else if (gdv == "")
            {
                MessageBox.Show("Bạn Chưa Nhập Giá Dịch Vụ", "Thông Báo");

            }
            else if (sl == "")
            {
                MessageBox.Show("Bạn Chưa Nhập Số Lượng", "Thông Báo");

            }
            else if (pl == "")
            {
                MessageBox.Show("Bạn Chưa Nhập Phân Loại", "Thông Báo");

            }
            else
            {

                addDV();
            }
        }

        private void bt_sua_thai_Click(object sender, EventArgs e)
        {
            updateDV();
        }

        private void bt_xoa_thai_Click(object sender, EventArgs e)
        {
            deleteDV();
        }

        private void bt_thoat_thai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_serach_thai_Click(object sender, EventArgs e)
        {
            search();
        }

        private void dgv_thai_SelectionChanged(object sender, EventArgs e)
        {

            fillForm();
        }

        private void bt_rf_thai_Click(object sender, EventArgs e)
        {
            filldichvu();
        }

        private void tb_soluong_thai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void tb_giadv_thai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void tb_tendv_thai_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (!(Char.IsLetter(e.KeyChar) || (e.KeyChar == 8) || Char.IsWhiteSpace(e.KeyChar)))
                    e.Handled = true;
            }
        }
    }
}
