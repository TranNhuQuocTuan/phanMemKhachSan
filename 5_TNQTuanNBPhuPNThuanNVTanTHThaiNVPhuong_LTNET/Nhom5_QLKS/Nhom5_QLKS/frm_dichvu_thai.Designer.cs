
namespace Nhom5_QLKS
{
    partial class frm_dichvu_thai
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
            this.tb_search_thai = new System.Windows.Forms.TextBox();
            this.rb_tendv_thai = new System.Windows.Forms.RadioButton();
            this.rb_madv_thai = new System.Windows.Forms.RadioButton();
            this.grb_search_thai = new System.Windows.Forms.GroupBox();
            this.dgv_thai = new System.Windows.Forms.DataGridView();
            this.maDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tb_soluong_thai = new System.Windows.Forms.TextBox();
            this.tb_giadv_thai = new System.Windows.Forms.TextBox();
            this.tb_tendv_thai = new System.Windows.Forms.TextBox();
            this.tb_madv_thai = new System.Windows.Forms.TextBox();
            this.lb_loaidv_thai = new System.Windows.Forms.Label();
            this.lb_soluong_thai = new System.Windows.Forms.Label();
            this.lb_giadv_thai = new System.Windows.Forms.Label();
            this.lb_tendv_thai = new System.Windows.Forms.Label();
            this.lb_madv_thai = new System.Windows.Forms.Label();
            this.lb_dvks_thai = new System.Windows.Forms.Label();
            this.grb_thongtin_thai = new System.Windows.Forms.GroupBox();
            this.cb_loaidv_thai = new System.Windows.Forms.ComboBox();
            this.bt_thoat_thai = new System.Windows.Forms.Button();
            this.bt_rf_thai = new System.Windows.Forms.Button();
            this.btn_serach_thai = new System.Windows.Forms.Button();
            this.bt_xoa_thai = new System.Windows.Forms.Button();
            this.bt_sua_thai = new System.Windows.Forms.Button();
            this.bt_them_thai = new System.Windows.Forms.Button();
            this.grb_search_thai.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_thai)).BeginInit();
            this.grb_thongtin_thai.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_search_thai
            // 
            this.tb_search_thai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tb_search_thai.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_search_thai.Location = new System.Drawing.Point(4, 82);
            this.tb_search_thai.Margin = new System.Windows.Forms.Padding(2);
            this.tb_search_thai.Name = "tb_search_thai";
            this.tb_search_thai.Size = new System.Drawing.Size(166, 23);
            this.tb_search_thai.TabIndex = 16;
            // 
            // rb_tendv_thai
            // 
            this.rb_tendv_thai.AutoSize = true;
            this.rb_tendv_thai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_tendv_thai.Location = new System.Drawing.Point(18, 56);
            this.rb_tendv_thai.Margin = new System.Windows.Forms.Padding(2);
            this.rb_tendv_thai.Name = "rb_tendv_thai";
            this.rb_tendv_thai.Size = new System.Drawing.Size(97, 23);
            this.rb_tendv_thai.TabIndex = 2;
            this.rb_tendv_thai.TabStop = true;
            this.rb_tendv_thai.Text = "Tên dịch vụ";
            this.rb_tendv_thai.UseVisualStyleBackColor = true;
            // 
            // rb_madv_thai
            // 
            this.rb_madv_thai.AutoSize = true;
            this.rb_madv_thai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_madv_thai.Location = new System.Drawing.Point(18, 24);
            this.rb_madv_thai.Margin = new System.Windows.Forms.Padding(2);
            this.rb_madv_thai.Name = "rb_madv_thai";
            this.rb_madv_thai.Size = new System.Drawing.Size(95, 23);
            this.rb_madv_thai.TabIndex = 1;
            this.rb_madv_thai.TabStop = true;
            this.rb_madv_thai.Text = "Mã dịch vụ";
            this.rb_madv_thai.UseVisualStyleBackColor = true;
            // 
            // grb_search_thai
            // 
            this.grb_search_thai.BackColor = System.Drawing.Color.SkyBlue;
            this.grb_search_thai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.grb_search_thai.Controls.Add(this.bt_rf_thai);
            this.grb_search_thai.Controls.Add(this.tb_search_thai);
            this.grb_search_thai.Controls.Add(this.btn_serach_thai);
            this.grb_search_thai.Controls.Add(this.rb_tendv_thai);
            this.grb_search_thai.Controls.Add(this.rb_madv_thai);
            this.grb_search_thai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_search_thai.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grb_search_thai.Location = new System.Drawing.Point(412, 130);
            this.grb_search_thai.Margin = new System.Windows.Forms.Padding(2);
            this.grb_search_thai.Name = "grb_search_thai";
            this.grb_search_thai.Padding = new System.Windows.Forms.Padding(2);
            this.grb_search_thai.Size = new System.Drawing.Size(289, 116);
            this.grb_search_thai.TabIndex = 32;
            this.grb_search_thai.TabStop = false;
            this.grb_search_thai.Text = "Search";
            // 
            // dgv_thai
            // 
            this.dgv_thai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_thai.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.dgv_thai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_thai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maDV,
            this.tenDV,
            this.giaDV,
            this.soluong,
            this.loaiDV});
            this.dgv_thai.Location = new System.Drawing.Point(9, 251);
            this.dgv_thai.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_thai.Name = "dgv_thai";
            this.dgv_thai.RowHeadersWidth = 51;
            this.dgv_thai.RowTemplate.Height = 24;
            this.dgv_thai.Size = new System.Drawing.Size(698, 133);
            this.dgv_thai.TabIndex = 28;
            this.dgv_thai.SelectionChanged += new System.EventHandler(this.dgv_thai_SelectionChanged);
            // 
            // maDV
            // 
            this.maDV.DataPropertyName = "maDV";
            this.maDV.HeaderText = "Mã dịch vụ";
            this.maDV.MinimumWidth = 6;
            this.maDV.Name = "maDV";
            // 
            // tenDV
            // 
            this.tenDV.DataPropertyName = "tenDV";
            this.tenDV.HeaderText = "Tên dịch vụ";
            this.tenDV.MinimumWidth = 6;
            this.tenDV.Name = "tenDV";
            // 
            // giaDV
            // 
            this.giaDV.DataPropertyName = "giaDV";
            this.giaDV.HeaderText = "Giá dịch vụ";
            this.giaDV.MinimumWidth = 6;
            this.giaDV.Name = "giaDV";
            // 
            // soluong
            // 
            this.soluong.DataPropertyName = "soluong";
            this.soluong.HeaderText = "Số lượng";
            this.soluong.MinimumWidth = 6;
            this.soluong.Name = "soluong";
            // 
            // loaiDV
            // 
            this.loaiDV.DataPropertyName = "loaiDV";
            this.loaiDV.HeaderText = "Loại dịch vụ";
            this.loaiDV.MinimumWidth = 6;
            this.loaiDV.Name = "loaiDV";
            // 
            // tb_soluong_thai
            // 
            this.tb_soluong_thai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tb_soluong_thai.Location = new System.Drawing.Point(108, 136);
            this.tb_soluong_thai.Margin = new System.Windows.Forms.Padding(2);
            this.tb_soluong_thai.MaxLength = 4;
            this.tb_soluong_thai.Name = "tb_soluong_thai";
            this.tb_soluong_thai.Size = new System.Drawing.Size(276, 26);
            this.tb_soluong_thai.TabIndex = 26;
            this.tb_soluong_thai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_soluong_thai_KeyPress);
            // 
            // tb_giadv_thai
            // 
            this.tb_giadv_thai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tb_giadv_thai.Location = new System.Drawing.Point(108, 102);
            this.tb_giadv_thai.Margin = new System.Windows.Forms.Padding(2);
            this.tb_giadv_thai.Name = "tb_giadv_thai";
            this.tb_giadv_thai.Size = new System.Drawing.Size(276, 26);
            this.tb_giadv_thai.TabIndex = 25;
            this.tb_giadv_thai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_giadv_thai_KeyPress);
            // 
            // tb_tendv_thai
            // 
            this.tb_tendv_thai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tb_tendv_thai.Location = new System.Drawing.Point(108, 67);
            this.tb_tendv_thai.Margin = new System.Windows.Forms.Padding(2);
            this.tb_tendv_thai.Name = "tb_tendv_thai";
            this.tb_tendv_thai.Size = new System.Drawing.Size(276, 26);
            this.tb_tendv_thai.TabIndex = 24;
            this.tb_tendv_thai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_tendv_thai_KeyPress);
            // 
            // tb_madv_thai
            // 
            this.tb_madv_thai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tb_madv_thai.Location = new System.Drawing.Point(108, 31);
            this.tb_madv_thai.Margin = new System.Windows.Forms.Padding(2);
            this.tb_madv_thai.Name = "tb_madv_thai";
            this.tb_madv_thai.Size = new System.Drawing.Size(276, 26);
            this.tb_madv_thai.TabIndex = 23;
            // 
            // lb_loaidv_thai
            // 
            this.lb_loaidv_thai.AutoSize = true;
            this.lb_loaidv_thai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_loaidv_thai.Location = new System.Drawing.Point(13, 172);
            this.lb_loaidv_thai.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_loaidv_thai.Name = "lb_loaidv_thai";
            this.lb_loaidv_thai.Size = new System.Drawing.Size(90, 19);
            this.lb_loaidv_thai.TabIndex = 22;
            this.lb_loaidv_thai.Text = "Loại dịch vụ :";
            // 
            // lb_soluong_thai
            // 
            this.lb_soluong_thai.AutoSize = true;
            this.lb_soluong_thai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_soluong_thai.Location = new System.Drawing.Point(11, 139);
            this.lb_soluong_thai.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_soluong_thai.Name = "lb_soluong_thai";
            this.lb_soluong_thai.Size = new System.Drawing.Size(91, 19);
            this.lb_soluong_thai.TabIndex = 21;
            this.lb_soluong_thai.Text = "Số lượng      :";
            // 
            // lb_giadv_thai
            // 
            this.lb_giadv_thai.AutoSize = true;
            this.lb_giadv_thai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_giadv_thai.Location = new System.Drawing.Point(11, 102);
            this.lb_giadv_thai.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_giadv_thai.Name = "lb_giadv_thai";
            this.lb_giadv_thai.Size = new System.Drawing.Size(88, 19);
            this.lb_giadv_thai.TabIndex = 20;
            this.lb_giadv_thai.Text = "Giá dịch vụ  :";
            // 
            // lb_tendv_thai
            // 
            this.lb_tendv_thai.AutoSize = true;
            this.lb_tendv_thai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tendv_thai.Location = new System.Drawing.Point(11, 71);
            this.lb_tendv_thai.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_tendv_thai.Name = "lb_tendv_thai";
            this.lb_tendv_thai.Size = new System.Drawing.Size(90, 19);
            this.lb_tendv_thai.TabIndex = 19;
            this.lb_tendv_thai.Text = "Tên dịch vụ  :";
            // 
            // lb_madv_thai
            // 
            this.lb_madv_thai.AutoSize = true;
            this.lb_madv_thai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_madv_thai.Location = new System.Drawing.Point(11, 31);
            this.lb_madv_thai.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_madv_thai.Name = "lb_madv_thai";
            this.lb_madv_thai.Size = new System.Drawing.Size(92, 19);
            this.lb_madv_thai.TabIndex = 18;
            this.lb_madv_thai.Text = "Mã dịch vụ   :";
            // 
            // lb_dvks_thai
            // 
            this.lb_dvks_thai.AutoSize = true;
            this.lb_dvks_thai.BackColor = System.Drawing.Color.SkyBlue;
            this.lb_dvks_thai.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_dvks_thai.ForeColor = System.Drawing.Color.Black;
            this.lb_dvks_thai.Location = new System.Drawing.Point(268, 0);
            this.lb_dvks_thai.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_dvks_thai.Name = "lb_dvks_thai";
            this.lb_dvks_thai.Size = new System.Drawing.Size(199, 25);
            this.lb_dvks_thai.TabIndex = 17;
            this.lb_dvks_thai.Text = "Dịch Vụ Khách Sạn";
            // 
            // grb_thongtin_thai
            // 
            this.grb_thongtin_thai.BackColor = System.Drawing.Color.SkyBlue;
            this.grb_thongtin_thai.Controls.Add(this.cb_loaidv_thai);
            this.grb_thongtin_thai.Controls.Add(this.lb_madv_thai);
            this.grb_thongtin_thai.Controls.Add(this.lb_tendv_thai);
            this.grb_thongtin_thai.Controls.Add(this.lb_giadv_thai);
            this.grb_thongtin_thai.Controls.Add(this.lb_soluong_thai);
            this.grb_thongtin_thai.Controls.Add(this.lb_loaidv_thai);
            this.grb_thongtin_thai.Controls.Add(this.tb_madv_thai);
            this.grb_thongtin_thai.Controls.Add(this.tb_tendv_thai);
            this.grb_thongtin_thai.Controls.Add(this.tb_giadv_thai);
            this.grb_thongtin_thai.Controls.Add(this.tb_soluong_thai);
            this.grb_thongtin_thai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_thongtin_thai.Location = new System.Drawing.Point(10, 37);
            this.grb_thongtin_thai.Margin = new System.Windows.Forms.Padding(2);
            this.grb_thongtin_thai.Name = "grb_thongtin_thai";
            this.grb_thongtin_thai.Padding = new System.Windows.Forms.Padding(2);
            this.grb_thongtin_thai.Size = new System.Drawing.Size(398, 210);
            this.grb_thongtin_thai.TabIndex = 34;
            this.grb_thongtin_thai.TabStop = false;
            this.grb_thongtin_thai.Text = "Thông Tin";
            // 
            // cb_loaidv_thai
            // 
            this.cb_loaidv_thai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cb_loaidv_thai.FormattingEnabled = true;
            this.cb_loaidv_thai.Items.AddRange(new object[] {
            "Đồ Ăn",
            "Đồ Uống",
            "Giải Trí"});
            this.cb_loaidv_thai.Location = new System.Drawing.Point(108, 172);
            this.cb_loaidv_thai.Margin = new System.Windows.Forms.Padding(2);
            this.cb_loaidv_thai.Name = "cb_loaidv_thai";
            this.cb_loaidv_thai.Size = new System.Drawing.Size(276, 27);
            this.cb_loaidv_thai.TabIndex = 27;
            // 
            // bt_thoat_thai
            // 
            this.bt_thoat_thai.BackColor = System.Drawing.Color.White;
            this.bt_thoat_thai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_thoat_thai.ForeColor = System.Drawing.Color.Black;
            this.bt_thoat_thai.Image = global::Nhom5_QLKS.Properties.Resources.x;
            this.bt_thoat_thai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_thoat_thai.Location = new System.Drawing.Point(542, 80);
            this.bt_thoat_thai.Margin = new System.Windows.Forms.Padding(2);
            this.bt_thoat_thai.Name = "bt_thoat_thai";
            this.bt_thoat_thai.Size = new System.Drawing.Size(117, 39);
            this.bt_thoat_thai.TabIndex = 33;
            this.bt_thoat_thai.Text = "Thoát";
            this.bt_thoat_thai.UseVisualStyleBackColor = false;
            this.bt_thoat_thai.Click += new System.EventHandler(this.bt_thoat_thai_Click);
            // 
            // bt_rf_thai
            // 
            this.bt_rf_thai.BackColor = System.Drawing.Color.White;
            this.bt_rf_thai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_rf_thai.ForeColor = System.Drawing.Color.Black;
            this.bt_rf_thai.Image = global::Nhom5_QLKS.Properties.Resources.load;
            this.bt_rf_thai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_rf_thai.Location = new System.Drawing.Point(174, 68);
            this.bt_rf_thai.Margin = new System.Windows.Forms.Padding(2);
            this.bt_rf_thai.Name = "bt_rf_thai";
            this.bt_rf_thai.Size = new System.Drawing.Size(108, 36);
            this.bt_rf_thai.TabIndex = 35;
            this.bt_rf_thai.Text = "Refresh";
            this.bt_rf_thai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_rf_thai.UseVisualStyleBackColor = false;
            this.bt_rf_thai.Click += new System.EventHandler(this.bt_rf_thai_Click);
            // 
            // btn_serach_thai
            // 
            this.btn_serach_thai.BackColor = System.Drawing.Color.White;
            this.btn_serach_thai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_serach_thai.ForeColor = System.Drawing.Color.Black;
            this.btn_serach_thai.Image = global::Nhom5_QLKS.Properties.Resources.search_button_green_icon;
            this.btn_serach_thai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_serach_thai.Location = new System.Drawing.Point(168, 28);
            this.btn_serach_thai.Margin = new System.Windows.Forms.Padding(2);
            this.btn_serach_thai.Name = "btn_serach_thai";
            this.btn_serach_thai.Size = new System.Drawing.Size(114, 36);
            this.btn_serach_thai.TabIndex = 0;
            this.btn_serach_thai.Text = "Tìm kiếm";
            this.btn_serach_thai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_serach_thai.UseVisualStyleBackColor = false;
            this.btn_serach_thai.Click += new System.EventHandler(this.btn_serach_thai_Click);
            // 
            // bt_xoa_thai
            // 
            this.bt_xoa_thai.BackColor = System.Drawing.Color.White;
            this.bt_xoa_thai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_xoa_thai.ForeColor = System.Drawing.Color.Black;
            this.bt_xoa_thai.Image = global::Nhom5_QLKS.Properties.Resources.Button_Delete_icon;
            this.bt_xoa_thai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_xoa_thai.Location = new System.Drawing.Point(417, 80);
            this.bt_xoa_thai.Margin = new System.Windows.Forms.Padding(2);
            this.bt_xoa_thai.Name = "bt_xoa_thai";
            this.bt_xoa_thai.Size = new System.Drawing.Size(121, 39);
            this.bt_xoa_thai.TabIndex = 31;
            this.bt_xoa_thai.Text = "Xóa";
            this.bt_xoa_thai.UseVisualStyleBackColor = false;
            this.bt_xoa_thai.Click += new System.EventHandler(this.bt_xoa_thai_Click);
            // 
            // bt_sua_thai
            // 
            this.bt_sua_thai.BackColor = System.Drawing.Color.White;
            this.bt_sua_thai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_sua_thai.ForeColor = System.Drawing.Color.Black;
            this.bt_sua_thai.Image = global::Nhom5_QLKS.Properties.Resources.update_icon;
            this.bt_sua_thai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_sua_thai.Location = new System.Drawing.Point(542, 36);
            this.bt_sua_thai.Margin = new System.Windows.Forms.Padding(2);
            this.bt_sua_thai.Name = "bt_sua_thai";
            this.bt_sua_thai.Size = new System.Drawing.Size(117, 39);
            this.bt_sua_thai.TabIndex = 30;
            this.bt_sua_thai.Text = "Sửa";
            this.bt_sua_thai.UseVisualStyleBackColor = false;
            this.bt_sua_thai.Click += new System.EventHandler(this.bt_sua_thai_Click);
            // 
            // bt_them_thai
            // 
            this.bt_them_thai.BackColor = System.Drawing.Color.White;
            this.bt_them_thai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_them_thai.ForeColor = System.Drawing.Color.Black;
            this.bt_them_thai.Image = global::Nhom5_QLKS.Properties.Resources.Button_Add_icon;
            this.bt_them_thai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_them_thai.Location = new System.Drawing.Point(417, 37);
            this.bt_them_thai.Margin = new System.Windows.Forms.Padding(2);
            this.bt_them_thai.Name = "bt_them_thai";
            this.bt_them_thai.Size = new System.Drawing.Size(121, 38);
            this.bt_them_thai.TabIndex = 29;
            this.bt_them_thai.Text = "Thêm";
            this.bt_them_thai.UseVisualStyleBackColor = false;
            this.bt_them_thai.Click += new System.EventHandler(this.bt_them_thai_Click);
            // 
            // frm_dichvu_thai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(714, 392);
            this.Controls.Add(this.grb_thongtin_thai);
            this.Controls.Add(this.bt_thoat_thai);
            this.Controls.Add(this.grb_search_thai);
            this.Controls.Add(this.bt_xoa_thai);
            this.Controls.Add(this.bt_sua_thai);
            this.Controls.Add(this.bt_them_thai);
            this.Controls.Add(this.dgv_thai);
            this.Controls.Add(this.lb_dvks_thai);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_dichvu_thai";
            this.Text = " frm_DichVu_Thai";
            this.Load += new System.EventHandler(this.frm_dichvu_thai_Load);
            this.grb_search_thai.ResumeLayout(false);
            this.grb_search_thai.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_thai)).EndInit();
            this.grb_thongtin_thai.ResumeLayout(false);
            this.grb_thongtin_thai.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_thoat_thai;
        private System.Windows.Forms.TextBox tb_search_thai;
        private System.Windows.Forms.RadioButton rb_tendv_thai;
        private System.Windows.Forms.RadioButton rb_madv_thai;
        private System.Windows.Forms.GroupBox grb_search_thai;
        private System.Windows.Forms.Button btn_serach_thai;
        private System.Windows.Forms.Button bt_xoa_thai;
        private System.Windows.Forms.Button bt_sua_thai;
        private System.Windows.Forms.Button bt_them_thai;
        private System.Windows.Forms.DataGridView dgv_thai;
        private System.Windows.Forms.TextBox tb_soluong_thai;
        private System.Windows.Forms.TextBox tb_giadv_thai;
        private System.Windows.Forms.TextBox tb_tendv_thai;
        private System.Windows.Forms.TextBox tb_madv_thai;
        private System.Windows.Forms.Label lb_loaidv_thai;
        private System.Windows.Forms.Label lb_soluong_thai;
        private System.Windows.Forms.Label lb_giadv_thai;
        private System.Windows.Forms.Label lb_tendv_thai;
        private System.Windows.Forms.Label lb_madv_thai;
        private System.Windows.Forms.Label lb_dvks_thai;
        private System.Windows.Forms.GroupBox grb_thongtin_thai;
        private System.Windows.Forms.Button bt_rf_thai;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaiDV;
        private System.Windows.Forms.ComboBox cb_loaidv_thai;
    }
}

   