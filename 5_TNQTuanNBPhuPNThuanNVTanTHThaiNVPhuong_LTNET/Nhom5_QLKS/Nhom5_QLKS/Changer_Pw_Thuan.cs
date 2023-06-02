using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom5_QLKS
{
    public partial class Changer_Pw_Thuan : Form
    {
        public Changer_Pw_Thuan()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["kn"].ConnectionString);
        private void doimatkhau_Thuan_Load(object sender, EventArgs e)
        {
            txtCurPass_Thuan.UseSystemPasswordChar = true;
            txtNewPass_Thuan.UseSystemPasswordChar = true;
            txtConfPass_Thuan.UseSystemPasswordChar = true;
            txtTK_Thuan.Text = phanquyen.user_name;
            
        }

        private void chkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPass.Checked)
            {
                txtCurPass_Thuan.UseSystemPasswordChar = false;
                txtNewPass_Thuan.UseSystemPasswordChar = false;
                txtConfPass_Thuan.UseSystemPasswordChar = false;
            }
            else
            {
                txtCurPass_Thuan.UseSystemPasswordChar = true;
                txtNewPass_Thuan.UseSystemPasswordChar = true;
                txtConfPass_Thuan.UseSystemPasswordChar = true;
            }
        }
        public bool Checkaccount(string ac)
        {

            return Regex.IsMatch(ac, "^[a-zA-Z0-9]{3,10}$");
        }
        public void reset()
        {
            txtCurPass_Thuan.Text = "";
            txtNewPass_Thuan.Text = "";
            txtConfPass_Thuan.Text = "";
        }
        private void btndmk_Thuan_Click(object sender, EventArgs e)
        {
            try
            {
                string user = txtTK_Thuan.Text;
                string curPass = txtCurPass_Thuan.Text;
                string newPass = txtNewPass_Thuan.Text;
                string confPass = txtConfPass_Thuan.Text;
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }


                //string CurPass = txtCurPass_Thuan.Text;

               

                else
                {
                    
                     if (curPass == "")
                    {
                        MessageBox.Show("Bạn Chưa Nhập Mật Khẩu", "Thông Báo!! ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtCurPass_Thuan.Focus();
                    }
                    else if (newPass == "")
                    {
                        MessageBox.Show("Bạn Chưa Nhập Mật Khẩu Mới !!", "Thông Báo !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtNewPass_Thuan.Focus();
                    }
                    else if(confPass == "")
                    {
                        MessageBox.Show("Bạn Chưa Nhập Lại Mật Khẩu Mới !!", "Thông Báo !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtConfPass_Thuan.Focus();
                    }
                    else if(curPass == newPass )
                    {
                        MessageBox.Show("Mật Khẩu Mới và Mật Khẩu cũ phải khác nhau !!", "Thông Báo!! ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        
                    }
                     else if(confPass != newPass)
                    {
                        MessageBox.Show("Bạn Phải Nhập 2 mật khẩu mới giống nhau !!", "Thông Báo!! ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    else
                    {
                       string sql = "select * from TaiKhoan where user_name = '" + user + "'and pass_word = '" + curPass + "' ";
                        //SqlCommand cmd = new SqlCommand(sql, con);

                        SqlDataAdapter da = new SqlDataAdapter(sql, con);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        if (dt.Rows.Count > 0)
                        {

                            string sql1 = "update TaiKhoan set pass_word=@pass_word where user_name= '" + user + "'";
                            SqlCommand cmd1 = new SqlCommand(sql1, con);
                            cmd1.Parameters.AddWithValue("@pass_word", newPass);
                            if (cmd1.ExecuteNonQuery() > 0)
                            {
                                MessageBox.Show("Thay Đổi Mật Khẩu Thành Công", "Thông Báo !!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                reset();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Mật Khẩu Cũ Không Chính Xác !!!");
                        }
                        
                    } 
                        
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi");
            }
        }

      

        
    }
}
