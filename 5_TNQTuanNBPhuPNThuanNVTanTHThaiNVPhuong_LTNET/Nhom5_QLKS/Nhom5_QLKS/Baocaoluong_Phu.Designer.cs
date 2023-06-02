
namespace Nhom5_QLKS
{
    partial class Baocaoluong_Phu
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
            this.label2 = new System.Windows.Forms.Label();
            this.dgLuong_Phu = new System.Windows.Forms.DataGridView();
            this.btnThoat_Phu = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbLuong_Phu = new System.Windows.Forms.Label();
            this.lbChu_Phu = new System.Windows.Forms.Label();
            this.cbMa_Phu = new System.Windows.Forms.ComboBox();
            this.tbSearch_Phu = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnXuat_Phu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgLuong_Phu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhân viên";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(103, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(327, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "THỐNG KÊ LƯƠNG NHÂN VIÊN";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgLuong_Phu
            // 
            this.dgLuong_Phu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgLuong_Phu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLuong_Phu.Location = new System.Drawing.Point(8, 86);
            this.dgLuong_Phu.Margin = new System.Windows.Forms.Padding(2);
            this.dgLuong_Phu.Name = "dgLuong_Phu";
            this.dgLuong_Phu.RowTemplate.Height = 28;
            this.dgLuong_Phu.Size = new System.Drawing.Size(581, 133);
            this.dgLuong_Phu.TabIndex = 3;
            // 
            // btnThoat_Phu
            // 
            this.btnThoat_Phu.BackColor = System.Drawing.Color.White;
            this.btnThoat_Phu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat_Phu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat_Phu.Location = new System.Drawing.Point(456, 268);
            this.btnThoat_Phu.Name = "btnThoat_Phu";
            this.btnThoat_Phu.Size = new System.Drawing.Size(133, 37);
            this.btnThoat_Phu.TabIndex = 46;
            this.btnThoat_Phu.Text = "Thoát";
            this.btnThoat_Phu.UseVisualStyleBackColor = false;
            this.btnThoat_Phu.Click += new System.EventHandler(this.btnThoat_Phu_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 250);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 18);
            this.label3.TabIndex = 47;
            this.label3.Text = "Lương";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 292);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 18);
            this.label4.TabIndex = 48;
            this.label4.Text = "Lương (Chữ)";
            // 
            // lbLuong_Phu
            // 
            this.lbLuong_Phu.Location = new System.Drawing.Point(136, 250);
            this.lbLuong_Phu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbLuong_Phu.Name = "lbLuong_Phu";
            this.lbLuong_Phu.Size = new System.Drawing.Size(97, 24);
            this.lbLuong_Phu.TabIndex = 50;
            // 
            // lbChu_Phu
            // 
            this.lbChu_Phu.Location = new System.Drawing.Point(136, 292);
            this.lbChu_Phu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbChu_Phu.Name = "lbChu_Phu";
            this.lbChu_Phu.Size = new System.Drawing.Size(97, 24);
            this.lbChu_Phu.TabIndex = 51;
            // 
            // cbMa_Phu
            // 
            this.cbMa_Phu.FormattingEnabled = true;
            this.cbMa_Phu.Items.AddRange(new object[] {
            "Mã nhân viên",
            "Tên nhân viên"});
            this.cbMa_Phu.Location = new System.Drawing.Point(254, 46);
            this.cbMa_Phu.Margin = new System.Windows.Forms.Padding(2);
            this.cbMa_Phu.Name = "cbMa_Phu";
            this.cbMa_Phu.Size = new System.Drawing.Size(104, 21);
            this.cbMa_Phu.TabIndex = 49;
            // 
            // tbSearch_Phu
            // 
            this.tbSearch_Phu.Location = new System.Drawing.Point(401, 46);
            this.tbSearch_Phu.Margin = new System.Windows.Forms.Padding(2);
            this.tbSearch_Phu.Name = "tbSearch_Phu";
            this.tbSearch_Phu.Size = new System.Drawing.Size(89, 20);
            this.tbSearch_Phu.TabIndex = 52;
            this.tbSearch_Phu.TextChanged += new System.EventHandler(this.tbSearch_Phu_TextChanged);
            // 
            // btnXuat_Phu
            // 
            this.btnXuat_Phu.BackColor = System.Drawing.Color.White;
            this.btnXuat_Phu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuat_Phu.Image = global::Nhom5_QLKS.Properties.Resources.exx;
            this.btnXuat_Phu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXuat_Phu.Location = new System.Drawing.Point(291, 268);
            this.btnXuat_Phu.Name = "btnXuat_Phu";
            this.btnXuat_Phu.Size = new System.Drawing.Size(154, 37);
            this.btnXuat_Phu.TabIndex = 45;
            this.btnXuat_Phu.Text = "   Xuất Excel";
            this.btnXuat_Phu.UseVisualStyleBackColor = false;
            this.btnXuat_Phu.Click += new System.EventHandler(this.btnXuat_Phu_Click);
            // 
            // Baocaoluong_Phu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(603, 338);
            this.Controls.Add(this.tbSearch_Phu);
            this.Controls.Add(this.lbChu_Phu);
            this.Controls.Add(this.lbLuong_Phu);
            this.Controls.Add(this.cbMa_Phu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnThoat_Phu);
            this.Controls.Add(this.btnXuat_Phu);
            this.Controls.Add(this.dgLuong_Phu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Baocaoluong_Phu";
            this.Text = "Baocaoluong_Phu";
            this.Load += new System.EventHandler(this.Baocaoluong_Phu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgLuong_Phu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgLuong_Phu;
        private System.Windows.Forms.Button btnXuat_Phu;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThoat_Phu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbLuong_Phu;
        private System.Windows.Forms.Label lbChu_Phu;
        private System.Windows.Forms.ComboBox cbMa_Phu;
        private System.Windows.Forms.TextBox tbSearch_Phu;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}