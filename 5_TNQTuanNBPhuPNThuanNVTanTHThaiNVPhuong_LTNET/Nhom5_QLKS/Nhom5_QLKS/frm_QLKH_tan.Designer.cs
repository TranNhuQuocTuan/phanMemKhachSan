
namespace Nhom5_QLKS
{
    partial class frm_QLKH_tan
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
            this.label1 = new System.Windows.Forms.Label();
            this.bt_thoat_tan = new System.Windows.Forms.Button();
            this.bt_sua_tan = new System.Windows.Forms.Button();
            this.bt_timkiem_tan = new System.Windows.Forms.Button();
            this.rb_nu_tan = new System.Windows.Forms.RadioButton();
            this.rb_nam_tan = new System.Windows.Forms.RadioButton();
            this.cb_qt_tan = new System.Windows.Forms.ComboBox();
            this.tb_cmt_tan = new System.Windows.Forms.TextBox();
            this.tb_sdt_tan = new System.Windows.Forms.TextBox();
            this.dgv_qlkh_tan = new System.Windows.Forms.DataGridView();
            this.maKhach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenKhach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quocTich = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioiTinh = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tb_ten_tan = new System.Windows.Forms.TextBox();
            this.tb_tukhoa_tan = new System.Windows.Forms.TextBox();
            this.tb_ma_tan = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_xoa_tan = new System.Windows.Forms.Button();
            this.bt_them_tan = new System.Windows.Forms.Button();
            this.bt_quaylai_tan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_qlkh_tan)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(247, -2);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "QUẢN LÝ KHÁCH HÀNG";
            // 
            // bt_thoat_tan
            // 
            this.bt_thoat_tan.BackColor = System.Drawing.Color.White;
            this.bt_thoat_tan.Image = global::Nhom5_QLKS.Properties.Resources.x;
            this.bt_thoat_tan.Location = new System.Drawing.Point(600, 167);
            this.bt_thoat_tan.Margin = new System.Windows.Forms.Padding(2);
            this.bt_thoat_tan.Name = "bt_thoat_tan";
            this.bt_thoat_tan.Size = new System.Drawing.Size(130, 35);
            this.bt_thoat_tan.TabIndex = 43;
            this.bt_thoat_tan.Text = "Thoát";
            this.bt_thoat_tan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_thoat_tan.UseVisualStyleBackColor = false;
            this.bt_thoat_tan.Click += new System.EventHandler(this.bt_thoat_tan_Click);
            // 
            // bt_sua_tan
            // 
            this.bt_sua_tan.BackColor = System.Drawing.Color.White;
            this.bt_sua_tan.Image = global::Nhom5_QLKS.Properties.Resources.update_icon;
            this.bt_sua_tan.Location = new System.Drawing.Point(600, 115);
            this.bt_sua_tan.Margin = new System.Windows.Forms.Padding(2);
            this.bt_sua_tan.Name = "bt_sua_tan";
            this.bt_sua_tan.Size = new System.Drawing.Size(130, 44);
            this.bt_sua_tan.TabIndex = 42;
            this.bt_sua_tan.Text = "Sửa ";
            this.bt_sua_tan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_sua_tan.UseVisualStyleBackColor = false;
            this.bt_sua_tan.Click += new System.EventHandler(this.bt_sua_tan_Click);
            // 
            // bt_timkiem_tan
            // 
            this.bt_timkiem_tan.BackColor = System.Drawing.Color.White;
            this.bt_timkiem_tan.Location = new System.Drawing.Point(4, 20);
            this.bt_timkiem_tan.Margin = new System.Windows.Forms.Padding(2);
            this.bt_timkiem_tan.Name = "bt_timkiem_tan";
            this.bt_timkiem_tan.Size = new System.Drawing.Size(177, 34);
            this.bt_timkiem_tan.TabIndex = 38;
            this.bt_timkiem_tan.Text = "Tìm Kiếm Tên Khách Hàng";
            this.bt_timkiem_tan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_timkiem_tan.UseVisualStyleBackColor = false;
            this.bt_timkiem_tan.Click += new System.EventHandler(this.bt_timkiem_tan_Click);
            // 
            // rb_nu_tan
            // 
            this.rb_nu_tan.AutoSize = true;
            this.rb_nu_tan.Location = new System.Drawing.Point(517, 128);
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
            this.rb_nam_tan.Location = new System.Drawing.Point(452, 128);
            this.rb_nam_tan.Margin = new System.Windows.Forms.Padding(2);
            this.rb_nam_tan.Name = "rb_nam_tan";
            this.rb_nam_tan.Size = new System.Drawing.Size(61, 22);
            this.rb_nam_tan.TabIndex = 36;
            this.rb_nam_tan.TabStop = true;
            this.rb_nam_tan.Text = "Nam";
            this.rb_nam_tan.UseVisualStyleBackColor = true;
            this.rb_nam_tan.CheckedChanged += new System.EventHandler(this.rb_nam_tan_CheckedChanged);
            // 
            // cb_qt_tan
            // 
            this.cb_qt_tan.FormattingEnabled = true;
            this.cb_qt_tan.Items.AddRange(new object[] {
            "Việt Nam ",
            "America",
            "Singapore",
            "Philipine",
            "Malaysia",
            "Laos",
            "England",
            "Germany",
            "Italia",
            "Cambodia",
            "Thailand",
            "Seria",
            "Agytt",
            "Denmark",
            "Ireland",
            "Finland ",
            "Norway",
            "Sweden",
            "Austria"});
            this.cb_qt_tan.Location = new System.Drawing.Point(452, 72);
            this.cb_qt_tan.Margin = new System.Windows.Forms.Padding(2);
            this.cb_qt_tan.Name = "cb_qt_tan";
            this.cb_qt_tan.Size = new System.Drawing.Size(114, 26);
            this.cb_qt_tan.TabIndex = 35;
            // 
            // tb_cmt_tan
            // 
            this.tb_cmt_tan.Location = new System.Drawing.Point(147, 173);
            this.tb_cmt_tan.Margin = new System.Windows.Forms.Padding(2);
            this.tb_cmt_tan.Name = "tb_cmt_tan";
            this.tb_cmt_tan.Size = new System.Drawing.Size(143, 24);
            this.tb_cmt_tan.TabIndex = 33;
            this.tb_cmt_tan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_cmt_tan_KeyPress);
            // 
            // tb_sdt_tan
            // 
            this.tb_sdt_tan.Location = new System.Drawing.Point(452, 174);
            this.tb_sdt_tan.Margin = new System.Windows.Forms.Padding(2);
            this.tb_sdt_tan.Name = "tb_sdt_tan";
            this.tb_sdt_tan.Size = new System.Drawing.Size(114, 24);
            this.tb_sdt_tan.TabIndex = 32;
            this.tb_sdt_tan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_sdt_tan_KeyPress);
            // 
            // dgv_qlkh_tan
            // 
            this.dgv_qlkh_tan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_qlkh_tan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_qlkh_tan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maKhach,
            this.tenKhach,
            this.CMT,
            this.quocTich,
            this.gioiTinh,
            this.SDT});
            this.dgv_qlkh_tan.Location = new System.Drawing.Point(83, 31);
            this.dgv_qlkh_tan.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_qlkh_tan.Name = "dgv_qlkh_tan";
            this.dgv_qlkh_tan.RowHeadersWidth = 51;
            this.dgv_qlkh_tan.RowTemplate.Height = 29;
            this.dgv_qlkh_tan.Size = new System.Drawing.Size(586, 186);
            this.dgv_qlkh_tan.TabIndex = 1;
            this.dgv_qlkh_tan.SelectionChanged += new System.EventHandler(this.dgv_qlkh_tan_SelectionChanged);
            // 
            // maKhach
            // 
            this.maKhach.DataPropertyName = "maKhach";
            this.maKhach.HeaderText = "Mã Khách Hàng ";
            this.maKhach.MinimumWidth = 6;
            this.maKhach.Name = "maKhach";
            // 
            // tenKhach
            // 
            this.tenKhach.DataPropertyName = "tenKhach";
            this.tenKhach.HeaderText = "Tên Khách Hàng";
            this.tenKhach.MinimumWidth = 6;
            this.tenKhach.Name = "tenKhach";
            // 
            // CMT
            // 
            this.CMT.DataPropertyName = "CMT";
            this.CMT.HeaderText = "CMT/CCCD";
            this.CMT.MinimumWidth = 6;
            this.CMT.Name = "CMT";
            // 
            // quocTich
            // 
            this.quocTich.DataPropertyName = "quocTich";
            this.quocTich.HeaderText = "Quốc Tịch";
            this.quocTich.MinimumWidth = 6;
            this.quocTich.Name = "quocTich";
            // 
            // gioiTinh
            // 
            this.gioiTinh.DataPropertyName = "gioiTinh";
            this.gioiTinh.HeaderText = "Giới Tính";
            this.gioiTinh.MinimumWidth = 6;
            this.gioiTinh.Name = "gioiTinh";
            this.gioiTinh.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.gioiTinh.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "SDT";
            this.SDT.MinimumWidth = 6;
            this.SDT.Name = "SDT";
            // 
            // tb_ten_tan
            // 
            this.tb_ten_tan.Location = new System.Drawing.Point(147, 128);
            this.tb_ten_tan.Margin = new System.Windows.Forms.Padding(2);
            this.tb_ten_tan.Name = "tb_ten_tan";
            this.tb_ten_tan.Size = new System.Drawing.Size(143, 24);
            this.tb_ten_tan.TabIndex = 34;
            this.tb_ten_tan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_ten_tan_KeyPress);
            // 
            // tb_tukhoa_tan
            // 
            this.tb_tukhoa_tan.Location = new System.Drawing.Point(208, 28);
            this.tb_tukhoa_tan.Margin = new System.Windows.Forms.Padding(2);
            this.tb_tukhoa_tan.Name = "tb_tukhoa_tan";
            this.tb_tukhoa_tan.Size = new System.Drawing.Size(189, 24);
            this.tb_tukhoa_tan.TabIndex = 31;
            this.tb_tukhoa_tan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_tukhoa_tan_KeyPress);
            // 
            // tb_ma_tan
            // 
            this.tb_ma_tan.Location = new System.Drawing.Point(147, 75);
            this.tb_ma_tan.Margin = new System.Windows.Forms.Padding(2);
            this.tb_ma_tan.Name = "tb_ma_tan";
            this.tb_ma_tan.Size = new System.Drawing.Size(143, 24);
            this.tb_ma_tan.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(351, 130);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 18);
            this.label7.TabIndex = 29;
            this.label7.Text = "Giới TÍnh";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(351, 179);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 18);
            this.label6.TabIndex = 28;
            this.label6.Text = "SDT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 175);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 18);
            this.label5.TabIndex = 27;
            this.label5.Text = "CMT/CCCD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 130);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 18);
            this.label3.TabIndex = 25;
            this.label3.Text = "Tên Khách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 18);
            this.label2.TabIndex = 24;
            this.label2.Text = "Mã Khách Hàng";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.SkyBlue;
            this.groupBox2.Controls.Add(this.bt_thoat_tan);
            this.groupBox2.Controls.Add(this.bt_sua_tan);
            this.groupBox2.Controls.Add(this.bt_xoa_tan);
            this.groupBox2.Controls.Add(this.bt_them_tan);
            this.groupBox2.Controls.Add(this.bt_quaylai_tan);
            this.groupBox2.Controls.Add(this.bt_timkiem_tan);
            this.groupBox2.Controls.Add(this.rb_nu_tan);
            this.groupBox2.Controls.Add(this.rb_nam_tan);
            this.groupBox2.Controls.Add(this.cb_qt_tan);
            this.groupBox2.Controls.Add(this.tb_ten_tan);
            this.groupBox2.Controls.Add(this.tb_cmt_tan);
            this.groupBox2.Controls.Add(this.tb_sdt_tan);
            this.groupBox2.Controls.Add(this.tb_tukhoa_tan);
            this.groupBox2.Controls.Add(this.tb_ma_tan);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(9, 217);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(758, 228);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(351, 77);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 18);
            this.label4.TabIndex = 26;
            this.label4.Text = "Quốc Tịch";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SkyBlue;
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dgv_qlkh_tan);
            this.groupBox1.Location = new System.Drawing.Point(8, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(771, 469);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // bt_xoa_tan
            // 
            this.bt_xoa_tan.BackColor = System.Drawing.Color.White;
            this.bt_xoa_tan.Image = global::Nhom5_QLKS.Properties.Resources.Button_Delete_icon;
            this.bt_xoa_tan.Location = new System.Drawing.Point(600, 67);
            this.bt_xoa_tan.Margin = new System.Windows.Forms.Padding(2);
            this.bt_xoa_tan.Name = "bt_xoa_tan";
            this.bt_xoa_tan.Size = new System.Drawing.Size(130, 44);
            this.bt_xoa_tan.TabIndex = 41;
            this.bt_xoa_tan.Text = "Xóa ";
            this.bt_xoa_tan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_xoa_tan.UseVisualStyleBackColor = false;
            this.bt_xoa_tan.Click += new System.EventHandler(this.bt_xoa_tan_Click);
            // 
            // bt_them_tan
            // 
            this.bt_them_tan.BackColor = System.Drawing.Color.White;
            this.bt_them_tan.Image = global::Nhom5_QLKS.Properties.Resources.Button_Add_icon;
            this.bt_them_tan.Location = new System.Drawing.Point(600, 19);
            this.bt_them_tan.Margin = new System.Windows.Forms.Padding(2);
            this.bt_them_tan.Name = "bt_them_tan";
            this.bt_them_tan.Size = new System.Drawing.Size(130, 44);
            this.bt_them_tan.TabIndex = 40;
            this.bt_them_tan.Text = "Thêm";
            this.bt_them_tan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_them_tan.UseVisualStyleBackColor = false;
            this.bt_them_tan.Click += new System.EventHandler(this.bt_them_tan_Click);
            // 
            // bt_quaylai_tan
            // 
            this.bt_quaylai_tan.BackColor = System.Drawing.Color.White;
            this.bt_quaylai_tan.Image = global::Nhom5_QLKS.Properties.Resources.load;
            this.bt_quaylai_tan.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_quaylai_tan.Location = new System.Drawing.Point(452, 18);
            this.bt_quaylai_tan.Margin = new System.Windows.Forms.Padding(2);
            this.bt_quaylai_tan.Name = "bt_quaylai_tan";
            this.bt_quaylai_tan.Size = new System.Drawing.Size(122, 36);
            this.bt_quaylai_tan.TabIndex = 39;
            this.bt_quaylai_tan.Text = "Refresh";
            this.bt_quaylai_tan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_quaylai_tan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_quaylai_tan.UseVisualStyleBackColor = false;
            this.bt_quaylai_tan.Click += new System.EventHandler(this.bt_quaylai_tan_Click);
            // 
            // frm_QLKH_tan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(790, 480);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_QLKH_tan";
            this.Text = "frm_Quản lý Khách Hàng_Nguyễn Văn Tân";
            this.Load += new System.EventHandler(this.frm_QLKH_tan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_qlkh_tan)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_thoat_tan;
        private System.Windows.Forms.Button bt_sua_tan;
        private System.Windows.Forms.Button bt_xoa_tan;
        private System.Windows.Forms.Button bt_them_tan;
        private System.Windows.Forms.Button bt_quaylai_tan;
        private System.Windows.Forms.Button bt_timkiem_tan;
        private System.Windows.Forms.RadioButton rb_nu_tan;
        private System.Windows.Forms.RadioButton rb_nam_tan;
        private System.Windows.Forms.ComboBox cb_qt_tan;
        private System.Windows.Forms.TextBox tb_cmt_tan;
        private System.Windows.Forms.TextBox tb_sdt_tan;
        private System.Windows.Forms.DataGridView dgv_qlkh_tan;
        private System.Windows.Forms.TextBox tb_ten_tan;
        private System.Windows.Forms.TextBox tb_tukhoa_tan;
        private System.Windows.Forms.TextBox tb_ma_tan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKhach;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenKhach;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMT;
        private System.Windows.Forms.DataGridViewTextBoxColumn quocTich;
        private System.Windows.Forms.DataGridViewCheckBoxColumn gioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;

    }
}