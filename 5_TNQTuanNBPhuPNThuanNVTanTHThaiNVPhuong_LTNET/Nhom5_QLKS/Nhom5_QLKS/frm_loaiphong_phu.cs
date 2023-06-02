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
using System.Text.RegularExpressions;


namespace Nhom5_QLKS
{
    public partial class frm_loaiphong_phu : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["kn"].ConnectionString);
        public frm_loaiphong_phu()
        {
            InitializeComponent();
        }
        private void Namecolumn1()
        {

            dgloaiPhong_Phu.Columns[0].HeaderText = "Loại phòng"; dgloaiPhong_Phu.Columns[0].Width = 130;
            dgloaiPhong_Phu.Columns[1].HeaderText = "Giá phòng"; dgloaiPhong_Phu.Columns[1].Width = 130;
        }
        private void load()
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand("Select * from loaiPhong ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgloaiPhong_Phu.DataSource = dt;
        }

        public void add()
        {
            try
            {
                if (cbLoaiphong_Phu.Text == "" || tbGiaphong_Phu.Text == "")
                {
                    MessageBox.Show("Ban chưa nhập đầy đủ thông Tin !", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    string map = cbLoaiphong_Phu.Text.Trim();
                    if (map.Length > 15)
                    {
                        MessageBox.Show("Mã phòng quá dài ! chỉ nhập nhiều nhất 15 ký tự", "Thông báo", MessageBoxButtons.OK);
                        cbLoaiphong_Phu.Text = "";
                        cbLoaiphong_Phu.Focus();

                    }
                    else
                    {

                        String sql = "insert into loaiPhong(loaiPhong,giaPhong) values(@loaiPhong,@giaPhong)";
                        SqlCommand cmd = new SqlCommand(sql, con);
                        cmd.Parameters.AddWithValue("@loaiPhong", cbLoaiphong_Phu.Text);
                        cmd.Parameters.AddWithValue("@giaPhong", tbGiaphong_Phu.Text);

                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Thêm phòng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            load();
                        }


                        else MessageBox.Show("Thêm phòng thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Trùng loại phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        public void fill()
        {
            try
            {
                int dongchon = dgloaiPhong_Phu.CurrentCell.RowIndex;
                if (dongchon > -1)
                {

                    cbLoaiphong_Phu.Text = dgloaiPhong_Phu.Rows[dongchon].Cells["loaiPhong"].Value.ToString();
                    tbGiaphong_Phu.Text = dgloaiPhong_Phu.Rows[dongchon].Cells["giaPhong"].Value.ToString();

                }
            }
            catch
            {
                MessageBox.Show("Vui lòng chọn bảng", "Thông báo", MessageBoxButtons.OK);
            }

        }
        public void update()
        {
            try
            {
                int dongchon = dgloaiPhong_Phu.CurrentCell.RowIndex;
                string sql = "update loaiPhong set loaiPhong=@loaiPhong,giaPhong=@giaPhong where loaiPhong=@loaiPhongcu";
                SqlCommand cmd = new SqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@loaiPhong", cbLoaiphong_Phu.Text);
                cmd.Parameters.AddWithValue("@giaPhong", tbGiaphong_Phu.Text);
                cmd.Parameters.AddWithValue("@loaiPhongcu", dgloaiPhong_Phu.Rows[dongchon].Cells["loaiPhong"].Value.ToString());
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Sửa loại phòng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    load();
                }

                else MessageBox.Show("Sửa loại phòng thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch
            {

            }
        }
        public void delete()
        {
            if (MessageBox.Show("Bạn có muốn xóa không ?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    string sql = "delete from loaiPhong where loaiPhong = '" + cbLoaiphong_Phu.Text + "'";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Xóa thành công");
                        load();
                    }
                }
                catch
                {
                    MessageBox.Show("Có lỗi khi xóa!", "Thông báo");
                }
            }

        }

        private void frm_loaiphong_phu_Load(object sender, EventArgs e)
        {
            load();
            Namecolumn1();
        }

        private void btnThem_Phu_Click(object sender, EventArgs e)
        {
            if (!Checkaccount(tbGiaphong_Phu.Text))
            {
                MessageBox.Show(" Chỉ nhập sô từ 0-9 Và Không Có ký Tự Đặc biệt !!", "Thông Báo");
                return;
            }
            else { add(); }
        }
        public bool Checkaccount(string ac)
        {

            return Regex.IsMatch(ac, "^[0-9]{3,10}$");
        }

        private void dgloaiPhong_Phu_SelectionChanged(object sender, EventArgs e)
        {
            fill();
        }

        private void btnSua_Phu_Click(object sender, EventArgs e)
        {
            update();
        }

        private void btnXoa_Phu_Click(object sender, EventArgs e)
        {
            delete();
        }

        private void btnThoat_Phu_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có muốn thoát", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
