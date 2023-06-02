using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Data.SqlClient;
using System.Configuration;
using System.Runtime.InteropServices;

namespace Nhom5_QLKS
{
    public partial class Login_Thuan : Form
    {
        public Login_Thuan()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["kn"].ConnectionString);
        private void btn_exit_Thuan_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txt_username_Thuan_Click(object sender, EventArgs e)
        {
            txt_username_Thuan.BackColor = Color.White;
            panel_user.BackColor = Color.White;
            txt_password_Thuan.BackColor = SystemColors.Control;
            panel_password.BackColor= SystemColors.Control;
            user_err_Thuan.Visible = false;
        }

        private void txt_password_Thuan_Click(object sender, EventArgs e)
        {
            txt_password_Thuan.BackColor = Color.White;
            panel_password.BackColor = Color.White;
            txt_username_Thuan.BackColor = SystemColors.Control;
            panel_user.BackColor= SystemColors.Control;
            password_err_Thuan.Visible = false;
        }

        private void pictureBox_PW_Thuan_MouseDown(object sender, MouseEventArgs e)
        {
            txt_password_Thuan.UseSystemPasswordChar = false;
        }

        private void pictureBox_PW_Thuan_MouseUp(object sender, MouseEventArgs e)
        {
            txt_password_Thuan.UseSystemPasswordChar = true;
        }

        private void btn_Login_Thuan_Click(object sender, EventArgs e)
        {
            //if(txt_username_Thuan.Text=="" || txt_password_Thuan.Text=="")
            //{
                
                
                
                
            //    err_msb_Thuan.Text = "Please fill the form !";
            //}
            //else
            //{
            //    MessageBox.Show("hello");
            //}
            //SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-EKU6PE0;Initial Catalog=Nhom5_QLKS;Integrated Security=True");
            try
            {


                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                string tk = txt_username_Thuan.Text;
                string mk = txt_password_Thuan.Text;

                if (tk == "")
                {
                    user_err_Thuan.Visible = true;
                    user_err_Thuan.Text = "!";
                    err_msb_Thuan.Text = "Vui Lòng Nhập Tên Tài Khoản !";
                    txt_username_Thuan.Focus();
                }
                else if (mk == "")
                {
                    password_err_Thuan.Visible = true;
                    password_err_Thuan.Text = "!";
                    err_msb_Thuan.Text = "Vui Lòng Nhập Mật Khẩu !";
                    txt_password_Thuan.Focus();
                }
                else
                {
                    /*string sql = "select * from TaiKhoan where user_name = '" + tk + "'and pass_word = '" + mk + "' ";
                     SqlDataAdapter da = new SqlDataAdapter(sql, con);
                     DataTable dt = new DataTable();
                     da.Fill(dt);
                    */
                    //if (dt.Rows.Count > 0)
                    string sql1 = "select * from TaiKhoan where user_name = '" + tk + "'and pass_word = '" + mk + "' ";
                    ///string sql12 = "select TaiKhoan.user_name,TaiKhoan.pass_word,TaiKhoan.user_au,nhanvien.hoTen from TaiKhoan,nhanvien where TaiKhoan.user_name='"+tk+"'and TaiKhoan.pass_word='"+mk+"' and nhanvien.user_name='"+tk+"'";
                    SqlCommand cmd = new SqlCommand(sql1, con);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read() == true)
                    {
                        phanquyen.quyen = dr["user_au"].ToString();
                        //phanquyen.ten = dr["hoTen"].ToString();
                        phanquyen.user_name = dr["user_name"].ToString();
                        MessageBox.Show("Đăng Nhập Thành Công ", "Thông Báo !!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Menu_Thuan f = new Menu_Thuan();
                        f.Show();
                        this.Hide();




                        //MessageBox.Show("Ban Nhap : " + phanquyen.quyen);


                        //DataTable dt1 = new DataTable();
                        //da1.Fill(dt1);

                        //db.Login_user(txtTK.Text, txtMK.Text);
                        //this.Hide();


                    }
                    else
                    {
                        err_msb_Thuan.Text = "Tên Tài Khoản \r\nHoặc Mật Khẩu Không Chính Xác !";
                    }

                    /*
                    SqlCommand cmd = new SqlCommand(sql, con);
                    SqlDataReader sdr = cmd.ExecuteReader(); 
                    if(sdr.Read()==true)
                    {
                        Dangki f = new Dangki();
                        f.Show();
                    }
                    */
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Kết Nối !!!", "Thông Báo");
            }
            con.Close();
        }

        private void txt_username_Thuan_TextChanged(object sender, EventArgs e)
        {
            //if(txt_username_Thuan.Text=="")
            //{
            //    user_err_Thuan.Visible = true;
            //    err_msb_Thuan.Text = "Please enter your account name !";
            //}
        }

        private void txt_password_Thuan_TextChanged(object sender, EventArgs e)
        {
            //if (txt_password_Thuan.Text == "")
            //{
            //    password_err_Thuan.Visible = true;
            //    err_msb_Thuan.Text = "Please enter your password !";
            //}
        }

        private void picturemx_Thuan_Click(object sender, EventArgs e)
        {
            if(WindowState==FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }
        //[DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        //private extern static void ReleaseCapture();
        //private void panel3_MouseDown(object sender, MouseEventArgs e)
        //{
        //    ReleaseCapture();

        //}
    }
}
