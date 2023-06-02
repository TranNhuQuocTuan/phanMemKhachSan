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
using COMExcel = Microsoft.Office.Interop.Excel;

namespace Nhom5_QLKS
{
    public partial class frm__ThanhToan_tuan : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["kn"].ConnectionString);
        string a;
        string b;
        string c="";
        public frm__ThanhToan_tuan()
        {
            InitializeComponent();
        }

        private void frm__ThanhToan_tuan_Load(object sender, EventArgs e)
        {

            load_HD_Thanhtoan();
            load_HDDA_Thanhtoan();
            tb_mahd_tuan.Enabled = false;
            tb_tenkhach_tuan.Enabled = false;
            tb_tenNV_tuan.Enabled = false;
            tb_gia1ngay_tuan.Enabled = false;
            tb_tenPhong_tuan.Enabled = false;
            tb_tienDV_tuan.Enabled = false;
            tb_tienPhong_tuan.Enabled = false;
            tb_Tong_tuan.Enabled = false;
            dtp_ngaythue_tuan.Enabled = false;
            rdb_daTT_Tuan.Enabled = false;
            rdb_chuaTT_Tuan.Enabled = false;
            bt_tim_tuan.Enabled = false;
            bt_Xuat_Tuan.Enabled = false;
        }

        public void load_HD_Thanhtoan()
        {
            con.Close();
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select maHD,khach.tenKhach, nhanvien.hoTen,tenPhong,hoadon.giaPhong,ngayThue,ngayTra,tienDV,thanhTien,trangThaiTT from hoadon , khach,nhanvien,phong where hoadon.maNV=nhanvien.maNV and hoadon.maKhach=khach.maKhach and hoadon.maPhong=phong.maPhong and trangthaiTT='false'", con);
            DataTable db = new DataTable();
            da.Fill(db);
            dgv_hoadontraphong_Tuan.DataSource = db;
        }

        public void load_HDDA_Thanhtoan()
        {
            con.Close();
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select maHD,khach.tenKhach, nhanvien.hoTen,tenPhong,hoadon.giaPhong,ngayThue,ngayTra,tienDV,thanhTien,trangThaiTT from hoadon , khach,nhanvien,phong where hoadon.maNV=nhanvien.maNV and hoadon.maKhach=khach.maKhach and hoadon.maPhong=phong.maPhong and trangthaiTT='true'", con);
            DataTable db = new DataTable();
            da.Fill(db);
            dgv_hddaTT_tuan.DataSource = db;
        }

        private void dgv_hoadontraphong_Tuan_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int dongchon = dgv_hoadontraphong_Tuan.CurrentCell.RowIndex;
                if (dongchon >= 0)
                {

                    this.tb_mahd_tuan.Text = dgv_hoadontraphong_Tuan.Rows[dongchon].Cells[0].Value.ToString();
                    this.tb_tenkhach_tuan.Text = dgv_hoadontraphong_Tuan.Rows[dongchon].Cells[1].Value.ToString();
                    this.tb_tenNV_tuan.Text = dgv_hoadontraphong_Tuan.Rows[dongchon].Cells[2].Value.ToString();
                    this.tb_tenPhong_tuan.Text = dgv_hoadontraphong_Tuan.Rows[dongchon].Cells[3].Value.ToString();
                    this.tb_gia1ngay_tuan.Text = dgv_hoadontraphong_Tuan.Rows[dongchon].Cells[4].Value.ToString();
                    this.dtp_ngaythue_tuan.Value = Convert.ToDateTime(dgv_hoadontraphong_Tuan.Rows[dongchon].Cells[5].Value);
                }
                double a;
                SqlCommand cmd = new SqlCommand(" select SUM(thanhtien) from hoadonCT where maHD=@maHD", con);
                cmd.Parameters.AddWithValue("@maHD", this.tb_mahd_tuan.Text);
                tb_tienDV_tuan.Text = cmd.ExecuteScalar().ToString();

                DateTime thue = dtp_ngaythue_tuan.Value;
                DateTime tra = dtp_ngaytra_tuan.Value;
                if (tra >= thue)
                {
                    a = Convert.ToInt32((1 + tra.Subtract(thue).Days).ToString());
                    double b = Convert.ToDouble(tb_gia1ngay_tuan.Text) * a;
                    tb_tienPhong_tuan.Text = b.ToString();

                    double c = (b + Convert.ToDouble(tb_tienDV_tuan.Text));
                    tb_Tong_tuan.Text = c.ToString();
                }
                dtp_ngaytra_tuan.Enabled = false;
                bt_Thanhtoan_tuan.Enabled = true;
                bt_Xuat_Tuan.Enabled = false;
            }
            catch (Exception ex) { }
        }

        private void dtp_ngaytra_tuan_ValueChanged(object sender, EventArgs e)
        {
        }

        private void bt_chitietDV_tuan_Click(object sender, EventArgs e)
        {

            frm_DV_tuan f = new frm_DV_tuan();
            f.Ma = tb_mahd_tuan.Text;
            f.Gr = false;
            f.Show();
        
        }

        private void bt_Thanhtoan_tuan_Click(object sender, EventArgs e)
        {


            try
            {

                SqlCommand cmd = new SqlCommand(" select maKhach from khach where tenKhach=@tenKhach ", con);
                cmd.Parameters.AddWithValue("@tenKhach", this.tb_tenkhach_tuan.Text);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    a = dr["maKhach"].ToString();
                }
                dr.Close();

                SqlCommand cmd1 = new SqlCommand(" select maNV from nhanvien where hoTen=@hoTen ", con);
                cmd1.Parameters.AddWithValue("@hoTen", this.tb_tenNV_tuan.Text);
                SqlDataReader dr1 = cmd1.ExecuteReader();
                while (dr1.Read())
                {
                    b = dr1["maNV"].ToString();
                }
                dr1.Close();


                SqlCommand cmd2 = new SqlCommand(" select maPhong from phong where tenPhong=@tenPhong ", con);
                cmd2.Parameters.AddWithValue("@tenPhong", this.tb_tenPhong_tuan.Text);
                SqlDataReader dr2 = cmd2.ExecuteReader();
                while (dr2.Read())
                {
                    c = dr2["maPhong"].ToString();
                }
                dr2.Close();

                SqlCommand cmd3 = new SqlCommand("update hoadon set maKhach=@maKhach , maNV=@maNV, giaPhong=@giaPhong,maPhong=@maPhong,ngayThue=@ngayThue,ngayTra=@ngayTra,thanhTien=@thanhTien,trangThaiTT=@trangThaiTT,tienDV=@tienDV   where  maHD=@maHD  ", con);

                cmd3.Parameters.AddWithValue("@maKhach", a);
                cmd3.Parameters.AddWithValue("@maNV", b);
                cmd3.Parameters.AddWithValue("@giaPhong", tb_gia1ngay_tuan.Text);
                cmd3.Parameters.AddWithValue("@maPhong", c);
                cmd3.Parameters.AddWithValue("@ngayThue", dtp_ngaythue_tuan.Value);
                cmd3.Parameters.AddWithValue("@ngayTra", dtp_ngaytra_tuan.Value);
                cmd3.Parameters.AddWithValue("@thanhTien", tb_Tong_tuan.Text);
                cmd3.Parameters.AddWithValue("@trangThaiTT", true);
                cmd3.Parameters.AddWithValue("@tienDV", tb_tienDV_tuan.Text);
                cmd3.Parameters.AddWithValue("@maHD", tb_mahd_tuan.Text);

                SqlCommand cmd4 = new SqlCommand("update phong set tinhTrang=@tinhTrang  where  tenPhong=@tenPhong  ", con);
                cmd4.Parameters.AddWithValue("@tinhTrang", false);
                cmd4.Parameters.AddWithValue("@tenPhong", this.tb_tenPhong_tuan.Text);

                if (cmd3.ExecuteNonQuery() > 0 && cmd4.ExecuteNonQuery() > 0) MessageBox.Show("Thành công ", "Thông báo");
                load_HD_Thanhtoan();
                load_HDDA_Thanhtoan();
            }
            catch
            {
                MessageBox.Show("Không thành công ", "Thông báo");
            }
        }

        private void bt_tim_tuan_Click(object sender, EventArgs e)
        {
            try
            {
                con.Close();
                con.Open();

                if (rdb_chuaTT_Tuan.Checked)
                {
                    SqlDataAdapter da = new SqlDataAdapter("select maHD,khach.tenKhach, nhanvien.hoTen,tenPhong,hoadon.giaPhong,ngayThue,ngayTra,tienDV,thanhTien,trangThaiTT from hoadon , khach,nhanvien,phong where hoadon.maNV=nhanvien.maNV and hoadon.maKhach=khach.maKhach and hoadon.maPhong=phong.maPhong and khach.tenKhach=N'" + tb_timkiem_tuan.Text + "' and trangThaiTT='false' ", con);
                    DataTable db = new DataTable();
                    da.Fill(db);
                    dgv_hoadontraphong_Tuan.DataSource = db;
                    if (dgv_hoadontraphong_Tuan.Rows.Count > 1)
                    {
                        MessageBox.Show("Có tìm thấy trong danh sách chưa TT", "Thông báo");
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy ở danh sách chưa thanh toán", "Thông báo");
                        frm__ThanhToan_tuan_Load(sender, e);
                    }
                }
                else if (rdb_daTT_Tuan.Checked)
                {
                    SqlDataAdapter da = new SqlDataAdapter("select maHD,khach.tenKhach, nhanvien.hoTen,tenPhong,hoadon.giaPhong,ngayThue,ngayTra,tienDV,thanhTien,trangThaiTT from hoadon , khach,nhanvien,phong where hoadon.maNV=nhanvien.maNV and hoadon.maKhach=khach.maKhach and hoadon.maPhong=phong.maPhong and hoadon.maHD=N'" + tb_timkiem_tuan.Text + "' and trangThaiTT='true' ", con);
                    DataTable db = new DataTable();
                    da.Fill(db);
                    dgv_hddaTT_tuan.DataSource = db;
                    if (dgv_hddaTT_tuan.Rows.Count > 1)
                    {
                        bt_Xuat_Tuan.Enabled = true;
                        MessageBox.Show("Có tìm thấy trong DS đã TT", "Thông báo");
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy ở danh sách đã thanh toán", "Thông báo");
                        frm__ThanhToan_tuan_Load(sender, e);
                    }
                }

            }
            catch { }
        }



        private void bt_Xuat_Tuan_Click(object sender, EventArgs e)
        {
            try
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    ToExcel(dgv_hddaTT_tuan, saveFileDialog1.FileName);
                }
            }catch(Exception ex) { }
          
        }
        private void ToExcel(DataGridView dgv, string fileName)
        {
            Microsoft.Office.Interop.Excel.Application excel;
           

            try
            {
                
                b = phanquyen.user_name;
                SqlCommand cmd = new SqlCommand(" select nhanvien.hoTen from nhanvien, TaiKhoan where nhanvien.user_name=TaiKhoan.user_name and TaiKhoan.user_name=@a", con);
                cmd.Parameters.AddWithValue("@a", b);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    c = dr["hoTen"].ToString();
                }
                dr.Close();
                excel = new Microsoft.Office.Interop.Excel.Application();

                excel.Application.Workbooks.Add(Type.Missing);
                excel.Columns.ColumnWidth = 18;
                excel.Range["A1:Z300"].Font.Name = "Times new roman";

                excel.Range["A1:Z300"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
                excel.Cells[1, 5] = "KHÁCH SẠN NHÓM 5";
                excel.Range["1:1"].Font.Size = 18;
                excel.Range["1:1"].Font.Bold = true;

                excel.Cells[2, 5] = "Ngõ 218-Lĩnh Nam-Hoàng Mai-Hà Nội";
                excel.Range["2:2"].Font.Size = 16;
                excel.Range["2:2"].Font.Bold = true;

                excel.Cells[4, 5] = "HÓA ĐƠN THANH TOÁN  ";
                excel.Range["4:5"].Font.Size = 22;
                excel.Range["4:5"].Font.Bold = true;

                excel.Range["A5:L5"].Font.Size = 14;

                excel.Range["10:8"].Font.Bold = true;
                excel.Range["11:8"].Font.Bold = true;
                excel.Range["13:8"].Font.Size = 16;
                excel.Range["13:8"].Font.Bold = true;
                excel.Range["A:A"].ColumnWidth = 15;
                excel.Range["E:E"].ColumnWidth = 15;


                for (int i = 1; i < dgv.Columns.Count + 1; i++)
                {

                    excel.Cells[5, i] = dgv.Columns[i - 1].HeaderText;
                    excel.Range["A5 : L5"].Font.Bold = true;
                }
                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    for (int j = 0; j < dgv.Columns.Count; j++)
                    {
                        if (dgv.Rows[i].Cells[j].Value != null)
                        {
                            excel.Cells[i + 6, j + 1] = dgv.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                }

                DateTime a = DateTime.Now;
                excel.Cells[(5 + dgv.Rows.Count + 3), (dgv.Columns.Count - 1)] = "Hà Nội, " + a.Day + "  tháng  " + a.Month + "  năm  " + a.Year;
                excel.Cells[(5 + dgv.Rows.Count + 4), (dgv.Columns.Count - 1)] = "Người xuất hóa đơn";
                excel.Cells[(5 + dgv.Rows.Count + 6), (dgv.Columns.Count - 1)] = c.ToString();

                excel.ActiveWorkbook.SaveCopyAs(fileName + ".xlsx");
                excel.ActiveWorkbook.Saved = true;
                MessageBox.Show("Xuất file excel thành công", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thành công", "Thông báo");
            }
        }

        private void rdb_chuaTT_Tuan_CheckedChanged(object sender, EventArgs e)
        {
            bt_tim_tuan.Enabled = true;
        }

        private void rdb_daTT_Tuan_CheckedChanged(object sender, EventArgs e)
        {
            bt_tim_tuan.Enabled = true;
        }

        private void bt_refresh_tuan_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void dgv_hddaTT_tuan_SelectionChanged_1(object sender, EventArgs e)
        {

            int dongchon = dgv_hddaTT_tuan.CurrentCell.RowIndex;
            if (dongchon >= 0)
            {

                this.tb_mahd_tuan.Text = dgv_hddaTT_tuan.Rows[dongchon].Cells[0].Value.ToString();
                this.tb_tenNV_tuan.Text = dgv_hddaTT_tuan.Rows[dongchon].Cells[2].Value.ToString();
            }
            tb_tenkhach_tuan.Clear();
            tb_gia1ngay_tuan.Clear();
            tb_tenPhong_tuan.Clear();
            tb_tienDV_tuan.Clear();
            tb_tienPhong_tuan.Clear();
            dtp_ngaythue_tuan.Text = "";
            tb_Tong_tuan.Clear();
            dtp_ngaytra_tuan.Enabled = false;
            bt_Thanhtoan_tuan.Enabled = false;
            bt_Xuat_Tuan.Enabled = true;

        }

        private void tb_timkiem_tuan_TextChanged(object sender, EventArgs e)
        {
            if (tb_timkiem_tuan.Text == "")
            {

                rdb_chuaTT_Tuan.Enabled = false;
                rdb_daTT_Tuan.Enabled = false;
                bt_tim_tuan.Enabled = false;
                load_HD_Thanhtoan();
                load_HDDA_Thanhtoan();
            }
            else if (tb_timkiem_tuan.Text != null)
            {
                rdb_chuaTT_Tuan.Enabled = true;
                rdb_daTT_Tuan.Enabled = true;
            }
        }
    }
    
}
