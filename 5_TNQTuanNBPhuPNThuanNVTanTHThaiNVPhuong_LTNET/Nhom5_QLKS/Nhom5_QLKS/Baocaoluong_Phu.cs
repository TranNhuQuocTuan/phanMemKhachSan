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
    public partial class Baocaoluong_Phu : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["kn"].ConnectionString);
        string b;
        string c;
        public Baocaoluong_Phu()
        {
            InitializeComponent();
        }

        private void Baocaoluong_Phu_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("Select luong.phieuLuong,nhanvien.maNV,nhanvien.hoTen,luong.songaylam,luong.Luong from luong,nhanvien where (luong.maNV = nhanvien.maNV)", con);
                System.Data.DataTable dt = new System.Data.DataTable();
                da.Fill(dt);
                dgLuong_Phu.DataSource = dt;
                Namecolumn();

                //Dổ dữ liệu lên Combobox

            }
        }
        private void Namecolumn()
        {

            dgLuong_Phu.Columns[0].HeaderText = "Mã phiếu"; dgLuong_Phu.Columns[0].Width = 130;
            dgLuong_Phu.Columns[1].HeaderText = "Mã nhân viên"; dgLuong_Phu.Columns[1].Width = 130;
            dgLuong_Phu.Columns[2].HeaderText = "Tên nhân viên "; dgLuong_Phu.Columns[2].Width = 120;
            dgLuong_Phu.Columns[3].HeaderText = "Số ngày làm"; dgLuong_Phu.Columns[3].Width = 120;
            dgLuong_Phu.Columns[4].HeaderText = "Lương"; dgLuong_Phu.Columns[4].Width = 120;



            int sc = dgLuong_Phu.Rows.Count;
            double thanhtien = 0;
            for (int i = 0; i < sc - 1; i++)
            {

                thanhtien += float.Parse(dgLuong_Phu.Rows[i].Cells[4].Value.ToString());


            }

            lbLuong_Phu.Text = thanhtien.ToString() + " (VNĐ) ";
            lbChu_Phu.Text = chuyenso_thanhchu.So_chu(thanhtien).ToString();


        }

        private void btnThoat_Phu_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có muốn thoát", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                this.Close();
            }
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

                excel.Cells[4, 5] = " BẢNG THÔNG KÊ LƯƠNG NHÂN VIÊN ";
                excel.Range["4:5"].Font.Size = 22;
                excel.Range["4:5"].Font.Bold = true;

                excel.Range["A5:L5"].Font.Size = 14;



                //excel.Range["A8:L8"].Font.Bold = false;
                excel.Range["11:8"].Font.Bold = true;
                excel.Range["13:8"].Font.Size = 16;
                excel.Range["13:8"].Font.Bold = true;
                excel.Range["A:A"].ColumnWidth = 15;
                excel.Range["E:E"].ColumnWidth = 15;


                for (int i = 1; i < dgv.Columns.Count + 1; i++)
                {

                    excel.Cells[5, i + 2] = dgv.Columns[i - 1].HeaderText;
                    excel.Range["A5 : L5"].Font.Bold = true;
                }
                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    for (int j = 0; j < dgv.Columns.Count; j++)
                    {
                        if (dgv.Rows[i].Cells[j].Value != null)
                        {
                            excel.Cells[i + 6, j + 3] = dgv.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                }
                excel.Cells[(5 + dgv.Rows.Count + 2), (dgv.Columns.Count + 2)] = "TỔNG TIỀN: " + lbLuong_Phu.Text;
                excel.Cells[(5 + dgv.Rows.Count + 3), (dgv.Columns.Count + 2)] = "TỔNG TIỀN CHỮ : " + lbChu_Phu.Text;
                DateTime a = DateTime.Now;
                excel.Cells[(5 + dgv.Rows.Count + 4), (dgv.Columns.Count + 2)] = "Hà Nội, " + a.Day + "  tháng  " + a.Month + "  năm  " + a.Year;
                excel.Cells[(5 + dgv.Rows.Count + 5), (dgv.Columns.Count + 2)] = "Người xuất hóa đơn";
                excel.Cells[(5 + dgv.Rows.Count + 6), (dgv.Columns.Count + 2)] = c.ToString();

                excel.ActiveWorkbook.SaveCopyAs(fileName + ".xlsx");
                excel.ActiveWorkbook.Saved = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thành công", "Thông báo");
            }
        }

        private void tbSearch_Phu_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string tukhoa = tbSearch_Phu.Text;
                String chuoi1 = "";
                if (String.Compare(cbMa_Phu.Text, "Mã nhân viên", true) == 0 || cbMa_Phu.SelectedItem == null)
                {
                    chuoi1 = "Select luong.phieuLuong,nhanvien.maNV,nhanvien.hoTen,luong.songaylam,luong.Luong from luong,nhanvien where (luong.maNV = nhanvien.maNV)and(nhanvien.maNV like N'%" + tukhoa + "%')";
                }
                else if (String.Compare(cbMa_Phu.Text, "Tên nhân viên", true) == 0)
                {
                    chuoi1 = "Select luong.phieuLuong,nhanvien.maNV,nhanvien.hoTen,luong.songaylam,luong.Luong from luong,nhanvien where (luong.maNV = nhanvien.maNV)and(nhanvien.hoTen like N'%" + tukhoa + "%')";
                }



                SqlDataAdapter da = new SqlDataAdapter(chuoi1, con);
                System.Data.DataTable dt = new System.Data.DataTable();
                da.Fill(dt);
                dgLuong_Phu.DataSource = dt;
                Namecolumn();
            }
            catch (Exception ex)
            {

            }
        }

        private void btnXuat_Phu_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                //gọi hàm ToExcel() với tham số là dtgDSHS và filename từ SaveFileDialog
                ToExcel(dgLuong_Phu, saveFileDialog1.FileName);
                DialogResult dialog = MessageBox.Show("Xuất thành công. Bạn có muốn mở file Exel?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                    System.Diagnostics.Process.Start(@"C:\");

                else if (dialog == DialogResult.No)
                {
                    //
                }

            }
        }
    }
}
