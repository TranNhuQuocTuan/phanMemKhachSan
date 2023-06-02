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
using System.Data;
using System.Text.RegularExpressions;
using System.Configuration;
namespace Nhom5_QLKS
{
    public partial class QLTK_Thuan : Form
    {
        public QLTK_Thuan()
        {
            InitializeComponent();
        }
        //AccsesDataBase db = new AccsesDataBase();
         SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["kn"].ConnectionString);
        private void DangKy_NhuThuan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nhom5_QLKSDataSet.TaiKhoan' table. You can move, or remove it, as needed.
            // this.taiKhoanTableAdapter.Fill(this.nhom5_QLKSDataSet.TaiKhoan);

            //con = new SqlConnection(@"Data Source=DESKTOP-EKU6PE0;Initial Catalog=Nhom5_QLKS;Integrated Security=True");
            //SqlDataAdapter da = new SqlDataAdapter("select * from TaiKhoan",con);
            // DataTable dt = new DataTable();
            // da.Fill(dt);
            // drv_Taikhoan_Thuan.DataSource = dt;
             // cbb_LND_Thuan.DataSource = dt;
             //cbb_LND_Thuan.DisplayMember = "user_au";
            
            loadform();
            //cbb_LND_Thuan.Items.Add("Admin");
            //cbb_LND_Thuan.Items.Add("Nhân Viên");
        }
       public void loadform()
        {

            //con = new SqlConnection(@"Data Source=DESKTOP-EKU6PE0;Initial Catalog=Nhom5_QLKS;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter("select * from TaiKhoan", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            drv_Taikhoan_Thuan.DataSource = dt;
            cbb_LND_Thuan.Items.Add("Admin");
            cbb_LND_Thuan.Items.Add("Nhân Viên");
            
            //drv_Taikhoan_Thuan.DataSource= db.User_name();
        }
       
        public bool Checkaccount(string ac )
        {

            return Regex.IsMatch(ac,"^[a-zA-Z0-9]{3,10}$");
        }
       
        public void reset()
        {
            //txt_HT_Thuan.Clear();
            //txt_MK1_Thuan.Clear();
            //txt_MK2_Thuan.Clear();
            txt_TenTK_Thuan.Clear();
        }
       
            private void btn_DK_Thuan_Click(object sender, EventArgs e)
        {
            
            try
            {
                if(con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                
                string matkhau1 = "12345";
                //string matkhau2 = txt_MK2_Thuan.Text;
                string tentk = txt_TenTK_Thuan.Text;
                //string hoten = txt_HT_Thuan.Text;
                if (!Checkaccount(tentk))
                {
                    MessageBox.Show(" Nhập Tên Tài Khoản Từ 3-10 Ký Tự Và Không Có ký Tự Đặc biệt !!", "Thông Báo");
                    return;
                }
                //else
                //{
                    //if (matkhau1 == "")
                    //{
                    //    MessageBox.Show("Bạn Chưa Nhập Mật Khẩu", "Thông Báo !");
                    //    txt_MK1_Thuan.Focus();
                    //}   
                        
                    //else if (matkhau2 == "")
                    //{
                    //    MessageBox.Show("Bạn Chưa Nhập Lại Mật Khẩu", "Thông Báo");
                    //    txt_MK2_Thuan.Focus();
                    //}
                    //else if (matkhau1 != matkhau2)
                    //{
                    //    MessageBox.Show("Bạn Phải Nhập 2 mật khẩu giống nhau ! ", "Thông Báo !!! ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //}
                    //else if (hoten == "")
                    //{
                    //    MessageBox.Show("Bạn Nhập Họ Tên Tài Khoản", "Thông Báo");
                    //    txt_HT_Thuan.Focus();
                    //}
                    
                    
                    
                    else
                    {
                        
                        
                        SqlCommand cmd = new SqlCommand("insert into TaiKhoan(user_name,pass_word,user_au) values(@user_name,@pass_word,@user_au) ", con);
                        cmd.Parameters.AddWithValue("@user_name", txt_TenTK_Thuan.Text);
                        cmd.Parameters.AddWithValue("@pass_word", matkhau1);
                        //cmd.Parameters.AddWithValue("@name_user", txt_HT_Thuan.Text);
                        cmd.Parameters.AddWithValue("@user_au", cbb_LND_Thuan.Text);
                        
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            phanquyen.user_name1 = txt_TenTK_Thuan.Text;
                            MessageBox.Show("Thêm Thành Công", "Thông Báo !!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        
                        //DangKy_NhuThuan_Load(sender, e);
                        
                       // db.insert_User(txt_TenTK_Thuan.Text, txt_MK1_Thuan.Text, txt_HT_Thuan.Text, cbb_LND_Thuan.Text);
                        loadform();
                        reset();
                    }
               // }
            }
             catch(Exception ex)
            {
                MessageBox.Show("Thêm Không Thành Công , Tên Tài Khoản Đã tồn Tại", "Thông Báo !!");
                txt_TenTK_Thuan.Focus();
            } 
                
           

        }

        private void btn_sua_Thuan_Click(object sender, EventArgs e)
        {
            try
            {
                
                //string matkhau1 = txt_MK1_Thuan.Text;
                //string matkhau2 = txt_MK2_Thuan.Text;
                string tentk = txt_TenTK_Thuan.Text;
                //string hoten = txt_HT_Thuan.Text;
                if (!Checkaccount(tentk))
                {
                    MessageBox.Show(" Nhập Tên Tài Khoản Từ 3-10 Ký Tự Và Không Có ký Tự Đặc biệt !!", "Thông Báo");
                    return;
                }
                //else
                //{

                    //if (matkhau1 == "")
                    //{
                    //    MessageBox.Show("Bạn Chưa Nhập Mật Khẩu", "Thông Báo !");
                    //    txt_MK1_Thuan.Focus();
                    //}

                    //else if (matkhau2 == "")
                    //{
                    //    MessageBox.Show("Bạn Chưa Nhập Lại Mật Khẩu", "Thông Báo");
                    //    txt_MK2_Thuan.Focus();
                    //}
                    //else if (matkhau1 != matkhau2)
                    //{
                    //    MessageBox.Show("Bạn Phải Nhập 2 mật khẩu giống nhau ! ", "Thông Báo !!! ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //}
                    //else if (hoten == "")
                    //{
                    //    MessageBox.Show("Bạn Nhập Họ Tên Tài Khoản", "Thông Báo");
                    //    //txt_HT_Thuan.Focus();
                    //}
                    else
                    {
                         int dongchon = drv_Taikhoan_Thuan.CurrentCell.RowIndex;
                         SqlCommand cmd = new SqlCommand("update TaiKhoan set user_name=@user_name,pass_word=@pass_word,name_user=@name_user,user_au=@user_au where user_name=@user_name_cu  ", con);
                         cmd.Parameters.AddWithValue("@user_name", txt_TenTK_Thuan.Text.Trim());
                        // cmd.Parameters.AddWithValue("@pass_word", txt_MK1_Thuan.Text);
                         //cmd.Parameters.AddWithValue("@name_user", txt_HT_Thuan.Text);
                         cmd.Parameters.AddWithValue("@user_au", cbb_LND_Thuan.Text);
                         cmd.Parameters.AddWithValue("user_name_cu", drv_Taikhoan_Thuan.Rows[dongchon].Cells["user_name"].Value.ToString());
                         if (cmd.ExecuteNonQuery() > 0)
                         {
                             MessageBox.Show("Sửa Thành Công", "Thông Báo !!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                             DangKy_NhuThuan_Load(sender, e);
                         }
                        //db.update_User(txt_TenTK_Thuan.Text,txt_MK1_Thuan.Text, txt_HT_Thuan.Text, cbb_LND_Thuan.Text, txt_TenTK_Thuan.Text);
                        loadform();
                        reset();
                    }
                    
                //}
            }
            catch(Exception ex)
            {
                MessageBox.Show("Sửa Không Thành Công , Tên Tài Khoản Đã tồn Tại","Thông Báo !!");

            }
        }
        /*
        public void delete()
        {
            int dongchon = drv_Taikhoan_Thuan.CurrentCell.RowIndex;
             SqlCommand cmd = new SqlCommand("Delete FROM TaiKhoan where user_name=@user_name", con);
             cmd.Parameters.AddWithValue("@user_name", txt_TenTK_Thuan.Text);
             if (cmd.ExecuteNonQuery() > 0)
             {
                 MessageBox.Show("Xóa Thành Công", "Thông Báo !!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 loadform();
             }
             
            
        }
        */
        private void btn_Xoa_Thuan_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                else
                {
                    //db.delete_User(txt_TenTK_Thuan.Text);
                    string sqlDelete = "Delete FROM TaiKhoan where user_name=@user_name";
                    SqlCommand cmd = new SqlCommand(sqlDelete, con);
                    cmd.Parameters.AddWithValue("@user_name", txt_TenTK_Thuan.Text);
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Xóa Thành Công", "Thông Báo !!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    loadform();

                    reset();
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Không Thành Công Do NHân Viên Vẫn Còn Sử Dụng Tài Khoản Này", "Thông Báo !!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
       
        private void btn_Thoat_Thuan_Click(object sender, EventArgs e)
        {
            //Menu_NhuThuan f = new Menu_NhuThuan();
            //this.Hide();
            //f.ShowDialog();
            //this.Show();
            
        }
       
      

       

        

        

        private void drv_Taikhoan_Thuan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int dongchon = drv_Taikhoan_Thuan.CurrentCell.RowIndex;
            if (dongchon >= 0)
            {
                txt_TenTK_Thuan.Text = drv_Taikhoan_Thuan.Rows[dongchon].Cells[0].Value.ToString();
                //txt_MK1_Thuan.Text = drv_Taikhoan_Thuan.Rows[dongchon].Cells[1].Value.ToString();
                //txt_HT_Thuan.Text = drv_Taikhoan_Thuan.Rows[dongchon].Cells["name_user"].Value.ToString();
                cbb_LND_Thuan.Text = drv_Taikhoan_Thuan.Rows[dongchon].Cells[2].Value.ToString();

            }
        }

        
    }
}
