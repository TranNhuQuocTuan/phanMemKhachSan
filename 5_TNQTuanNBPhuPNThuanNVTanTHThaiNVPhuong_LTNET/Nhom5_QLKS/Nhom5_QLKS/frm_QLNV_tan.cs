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
    public partial class frm_QLNV_tan : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["kn"].ConnectionString);
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        string a, ma;
        public frm_QLNV_tan()
        {
            InitializeComponent();
        }
        private void clear()
        {
            tb_ma_tan.Text = "";
            tb_ten_tan.Text = "";
            cb_ca_tan.Text = "";
            cb_cv_tan.Text = "";
            tb_giobd_tan.Text = "";
            tb_giokt_tan.Text = "";
            tb_timkiem_tan.Text = "";
            rb_nam_tan.Checked = false;
            rb_nu_tan.Checked = false;
            tb_user_tan.Text = "";


        }
        private void load()
        {

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("select maNV,hoTen,ngaySinh,gioiTinh,maCa,tenCV,user_name from nhanvien,chucvu where (chucvu.maCV=nhanvien.maCV)", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv_ttnv_tan.DataSource = dt;


            SqlDataAdapter da1 = new SqlDataAdapter("select * from calam", con);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            cb_ca_tan.DataSource = dt1;
            cb_ca_tan.DisplayMember = "maCa";
            cb_ca_tan.ValueMember = "maCa";

            SqlDataAdapter da2 = new SqlDataAdapter("select tenCV from chucvu", con);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            cb_cv_tan.DataSource = dt2;
            cb_cv_tan.DisplayMember = "tenCV";
            cb_cv_tan.ValueMember = "tenCV";

            
        }

        private void dgv_ttnv_tan_SelectionChanged(object sender, EventArgs e)
        {

            //try
            //{
            //    int i = dgv_ttnv_tan.CurrentRow.Index;
            //    tb_ma_tan.Text = dgv_ttnv_tan.Rows[i].Cells[0].Value.ToString();
            //    ma = dgv_ttnv_tan.Rows[i].Cells[0].Value.ToString();
            //    tb_ten_tan.Text = dgv_ttnv_tan.Rows[i].Cells[1].Value.ToString();
            //    dtp_ngaysinh_tan.Text = dgv_ttnv_tan.Rows[i].Cells[2].Value.ToString();
                
            //    if (Convert.ToBoolean(dgv_ttnv_tan.Rows[i].Cells[3].Value.ToString()) == true)
            //    {
            //        rb_nam_tan.Checked = true;

            //    }
            //    else
            //    {
            //        rb_nu_tan.Checked = true;
            //    }
            //    cb_ca_tan.Text = dgv_ttnv_tan.Rows[i].Cells[4].Value.ToString();
            //    cb_cv_tan.Text = dgv_ttnv_tan.Rows[i].Cells["tenCV"].Value.ToString();
            //    tb_user_tan.Text = dgv_ttnv_tan.Rows[i].Cells[6].Value.ToString();
            //    string sql = "select gioBatDau from calam where maCa ='" + dgv_ttnv_tan.Rows[i].Cells["maCa"].Value.ToString() + "'";
            //    string sql2 = "select gioKetThuc from calam where maCa ='" + dgv_ttnv_tan.Rows[i].Cells["maCa"].Value.ToString() + "'";
            //    SqlCommand cmd = new SqlCommand(sql, con);
            //    SqlCommand cmd2 = new SqlCommand(sql2, con);
            //    tb_giobd_tan.Text = cmd.ExecuteScalar().ToString();
            //    tb_giokt_tan.Text = cmd2.ExecuteScalar().ToString();
            //}
            //catch
            //{

            //}
        }

        private void bt_them_tan_Click(object sender, EventArgs e)
        {
            if (tb_ma_tan.Text == "" || tb_ten_tan.Text == "" || cb_ca_tan.Text == "" || cb_cv_tan.Text == "" || tb_user_tan.Text == "")
            {
                MessageBox.Show("VUI LÒNG NHẬP ĐẦY ĐỦ THÔNG TIN !!!");
            }
            else
            {
                
                SqlCommand cmd4 = new SqlCommand("select maCV from chucvu where tenCV=@tenCV", con);
                cmd4.Parameters.AddWithValue("@tenCV", this.cb_cv_tan.Text);
                SqlDataReader da4 = cmd4.ExecuteReader();

                while (da4.Read())
                {
                    a = da4["maCV"].ToString();
                }
                da4.Close();

                try
                {
                    SqlCommand cmd = new SqlCommand("insert into nhanvien (maNV,hoTen,ngaySinh,gioiTinh,maCa,maCV,user_name) values(@maNV,@hoTen,@ngaySinh,@gioiTinh,@maCa,@maCV,@user_name)", con);
                    cmd.Parameters.AddWithValue("@maNV", tb_ma_tan.Text);
                    cmd.Parameters.AddWithValue("@hoTen", tb_ten_tan.Text);
                    cmd.Parameters.AddWithValue("@ngaySinh", Convert.ToDateTime(this.dtp_ngaysinh_tan.Text));
                    
                    if (rb_nam_tan.Checked == true)
                    {
                        cmd.Parameters.AddWithValue("@gioiTinh", true);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@gioiTinh", false);
                    }
                    cmd.Parameters.AddWithValue("@maCa", this.cb_ca_tan.Text);
                    cmd.Parameters.AddWithValue("@maCV", a);
                    cmd.Parameters.AddWithValue("@user_name", tb_user_tan.Text);
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("THÊM THÀNH CÔNG ", "THÔNG BÁO");
                    }
                    else
                    {
                        MessageBox.Show("THÊM THẤT BẠI ", "THÔNG BÁO");
                    }
                    load();

                }
                catch
                {
                    MessageBox.Show("TRÙNG MÃ NHÂN VIÊN !!!");
                }
            }

            clear();
        }

        private void bt_xoa_tan_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM nhanvien WHERE maNV='" + tb_ma_tan.Text + "'", con);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("XÓA THÀNH CÔNG ", "THÔNG BÁO");
                }
                else
                {
                    MessageBox.Show("XÓA THẤT BẠI", "THÔNG BÁO");
                }
                load();
            }
            catch
            {
                MessageBox.Show("XÓA THẤT BẠI", "THÔNG BÁO");
            }
            clear();
        }

        private void bt_sua_tan_Click(object sender, EventArgs e)
        {
            if (tb_ma_tan.Text == "" || tb_ten_tan.Text == "" || cb_ca_tan.Text == "" || cb_cv_tan.Text == "" ||tb_user_tan.Text=="")
            {
                MessageBox.Show("VUI LÒNG NHẬP ĐẦY ĐỦ THÔNG TIN !!!");
            }
            else
            {
                SqlCommand cmd4 = new SqlCommand("select maCV from chucvu where tenCV=@tenCV", con);
                cmd4.Parameters.AddWithValue("@tenCV", this.cb_cv_tan.Text);
                SqlDataReader da4 = cmd4.ExecuteReader();

                while (da4.Read())
                {
                    a = da4["maCV"].ToString();
                }
                da4.Close();

                try
                {
                    SqlCommand cmd = new SqlCommand(" UPDATE nhanvien SET hoTen=N'" + tb_ten_tan.Text + "',ngaySinh='" + dtp_ngaysinh_tan.Value + "',gioiTinh='" + rb_nam_tan.Checked + "',maCa='" + cb_ca_tan.Text + "',maCV='" + a + "',user_name='"+ tb_user_tan.Text +"' WHERE maNV=N'" + ma + "'", con);
                    //cmd.Parameters.AddWithValue("@maNV", tb_ma_tan.Text);
                    cmd.Parameters.AddWithValue("@hoTen", tb_ten_tan.Text);
                    cmd.Parameters.AddWithValue("@ngaySinh", Convert.ToDateTime(this.dtp_ngaysinh_tan.Text));
                    if (rb_nam_tan.Checked == true)
                    {
                        cmd.Parameters.AddWithValue("@gioiTinh", true);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@gioiTinh", false);
                    }
                    cmd.Parameters.AddWithValue("@maCa", this.cb_ca_tan.Text);
                    cmd.Parameters.AddWithValue("@user_name", tb_user_tan.Text);
                    cmd.Parameters.AddWithValue("@maCV", this.cb_cv_tan.Text);

                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("SỬA THÀNH CÔNG ", "THÔNG BÁO ");
                    }
                    else
                    {
                        MessageBox.Show("SỬA KHÔNG THÀNH CÔNG ", "THÔNG BÁO");
                    }
                    load();

                }
                catch
                {
                    MessageBox.Show("TRÙNG MÃ NHÂN VIÊN !!!");
                }
                clear();
            }
        }

        private void bt_thoat_tan_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_timkiem_tan_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand("select maNV,hoTen,ngaySinh,gioiTinh,maCa,tenCV,user_name from nhanvien,chucvu where (chucvu.maCV=nhanvien.maCV) and hoTen LIKE N'%" + tb_timkiem_tan.Text + "%'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv_ttnv_tan.DataSource = dt;
            cmd.ExecuteNonQuery();
            if (dgv_ttnv_tan.Rows.Count > 1)
            {
            }
            else
            {

                MessageBox.Show("KHÔNG CÓ NHÂN VIÊN BẠN MUỐN TÌM");
                load();
            }

            clear();
        }

        private void bt_ql_tan_Click(object sender, EventArgs e)
        {
            load();
            clear();
        }

        private void frm_QLNV_tan_Load(object sender, EventArgs e)
        {
            clear();
            cb_cv_tan.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cb_cv_tan.AutoCompleteSource = AutoCompleteSource.CustomSource;
            load();
            tb_user_tan.Text = phanquyen.user_name1;
            tb_ma_tan.Text = phanquyen.user_name1;
        }

        private void cb_ca_tan_SelectedIndexChanged(object sender, EventArgs e)
        {
            getH();
        }

        private void rb_nam_tan_CheckedChanged(object sender, EventArgs e)
        {

            if (rb_nam_tan.Checked == false)
                rb_nu_tan.Checked = true;
        }

        private void tb_ten_tan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || (e.KeyChar == 8) || Char.IsWhiteSpace(e.KeyChar)))
                e.Handled = true;
        }

        private void tb_timkiem_tan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || (e.KeyChar == 8) || Char.IsWhiteSpace(e.KeyChar)))
                e.Handled = true;
        }

        private void dgv_ttnv_tan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int i = dgv_ttnv_tan.CurrentRow.Index;
                tb_ma_tan.Text = dgv_ttnv_tan.Rows[i].Cells[0].Value.ToString();
                ma = dgv_ttnv_tan.Rows[i].Cells[0].Value.ToString();
                tb_ten_tan.Text = dgv_ttnv_tan.Rows[i].Cells[1].Value.ToString();
                dtp_ngaysinh_tan.Text = dgv_ttnv_tan.Rows[i].Cells[2].Value.ToString();

                if (Convert.ToBoolean(dgv_ttnv_tan.Rows[i].Cells[3].Value.ToString()) == true)
                {
                    rb_nam_tan.Checked = true;

                }
                else
                {
                    rb_nu_tan.Checked = true;
                }
                cb_ca_tan.Text = dgv_ttnv_tan.Rows[i].Cells[4].Value.ToString();
                cb_cv_tan.Text = dgv_ttnv_tan.Rows[i].Cells["tenCV"].Value.ToString();
                tb_user_tan.Text = dgv_ttnv_tan.Rows[i].Cells[6].Value.ToString();
                string sql = "select gioBatDau from calam where maCa ='" + dgv_ttnv_tan.Rows[i].Cells["maCa"].Value.ToString() + "'";
                string sql2 = "select gioKetThuc from calam where maCa ='" + dgv_ttnv_tan.Rows[i].Cells["maCa"].Value.ToString() + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlCommand cmd2 = new SqlCommand(sql2, con);
                tb_giobd_tan.Text = cmd.ExecuteScalar().ToString();
                tb_giokt_tan.Text = cmd2.ExecuteScalar().ToString();
            }
            catch
            {

            }
        }

        private void getH()
        {
            string sql = "select gioBatDau from calam where maCa ='" + cb_ca_tan.Text + "'";
            string sql2 = "select gioKetThuc from calam where maCa ='" + cb_ca_tan.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlCommand cmd2 = new SqlCommand(sql2, con);
            String gbd = Convert.ToString(cmd.ExecuteScalar());
            String gkt = Convert.ToString(cmd2.ExecuteScalar());
            tb_giobd_tan.Text = gbd.ToString();
            tb_giokt_tan.Text = gkt.ToString();
        }
    }
}
