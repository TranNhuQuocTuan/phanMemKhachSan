
namespace Nhom5_QLKS
{
    partial class frm_QLNV_tan
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_ttnv_tan = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bt_ql_tan = new System.Windows.Forms.Button();
            this.tb_timkiem_tan = new System.Windows.Forms.TextBox();
            this.bt_timkiem_tan = new System.Windows.Forms.Button();
            this.bt_thoat_tan = new System.Windows.Forms.Button();
            this.bt_xoa_tan = new System.Windows.Forms.Button();
            this.bt_sua_tan = new System.Windows.Forms.Button();
            this.bt_them_tan = new System.Windows.Forms.Button();
            this.rb_nu_tan = new System.Windows.Forms.RadioButton();
            this.rb_nam_tan = new System.Windows.Forms.RadioButton();
            this.cb_cv_tan = new System.Windows.Forms.ComboBox();
            this.cb_ca_tan = new System.Windows.Forms.ComboBox();
            this.dtp_ngaysinh_tan = new System.Windows.Forms.DateTimePicker();
            this.tb_giobd_tan = new System.Windows.Forms.TextBox();
            this.tb_giokt_tan = new System.Windows.Forms.TextBox();
            this.tb_ten_tan = new System.Windows.Forms.TextBox();
            this.tb_ma_tan = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_user_tan = new System.Windows.Forms.TextBox();
            this.maNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySInh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioiTinh = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.maCa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenCV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ttnv_tan)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SkyBlue;
            this.groupBox1.Controls.Add(this.dgv_ttnv_tan);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(9, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(875, 519);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // dgv_ttnv_tan
            // 
            this.dgv_ttnv_tan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ttnv_tan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNV,
            this.hoTen,
            this.ngaySInh,
            this.gioiTinh,
            this.maCa,
            this.tenCV,
            this.user_name});
            this.dgv_ttnv_tan.Location = new System.Drawing.Point(4, 315);
            this.dgv_ttnv_tan.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_ttnv_tan.Name = "dgv_ttnv_tan";
            this.dgv_ttnv_tan.RowHeadersWidth = 51;
            this.dgv_ttnv_tan.RowTemplate.Height = 29;
            this.dgv_ttnv_tan.Size = new System.Drawing.Size(852, 200);
            this.dgv_ttnv_tan.TabIndex = 21;
            this.dgv_ttnv_tan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ttnv_tan_CellClick);
            this.dgv_ttnv_tan.SelectionChanged += new System.EventHandler(this.dgv_ttnv_tan_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(305, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 30);
            this.label1.TabIndex = 20;
            this.label1.Text = "QUẢN LÝ NHÂN VIÊN";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.SkyBlue;
            this.groupBox2.Controls.Add(this.tb_user_tan);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.bt_ql_tan);
            this.groupBox2.Controls.Add(this.tb_timkiem_tan);
            this.groupBox2.Controls.Add(this.bt_timkiem_tan);
            this.groupBox2.Controls.Add(this.bt_thoat_tan);
            this.groupBox2.Controls.Add(this.bt_xoa_tan);
            this.groupBox2.Controls.Add(this.bt_sua_tan);
            this.groupBox2.Controls.Add(this.bt_them_tan);
            this.groupBox2.Controls.Add(this.rb_nu_tan);
            this.groupBox2.Controls.Add(this.rb_nam_tan);
            this.groupBox2.Controls.Add(this.cb_cv_tan);
            this.groupBox2.Controls.Add(this.cb_ca_tan);
            this.groupBox2.Controls.Add(this.dtp_ngaysinh_tan);
            this.groupBox2.Controls.Add(this.tb_giobd_tan);
            this.groupBox2.Controls.Add(this.tb_giokt_tan);
            this.groupBox2.Controls.Add(this.tb_ten_tan);
            this.groupBox2.Controls.Add(this.tb_ma_tan);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 18);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(852, 293);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // bt_ql_tan
            // 
            this.bt_ql_tan.BackColor = System.Drawing.Color.White;
            this.bt_ql_tan.Image = global::Nhom5_QLKS.Properties.Resources.load;
            this.bt_ql_tan.Location = new System.Drawing.Point(472, 216);
            this.bt_ql_tan.Margin = new System.Windows.Forms.Padding(2);
            this.bt_ql_tan.Name = "bt_ql_tan";
            this.bt_ql_tan.Size = new System.Drawing.Size(124, 49);
            this.bt_ql_tan.TabIndex = 44;
            this.bt_ql_tan.Text = "Quay Lại";
            this.bt_ql_tan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_ql_tan.UseVisualStyleBackColor = false;
            this.bt_ql_tan.Click += new System.EventHandler(this.bt_ql_tan_Click);
            // 
            // tb_timkiem_tan
            // 
            this.tb_timkiem_tan.Location = new System.Drawing.Point(169, 233);
            this.tb_timkiem_tan.Margin = new System.Windows.Forms.Padding(2);
            this.tb_timkiem_tan.Name = "tb_timkiem_tan";
            this.tb_timkiem_tan.Size = new System.Drawing.Size(218, 24);
            this.tb_timkiem_tan.TabIndex = 43;
            this.tb_timkiem_tan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_timkiem_tan_KeyPress);
            // 
            // bt_timkiem_tan
            // 
            this.bt_timkiem_tan.BackColor = System.Drawing.Color.White;
            this.bt_timkiem_tan.Location = new System.Drawing.Point(14, 218);
            this.bt_timkiem_tan.Margin = new System.Windows.Forms.Padding(2);
            this.bt_timkiem_tan.Name = "bt_timkiem_tan";
            this.bt_timkiem_tan.Size = new System.Drawing.Size(122, 45);
            this.bt_timkiem_tan.TabIndex = 42;
            this.bt_timkiem_tan.Text = "Tìm Kiếm Tên Nhân Viên";
            this.bt_timkiem_tan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_timkiem_tan.UseVisualStyleBackColor = false;
            this.bt_timkiem_tan.Click += new System.EventHandler(this.bt_timkiem_tan_Click);
            // 
            // bt_thoat_tan
            // 
            this.bt_thoat_tan.BackColor = System.Drawing.Color.White;
            this.bt_thoat_tan.Image = global::Nhom5_QLKS.Properties.Resources.x;
            this.bt_thoat_tan.Location = new System.Drawing.Point(709, 160);
            this.bt_thoat_tan.Margin = new System.Windows.Forms.Padding(2);
            this.bt_thoat_tan.Name = "bt_thoat_tan";
            this.bt_thoat_tan.Size = new System.Drawing.Size(117, 45);
            this.bt_thoat_tan.TabIndex = 41;
            this.bt_thoat_tan.Text = "Thoát";
            this.bt_thoat_tan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_thoat_tan.UseVisualStyleBackColor = false;
            this.bt_thoat_tan.Click += new System.EventHandler(this.bt_thoat_tan_Click);
            // 
            // bt_xoa_tan
            // 
            this.bt_xoa_tan.BackColor = System.Drawing.Color.White;
            this.bt_xoa_tan.Image = global::Nhom5_QLKS.Properties.Resources.Button_Delete_icon;
            this.bt_xoa_tan.Location = new System.Drawing.Point(269, 160);
            this.bt_xoa_tan.Margin = new System.Windows.Forms.Padding(2);
            this.bt_xoa_tan.Name = "bt_xoa_tan";
            this.bt_xoa_tan.Size = new System.Drawing.Size(117, 45);
            this.bt_xoa_tan.TabIndex = 40;
            this.bt_xoa_tan.Text = "Xóa ";
            this.bt_xoa_tan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_xoa_tan.UseVisualStyleBackColor = false;
            this.bt_xoa_tan.Click += new System.EventHandler(this.bt_xoa_tan_Click);
            // 
            // bt_sua_tan
            // 
            this.bt_sua_tan.BackColor = System.Drawing.Color.White;
            this.bt_sua_tan.Image = global::Nhom5_QLKS.Properties.Resources.update_icon;
            this.bt_sua_tan.Location = new System.Drawing.Point(479, 160);
            this.bt_sua_tan.Margin = new System.Windows.Forms.Padding(2);
            this.bt_sua_tan.Name = "bt_sua_tan";
            this.bt_sua_tan.Size = new System.Drawing.Size(117, 45);
            this.bt_sua_tan.TabIndex = 39;
            this.bt_sua_tan.Text = "Sửa";
            this.bt_sua_tan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_sua_tan.UseVisualStyleBackColor = false;
            this.bt_sua_tan.Click += new System.EventHandler(this.bt_sua_tan_Click);
            // 
            // bt_them_tan
            // 
            this.bt_them_tan.BackColor = System.Drawing.Color.White;
            this.bt_them_tan.Image = global::Nhom5_QLKS.Properties.Resources.Button_Add_icon;
            this.bt_them_tan.Location = new System.Drawing.Point(42, 160);
            this.bt_them_tan.Margin = new System.Windows.Forms.Padding(2);
            this.bt_them_tan.Name = "bt_them_tan";
            this.bt_them_tan.Size = new System.Drawing.Size(117, 45);
            this.bt_them_tan.TabIndex = 38;
            this.bt_them_tan.Text = "Thêm";
            this.bt_them_tan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_them_tan.UseVisualStyleBackColor = false;
            this.bt_them_tan.Click += new System.EventHandler(this.bt_them_tan_Click);
            // 
            // rb_nu_tan
            // 
            this.rb_nu_tan.AutoSize = true;
            this.rb_nu_tan.Location = new System.Drawing.Point(269, 120);
            this.rb_nu_tan.Margin = new System.Windows.Forms.Padding(2);
            this.rb_nu_tan.Name = "rb_nu_tan";
            this.rb_nu_tan.Size = new System.Drawing.Size(47, 22);
            this.rb_nu_tan.TabIndex = 37;
            this.rb_nu_tan.TabStop = true;
            this.rb_nu_tan.Text = "Nữ";
            this.rb_nu_tan.UseVisualStyleBackColor = true;
            // 
            // rb_nam_tan
            // 
            this.rb_nam_tan.AutoSize = true;
            this.rb_nam_tan.Location = new System.Drawing.Point(169, 120);
            this.rb_nam_tan.Margin = new System.Windows.Forms.Padding(2);
            this.rb_nam_tan.Name = "rb_nam_tan";
            this.rb_nam_tan.Size = new System.Drawing.Size(61, 22);
            this.rb_nam_tan.TabIndex = 36;
            this.rb_nam_tan.TabStop = true;
            this.rb_nam_tan.Text = "Nam";
            this.rb_nam_tan.UseVisualStyleBackColor = true;
            this.rb_nam_tan.CheckedChanged += new System.EventHandler(this.rb_nam_tan_CheckedChanged);
            // 
            // cb_cv_tan
            // 
            this.cb_cv_tan.FormattingEnabled = true;
            this.cb_cv_tan.Location = new System.Drawing.Point(498, 94);
            this.cb_cv_tan.Margin = new System.Windows.Forms.Padding(2);
            this.cb_cv_tan.Name = "cb_cv_tan";
            this.cb_cv_tan.Size = new System.Drawing.Size(238, 26);
            this.cb_cv_tan.TabIndex = 34;
            // 
            // cb_ca_tan
            // 
            this.cb_ca_tan.FormattingEnabled = true;
            this.cb_ca_tan.Location = new System.Drawing.Point(498, 19);
            this.cb_ca_tan.Margin = new System.Windows.Forms.Padding(2);
            this.cb_ca_tan.Name = "cb_ca_tan";
            this.cb_ca_tan.Size = new System.Drawing.Size(238, 26);
            this.cb_ca_tan.TabIndex = 33;
            this.cb_ca_tan.SelectedIndexChanged += new System.EventHandler(this.cb_ca_tan_SelectedIndexChanged);
            // 
            // dtp_ngaysinh_tan
            // 
            this.dtp_ngaysinh_tan.Location = new System.Drawing.Point(169, 90);
            this.dtp_ngaysinh_tan.Margin = new System.Windows.Forms.Padding(2);
            this.dtp_ngaysinh_tan.Name = "dtp_ngaysinh_tan";
            this.dtp_ngaysinh_tan.Size = new System.Drawing.Size(234, 24);
            this.dtp_ngaysinh_tan.TabIndex = 32;
            // 
            // tb_giobd_tan
            // 
            this.tb_giobd_tan.Enabled = false;
            this.tb_giobd_tan.Location = new System.Drawing.Point(517, 57);
            this.tb_giobd_tan.Margin = new System.Windows.Forms.Padding(2);
            this.tb_giobd_tan.Name = "tb_giobd_tan";
            this.tb_giobd_tan.Size = new System.Drawing.Size(37, 24);
            this.tb_giobd_tan.TabIndex = 31;
            // 
            // tb_giokt_tan
            // 
            this.tb_giokt_tan.Enabled = false;
            this.tb_giokt_tan.Location = new System.Drawing.Point(698, 55);
            this.tb_giokt_tan.Margin = new System.Windows.Forms.Padding(2);
            this.tb_giokt_tan.Name = "tb_giokt_tan";
            this.tb_giokt_tan.Size = new System.Drawing.Size(38, 24);
            this.tb_giokt_tan.TabIndex = 30;
            // 
            // tb_ten_tan
            // 
            this.tb_ten_tan.Location = new System.Drawing.Point(169, 57);
            this.tb_ten_tan.Margin = new System.Windows.Forms.Padding(2);
            this.tb_ten_tan.Name = "tb_ten_tan";
            this.tb_ten_tan.Size = new System.Drawing.Size(234, 24);
            this.tb_ten_tan.TabIndex = 29;
            this.tb_ten_tan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_ten_tan_KeyPress);
            // 
            // tb_ma_tan
            // 
            this.tb_ma_tan.Location = new System.Drawing.Point(169, 20);
            this.tb_ma_tan.Margin = new System.Windows.Forms.Padding(2);
            this.tb_ma_tan.Name = "tb_ma_tan";
            this.tb_ma_tan.Size = new System.Drawing.Size(234, 24);
            this.tb_ma_tan.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(407, 97);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 18);
            this.label9.TabIndex = 27;
            this.label9.Text = "Chức Vụ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(573, 61);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 18);
            this.label8.TabIndex = 26;
            this.label8.Text = "Giờ Kết Thúc";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(407, 61);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 18);
            this.label7.TabIndex = 25;
            this.label7.Text = "Giờ Bắt đầu ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(407, 25);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 18);
            this.label6.TabIndex = 24;
            this.label6.Text = "Ca Làm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 120);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 18);
            this.label5.TabIndex = 23;
            this.label5.Text = "Giới Tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 94);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 18);
            this.label4.TabIndex = 22;
            this.label4.Text = "Ngày Sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 61);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 18);
            this.label3.TabIndex = 21;
            this.label3.Text = "Tên Nhân Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 18);
            this.label2.TabIndex = 20;
            this.label2.Text = "Mã Nhân Viên";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(407, 130);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 18);
            this.label10.TabIndex = 45;
            this.label10.Text = "Username";
            // 
            // tb_user_tan
            // 
            this.tb_user_tan.Location = new System.Drawing.Point(498, 124);
            this.tb_user_tan.Margin = new System.Windows.Forms.Padding(2);
            this.tb_user_tan.Name = "tb_user_tan";
            this.tb_user_tan.Size = new System.Drawing.Size(208, 24);
            this.tb_user_tan.TabIndex = 46;
            // 
            // maNV
            // 
            this.maNV.DataPropertyName = "maNV";
            this.maNV.FillWeight = 113.0526F;
            this.maNV.HeaderText = "Mã Nhân Viên";
            this.maNV.MinimumWidth = 6;
            this.maNV.Name = "maNV";
            this.maNV.Width = 130;
            // 
            // hoTen
            // 
            this.hoTen.DataPropertyName = "hoTen";
            this.hoTen.FillWeight = 112.2995F;
            this.hoTen.HeaderText = "Tên Nhân Viên";
            this.hoTen.MinimumWidth = 6;
            this.hoTen.Name = "hoTen";
            this.hoTen.Width = 160;
            // 
            // ngaySInh
            // 
            this.ngaySInh.DataPropertyName = "ngaySinh";
            this.ngaySInh.FillWeight = 102.9464F;
            this.ngaySInh.HeaderText = "Ngày Sinh";
            this.ngaySInh.MinimumWidth = 6;
            this.ngaySInh.Name = "ngaySInh";
            this.ngaySInh.Width = 130;
            // 
            // gioiTinh
            // 
            this.gioiTinh.DataPropertyName = "gioiTinh";
            this.gioiTinh.FillWeight = 81.96162F;
            this.gioiTinh.HeaderText = "Giới Tính";
            this.gioiTinh.MinimumWidth = 6;
            this.gioiTinh.Name = "gioiTinh";
            this.gioiTinh.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.gioiTinh.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.gioiTinh.Width = 95;
            // 
            // maCa
            // 
            this.maCa.DataPropertyName = "maCa";
            this.maCa.FillWeight = 81.96162F;
            this.maCa.HeaderText = "Ca Làm";
            this.maCa.MinimumWidth = 6;
            this.maCa.Name = "maCa";
            this.maCa.Width = 95;
            // 
            // tenCV
            // 
            this.tenCV.DataPropertyName = "tenCV";
            this.tenCV.FillWeight = 107.7784F;
            this.tenCV.HeaderText = "Chức Vụ";
            this.tenCV.MinimumWidth = 6;
            this.tenCV.Name = "tenCV";
            this.tenCV.Width = 125;
            // 
            // user_name
            // 
            this.user_name.DataPropertyName = "user_name";
            this.user_name.HeaderText = "UserName";
            this.user_name.Name = "user_name";
            // 
            // frm_QLNV_tan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(885, 538);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_QLNV_tan";
            this.Text = "frm_Quản Lý Nhân Viên_Nguyễn Văn Tân";
            this.Load += new System.EventHandler(this.frm_QLNV_tan_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ttnv_tan)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_ttnv_tan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bt_ql_tan;
        private System.Windows.Forms.TextBox tb_timkiem_tan;
        private System.Windows.Forms.Button bt_timkiem_tan;
        private System.Windows.Forms.Button bt_thoat_tan;
        private System.Windows.Forms.Button bt_xoa_tan;
        private System.Windows.Forms.Button bt_sua_tan;
        private System.Windows.Forms.Button bt_them_tan;
        private System.Windows.Forms.RadioButton rb_nu_tan;
        private System.Windows.Forms.RadioButton rb_nam_tan;
        private System.Windows.Forms.ComboBox cb_cv_tan;
        private System.Windows.Forms.ComboBox cb_ca_tan;
        private System.Windows.Forms.DateTimePicker dtp_ngaysinh_tan;
        private System.Windows.Forms.TextBox tb_giobd_tan;
        private System.Windows.Forms.TextBox tb_giokt_tan;
        private System.Windows.Forms.TextBox tb_ten_tan;
        private System.Windows.Forms.TextBox tb_ma_tan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_user_tan;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySInh;
        private System.Windows.Forms.DataGridViewCheckBoxColumn gioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn maCa;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenCV;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_name;
    }
}