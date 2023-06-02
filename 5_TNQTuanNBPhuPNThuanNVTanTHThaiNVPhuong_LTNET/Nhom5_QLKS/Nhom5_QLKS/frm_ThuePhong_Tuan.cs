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
    public partial class frm_ThuePhong_Tuan : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["kn"].ConnectionString);
        string a;
        string b;
        string c="";

        public frm_ThuePhong_Tuan()
        {
            InitializeComponent();
        }
        public void load_DV()
        {
            con.Close();
            con.Open();
            SqlDataAdapter da1 = new SqlDataAdapter("select maPhong , tenPhong,loaiPhong.loaiPhong ,loaiPhong.giaPhong,tinhTrang from phong , loaiPhong where phong.loaiPhong=loaiPhong.loaiPhong and tinhTrang='False' ", con);
            DataTable db1 = new DataTable();
            da1.Fill(db1);
            dgv_Phong_tuan.DataSource = db1;
        }
        public void load_HD()
        {


            con.Close();
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select maHD,khach.tenKhach, nhanvien.hoTen,hoadon.giaPhong,tenPhong,ngayThue,trangThaiTT from hoadon , khach,nhanvien,phong where hoadon.maNV=nhanvien.maNV and hoadon.maKhach=khach.maKhach and hoadon.maPhong=phong.maPhong and trangthaiTT='false'", con);
            DataTable db = new DataTable();
            da.Fill(db);
            dgv_hoadon_Tuan.DataSource = db;

            tb_gia_Tuan.Enabled = false;
            tb_phong_tuan.Enabled = false;
        }
        private void bt_Them_Tuan_Click(object sender, EventArgs e)
        {
            if (tb_maHD_Tuan.Text != "" && tb_tenKhach_tuan.Text != "" && tb_tenNV_Tuan.Text != "")
            {
                SqlCommand cmd3 = new SqlCommand(" select maPhong from phong where tenPhong=@tenPhong", con);
                cmd3.Parameters.AddWithValue("@tenPhong", this.tb_phong_tuan.Text);
                SqlDataReader dr1 = cmd3.ExecuteReader();

                while (dr1.Read())
                {
                    b = dr1["maPhong"].ToString();
                }
                dr1.Close();

                SqlCommand cmd1 = new SqlCommand("select maNV from nhanvien where hoTen=@hoTen", con);
                cmd1.Parameters.AddWithValue("@hoTen", this.tb_tenNV_Tuan.Text);
                SqlDataReader dr = cmd1.ExecuteReader();
                while (dr.Read())
                {
                    a = dr["maNV"].ToString();
                }
                dr.Close();
                SqlCommand cmd4 = new SqlCommand("select maKhach from khach where tenKhach=@tenKhach", con);
                cmd4.Parameters.AddWithValue("@tenKhach", this.tb_tenKhach_tuan.Text);
                SqlDataReader dr4 = cmd4.ExecuteReader();
                while (dr4.Read())
                {
                    c = dr4["maKhach"].ToString();
                }
                dr4.Close();
                try
                {
                    SqlCommand cmd = new SqlCommand("insert into hoadon (maHD,maKhach,maNV,giaPhong,maPhong,ngayThue,trangThaiTT) values(@maHD,@maKhach,@maNV,@giaPhong,@maPhong,@ngayThue,@trangThaiTT)", con);
                    cmd.Parameters.AddWithValue("@maHD", tb_maHD_Tuan.Text);
                    cmd.Parameters.AddWithValue("@maKhach", c);
                    cmd.Parameters.AddWithValue("@maNV", a);
                    cmd.Parameters.AddWithValue("@giaphong", tb_gia_Tuan.Text);
                    cmd.Parameters.AddWithValue("@maPhong", b);
                    cmd.Parameters.AddWithValue("@ngayThue", this.dtp_ngaythue_Tuan.Value);
                    cmd.Parameters.AddWithValue("@trangThaiTT", false);

                    SqlCommand cmd2 = new SqlCommand("update phong set tinhTrang=@tinhTrang  where  tenPhong=@tenPhong  ", con);
                    cmd2.Parameters.AddWithValue("@tinhTrang", true);
                    cmd2.Parameters.AddWithValue("@tenPhong", this.tb_phong_tuan.Text);

                    if (cmd.ExecuteNonQuery() > 0 && cmd2.ExecuteNonQuery() > 0) MessageBox.Show("Thành công ", "Thông báo");
                    load_HD();
                    load_DV();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Nhập sai thông tin ", "Thông báo");
                }
            }
            else MessageBox.Show("Bạn chưa nhập đủ thông tin", "Thông báo");

        }

        private void bt_xoa_Tuan_Click(object sender, EventArgs e)
        {
            try
            {
            
                SqlCommand cmd = new SqlCommand("DELETE FROM hoadon WHERE maHD=@maHD", con);
                cmd.Parameters.AddWithValue("@maHD", tb_maHD_Tuan.Text);

                SqlCommand cmd1 = new SqlCommand("update phong set tinhTrang=@tinhTrang  where  tenPhong=@tenPhong  ", con);
                cmd1.Parameters.AddWithValue("@tinhTrang", false);
                cmd1.Parameters.AddWithValue("@tenPhong", this.tb_phong_tuan.Text);
                if (cmd.ExecuteNonQuery() > 0 && cmd1.ExecuteNonQuery() > 0) MessageBox.Show("Thành công ", "Thông báo");
                load_HD();
                load_DV();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thành công do đang liên kết CSDL ở bảng khác  ", "Thông báo");
            }
        }

        private void bt_Refresh_Tuan_Click(object sender, EventArgs e)
        {
            load_HD();
            Clear();
        }

        private void frm_ThuePhong_Tuan_Load(object sender, EventArgs e)
        {
            load_DV();
            load_HD();
            //SqlCommand cmd = new SqlCommand("update hoadon set thanhTien=giaPhong*(  DATEDIFF (dd, ngayThue, ngayTra)+1 )  ", con);
            groupBox1.Enabled = false;
        }

        private void dgv_hoadon_Tuan_SelectionChanged(object sender, EventArgs e)
        {
            bt_Them_Tuan.Enabled = false;
            bt_xoa_Tuan.Enabled = true;
            bt_ChonDV_Tuan.Enabled = true;
            tb_maHD_Tuan.Enabled = false;
            tb_tenKhach_tuan.Enabled = false;
            tb_tenNV_Tuan.Enabled = false;
            int dongchon = dgv_hoadon_Tuan.CurrentCell.RowIndex;
            if (dongchon >= 0)
            {

                this.tb_maHD_Tuan.Text = dgv_hoadon_Tuan.Rows[dongchon].Cells[0].Value.ToString();
                this.tb_tenKhach_tuan.Text = dgv_hoadon_Tuan.Rows[dongchon].Cells[1].Value.ToString();
                this.tb_tenNV_Tuan.Text = dgv_hoadon_Tuan.Rows[dongchon].Cells[2].Value.ToString();
                this.tb_gia_Tuan.Text = dgv_hoadon_Tuan.Rows[dongchon].Cells[3].Value.ToString();
                this.tb_phong_tuan.Text = dgv_hoadon_Tuan.Rows[dongchon].Cells[4].Value.ToString();
                this.dtp_ngaythue_Tuan.Value = Convert.ToDateTime(dgv_hoadon_Tuan.Rows[dongchon].Cells[5].Value);
            }
        }
        public void Clear()
        {
            tb_maHD_Tuan.Clear();
            tb_gia_Tuan.Clear();
            tb_tenKhach_tuan.Text = "";
            tb_tenNV_Tuan.Text = "";
            tb_phong_tuan.Text = "";
            dtp_ngaythue_Tuan.Text = "";
        }

        private void bt_ChonDV_Tuan_Click(object sender, EventArgs e)
        {
            frm_DV_tuan dv = new frm_DV_tuan();
            dv.Ma = tb_maHD_Tuan.Text;
            dv.Gr = true;
            dv.ShowDialog();
            this.Close();
        }

        private void dgv_phong_tuan_SelectionChanged(object sender, EventArgs e)
        {
           
        }

        private void tb_tenKhach_tuan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || (e.KeyChar == 8) || Char.IsWhiteSpace(e.KeyChar)))
                e.Handled = true;
        }

        private void tb_tenNV_Tuan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || (e.KeyChar == 8) || Char.IsWhiteSpace(e.KeyChar)))
                e.Handled = true;
        }

        private void frm_ThuePhong_Tuan_Load_1(object sender, EventArgs e)
        {
          
            load_DV();
            load_HD();
        }

        private void bt_ChonDV_Tuan_Click_1(object sender, EventArgs e)
        {
            frm_DV_tuan dv = new frm_DV_tuan();
            dv.Ma = tb_maHD_Tuan.Text;
            dv.Gr = true;
            dv.Show();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_Refresh_Tuan_Click_1(object sender, EventArgs e)
        {
            load_HD();
            load_DV();
        }

   

        private void dgv_Phong_tuan_SelectionChanged_2(object sender, EventArgs e)
        {
           
            Clear();
            tb_maHD_Tuan.Enabled = true;
            tb_tenKhach_tuan.Enabled = true;
            int dongchon = dgv_Phong_tuan.CurrentCell.RowIndex;
            if (dongchon >= 0)
            {
                this.tb_phong_tuan.Text = dgv_Phong_tuan.Rows[dongchon].Cells[1].Value.ToString();
                this.tb_gia_Tuan.Text = dgv_Phong_tuan.Rows[dongchon].Cells[3].Value.ToString();
            }
            b = phanquyen.user_name;
            SqlCommand cmd = new SqlCommand(" select nhanvien.hoTen from nhanvien, TaiKhoan where nhanvien.user_name=TaiKhoan.user_name and TaiKhoan.user_name=@a", con);
            cmd.Parameters.AddWithValue("@a", b);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                c = dr["hoTen"].ToString();
                
            }
            dr.Close();
            tb_tenNV_Tuan.Text = c.ToString();
            bt_Them_Tuan.Enabled = true;
            groupBox1.Enabled = true;
            bt_xoa_Tuan.Enabled = false;
            bt_ChonDV_Tuan.Enabled = false;

        }
    }
}
