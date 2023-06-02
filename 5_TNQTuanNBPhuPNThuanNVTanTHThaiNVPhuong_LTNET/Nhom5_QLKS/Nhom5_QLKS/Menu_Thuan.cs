using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom5_QLKS
{
    public partial class Menu_Thuan : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        public Menu_Thuan()
        {
            InitializeComponent();
            random = new Random();
        }
        private Color SelectThemColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while(tempIndex==index)
            {
               index= random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        private void ActivateButton(object btnSender)
        {
            if(btnSender != null)
            {
                if(currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font= new System.Drawing.Font("Times New Roman", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    
                }
            }
        }
        private void DisableButton()
        {
            foreach(Control previouBtn in panel_Menu.Controls)
            { 
                if(previouBtn.GetType()== typeof(Button))
                {
                    previouBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previouBtn.ForeColor = Color.Gainsboro;
                    previouBtn.Font = new System.Drawing.Font("Times New Roman", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void OpenChildForm(Form childForm , object btnSender)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lb_title_Thuan.Text = childForm.Text;
        }
        private void btn_QLTK_Thuan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form1(), sender);
            //btn_changePw_Thuan.Visible = true;
            ActivateButton(sender);
            panel_Optionn.Visible = true;
            btn_ChagePW_Thuan.Visible = true;
            
            btn_Logout_Thuan.Visible = true;
            btn_DT_Thuan.Visible = false;
            btn_TKLNV_Thuan.Visible = false;
            btn_LP_Thuan.Visible = false;
            btn_DSP_Thuan.Visible = false;

        }

        private void btn_QLKH_Thuan_Click(object sender, EventArgs e)
        {
            frm_QLKH_tan f = new frm_QLKH_tan();
            f.Show();
        }

        private void btn_logo_Thuan_Click(object sender, EventArgs e)
        {
            //OpenChildForm( Menu_Thuan(), sender);
            this.Hide();
            Menu_Thuan f = new Menu_Thuan();
            f.Show();
        }

        private void Menu_Thuan_Load(object sender, EventArgs e)
        {
            switch (phanquyen.quyen)
            {
                case "Admin":
                    btn_QLTKK_Thuan.Visible = true;
                    btn_NhanVien_Thuan.Visible = true;
                    bt_luong_thuan.Visible = true;
                    break;
            }

        }

        private void btn_changePw_Thuan_Click(object sender, EventArgs e)
        {

            
            //btn_changePw_Thuan.Visible = false;

        }

       

        

        private void btn_ChagePW_Thuan_Click(object sender, EventArgs e)
        {
            panel_Optionn.Visible = false;
            OpenChildForm(new Changer_Pw_Thuan(), sender);
        }

        private void btn_QLTKK_Thuan_Click(object sender, EventArgs e)
        {
            panel_Optionn.Visible = false;
            OpenChildForm(new QLTK_Thuan(), sender);
        }

        private void btn_Logout_Thuan_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_Thuan f = new Login_Thuan();
            f.Show();
        }

        private void btn_TKe_Thuan_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new Form1(), sender);
            panel_Optionn.Visible = true;
            btn_DT_Thuan.Visible = true;
            btn_TKLNV_Thuan.Visible = true;
            btn_ChagePW_Thuan.Visible = false;
            btn_Logout_Thuan.Visible = false;
            btn_QLTKK_Thuan.Visible = false;
            btn_LP_Thuan.Visible = false;
            btn_DSP_Thuan.Visible = false;
        }

        private void btn_Phong_Thuan_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new Form1(), sender);
            panel_Optionn.Visible = true;
            btn_DT_Thuan.Visible = false;
            btn_TKLNV_Thuan.Visible = false;
            btn_ChagePW_Thuan.Visible = false;
            btn_Logout_Thuan.Visible = false;
            btn_QLTKK_Thuan.Visible = false;
            btn_DSP_Thuan.Visible = true;
            btn_LP_Thuan.Visible=true;
        }

        private void btn_DV_Thuan_Click(object sender, EventArgs e)
        {
            frm_dichvu_thai f = new frm_dichvu_thai();
            f.Show();
        }

        private void btn_NhanVien_Thuan_Click(object sender, EventArgs e)
        {
            frm_QLNV_tan f = new frm_QLNV_tan();
            f.Show();
        }

        private void btn_DP_Thuan_Click(object sender, EventArgs e)
        {
            frm_ThuePhong_Tuan f = new frm_ThuePhong_Tuan();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm__ThanhToan_tuan f = new frm__ThanhToan_tuan();
            f.Show();
        }

        private void btn_LP_Thuan_Click(object sender, EventArgs e)
        {
            frm_loaiphong_phu f = new frm_loaiphong_phu();
            f.Show();
        }

        private void btn_DT_Thuan_Click(object sender, EventArgs e)
        {
            frm_baocaohoadon1_phu f = new frm_baocaohoadon1_phu();
            f.Show();
        }

        private void btn_DSP_Thuan_Click(object sender, EventArgs e)
        {
            frm_Phong_Phu f = new frm_Phong_Phu();
            f.Show();
        }

        private void btn_TKLNV_Thuan_Click(object sender, EventArgs e)
        {
            Baocaoluong_Phu f = new Baocaoluong_Phu();
            f.Show();
        }

        private void bt_luong_thuan_Click(object sender, EventArgs e)
        {
            frm_luongnv_Phuong f = new frm_luongnv_Phuong();
            f.Show();
        }
    }
}
