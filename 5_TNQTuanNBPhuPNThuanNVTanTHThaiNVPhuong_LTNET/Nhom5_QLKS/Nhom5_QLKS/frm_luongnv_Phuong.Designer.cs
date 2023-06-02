
namespace Nhom5_QLKS
{
    partial class frm_luongnv_Phuong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.text_phuong = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bt_quaylai_phuong = new System.Windows.Forms.Button();
            this.tb_soNgayLam_phuong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bt_exit_phuong = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_search_phuong = new System.Windows.Forms.TextBox();
            this.bt_search_phuong = new System.Windows.Forms.Button();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.bt_sua = new System.Windows.Forms.Button();
            this.tb_nameCV_phuong = new System.Windows.Forms.TextBox();
            this.bt_them = new System.Windows.Forms.Button();
            this.tb_nameStaff_phuong = new System.Windows.Forms.TextBox();
            this.cb_idCV_phuong = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_idStaff_phuong = new System.Windows.Forms.ComboBox();
            this.label_nameStaff_phuong = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_luong_phuong = new System.Windows.Forms.TextBox();
            this.tb_phieuluong = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_luong_phuong = new System.Windows.Forms.DataGridView();
            this.phieuLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenCV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soNgayLam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.luongTheoCaMotNgay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.luongnv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_luong_phuong)).BeginInit();
            this.SuspendLayout();
            // 
            // text_phuong
            // 
            this.text_phuong.AutoSize = true;
            this.text_phuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_phuong.Location = new System.Drawing.Point(298, 0);
            this.text_phuong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.text_phuong.Name = "text_phuong";
            this.text_phuong.Size = new System.Drawing.Size(187, 26);
            this.text_phuong.TabIndex = 0;
            this.text_phuong.Text = "Lương nhân viên";
            this.text_phuong.Click += new System.EventHandler(this.text_phuong_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SkyBlue;
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.dgv_luong_phuong);
            this.groupBox1.Location = new System.Drawing.Point(8, 26);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(761, 525);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lương của nhân viên";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.SkyBlue;
            this.groupBox2.Controls.Add(this.bt_quaylai_phuong);
            this.groupBox2.Controls.Add(this.tb_soNgayLam_phuong);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.bt_exit_phuong);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tb_search_phuong);
            this.groupBox2.Controls.Add(this.bt_search_phuong);
            this.groupBox2.Controls.Add(this.bt_xoa);
            this.groupBox2.Controls.Add(this.bt_sua);
            this.groupBox2.Controls.Add(this.tb_nameCV_phuong);
            this.groupBox2.Controls.Add(this.bt_them);
            this.groupBox2.Controls.Add(this.tb_nameStaff_phuong);
            this.groupBox2.Controls.Add(this.cb_idCV_phuong);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cb_idStaff_phuong);
            this.groupBox2.Controls.Add(this.label_nameStaff_phuong);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tb_luong_phuong);
            this.groupBox2.Controls.Add(this.tb_phieuluong);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.groupBox2.Location = new System.Drawing.Point(8, 245);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(749, 276);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tính lương";
            // 
            // bt_quaylai_phuong
            // 
            this.bt_quaylai_phuong.BackColor = System.Drawing.Color.White;
            this.bt_quaylai_phuong.Image = global::Nhom5_QLKS.Properties.Resources.load;
            this.bt_quaylai_phuong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_quaylai_phuong.Location = new System.Drawing.Point(515, 16);
            this.bt_quaylai_phuong.Margin = new System.Windows.Forms.Padding(2);
            this.bt_quaylai_phuong.Name = "bt_quaylai_phuong";
            this.bt_quaylai_phuong.Size = new System.Drawing.Size(109, 47);
            this.bt_quaylai_phuong.TabIndex = 38;
            this.bt_quaylai_phuong.Text = "Quay lại";
            this.bt_quaylai_phuong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_quaylai_phuong.UseVisualStyleBackColor = false;
            this.bt_quaylai_phuong.Click += new System.EventHandler(this.bt_quaylai_phuong_Click);
            // 
            // tb_soNgayLam_phuong
            // 
            this.tb_soNgayLam_phuong.Location = new System.Drawing.Point(462, 85);
            this.tb_soNgayLam_phuong.Margin = new System.Windows.Forms.Padding(2);
            this.tb_soNgayLam_phuong.Name = "tb_soNgayLam_phuong";
            this.tb_soNgayLam_phuong.Size = new System.Drawing.Size(228, 24);
            this.tb_soNgayLam_phuong.TabIndex = 37;
            this.tb_soNgayLam_phuong.TextChanged += new System.EventHandler(this.tb_soNgayLam_phuong_TextChanged);
            this.tb_soNgayLam_phuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_soNgayLam_phuong_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(354, 87);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 18);
            this.label5.TabIndex = 36;
            this.label5.Text = "Số ngày làm";
            // 
            // bt_exit_phuong
            // 
            this.bt_exit_phuong.BackColor = System.Drawing.Color.White;
            this.bt_exit_phuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_exit_phuong.Image = global::Nhom5_QLKS.Properties.Resources.x;
            this.bt_exit_phuong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_exit_phuong.Location = new System.Drawing.Point(604, 210);
            this.bt_exit_phuong.Margin = new System.Windows.Forms.Padding(2);
            this.bt_exit_phuong.Name = "bt_exit_phuong";
            this.bt_exit_phuong.Size = new System.Drawing.Size(109, 47);
            this.bt_exit_phuong.TabIndex = 35;
            this.bt_exit_phuong.Text = "Thoát";
            this.bt_exit_phuong.UseVisualStyleBackColor = false;
            this.bt_exit_phuong.Click += new System.EventHandler(this.bt_exit_phuong_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(354, 156);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 18);
            this.label7.TabIndex = 34;
            this.label7.Text = "Tên chức vụ";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // tb_search_phuong
            // 
            this.tb_search_phuong.Location = new System.Drawing.Point(151, 27);
            this.tb_search_phuong.Margin = new System.Windows.Forms.Padding(2);
            this.tb_search_phuong.Name = "tb_search_phuong";
            this.tb_search_phuong.Size = new System.Drawing.Size(318, 24);
            this.tb_search_phuong.TabIndex = 6;
            this.tb_search_phuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_search_phuong_KeyPress);
            // 
            // bt_search_phuong
            // 
            this.bt_search_phuong.BackColor = System.Drawing.Color.White;
            this.bt_search_phuong.Image = global::Nhom5_QLKS.Properties.Resources.search_button_green_icon;
            this.bt_search_phuong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_search_phuong.Location = new System.Drawing.Point(11, 19);
            this.bt_search_phuong.Margin = new System.Windows.Forms.Padding(2);
            this.bt_search_phuong.Name = "bt_search_phuong";
            this.bt_search_phuong.Size = new System.Drawing.Size(109, 47);
            this.bt_search_phuong.TabIndex = 5;
            this.bt_search_phuong.Text = "Search";
            this.bt_search_phuong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_search_phuong.UseVisualStyleBackColor = false;
            this.bt_search_phuong.Click += new System.EventHandler(this.bt_search_phuong_Click);
            // 
            // bt_xoa
            // 
            this.bt_xoa.BackColor = System.Drawing.Color.White;
            this.bt_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_xoa.Image = global::Nhom5_QLKS.Properties.Resources.Button_Delete_icon;
            this.bt_xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_xoa.Location = new System.Drawing.Point(409, 210);
            this.bt_xoa.Margin = new System.Windows.Forms.Padding(2);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(109, 47);
            this.bt_xoa.TabIndex = 4;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.UseVisualStyleBackColor = false;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // bt_sua
            // 
            this.bt_sua.BackColor = System.Drawing.Color.White;
            this.bt_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_sua.Image = global::Nhom5_QLKS.Properties.Resources.update_icon;
            this.bt_sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_sua.Location = new System.Drawing.Point(212, 210);
            this.bt_sua.Margin = new System.Windows.Forms.Padding(2);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(109, 47);
            this.bt_sua.TabIndex = 3;
            this.bt_sua.Text = "Sửa";
            this.bt_sua.UseVisualStyleBackColor = false;
            this.bt_sua.Click += new System.EventHandler(this.bt_sua_Click);
            // 
            // tb_nameCV_phuong
            // 
            this.tb_nameCV_phuong.Enabled = false;
            this.tb_nameCV_phuong.Location = new System.Drawing.Point(462, 154);
            this.tb_nameCV_phuong.Margin = new System.Windows.Forms.Padding(2);
            this.tb_nameCV_phuong.Name = "tb_nameCV_phuong";
            this.tb_nameCV_phuong.Size = new System.Drawing.Size(228, 24);
            this.tb_nameCV_phuong.TabIndex = 33;
            // 
            // bt_them
            // 
            this.bt_them.BackColor = System.Drawing.Color.White;
            this.bt_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_them.Image = global::Nhom5_QLKS.Properties.Resources.Button_Add_icon;
            this.bt_them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_them.Location = new System.Drawing.Point(22, 210);
            this.bt_them.Margin = new System.Windows.Forms.Padding(2);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(109, 47);
            this.bt_them.TabIndex = 2;
            this.bt_them.Text = "    Thêm";
            this.bt_them.UseVisualStyleBackColor = false;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // tb_nameStaff_phuong
            // 
            this.tb_nameStaff_phuong.Enabled = false;
            this.tb_nameStaff_phuong.Location = new System.Drawing.Point(140, 135);
            this.tb_nameStaff_phuong.Margin = new System.Windows.Forms.Padding(2);
            this.tb_nameStaff_phuong.Name = "tb_nameStaff_phuong";
            this.tb_nameStaff_phuong.Size = new System.Drawing.Size(195, 24);
            this.tb_nameStaff_phuong.TabIndex = 32;
            // 
            // cb_idCV_phuong
            // 
            this.cb_idCV_phuong.FormattingEnabled = true;
            this.cb_idCV_phuong.Location = new System.Drawing.Point(462, 121);
            this.cb_idCV_phuong.Margin = new System.Windows.Forms.Padding(2);
            this.cb_idCV_phuong.Name = "cb_idCV_phuong";
            this.cb_idCV_phuong.Size = new System.Drawing.Size(228, 26);
            this.cb_idCV_phuong.TabIndex = 31;
            this.cb_idCV_phuong.SelectedIndexChanged += new System.EventHandler(this.cb_idCV_phuong_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(354, 123);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 18);
            this.label4.TabIndex = 30;
            this.label4.Text = "Mã chức vụ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // cb_idStaff_phuong
            // 
            this.cb_idStaff_phuong.FormattingEnabled = true;
            this.cb_idStaff_phuong.Location = new System.Drawing.Point(140, 104);
            this.cb_idStaff_phuong.Margin = new System.Windows.Forms.Padding(2);
            this.cb_idStaff_phuong.Name = "cb_idStaff_phuong";
            this.cb_idStaff_phuong.Size = new System.Drawing.Size(195, 26);
            this.cb_idStaff_phuong.TabIndex = 28;
            this.cb_idStaff_phuong.SelectedIndexChanged += new System.EventHandler(this.cb_idStaff_phuong_SelectedIndexChanged);
            // 
            // label_nameStaff_phuong
            // 
            this.label_nameStaff_phuong.AutoSize = true;
            this.label_nameStaff_phuong.Location = new System.Drawing.Point(24, 137);
            this.label_nameStaff_phuong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_nameStaff_phuong.Name = "label_nameStaff_phuong";
            this.label_nameStaff_phuong.Size = new System.Drawing.Size(117, 18);
            this.label_nameStaff_phuong.TabIndex = 27;
            this.label_nameStaff_phuong.Text = "Tên nhân viên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 106);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 18);
            this.label3.TabIndex = 26;
            this.label3.Text = "Mã nhân viên";
            // 
            // tb_luong_phuong
            // 
            this.tb_luong_phuong.Location = new System.Drawing.Point(140, 165);
            this.tb_luong_phuong.Margin = new System.Windows.Forms.Padding(2);
            this.tb_luong_phuong.Name = "tb_luong_phuong";
            this.tb_luong_phuong.Size = new System.Drawing.Size(195, 24);
            this.tb_luong_phuong.TabIndex = 23;
            // 
            // tb_phieuluong
            // 
            this.tb_phieuluong.Location = new System.Drawing.Point(140, 66);
            this.tb_phieuluong.Margin = new System.Windows.Forms.Padding(2);
            this.tb_phieuluong.Name = "tb_phieuluong";
            this.tb_phieuluong.Size = new System.Drawing.Size(195, 24);
            this.tb_phieuluong.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 165);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 18);
            this.label6.TabIndex = 15;
            this.label6.Text = "Lương";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "Phiếu lương";
            // 
            // dgv_luong_phuong
            // 
            this.dgv_luong_phuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_luong_phuong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.phieuLuong,
            this.maNV,
            this.hoTen,
            this.tenCV,
            this.soNgayLam,
            this.luongTheoCaMotNgay,
            this.luongnv});
            this.dgv_luong_phuong.Location = new System.Drawing.Point(0, 16);
            this.dgv_luong_phuong.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_luong_phuong.Name = "dgv_luong_phuong";
            this.dgv_luong_phuong.RowTemplate.Height = 28;
            this.dgv_luong_phuong.Size = new System.Drawing.Size(765, 219);
            this.dgv_luong_phuong.TabIndex = 0;
            this.dgv_luong_phuong.SelectionChanged += new System.EventHandler(this.dgv_luong_phuong_SelectionChanged);
            // 
            // phieuLuong
            // 
            this.phieuLuong.DataPropertyName = "phieuLuong";
            this.phieuLuong.HeaderText = "Phiếu lương";
            this.phieuLuong.Name = "phieuLuong";
            // 
            // maNV
            // 
            this.maNV.DataPropertyName = "maNV";
            this.maNV.HeaderText = "Mã nhân viên";
            this.maNV.Name = "maNV";
            // 
            // hoTen
            // 
            this.hoTen.DataPropertyName = "hoTen";
            this.hoTen.HeaderText = "Họ tên";
            this.hoTen.Name = "hoTen";
            // 
            // tenCV
            // 
            this.tenCV.DataPropertyName = "tenCV";
            this.tenCV.HeaderText = "Tên chức vụ";
            this.tenCV.Name = "tenCV";
            // 
            // soNgayLam
            // 
            this.soNgayLam.DataPropertyName = "soNgayLam";
            this.soNgayLam.HeaderText = "Số ngày làm";
            this.soNgayLam.Name = "soNgayLam";
            // 
            // luongTheoCaMotNgay
            // 
            this.luongTheoCaMotNgay.DataPropertyName = "luongTheoCa1Ngay";
            this.luongTheoCaMotNgay.HeaderText = "Lương theo ca một ngày";
            this.luongTheoCaMotNgay.Name = "luongTheoCaMotNgay";
            // 
            // luongnv
            // 
            this.luongnv.DataPropertyName = "Luong";
            this.luongnv.HeaderText = "Lương";
            this.luongnv.Name = "luongnv";
            // 
            // frm_luongnv_Phuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(784, 547);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.text_phuong);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_luongnv_Phuong";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frm_luongnv_Phuong_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_luong_phuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label text_phuong;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_luong_phuong;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tb_phieuluong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_luong_phuong;
        private System.Windows.Forms.ComboBox cb_idCV_phuong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_idStaff_phuong;
        private System.Windows.Forms.Label label_nameStaff_phuong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_nameStaff_phuong;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_nameCV_phuong;
        private System.Windows.Forms.Button bt_search_phuong;
        private System.Windows.Forms.TextBox tb_search_phuong;
        private System.Windows.Forms.Button bt_exit_phuong;
        private System.Windows.Forms.TextBox tb_soNgayLam_phuong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bt_quaylai_phuong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn phieuLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenCV;
        private System.Windows.Forms.DataGridViewTextBoxColumn soNgayLam;
        private System.Windows.Forms.DataGridViewTextBoxColumn luongTheoCaMotNgay;
        private System.Windows.Forms.DataGridViewTextBoxColumn luongnv;
    }
}