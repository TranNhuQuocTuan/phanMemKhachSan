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
    public partial class frm_QLKH_tan : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["kn"].ConnectionString);
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        private string a;
        private void clear()
        {
            tb_ma_tan.Text = "";
            tb_ten_tan.Text = "";
            tb_cmt_tan.Text = "";
            cb_qt_tan.Text = "";
            tb_sdt_tan.Text = "";
            rb_nam_tan.Checked = false;
            rb_nu_tan.Checked = false;
        }
        public frm_QLKH_tan()
        {
            InitializeComponent();
        }
        private void load()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("SELECT * from khach", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv_qlkh_tan.DataSource = dt;

        }
        private void frm_QLKH_tan_Load(object sender, EventArgs e)
        {
            cb_qt_tan.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cb_qt_tan.AutoCompleteSource = AutoCompleteSource.CustomSource;
            load();
            clear();

        }

        private void dgv_qlkh_tan_SelectionChanged(object sender, EventArgs e)
        {
            int i = dgv_qlkh_tan.CurrentRow.Index;

            tb_ma_tan.Text = dgv_qlkh_tan.Rows[i].Cells[0].Value.ToString();
            a = dgv_qlkh_tan.Rows[i].Cells[0].Value.ToString();
            tb_ten_tan.Text = dgv_qlkh_tan.Rows[i].Cells[1].Value.ToString();
            tb_cmt_tan.Text = dgv_qlkh_tan.Rows[i].Cells[2].Value.ToString();
            cb_qt_tan.Text = dgv_qlkh_tan.Rows[i].Cells[3].Value.ToString();

            if (Convert.ToBoolean(dgv_qlkh_tan.Rows[i].Cells[4].Value.ToString()) == true)
            {
                rb_nam_tan.Checked = true;
            }
            else
            {
                rb_nu_tan.Checked = true;
            }
            tb_sdt_tan.Text = dgv_qlkh_tan.Rows[i].Cells[5].Value.ToString();

        }

        private void bt_them_tan_Click(object sender, EventArgs e)
        {
            if (tb_ma_tan.Text == "" || tb_ten_tan.Text == "" || tb_cmt_tan.Text == "" || cb_qt_tan.Text == "" || tb_sdt_tan.Text == "")
            {
                MessageBox.Show("VUI LÒNG NHẬP ĐẦY ĐỦ THÔNG TIN !!!");
            }
            else
            {
                try

                {
                    SqlCommand cmd = new SqlCommand("insert into khach(maKhach,tenKhach,CMT,quocTich,gioiTinh,SDT) values (@maKhach,@tenKhach,@CMT,@quocTich,@gioiTinh,@SDT)", con);
                    cmd.Parameters.AddWithValue("@maKhach", tb_ma_tan.Text);
                    cmd.Parameters.AddWithValue("@tenKhach", tb_ten_tan.Text);
                    cmd.Parameters.AddWithValue("@CMT", tb_cmt_tan.Text);
                    cmd.Parameters.AddWithValue("@quocTich", cb_qt_tan.Text);
                    if (rb_nam_tan.Checked == true)
                    {
                        cmd.Parameters.AddWithValue("@gioiTinh", true);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@gioiTinh", false);
                    }
                    cmd.Parameters.AddWithValue("@SDT", tb_sdt_tan.Text);
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("THÊM THÀNH CÔNG ", "THÔNG BÁO");
                    }
                    else
                    {
                        MessageBox.Show("THÊM THẤT BẠI ", "THÔNG BÁO");
                    }

                    load();
                    clear();
                }
                catch
                {
                    MessageBox.Show("TRÙNG MÃ KHÁCH HÀNG ", "THÔNG BÁO");
                }
            }
        }

        private void bt_sua_tan_Click(object sender, EventArgs e)
        {
            if (tb_ma_tan.Text == "" || tb_ten_tan.Text == "" || tb_cmt_tan.Text == "" || cb_qt_tan.Text == "" || tb_sdt_tan.Text == "")
            {
                MessageBox.Show("VUI LÒNG NHẬP ĐẦY ĐỦ THÔNG TIN !!!");
            }
            else
            {

                try
                {

                    SqlCommand cmd = new SqlCommand("UPDATE khach SET tenKhach=N'" + tb_ten_tan.Text + "',CMT='" + tb_cmt_tan.Text + "',quocTich=N'" + cb_qt_tan.Text + "',gioiTinh='" + rb_nam_tan.Checked + "',SDT='" + tb_sdt_tan.Text + "' WHERE maKhach=N'" + a + "' ", con);
                    cmd.Parameters.AddWithValue("@maKhach", tb_ma_tan.Text);
                    cmd.Parameters.AddWithValue("tenKhach", tb_ten_tan.Text);
                    cmd.Parameters.AddWithValue("CMT", tb_cmt_tan.Text);
                    cmd.Parameters.AddWithValue("quocTich", cb_qt_tan.Text);
                    if (rb_nam_tan.Checked == true)
                    {
                        cmd.Parameters.AddWithValue("@gioiTinh", true);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@gioiTinh", false);
                    }
                    cmd.Parameters.AddWithValue("SDT", tb_sdt_tan.Text);
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("SỬA THÀNH CÔNG ", "THÔNG BÁO ");
                    }
                    else
                    {
                        MessageBox.Show("SỬA THẤT BẠI ", "THÔNG BÁO");
                    }
                    load();
                    clear();
                }
                catch
                {
                    MessageBox.Show("SỬA KHÔNG THÀNH CÔNG ", "THÔNG BÁO");
                }


            }
        }

        private void bt_thoat_tan_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_xoa_tan_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM khach WHERE maKhach='" + tb_ma_tan.Text + "'", con);
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

        private void bt_timkiem_tan_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM khach WHERE tenKhach LIKE N'%" + tb_tukhoa_tan.Text + "%'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv_qlkh_tan.DataSource = dt;
            cmd.ExecuteNonQuery();
            if (dgv_qlkh_tan.Rows.Count > 1)
            {
            }
            else
            {

                MessageBox.Show("KHÔNG CÓ NHÂN VIÊN BẠN MUỐN TÌM");
                load();
            }
            clear();
        }

        private void bt_quaylai_tan_Click(object sender, EventArgs e)
        {
            load();
            clear();
        }

        private void rb_nam_tan_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_nam_tan.Checked == false)
                rb_nu_tan.Checked = true;
        }

        private void tb_cmt_tan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void tb_sdt_tan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void tb_ten_tan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || (e.KeyChar == 8) || Char.IsWhiteSpace(e.KeyChar)))
                e.Handled = true;
        }

        private void tb_tukhoa_tan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || (e.KeyChar == 8) || Char.IsWhiteSpace(e.KeyChar)))
                e.Handled = true;
        }
    }
}
