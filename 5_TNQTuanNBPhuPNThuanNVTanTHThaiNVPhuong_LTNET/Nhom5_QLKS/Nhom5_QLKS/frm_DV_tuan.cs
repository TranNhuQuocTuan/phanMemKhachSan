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
    public partial class frm_DV_tuan : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["kn"].ConnectionString);
        private string ma;
        private bool gr;
        string a;
        public frm_DV_tuan()
        {
            InitializeComponent();
            load_dichvu();
        }
        public string Ma { get => ma; set => ma = value; }
        public bool Gr { get => gr; set => gr = value; }
        private void frm_DV_tuan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nhom5_QLKSDataSet.dichvu' table. You can move, or remove it, as needed.
            this.dichvuTableAdapter.Fill(this.nhom5_QLKSDataSet.dichvu);
            con.Close();
            con.Open();
            tb_maHDCT_Tuan.Text = Ma;
            groupBox1.Enabled = Gr;
            SqlDataAdapter da1 = new SqlDataAdapter("select maHD,tenDV,donGia,hoadonCT.soLuong,thanhtien from hoadonCT,dichvu where hoadonCT.maDV=dichvu.maDV and maHD='" + tb_maHDCT_Tuan.Text + "'", con);
            DataTable db1 = new DataTable();
            da1.Fill(db1);
            dgv_chitietHD_Tuan.DataSource = db1;
            tb_Thanhtien_Tuan.Enabled = false;
            tb_maHDCT_Tuan.Enabled = false;
            tb_tenDV_Tuan.Enabled = false;
            tb_Gia1SP_Tuan.Enabled = false;
            tb_tong_Tuan.Enabled = false;
            tb_soluongco_tuan.Enabled = false;
            tb_madv_tuan.Enabled = false;

        }
        public void load_dichvu()
        {
            // con = new SqlConnection(@"Data Source=TNV6996\SQLEXPRESS01;Initial Catalog=Nhom5_QLKS;Integrated Security=True");
            con.Close();
            //con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select* from dichvu", con);
            DataTable db = new DataTable();
            da.Fill(db);
            dgv_DichVu_Tuan.DataSource = db;
            tb_Thanhtien_Tuan.Enabled = false;


        }

        private void bt_bo_Tuan_Click(object sender, EventArgs e)
        {
            tb_tong_Tuan.Clear();
            try
            {


                SqlCommand cmd = new SqlCommand("DELETE FROM hoadonCT WHERE  maHD=@maHD and maDV=@maDV", con);
                cmd.Parameters.AddWithValue("@maHD", tb_maHDCT_Tuan.Text);
                cmd.Parameters.AddWithValue("@maDV", tb_madv_tuan.Text);

                int a = Convert.ToInt32(tb_soluongco_tuan.Text) + Convert.ToInt32(tb_SLSP_Tuan.Text);
                SqlCommand cmd1 = new SqlCommand("update dichvu set soLuong=@soLuong where maDV=@maDV ", con);
                cmd1.Parameters.AddWithValue("@maDV", this.tb_madv_tuan.Text);
                cmd1.Parameters.AddWithValue("@soLuong", a.ToString());

                if (cmd.ExecuteNonQuery() > 0 && cmd1.ExecuteNonQuery() > 0) MessageBox.Show("Thành công ", "Thông báo");
                frm_DV_tuan_Load(sender, e);
                load_dichvu();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bạn chỉ bỏ chọn được khi đã chọn trước đó  ", "Thông báo");
            }
        }

        private void dgv_chitietHD_Tuan_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int dongchon = dgv_chitietHD_Tuan.CurrentCell.RowIndex;

                if (dongchon >= 0)
                {
                    this.tb_maHDCT_Tuan.Text = dgv_chitietHD_Tuan.Rows[dongchon].Cells[0].Value.ToString();
                    this.tb_tenDV_Tuan.Text = dgv_chitietHD_Tuan.Rows[dongchon].Cells[1].Value.ToString();
                    this.tb_Gia1SP_Tuan.Text = dgv_chitietHD_Tuan.Rows[dongchon].Cells[2].Value.ToString();
                    this.tb_SLSP_Tuan.Text = dgv_chitietHD_Tuan.Rows[dongchon].Cells[3].Value.ToString();
                    this.tb_Thanhtien_Tuan.Text = dgv_chitietHD_Tuan.Rows[dongchon].Cells[4].Value.ToString();


                    SqlCommand cmd = new SqlCommand(" select maDV , soLuong from dichvu where tenDV=@tenDV", con);
                    cmd.Parameters.AddWithValue("@tenDV", this.tb_tenDV_Tuan.Text);
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        tb_madv_tuan.Text = dr["maDV"].ToString();
                        tb_soluongco_tuan.Text = dr["soLuong"].ToString();
                    }
                    dr.Close();

                }
                tb_SLSP_Tuan.Enabled = false;
                bt_chon_tuan.Enabled = false;
                bt_muathem_tuan.Enabled = false;


            }
            catch (Exception ex) { }
        }

        private void dgv_DichVu_Tuan_SelectionChanged(object sender, EventArgs e)
        {

            con.Close();
            con.Open();
            try
            {

                int dongchon = dgv_DichVu_Tuan.CurrentCell.RowIndex;
                if (dongchon >= 0)
                {
                    this.tb_madv_tuan.Text = dgv_DichVu_Tuan.Rows[dongchon].Cells["maDV"].Value.ToString();
                    this.tb_tenDV_Tuan.Text = dgv_DichVu_Tuan.Rows[dongchon].Cells["tenDV"].Value.ToString();
                    this.tb_soluongco_tuan.Text = dgv_DichVu_Tuan.Rows[dongchon].Cells["soLuong"].Value.ToString();
                    this.tb_Gia1SP_Tuan.Text = dgv_DichVu_Tuan.Rows[dongchon].Cells["giaDV"].Value.ToString();
                }
                SqlCommand cmd = new SqlCommand(" select hoadonCT.maDV  from hoadonCT,dichvu where hoadonCT.maDV=dichvu.maDV and dichvu.tenDV=@tenDV and maHD=@maHD", con);
                cmd.Parameters.AddWithValue("@maHD", this.tb_maHDCT_Tuan.Text);
                cmd.Parameters.AddWithValue("@tenDV", this.tb_tenDV_Tuan.Text);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    a = dr["maDV"].ToString();
                }
                string b = tb_madv_tuan.Text;
                if (String.Compare(a, b) == 0)
                {
                    bt_chon_tuan.Enabled = false;
                    bt_muathem_tuan.Enabled = true;
                }
                else
                {
                    bt_chon_tuan.Enabled = true;
                    bt_muathem_tuan.Enabled = false;
                }
                dr.Close();


                tb_SLSP_Tuan.Enabled = true;
                tb_SLSP_Tuan.Clear();
            }
            catch (Exception ex)
            { }
        }

        private void tb_SLSP_Tuan_TextChanged(object sender, EventArgs e)
        {

            try
            {
                int a = Convert.ToInt32(tb_Gia1SP_Tuan.Text) * Convert.ToInt32(tb_SLSP_Tuan.Text);
                tb_Thanhtien_Tuan.Text = a.ToString();


            }
            catch (Exception ex)
            {
                tb_Thanhtien_Tuan.Clear();
            }
        }

        private void bt_chon_tuan_Click(object sender, EventArgs e)
        {
            tb_tong_Tuan.Clear();
            try
            {
                SqlCommand cmd = new SqlCommand("insert into hoadonCT (maHD,maDV,donGia,soLuong,thanhtien) values(@maHD,@maDV,@donGia,@soLuong,@thanhtien)", con);
                cmd.Parameters.AddWithValue("@maHD", this.tb_maHDCT_Tuan.Text);
                cmd.Parameters.AddWithValue("@maDV", this.tb_madv_tuan.Text);
                cmd.Parameters.AddWithValue("@donGia", this.tb_Gia1SP_Tuan.Text);
                cmd.Parameters.AddWithValue("@soLuong", this.tb_SLSP_Tuan.Text);
                cmd.Parameters.AddWithValue("@thanhtien", this.tb_Thanhtien_Tuan.Text);


                int a = Convert.ToInt32(tb_soluongco_tuan.Text) - Convert.ToInt32(tb_SLSP_Tuan.Text);
                SqlCommand cmd1 = new SqlCommand("update dichvu set soLuong=@soLuong where maDV=@maDV ", con);
                cmd1.Parameters.AddWithValue("@maDV", this.tb_madv_tuan.Text);
                cmd1.Parameters.AddWithValue("@soLuong", a.ToString());
                if (cmd.ExecuteNonQuery() > 0 && cmd1.ExecuteNonQuery() > 0) MessageBox.Show("Thành công ", "Thông báo");
                frm_DV_tuan_Load(sender, e);
                load_dichvu();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thành công  ", "Thông báo");
            }
        }

        private void bt_Tongtien_Tuan_Click(object sender, EventArgs e)
        {
            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand(" select SUM(thanhtien) from hoadonCT where maHD=@maHD", con);
            cmd.Parameters.AddWithValue("@maHD", this.tb_maHDCT_Tuan.Text);
            tb_tong_Tuan.Text = cmd.ExecuteScalar().ToString();



        }

        private void bt_muathem_tuan_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(" select soluong from hoadonCT where maHD=@maHD and maDV=@maDV", con);
                cmd.Parameters.AddWithValue("@maHD", this.tb_maHDCT_Tuan.Text);
                cmd.Parameters.AddWithValue("@maDV", this.tb_madv_tuan.Text);
                string a = cmd.ExecuteScalar().ToString();

                SqlCommand cmd1 = new SqlCommand(" select thanhtien from hoadonCT where maHD=@maHD and maDV=@maDV", con);
                cmd1.Parameters.AddWithValue("@maHD", this.tb_maHDCT_Tuan.Text);
                cmd1.Parameters.AddWithValue("@maDV", this.tb_madv_tuan.Text);
                string b = cmd1.ExecuteScalar().ToString();

                double soLuongMoi = Convert.ToDouble(a) + Convert.ToDouble(tb_SLSP_Tuan.Text);
                double thanhTienMoi = Convert.ToDouble(b) + Convert.ToDouble(tb_Thanhtien_Tuan.Text);
                SqlCommand cmd2 = new SqlCommand("update hoadonCT set soLuong=@soLuong , thanhtien =@thanhtien where maHD=@maHD and maDV=@maDV ", con);
                cmd2.Parameters.AddWithValue("@maHD", this.tb_maHDCT_Tuan.Text);
                cmd2.Parameters.AddWithValue("@maDV", this.tb_madv_tuan.Text);
                cmd2.Parameters.AddWithValue("@soLuong", soLuongMoi.ToString());
                cmd2.Parameters.AddWithValue("@thanhtien", thanhTienMoi.ToString());

                int c = Convert.ToInt32(tb_soluongco_tuan.Text) - Convert.ToInt32(tb_SLSP_Tuan.Text);
                SqlCommand cmd3 = new SqlCommand("update dichvu set soLuong=@soLuong where maDV=@maDV ", con);
                cmd3.Parameters.AddWithValue("@maDV", this.tb_madv_tuan.Text);
                cmd3.Parameters.AddWithValue("@soLuong", c.ToString());

                if (cmd2.ExecuteNonQuery() > 0 && cmd3.ExecuteNonQuery() > 0) MessageBox.Show("Thành công ", "Thông báo");
                frm_DV_tuan_Load(sender, e);
                load_dichvu();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bạn chưa nhập sl ", "Thông báo");
            }
        }

        private void bt_chonlai_tuan_Click(object sender, EventArgs e)
        {

            frm_ThuePhong_Tuan f = new frm_ThuePhong_Tuan();
             f.Show();
          
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm__ThanhToan_tuan f = new frm__ThanhToan_tuan();
             f.Show();
            
            
        }

        private void tb_SLSP_Tuan_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void edb_doan_tuan_CheckedChanged(object sender, EventArgs e)
        {
            con.Close();
            //con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select* from dichvu where loaiDV=N'Đồ Ăn' ", con);
            DataTable db = new DataTable();
            da.Fill(db);
            dgv_DichVu_Tuan.DataSource = db;
        }

        private void rdb_douong_tuan_CheckedChanged(object sender, EventArgs e)
        {
            con.Close();
            //con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select* from dichvu where loaiDV=N'Đồ Uống' ", con);
            DataTable db = new DataTable();
            da.Fill(db);
            dgv_DichVu_Tuan.DataSource = db;
        }

        private void rdb_giaitri_tuan_CheckedChanged(object sender, EventArgs e)
        {
            con.Close();
            //con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select* from dichvu where loaiDV=N'Giải Trí' ", con);
            DataTable db = new DataTable();
            da.Fill(db);
            dgv_DichVu_Tuan.DataSource = db;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
