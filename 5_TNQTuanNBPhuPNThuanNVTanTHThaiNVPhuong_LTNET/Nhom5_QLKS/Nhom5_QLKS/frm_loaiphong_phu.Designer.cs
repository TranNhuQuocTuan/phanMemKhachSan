
namespace Nhom5_QLKS
{
    partial class frm_loaiphong_phu
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
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbGiaphong_Phu = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbLoaiphong_Phu = new System.Windows.Forms.ComboBox();
            this.dgloaiPhong_Phu = new System.Windows.Forms.DataGridView();
            this.btnThoat_Phu = new System.Windows.Forms.Button();
            this.btnXoa_Phu = new System.Windows.Forms.Button();
            this.btnSua_Phu = new System.Windows.Forms.Button();
            this.btnThem_Phu = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgloaiPhong_Phu)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(155, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(489, 36);
            this.label7.TabIndex = 81;
            this.label7.Text = "QUẢN LÝ LOẠI PHÒNG";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.tbGiaphong_Phu);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.cbLoaiphong_Phu);
            this.groupBox2.Controls.Add(this.dgloaiPhong_Phu);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 80);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(788, 328);
            this.groupBox2.TabIndex = 80;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin phòng";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(436, 262);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 16);
            this.label12.TabIndex = 11;
            this.label12.Text = "Giá phòng ";
            // 
            // tbGiaphong_Phu
            // 
            this.tbGiaphong_Phu.Location = new System.Drawing.Point(538, 258);
            this.tbGiaphong_Phu.Multiline = true;
            this.tbGiaphong_Phu.Name = "tbGiaphong_Phu";
            this.tbGiaphong_Phu.Size = new System.Drawing.Size(230, 33);
            this.tbGiaphong_Phu.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(32, 262);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 16);
            this.label11.TabIndex = 8;
            this.label11.Text = "Loại phòng";
            // 
            // cbLoaiphong_Phu
            // 
            this.cbLoaiphong_Phu.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbLoaiphong_Phu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cbLoaiphong_Phu.FormattingEnabled = true;
            this.cbLoaiphong_Phu.Location = new System.Drawing.Point(163, 258);
            this.cbLoaiphong_Phu.Name = "cbLoaiphong_Phu";
            this.cbLoaiphong_Phu.Size = new System.Drawing.Size(230, 23);
            this.cbLoaiphong_Phu.TabIndex = 5;
            // 
            // dgloaiPhong_Phu
            // 
            this.dgloaiPhong_Phu.AllowUserToOrderColumns = true;
            this.dgloaiPhong_Phu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgloaiPhong_Phu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgloaiPhong_Phu.Location = new System.Drawing.Point(27, 25);
            this.dgloaiPhong_Phu.Name = "dgloaiPhong_Phu";
            this.dgloaiPhong_Phu.RowTemplate.Height = 28;
            this.dgloaiPhong_Phu.Size = new System.Drawing.Size(738, 202);
            this.dgloaiPhong_Phu.TabIndex = 3;
            this.dgloaiPhong_Phu.SelectionChanged += new System.EventHandler(this.dgloaiPhong_Phu_SelectionChanged);
            // 
            // btnThoat_Phu
            // 
            this.btnThoat_Phu.BackColor = System.Drawing.SystemColors.Info;
            this.btnThoat_Phu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat_Phu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnThoat_Phu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat_Phu.Location = new System.Drawing.Point(507, 531);
            this.btnThoat_Phu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThoat_Phu.Name = "btnThoat_Phu";
            this.btnThoat_Phu.Size = new System.Drawing.Size(271, 57);
            this.btnThoat_Phu.TabIndex = 79;
            this.btnThoat_Phu.Text = "Thoát";
            this.btnThoat_Phu.UseVisualStyleBackColor = false;
            this.btnThoat_Phu.Click += new System.EventHandler(this.btnThoat_Phu_Click);
            // 
            // btnXoa_Phu
            // 
            this.btnXoa_Phu.BackColor = System.Drawing.SystemColors.Info;
            this.btnXoa_Phu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa_Phu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa_Phu.Location = new System.Drawing.Point(40, 531);
            this.btnXoa_Phu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXoa_Phu.Name = "btnXoa_Phu";
            this.btnXoa_Phu.Size = new System.Drawing.Size(252, 57);
            this.btnXoa_Phu.TabIndex = 78;
            this.btnXoa_Phu.Text = "Xóa loại phòng";
            this.btnXoa_Phu.UseVisualStyleBackColor = false;
            this.btnXoa_Phu.Click += new System.EventHandler(this.btnXoa_Phu_Click);
            // 
            // btnSua_Phu
            // 
            this.btnSua_Phu.BackColor = System.Drawing.SystemColors.Info;
            this.btnSua_Phu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua_Phu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua_Phu.Location = new System.Drawing.Point(510, 428);
            this.btnSua_Phu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSua_Phu.Name = "btnSua_Phu";
            this.btnSua_Phu.Size = new System.Drawing.Size(271, 57);
            this.btnSua_Phu.TabIndex = 77;
            this.btnSua_Phu.Text = "Sửa thông tin phòng";
            this.btnSua_Phu.UseVisualStyleBackColor = false;
            this.btnSua_Phu.Click += new System.EventHandler(this.btnSua_Phu_Click);
            // 
            // btnThem_Phu
            // 
            this.btnThem_Phu.BackColor = System.Drawing.SystemColors.Info;
            this.btnThem_Phu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem_Phu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem_Phu.Location = new System.Drawing.Point(40, 428);
            this.btnThem_Phu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThem_Phu.Name = "btnThem_Phu";
            this.btnThem_Phu.Size = new System.Drawing.Size(252, 57);
            this.btnThem_Phu.TabIndex = 76;
            this.btnThem_Phu.Text = "Thêm loại  phòng";
            this.btnThem_Phu.UseVisualStyleBackColor = false;
            this.btnThem_Phu.Click += new System.EventHandler(this.btnThem_Phu_Click);
            // 
            // frm_loaiphong_phu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(821, 668);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnThoat_Phu);
            this.Controls.Add(this.btnXoa_Phu);
            this.Controls.Add(this.btnSua_Phu);
            this.Controls.Add(this.btnThem_Phu);
            this.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frm_loaiphong_phu";
            this.Text = "frmLoaiphong_Phu";
            this.Load += new System.EventHandler(this.frm_loaiphong_phu_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgloaiPhong_Phu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbGiaphong_Phu;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbLoaiphong_Phu;
        private System.Windows.Forms.DataGridView dgloaiPhong_Phu;
        private System.Windows.Forms.Button btnThoat_Phu;
        private System.Windows.Forms.Button btnXoa_Phu;
        private System.Windows.Forms.Button btnSua_Phu;
        private System.Windows.Forms.Button btnThem_Phu;
    }
}