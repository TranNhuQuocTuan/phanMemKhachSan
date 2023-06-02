
namespace Nhom5_QLKS
{
    partial class frm_DV_tuan
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
            this.components = new System.ComponentModel.Container();
            this.dgv_DichVu_Tuan = new System.Windows.Forms.DataGridView();
            this.maDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dichvuBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.nhom5_QLKSDataSet = new Nhom5_QLKS.Nhom5_QLKSDataSet();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_tenDV_Tuan = new System.Windows.Forms.TextBox();
            this.tb_SLSP_Tuan = new System.Windows.Forms.TextBox();
            this.tb_Thanhtien_Tuan = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_Gia1SP_Tuan = new System.Windows.Forms.TextBox();
            this.bt_chon_tuan = new System.Windows.Forms.Button();
            this.bt_bo_Tuan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_soluongco_tuan = new System.Windows.Forms.TextBox();
            this.bt_muathem_tuan = new System.Windows.Forms.Button();
            this.tb_madv_tuan = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.edb_doan_tuan = new System.Windows.Forms.RadioButton();
            this.rdb_douong_tuan = new System.Windows.Forms.RadioButton();
            this.rdb_giaitri_tuan = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_chitietHD_Tuan = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tb_maHDCT_Tuan = new System.Windows.Forms.TextBox();
            this.tb_tong_Tuan = new System.Windows.Forms.TextBox();
            this.bt_Tongtien_Tuan = new System.Windows.Forms.Button();
            this.bt_chonlai_tuan = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dichvuTableAdapter = new Nhom5_QLKS.Nhom5_QLKSDataSetTableAdapters.dichvuTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dichvuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DichVu_Tuan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dichvuBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhom5_QLKSDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chitietHD_Tuan)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dichvuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_DichVu_Tuan
            // 
            this.dgv_DichVu_Tuan.AutoGenerateColumns = false;
            this.dgv_DichVu_Tuan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DichVu_Tuan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maDV,
            this.tenDV,
            this.giaDV,
            this.soLuong});
            this.dgv_DichVu_Tuan.DataSource = this.dichvuBindingSource1;
            this.dgv_DichVu_Tuan.Location = new System.Drawing.Point(20, 68);
            this.dgv_DichVu_Tuan.Name = "dgv_DichVu_Tuan";
            this.dgv_DichVu_Tuan.Size = new System.Drawing.Size(397, 150);
            this.dgv_DichVu_Tuan.TabIndex = 0;
            this.dgv_DichVu_Tuan.SelectionChanged += new System.EventHandler(this.dgv_DichVu_Tuan_SelectionChanged);
            // 
            // maDV
            // 
            this.maDV.DataPropertyName = "maDV";
            this.maDV.HeaderText = "Mã DV";
            this.maDV.Name = "maDV";
            // 
            // tenDV
            // 
            this.tenDV.DataPropertyName = "tenDV";
            this.tenDV.HeaderText = "Tên Dịch Vụ";
            this.tenDV.Name = "tenDV";
            // 
            // giaDV
            // 
            this.giaDV.DataPropertyName = "giaDV";
            this.giaDV.HeaderText = "Giá Dịch Vụ";
            this.giaDV.Name = "giaDV";
            // 
            // soLuong
            // 
            this.soLuong.DataPropertyName = "soLuong";
            this.soLuong.HeaderText = "Số Lượng";
            this.soLuong.Name = "soLuong";
            // 
            // dichvuBindingSource1
            // 
            this.dichvuBindingSource1.DataMember = "dichvu";
            this.dichvuBindingSource1.DataSource = this.nhom5_QLKSDataSet;
            // 
            // nhom5_QLKSDataSet
            // 
            this.nhom5_QLKSDataSet.DataSetName = "Nhom5_QLKSDataSet";
            this.nhom5_QLKSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(439, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 18);
            this.label8.TabIndex = 1;
            this.label8.Text = "Tên dịch vụ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(436, 213);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(159, 18);
            this.label9.TabIndex = 2;
            this.label9.Text = "Số lượng muốn mua";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(436, 248);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 18);
            this.label10.TabIndex = 3;
            this.label10.Text = "Thành tiền";
            // 
            // tb_tenDV_Tuan
            // 
            this.tb_tenDV_Tuan.Location = new System.Drawing.Point(546, 100);
            this.tb_tenDV_Tuan.Name = "tb_tenDV_Tuan";
            this.tb_tenDV_Tuan.Size = new System.Drawing.Size(269, 26);
            this.tb_tenDV_Tuan.TabIndex = 4;
            // 
            // tb_SLSP_Tuan
            // 
            this.tb_SLSP_Tuan.Location = new System.Drawing.Point(620, 205);
            this.tb_SLSP_Tuan.MaxLength = 3;
            this.tb_SLSP_Tuan.Name = "tb_SLSP_Tuan";
            this.tb_SLSP_Tuan.Size = new System.Drawing.Size(196, 26);
            this.tb_SLSP_Tuan.TabIndex = 5;
            this.tb_SLSP_Tuan.TextChanged += new System.EventHandler(this.tb_SLSP_Tuan_TextChanged);
            this.tb_SLSP_Tuan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_SLSP_Tuan_KeyPress);
            // 
            // tb_Thanhtien_Tuan
            // 
            this.tb_Thanhtien_Tuan.Location = new System.Drawing.Point(547, 244);
            this.tb_Thanhtien_Tuan.Name = "tb_Thanhtien_Tuan";
            this.tb_Thanhtien_Tuan.Size = new System.Drawing.Size(269, 26);
            this.tb_Thanhtien_Tuan.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(439, 173);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 18);
            this.label11.TabIndex = 7;
            this.label11.Text = "Giá 1 Sp\r\n";
            // 
            // tb_Gia1SP_Tuan
            // 
            this.tb_Gia1SP_Tuan.Location = new System.Drawing.Point(620, 173);
            this.tb_Gia1SP_Tuan.Name = "tb_Gia1SP_Tuan";
            this.tb_Gia1SP_Tuan.Size = new System.Drawing.Size(195, 26);
            this.tb_Gia1SP_Tuan.TabIndex = 8;
            // 
            // bt_chon_tuan
            // 
            this.bt_chon_tuan.Image = global::Nhom5_QLKS.Properties.Resources.Button_Add_icon;
            this.bt_chon_tuan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_chon_tuan.Location = new System.Drawing.Point(7, 238);
            this.bt_chon_tuan.Name = "bt_chon_tuan";
            this.bt_chon_tuan.Size = new System.Drawing.Size(94, 41);
            this.bt_chon_tuan.TabIndex = 9;
            this.bt_chon_tuan.Text = "Chọn";
            this.bt_chon_tuan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_chon_tuan.UseVisualStyleBackColor = true;
            this.bt_chon_tuan.Click += new System.EventHandler(this.bt_chon_tuan_Click);
            // 
            // bt_bo_Tuan
            // 
            this.bt_bo_Tuan.Image = global::Nhom5_QLKS.Properties.Resources.Button_Delete_icon;
            this.bt_bo_Tuan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_bo_Tuan.Location = new System.Drawing.Point(296, 237);
            this.bt_bo_Tuan.Name = "bt_bo_Tuan";
            this.bt_bo_Tuan.Size = new System.Drawing.Size(121, 42);
            this.bt_bo_Tuan.TabIndex = 10;
            this.bt_bo_Tuan.Text = "Bỏ chọn";
            this.bt_bo_Tuan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_bo_Tuan.UseVisualStyleBackColor = true;
            this.bt_bo_Tuan.Click += new System.EventHandler(this.bt_bo_Tuan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(439, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Số lượng hiện có";
            // 
            // tb_soluongco_tuan
            // 
            this.tb_soluongco_tuan.Location = new System.Drawing.Point(619, 141);
            this.tb_soluongco_tuan.Name = "tb_soluongco_tuan";
            this.tb_soluongco_tuan.Size = new System.Drawing.Size(196, 26);
            this.tb_soluongco_tuan.TabIndex = 12;
            // 
            // bt_muathem_tuan
            // 
            this.bt_muathem_tuan.Image = global::Nhom5_QLKS.Properties.Resources.update_icon;
            this.bt_muathem_tuan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_muathem_tuan.Location = new System.Drawing.Point(133, 238);
            this.bt_muathem_tuan.Name = "bt_muathem_tuan";
            this.bt_muathem_tuan.Size = new System.Drawing.Size(144, 41);
            this.bt_muathem_tuan.TabIndex = 13;
            this.bt_muathem_tuan.Text = "Mua Thêm ";
            this.bt_muathem_tuan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_muathem_tuan.UseVisualStyleBackColor = true;
            this.bt_muathem_tuan.Click += new System.EventHandler(this.bt_muathem_tuan_Click);
            // 
            // tb_madv_tuan
            // 
            this.tb_madv_tuan.Location = new System.Drawing.Point(546, 60);
            this.tb_madv_tuan.Name = "tb_madv_tuan";
            this.tb_madv_tuan.Size = new System.Drawing.Size(269, 26);
            this.tb_madv_tuan.TabIndex = 14;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(439, 68);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 18);
            this.label14.TabIndex = 15;
            this.label14.Text = "Mã dịch vụ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(39, 26);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 20);
            this.label15.TabIndex = 16;
            this.label15.Text = "Select";
            // 
            // edb_doan_tuan
            // 
            this.edb_doan_tuan.AutoSize = true;
            this.edb_doan_tuan.Location = new System.Drawing.Point(117, 26);
            this.edb_doan_tuan.Name = "edb_doan_tuan";
            this.edb_doan_tuan.Size = new System.Drawing.Size(77, 24);
            this.edb_doan_tuan.TabIndex = 17;
            this.edb_doan_tuan.TabStop = true;
            this.edb_doan_tuan.Text = "Đồ Ăn";
            this.edb_doan_tuan.UseVisualStyleBackColor = true;
            this.edb_doan_tuan.CheckedChanged += new System.EventHandler(this.edb_doan_tuan_CheckedChanged);
            // 
            // rdb_douong_tuan
            // 
            this.rdb_douong_tuan.AutoSize = true;
            this.rdb_douong_tuan.Location = new System.Drawing.Point(224, 26);
            this.rdb_douong_tuan.Name = "rdb_douong_tuan";
            this.rdb_douong_tuan.Size = new System.Drawing.Size(98, 24);
            this.rdb_douong_tuan.TabIndex = 18;
            this.rdb_douong_tuan.TabStop = true;
            this.rdb_douong_tuan.Text = "Đồ Uống";
            this.rdb_douong_tuan.UseVisualStyleBackColor = true;
            this.rdb_douong_tuan.CheckedChanged += new System.EventHandler(this.rdb_douong_tuan_CheckedChanged);
            // 
            // rdb_giaitri_tuan
            // 
            this.rdb_giaitri_tuan.AutoSize = true;
            this.rdb_giaitri_tuan.Location = new System.Drawing.Point(353, 26);
            this.rdb_giaitri_tuan.Name = "rdb_giaitri_tuan";
            this.rdb_giaitri_tuan.Size = new System.Drawing.Size(84, 24);
            this.rdb_giaitri_tuan.TabIndex = 19;
            this.rdb_giaitri_tuan.TabStop = true;
            this.rdb_giaitri_tuan.Text = "Giải Trí";
            this.rdb_giaitri_tuan.UseVisualStyleBackColor = true;
            this.rdb_giaitri_tuan.CheckedChanged += new System.EventHandler(this.rdb_giaitri_tuan_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SkyBlue;
            this.groupBox1.Controls.Add(this.rdb_giaitri_tuan);
            this.groupBox1.Controls.Add(this.rdb_douong_tuan);
            this.groupBox1.Controls.Add(this.edb_doan_tuan);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.tb_madv_tuan);
            this.groupBox1.Controls.Add(this.bt_muathem_tuan);
            this.groupBox1.Controls.Add(this.tb_soluongco_tuan);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.bt_bo_Tuan);
            this.groupBox1.Controls.Add(this.bt_chon_tuan);
            this.groupBox1.Controls.Add(this.tb_Gia1SP_Tuan);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.tb_Thanhtien_Tuan);
            this.groupBox1.Controls.Add(this.tb_SLSP_Tuan);
            this.groupBox1.Controls.Add(this.tb_tenDV_Tuan);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.dgv_DichVu_Tuan);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(856, 299);
            this.groupBox1.TabIndex = 56;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn Dịch Vụ";
            // 
            // dgv_chitietHD_Tuan
            // 
            this.dgv_chitietHD_Tuan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_chitietHD_Tuan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgv_chitietHD_Tuan.Location = new System.Drawing.Point(7, 22);
            this.dgv_chitietHD_Tuan.Name = "dgv_chitietHD_Tuan";
            this.dgv_chitietHD_Tuan.Size = new System.Drawing.Size(548, 209);
            this.dgv_chitietHD_Tuan.TabIndex = 0;
            this.dgv_chitietHD_Tuan.SelectionChanged += new System.EventHandler(this.dgv_chitietHD_Tuan_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "maHD";
            this.Column1.HeaderText = "Mã Hóa Đơn";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "tenDV";
            this.Column2.HeaderText = "Tên Dịch Vụ";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "donGia";
            this.Column3.HeaderText = "Đơn Giá";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "soLuong";
            this.Column4.HeaderText = "Số Lượng";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "thanhtien";
            this.Column5.HeaderText = "Thành Tiền";
            this.Column5.Name = "Column5";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(648, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 18);
            this.label12.TabIndex = 1;
            this.label12.Text = "Mã hóa đơn";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(648, 72);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(105, 18);
            this.label13.TabIndex = 2;
            this.label13.Text = "Tổng tiền DV";
            // 
            // tb_maHDCT_Tuan
            // 
            this.tb_maHDCT_Tuan.Location = new System.Drawing.Point(587, 43);
            this.tb_maHDCT_Tuan.Name = "tb_maHDCT_Tuan";
            this.tb_maHDCT_Tuan.Size = new System.Drawing.Size(228, 26);
            this.tb_maHDCT_Tuan.TabIndex = 3;
            // 
            // tb_tong_Tuan
            // 
            this.tb_tong_Tuan.Location = new System.Drawing.Point(588, 109);
            this.tb_tong_Tuan.Name = "tb_tong_Tuan";
            this.tb_tong_Tuan.Size = new System.Drawing.Size(228, 26);
            this.tb_tong_Tuan.TabIndex = 4;
            // 
            // bt_Tongtien_Tuan
            // 
            this.bt_Tongtien_Tuan.Image = global::Nhom5_QLKS.Properties.Resources.money_bag1;
            this.bt_Tongtien_Tuan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Tongtien_Tuan.Location = new System.Drawing.Point(640, 141);
            this.bt_Tongtien_Tuan.Name = "bt_Tongtien_Tuan";
            this.bt_Tongtien_Tuan.Size = new System.Drawing.Size(127, 47);
            this.bt_Tongtien_Tuan.TabIndex = 5;
            this.bt_Tongtien_Tuan.Text = "Tổng tiền";
            this.bt_Tongtien_Tuan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_Tongtien_Tuan.UseVisualStyleBackColor = true;
            this.bt_Tongtien_Tuan.Click += new System.EventHandler(this.bt_Tongtien_Tuan_Click);
            // 
            // bt_chonlai_tuan
            // 
            this.bt_chonlai_tuan.Location = new System.Drawing.Point(561, 191);
            this.bt_chonlai_tuan.Name = "bt_chonlai_tuan";
            this.bt_chonlai_tuan.Size = new System.Drawing.Size(91, 53);
            this.bt_chonlai_tuan.TabIndex = 6;
            this.bt_chonlai_tuan.Text = "Chọn lại HĐ";
            this.bt_chonlai_tuan.UseVisualStyleBackColor = true;
            this.bt_chonlai_tuan.Click += new System.EventHandler(this.bt_chonlai_tuan_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(758, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 53);
            this.button1.TabIndex = 7;
            this.button1.Text = "Quay Lại TT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.SkyBlue;
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.bt_chonlai_tuan);
            this.groupBox2.Controls.Add(this.bt_Tongtien_Tuan);
            this.groupBox2.Controls.Add(this.tb_tong_Tuan);
            this.groupBox2.Controls.Add(this.tb_maHDCT_Tuan);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.dgv_chitietHD_Tuan);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Red;
            this.groupBox2.Location = new System.Drawing.Point(12, 316);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(856, 258);
            this.groupBox2.TabIndex = 57;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết dịch vụ";
            // 
            // dichvuTableAdapter
            // 
            this.dichvuTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Nhom5_QLKS.Properties.Resources.x;
            this.pictureBox1.Location = new System.Drawing.Point(874, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 23);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dichvuBindingSource
            // 
            this.dichvuBindingSource.DataMember = "dichvu";
            // 
            // frm_DV_tuan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(896, 573);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "frm_DV_tuan";
            this.Text = "frm_DV_tuan";
            this.Load += new System.EventHandler(this.frm_DV_tuan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DichVu_Tuan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dichvuBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhom5_QLKSDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chitietHD_Tuan)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dichvuBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_DichVu_Tuan;
        private System.Windows.Forms.BindingSource dichvuBindingSource;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_tenDV_Tuan;
        private System.Windows.Forms.TextBox tb_SLSP_Tuan;
        private System.Windows.Forms.TextBox tb_Thanhtien_Tuan;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_Gia1SP_Tuan;
        private System.Windows.Forms.Button bt_chon_tuan;
        private System.Windows.Forms.Button bt_bo_Tuan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_soluongco_tuan;
        private System.Windows.Forms.Button bt_muathem_tuan;
        private System.Windows.Forms.TextBox tb_madv_tuan;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.RadioButton edb_doan_tuan;
        private System.Windows.Forms.RadioButton rdb_douong_tuan;
        private System.Windows.Forms.RadioButton rdb_giaitri_tuan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_chitietHD_Tuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tb_maHDCT_Tuan;
        private System.Windows.Forms.TextBox tb_tong_Tuan;
        private System.Windows.Forms.Button bt_Tongtien_Tuan;
        private System.Windows.Forms.Button bt_chonlai_tuan;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Nhom5_QLKSDataSet nhom5_QLKSDataSet;
        private System.Windows.Forms.BindingSource dichvuBindingSource1;
        private Nhom5_QLKSDataSetTableAdapters.dichvuTableAdapter dichvuTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuong;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}