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
    public partial class frm_Phong_Phu : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["kn"].ConnectionString);
        public frm_Phong_Phu()
        {
            InitializeComponent();
        }
        private void Namecolumn()
        {

            dgPhong_Phu.Columns[0].HeaderText = "Mã phòng"; dgPhong_Phu.Columns[0].Width = 130;
            dgPhong_Phu.Columns[1].HeaderText = "Tên phòng"; dgPhong_Phu.Columns[1].Width = 130;
            dgPhong_Phu.Columns[2].HeaderText = "Loại phòng"; dgPhong_Phu.Columns[2].Width = 120;

            dgPhong_Phu.Columns[3].HeaderText = "Giá phòng"; dgPhong_Phu.Columns[3].Width = 140;

            dgPhong_Phu.Columns[4].HeaderText = "Trạng Thái"; dgPhong_Phu.Columns[4].Width = 120;
        }

        private void frm_Phong_Phu_Load(object sender, EventArgs e)
        {
            load();
            Namecolumn();



            tbTenphong_Phu.Text = "";
            tbGiaphong_Phu.Text = "";
        }
        private void load()
        {


            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand("Select phong.maPhong,phong.tenPhong,phong.loaiPhong,loaiPhong.giaPhong,phong.tinhTrang from phong, loaiPhong where(phong.loaiPhong = loaiPhong.loaiPhong) ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgPhong_Phu.DataSource = dt;
            //đổ dữ liệu lên combobox

            SqlDataAdapter da1 = new SqlDataAdapter("Select * from phong", con);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            cbMaphong_Phu.DataSource = dt1;
            cbMaphong_Phu.DisplayMember = "maPhong";
            cbMaphong_Phu.ValueMember = "tenPhong";

            SqlDataAdapter da2 = new SqlDataAdapter("Select * from loaiPhong", con);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            cbLoaiphong_Phu.DataSource = dt2;
            cbLoaiphong_Phu.DisplayMember = "loaiPhong";
            cbLoaiphong_Phu.ValueMember = "giaPhong";


        }
        public void add()
        {
            try
            {
                if (cbMaphong_Phu.Text == "" || cbLoaiphong_Phu.Text == "" || tbTenphong_Phu.Text == "" || tbGiaphong_Phu.Text == "")
                {
                    MessageBox.Show("Ban chưa nhập đầy đủ thông Tin !", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    string map = cbMaphong_Phu.Text.Trim();
                    if (map.Length > 15)
                    {
                        MessageBox.Show("Mã phòng quá dài ! chỉ nhập nhiều nhất 15 ký tự", "Thông báo", MessageBoxButtons.OK);
                        cbMaphong_Phu.Text = "";
                        cbMaphong_Phu.Focus();

                    }
                    else
                    {

                        String sql = "insert into phong(maPhong,tenPhong,loaiPhong,tinhTrang) values(@maPhong,@tenPhong,@loaiPhong,@tinhTrang)";
                        SqlCommand cmd = new SqlCommand(sql, con);
                        cmd.Parameters.AddWithValue("@maPhong", cbMaphong_Phu.Text);
                        cmd.Parameters.AddWithValue("@tenPhong", tbTenphong_Phu.Text);
                        cmd.Parameters.AddWithValue("@loaiPhong", cbLoaiphong_Phu.Text);

                        if (rdbThue.Checked == true)
                        {
                            cmd.Parameters.AddWithValue("@tinhTrang", true);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@tinhTrang", false);
                        }
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
                MessageBox.Show("Trùng mã phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        public void fill()
        {
            try
            {
                int dongchon = dgPhong_Phu.CurrentCell.RowIndex;
                if (dongchon > -1)
                {
                    cbMaphong_Phu.Text = dgPhong_Phu.Rows[dongchon].Cells["maPhong"].Value.ToString();
                    tbTenphong_Phu.Text = dgPhong_Phu.Rows[dongchon].Cells["tenPhong"].Value.ToString();
                    cbLoaiphong_Phu.Text = dgPhong_Phu.Rows[dongchon].Cells["loaiPhong"].Value.ToString();
                    tbGiaphong_Phu.Text = dgPhong_Phu.Rows[dongchon].Cells["giaPhong"].Value.ToString();
                    if (Convert.ToBoolean(dgPhong_Phu.Rows[dongchon].Cells["tinhTrang"].Value.ToString()) == true)
                    {
                        rdbThue.Checked = true;
                    }
                    else
                    {
                        rdbTrong.Checked = true;
                    }
                }
            }
            catch
            {

            }

        }
        public void update()
        {
            try
            {
                int dongchon = dgPhong_Phu.CurrentCell.RowIndex;
                string sql = "update phong set maPhong=@maPhong,tenPhong=@tenPhong,loaiPhong=@loaiPhong,tinhTrang =@tinhTrang where maPhong=@maPhongcu";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@maPhong", cbMaphong_Phu.Text);
                cmd.Parameters.AddWithValue("@loaiPhong", cbLoaiphong_Phu.Text);
                cmd.Parameters.AddWithValue("@tenPhong", tbTenphong_Phu.Text);
                if (rdbThue.Checked == true)
                {
                    cmd.Parameters.AddWithValue("@tinhTrang", true);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@tinhTrang", false);
                }
                cmd.Parameters.AddWithValue("@maPhongcu", dgPhong_Phu.Rows[dongchon].Cells["maPhong"].Value.ToString());
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Sửa phòng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    load();
                }

                else MessageBox.Show("Sửa phòng thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    string sql = "delete from phong where maPhong = '" + cbMaphong_Phu.Text + "'";
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

        private void dgPhong_Phu_SelectionChanged(object sender, EventArgs e)
        {
            fill();
        }

        private void txt_search_Phu_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string tukhoa = txt_search_Phu.Text;
                String chuoi1 = "";
                if (String.Compare(cb_luachon_Phu.Text, "Mã phòng", true) == 0 || cb_luachon_Phu.SelectedItem == null)
                {
                    chuoi1 = "Select phong.maPhong,phong.tenPhong,phong.loaiPhong,loaiPhong.giaPhong,phong.tinhTrang from phong, loaiPhong where(phong.loaiPhong = loaiPhong.loaiPhong) and (phong.maPhong like N'%" + tukhoa + "%')";
                }
                else if (String.Compare(cb_luachon_Phu.Text, "Tên phòng", true) == 0)
                {
                    chuoi1 = "Select phong.maPhong,phong.tenPhong,phong.loaiPhong,loaiPhong.giaPhong,phong.tinhTrang from phong, loaiPhong where(phong.loaiPhong = loaiPhong.loaiPhong) and (phong.tenPhong like N'%" + tukhoa + "%')";
                }
                else
                {
                    chuoi1 = "Select phong.maPhong,phong.tenPhong,phong.loaiPhong,loaiPhong.giaPhong,phong.tinhTrang from phong, loaiPhong where(phong.loaiPhong = loaiPhong.loaiPhong) and (phong.loaiPhong like N'%" + tukhoa + "%')";
                }



                SqlDataAdapter da = new SqlDataAdapter(chuoi1, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgPhong_Phu.DataSource = dt;
                Namecolumn();
            }
            catch (Exception ex)
            {

            }
        }

        private void cb_luachon_Phu_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbTenphong_Phu.Text = cbMaphong_Phu.SelectedValue.ToString();
        }

        private void btnThem_Phu_Click(object sender, EventArgs e)
        {
            add();
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

        private void cbLoaiphong_Phu_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbGiaphong_Phu.Text = cbLoaiphong_Phu.SelectedValue.ToString();
        }
    }
}
