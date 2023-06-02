using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using Microsoft.Office.Interop.Excel;
using System.ComponentModel.Design.Serialization;
//using app = Microsoft.Office.Interop.Excel.Application;
using COMExcel = Microsoft.Office.Interop.Excel;
using System.IO;
using System.Configuration;

namespace Nhom5_QLKS
{
    public partial class frm_baocaohoadon1_phu : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["kn"].ConnectionString);
        string b;
        string c="";
        public frm_baocaohoadon1_phu()
        {
            InitializeComponent();
        }
        public string chuoi = "select hoadon.maHD,hoadon.maPhong,khach.tenKhach,nhanvien.hoTen ,hoadon.giaPhong," +
          "hoadon.ngayThue,hoadon.ngayTra,hoadon.thanhTien,hoadon.tienDV,hoadon.trangThaiTT from hoadon,nhanvien,khach where (hoadon.trangThaiTT = N'True') and  (hoadon.maKhach = khach.maKhach) and (hoadon.maNV = nhanvien.maNV)";


      

        private void frm_baocaohoadon1_phu_Load_1(object sender, EventArgs e)
        {
            if (con.State == System.Data.ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand(chuoi, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            System.Data.DataTable dt = new System.Data.DataTable();
            da.Fill(dt);
            dgThongke_Phu.DataSource = dt;
            Namecolumn();
        }
        private void Namecolumn()
        {

            dgThongke_Phu.Columns[0].HeaderText = "Mã hóa đơn"; dgThongke_Phu.Columns[0].Width = 130;
            dgThongke_Phu.Columns[1].HeaderText = "Mã phòng"; dgThongke_Phu.Columns[1].Width = 130;
            dgThongke_Phu.Columns[2].HeaderText = "Tên khách hàng "; dgThongke_Phu.Columns[2].Width = 120;
            dgThongke_Phu.Columns[3].HeaderText = "Tên nhân viên"; dgThongke_Phu.Columns[3].Width = 120;
            dgThongke_Phu.Columns[4].HeaderText = "Giá phòng"; dgThongke_Phu.Columns[4].Width = 120;
            dgThongke_Phu.Columns[5].HeaderText = "Ngày nhận "; dgThongke_Phu.Columns[5].Width = 120;
            dgThongke_Phu.Columns[6].HeaderText = "Ngày trả "; dgThongke_Phu.Columns[6].Width = 120;
            dgThongke_Phu.Columns[7].HeaderText = "Thành tiền"; dgThongke_Phu.Columns[7].Width = 120;
            dgThongke_Phu.Columns[8].HeaderText = "Tiền dịch vụ"; dgThongke_Phu.Columns[8].Width = 120;
            dgThongke_Phu.Columns[9].HeaderText = "Trạng thái"; dgThongke_Phu.Columns[9].Width = 120;

            int sc = dgThongke_Phu.Rows.Count;
            double thanhtien = 0;
            for (int i = 0; i < sc - 1; i++)
            {

                thanhtien += float.Parse(dgThongke_Phu.Rows[i].Cells[7].Value.ToString());


            }

            lbThanhtien_Phu.Text = thanhtien.ToString() + " (VNĐ) ";
            lbChu_Phu.Text = chuyenso_thanhchu.So_chu(thanhtien).ToString();


        }


        private void ToExcel(DataGridView dgv, string fileName)
        {
            Microsoft.Office.Interop.Excel.Application excel;

            try
            {
                excel = new Microsoft.Office.Interop.Excel.Application();

                b = phanquyen.user_name;
                SqlCommand cmd = new SqlCommand(" select nhanvien.hoTen from nhanvien, TaiKhoan where nhanvien.user_name=TaiKhoan.user_name and TaiKhoan.user_name=@a", con);
                cmd.Parameters.AddWithValue("@a", b);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    c = dr["hoTen"].ToString();
                }
                dr.Close();

                excel.Application.Workbooks.Add(Type.Missing);
                excel.Columns.ColumnWidth = 18;
                excel.Range["A1:Z300"].Font.Name = "Times new roman";

                excel.Range["A1:Z300"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
                excel.Cells[1, 5] = "CỘNG HÒA XÃ HỘI CHỦ NGHĨA VIỆT NAM";
                excel.Range["1:1"].Font.Size = 18;
                excel.Range["1:1"].Font.Bold = true;

                excel.Cells[2, 5] = "Độc Lập - Tự Do - Hạnh Phúc";
                excel.Range["2:2"].Font.Size = 16;
                excel.Range["2:2"].Font.Bold = true;

                excel.Cells[4, 5] = "THÔNG KÊ THU NHẬP TỪ   " + dtNgayden_Phu.Value + " ĐẾN  : " + dtNgaydi_Phu.Value; ;
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
                excel.Cells[(5 + dgv.Rows.Count + 2), (dgv.Columns.Count - 1)] = "TỔNG TIỀN: " + lbThanhtien_Phu.Text;
                excel.Cells[(5 + dgv.Rows.Count + 3), (dgv.Columns.Count - 1)] = "TỔNG TIỀN CHỮ : " + lbChu_Phu.Text;
                DateTime a = DateTime.Now;
                excel.Cells[(5 + dgv.Rows.Count + 4), (dgv.Columns.Count - 1)] = "Hà Nội, " + a.Day + "  tháng  " + a.Month + "  năm  " + a.Year;
                excel.Cells[(5 + dgv.Rows.Count + 5), (dgv.Columns.Count - 1)] = "Người xuất hóa đơn";
                excel.Cells[(5 + dgv.Rows.Count + 6), (dgv.Columns.Count - 1)] = c.ToString();

                excel.ActiveWorkbook.SaveCopyAs(fileName + ".xlsx");
                excel.ActiveWorkbook.Saved = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thành công", "Thông báo");
            }
        }

        private void btnXuat_Phu_Click(object sender, EventArgs e)
        {

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                //gọi hàm ToExcel() với tham số là dtgDSHS và filename từ SaveFileDialog
                ToExcel(dgThongke_Phu, saveFileDialog1.FileName);
                DialogResult dialog = MessageBox.Show("Xuất thành công. Bạn có muốn mở file Exel?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                    System.Diagnostics.Process.Start(@"C:\");

                else if (dialog == DialogResult.No)
                {
                    //
                }

            }
        }

        private void btnThongke_Phu_Click(object sender, EventArgs e)
        {
            String chuoi1 = "select hoadon.maHD,hoadon.maPhong,khach.tenKhach,nhanvien.hoTen ,hoadon.giaPhong," +
           "hoadon.ngayThue,hoadon.ngayTra,hoadon.thanhTien,hoadon.trangThaiTT from hoadon,nhanvien,khach where (hoadon.trangThaiTT = N'True') and  (hoadon.maKhach = khach.maKhach) and (hoadon.maNV = nhanvien.maNV) and (hoadon.ngayTra BETWEEN '" + dtNgayden_Phu.Value.ToString("yyyy-MM-dd") + "' AND '" + dtNgaydi_Phu.Value.ToString("yyyy-MM-dd") + "')";
            chuoiketnoi.Chuoiketnoi(chuoi1, dgThongke_Phu);
        }

        private void btnThoat_Phu_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có muốn thoát", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
