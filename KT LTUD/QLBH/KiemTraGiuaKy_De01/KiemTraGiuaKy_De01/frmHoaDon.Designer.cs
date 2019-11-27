namespace KiemTraGiuaKy_De01
{
    partial class frmHoadon
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
            this.tvHoadon = new System.Windows.Forms.TreeView();
            this.lvHoadon = new System.Windows.Forms.ListView();
            this.colMahoadon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHotenkh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNgayxuathd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLoaikh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colThanhtien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpNgayxuathd = new System.Windows.Forms.DateTimePicker();
            this.txtMahoadon = new System.Windows.Forms.TextBox();
            this.txtHotenkh = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtThanhtien = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTienthanhtoan = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupbox2 = new System.Windows.Forms.GroupBox();
            this.btnNhapmoi = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.cboLoaikh = new System.Windows.Forms.ComboBox();
            this.btnLuufile = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupbox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(411, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "HÓA ĐƠN KHÁCH HÀNG";
            // 
            // tvHoadon
            // 
            this.tvHoadon.Location = new System.Drawing.Point(36, 63);
            this.tvHoadon.Name = "tvHoadon";
            this.tvHoadon.Size = new System.Drawing.Size(188, 219);
            this.tvHoadon.TabIndex = 1;
            // 
            // lvHoadon
            // 
            this.lvHoadon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMahoadon,
            this.colHotenkh,
            this.colNgayxuathd,
            this.colLoaikh,
            this.colThanhtien});
            this.lvHoadon.Location = new System.Drawing.Point(260, 63);
            this.lvHoadon.Name = "lvHoadon";
            this.lvHoadon.Size = new System.Drawing.Size(468, 219);
            this.lvHoadon.TabIndex = 2;
            this.lvHoadon.UseCompatibleStateImageBehavior = false;
            this.lvHoadon.View = System.Windows.Forms.View.Details;
            // 
            // colMahoadon
            // 
            this.colMahoadon.Text = "Mã hóa đơn";
            this.colMahoadon.Width = 77;
            // 
            // colHotenkh
            // 
            this.colHotenkh.Text = "Họ tên KH";
            this.colHotenkh.Width = 128;
            // 
            // colNgayxuathd
            // 
            this.colNgayxuathd.Text = "Ngày xuất HĐ";
            this.colNgayxuathd.Width = 91;
            // 
            // colLoaikh
            // 
            this.colLoaikh.Text = "Loại KH";
            this.colLoaikh.Width = 87;
            // 
            // colThanhtien
            // 
            this.colThanhtien.Text = "Thành tiền";
            this.colThanhtien.Width = 80;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboLoaikh);
            this.groupBox1.Controls.Add(this.txtTienthanhtoan);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtThanhtien);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtHotenkh);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtMahoadon);
            this.groupBox1.Controls.Add(this.dtpNgayxuathd);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(36, 323);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(584, 154);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hóa đơn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ngày xuất hóa đơn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã hóa đơn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Loại khách hàng";
            // 
            // dtpNgayxuathd
            // 
            this.dtpNgayxuathd.Enabled = false;
            this.dtpNgayxuathd.Location = new System.Drawing.Point(148, 37);
            this.dtpNgayxuathd.Name = "dtpNgayxuathd";
            this.dtpNgayxuathd.Size = new System.Drawing.Size(115, 20);
            this.dtpNgayxuathd.TabIndex = 3;
            // 
            // txtMahoadon
            // 
            this.txtMahoadon.Enabled = false;
            this.txtMahoadon.Location = new System.Drawing.Point(148, 77);
            this.txtMahoadon.Name = "txtMahoadon";
            this.txtMahoadon.Size = new System.Drawing.Size(115, 20);
            this.txtMahoadon.TabIndex = 4;
            // 
            // txtHotenkh
            // 
            this.txtHotenkh.Enabled = false;
            this.txtHotenkh.Location = new System.Drawing.Point(456, 40);
            this.txtHotenkh.Name = "txtHotenkh";
            this.txtHotenkh.Size = new System.Drawing.Size(115, 20);
            this.txtHotenkh.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(315, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Họ tên khách hàng";
            // 
            // txtThanhtien
            // 
            this.txtThanhtien.Enabled = false;
            this.txtThanhtien.Location = new System.Drawing.Point(456, 77);
            this.txtThanhtien.Name = "txtThanhtien";
            this.txtThanhtien.Size = new System.Drawing.Size(115, 20);
            this.txtThanhtien.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(315, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Thành tiền";
            // 
            // txtTienthanhtoan
            // 
            this.txtTienthanhtoan.Enabled = false;
            this.txtTienthanhtoan.Location = new System.Drawing.Point(456, 112);
            this.txtTienthanhtoan.Name = "txtTienthanhtoan";
            this.txtTienthanhtoan.Size = new System.Drawing.Size(115, 20);
            this.txtTienthanhtoan.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(315, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Tiền thanh toán";
            // 
            // groupbox2
            // 
            this.groupbox2.Controls.Add(this.btnThoat);
            this.groupbox2.Controls.Add(this.btnLuu);
            this.groupbox2.Controls.Add(this.btnNhapmoi);
            this.groupbox2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupbox2.Location = new System.Drawing.Point(354, 535);
            this.groupbox2.Name = "groupbox2";
            this.groupbox2.Size = new System.Drawing.Size(326, 56);
            this.groupbox2.TabIndex = 4;
            this.groupbox2.TabStop = false;
            // 
            // btnNhapmoi
            // 
            this.btnNhapmoi.Location = new System.Drawing.Point(21, 19);
            this.btnNhapmoi.Name = "btnNhapmoi";
            this.btnNhapmoi.Size = new System.Drawing.Size(75, 23);
            this.btnNhapmoi.TabIndex = 0;
            this.btnNhapmoi.Text = "Nhập Mới";
            this.btnNhapmoi.UseVisualStyleBackColor = true;
            this.btnNhapmoi.Click += new System.EventHandler(this.btnNhapmoi_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Enabled = false;
            this.btnLuu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLuu.Location = new System.Drawing.Point(129, 19);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 1;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Enabled = false;
            this.btnThoat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnThoat.Location = new System.Drawing.Point(234, 19);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // cboLoaikh
            // 
            this.cboLoaikh.Enabled = false;
            this.cboLoaikh.FormattingEnabled = true;
            this.cboLoaikh.Items.AddRange(new object[] {
            "Khách hàng thành viên",
            "Khách hàng thân thiết",
            "Khách hàng VIP"});
            this.cboLoaikh.Location = new System.Drawing.Point(148, 107);
            this.cboLoaikh.Name = "cboLoaikh";
            this.cboLoaikh.Size = new System.Drawing.Size(115, 21);
            this.cboLoaikh.TabIndex = 12;
            // 
            // btnLuufile
            // 
            this.btnLuufile.Enabled = false;
            this.btnLuufile.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLuufile.Location = new System.Drawing.Point(246, 554);
            this.btnLuufile.Name = "btnLuufile";
            this.btnLuufile.Size = new System.Drawing.Size(75, 23);
            this.btnLuufile.TabIndex = 5;
            this.btnLuufile.Text = "Lưu file";
            this.btnLuufile.UseVisualStyleBackColor = true;
            this.btnLuufile.Click += new System.EventHandler(this.btnLuufile_Click);
            // 
            // frmHoadon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 612);
            this.Controls.Add(this.btnLuufile);
            this.Controls.Add(this.groupbox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lvHoadon);
            this.Controls.Add(this.tvHoadon);
            this.Controls.Add(this.label1);
            this.Name = "frmHoadon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmHoaDon";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupbox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView tvHoadon;
        private System.Windows.Forms.ListView lvHoadon;
        private System.Windows.Forms.ColumnHeader colMahoadon;
        private System.Windows.Forms.ColumnHeader colHotenkh;
        private System.Windows.Forms.ColumnHeader colNgayxuathd;
        private System.Windows.Forms.ColumnHeader colLoaikh;
        private System.Windows.Forms.ColumnHeader colThanhtien;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTienthanhtoan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtThanhtien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtHotenkh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMahoadon;
        private System.Windows.Forms.DateTimePicker dtpNgayxuathd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupbox2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnNhapmoi;
        private System.Windows.Forms.ComboBox cboLoaikh;
        private System.Windows.Forms.Button btnLuufile;
    }
}