namespace KiemTra
{
    partial class frmBangDiem
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
            this.lblMasv = new System.Windows.Forms.Label();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.lblDiemKetQua = new System.Windows.Forms.Label();
            this.lblDiemThi = new System.Windows.Forms.Label();
            this.lblDiemGiuKy = new System.Windows.Forms.Label();
            this.lblHocPhan = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtMasv = new System.Windows.Forms.TextBox();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.txtDiemKetQua = new System.Windows.Forms.TextBox();
            this.txtDiemThi = new System.Windows.Forms.TextBox();
            this.txtDiemGiuKy = new System.Windows.Forms.TextBox();
            this.cbbHocPhan = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.cloMaSinhVien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cloHoTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cloHoPhan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cloDiemGiuKy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cloDiemThi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cloDiemKetQua = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grbButton = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnTinhDiem = new System.Windows.Forms.Button();
            this.btnNhapMoi = new System.Windows.Forms.Button();
            this.grbButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(313, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "BẢNG ĐIỂM SINH VIÊN";
            // 
            // lblMasv
            // 
            this.lblMasv.AutoSize = true;
            this.lblMasv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMasv.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMasv.Location = new System.Drawing.Point(12, 62);
            this.lblMasv.Name = "lblMasv";
            this.lblMasv.Size = new System.Drawing.Size(88, 16);
            this.lblMasv.TabIndex = 1;
            this.lblMasv.Text = "Mã sinh viên: ";
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKetQua.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblKetQua.Location = new System.Drawing.Point(12, 234);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(56, 16);
            this.lblKetQua.TabIndex = 3;
            this.lblKetQua.Text = "Kết quả:";
            // 
            // lblDiemKetQua
            // 
            this.lblDiemKetQua.AutoSize = true;
            this.lblDiemKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiemKetQua.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDiemKetQua.Location = new System.Drawing.Point(11, 206);
            this.lblDiemKetQua.Name = "lblDiemKetQua";
            this.lblDiemKetQua.Size = new System.Drawing.Size(92, 16);
            this.lblDiemKetQua.TabIndex = 4;
            this.lblDiemKetQua.Text = "Điểm kết quả: ";
            // 
            // lblDiemThi
            // 
            this.lblDiemThi.AutoSize = true;
            this.lblDiemThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiemThi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDiemThi.Location = new System.Drawing.Point(11, 181);
            this.lblDiemThi.Name = "lblDiemThi";
            this.lblDiemThi.Size = new System.Drawing.Size(61, 16);
            this.lblDiemThi.TabIndex = 5;
            this.lblDiemThi.Text = "Điểm thi: ";
            // 
            // lblDiemGiuKy
            // 
            this.lblDiemGiuKy.AutoSize = true;
            this.lblDiemGiuKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiemGiuKy.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDiemGiuKy.Location = new System.Drawing.Point(12, 148);
            this.lblDiemGiuKy.Name = "lblDiemGiuKy";
            this.lblDiemGiuKy.Size = new System.Drawing.Size(83, 16);
            this.lblDiemGiuKy.TabIndex = 6;
            this.lblDiemGiuKy.Text = "Điễm giữ kỳ: ";
            // 
            // lblHocPhan
            // 
            this.lblHocPhan.AutoSize = true;
            this.lblHocPhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHocPhan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblHocPhan.Location = new System.Drawing.Point(12, 119);
            this.lblHocPhan.Name = "lblHocPhan";
            this.lblHocPhan.Size = new System.Drawing.Size(70, 16);
            this.lblHocPhan.TabIndex = 7;
            this.lblHocPhan.Text = "Học Phần:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblName.Location = new System.Drawing.Point(12, 92);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(108, 16);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "Họ tên sinh viên: ";
            // 
            // txtMasv
            // 
            this.txtMasv.Location = new System.Drawing.Point(120, 61);
            this.txtMasv.Name = "txtMasv";
            this.txtMasv.Size = new System.Drawing.Size(148, 20);
            this.txtMasv.TabIndex = 9;
            // 
            // txtKetQua
            // 
            this.txtKetQua.Location = new System.Drawing.Point(120, 234);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.ReadOnly = true;
            this.txtKetQua.Size = new System.Drawing.Size(148, 20);
            this.txtKetQua.TabIndex = 10;
            // 
            // txtDiemKetQua
            // 
            this.txtDiemKetQua.Location = new System.Drawing.Point(120, 206);
            this.txtDiemKetQua.Name = "txtDiemKetQua";
            this.txtDiemKetQua.ReadOnly = true;
            this.txtDiemKetQua.Size = new System.Drawing.Size(148, 20);
            this.txtDiemKetQua.TabIndex = 11;
            // 
            // txtDiemThi
            // 
            this.txtDiemThi.Location = new System.Drawing.Point(120, 177);
            this.txtDiemThi.Name = "txtDiemThi";
            this.txtDiemThi.Size = new System.Drawing.Size(148, 20);
            this.txtDiemThi.TabIndex = 12;
            // 
            // txtDiemGiuKy
            // 
            this.txtDiemGiuKy.Location = new System.Drawing.Point(120, 144);
            this.txtDiemGiuKy.Name = "txtDiemGiuKy";
            this.txtDiemGiuKy.Size = new System.Drawing.Size(148, 20);
            this.txtDiemGiuKy.TabIndex = 13;
            // 
            // cbbHocPhan
            // 
            this.cbbHocPhan.FormattingEnabled = true;
            this.cbbHocPhan.Items.AddRange(new object[] {
            "Lập trình hướng đối tượng",
            "Lập trình C# căn bản",
            "Lập trình C# nâng cao"});
            this.cbbHocPhan.Location = new System.Drawing.Point(120, 117);
            this.cbbHocPhan.Name = "cbbHocPhan";
            this.cbbHocPhan.Size = new System.Drawing.Size(148, 21);
            this.cbbHocPhan.TabIndex = 14;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(120, 88);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(148, 20);
            this.txtName.TabIndex = 15;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cloMaSinhVien,
            this.cloHoTen,
            this.cloHoPhan,
            this.cloDiemGiuKy,
            this.cloDiemThi,
            this.cloDiemKetQua});
            this.listView1.Location = new System.Drawing.Point(274, 46);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(555, 224);
            this.listView1.TabIndex = 16;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // cloMaSinhVien
            // 
            this.cloMaSinhVien.Text = "Mã Sinh viên";
            this.cloMaSinhVien.Width = 90;
            // 
            // cloHoTen
            // 
            this.cloHoTen.Text = "Họ Và Tên";
            this.cloHoTen.Width = 95;
            // 
            // cloHoPhan
            // 
            this.cloHoPhan.Text = "Học Phần";
            this.cloHoPhan.Width = 95;
            // 
            // cloDiemGiuKy
            // 
            this.cloDiemGiuKy.Text = "Điểm Giữ Kỳ";
            this.cloDiemGiuKy.Width = 90;
            // 
            // cloDiemThi
            // 
            this.cloDiemThi.Text = "Điểm Thi";
            this.cloDiemThi.Width = 90;
            // 
            // cloDiemKetQua
            // 
            this.cloDiemKetQua.Text = "Điểm Kết Quả";
            this.cloDiemKetQua.Width = 90;
            // 
            // grbButton
            // 
            this.grbButton.Controls.Add(this.btnThoat);
            this.grbButton.Controls.Add(this.btnLuu);
            this.grbButton.Controls.Add(this.btnTinhDiem);
            this.grbButton.Controls.Add(this.btnNhapMoi);
            this.grbButton.Location = new System.Drawing.Point(88, 291);
            this.grbButton.Name = "grbButton";
            this.grbButton.Size = new System.Drawing.Size(693, 75);
            this.grbButton.TabIndex = 17;
            this.grbButton.TabStop = false;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(591, 31);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(397, 31);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 2;
            this.btnLuu.Text = "Lưu File";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnTinhDiem
            // 
            this.btnTinhDiem.Location = new System.Drawing.Point(210, 31);
            this.btnTinhDiem.Name = "btnTinhDiem";
            this.btnTinhDiem.Size = new System.Drawing.Size(75, 23);
            this.btnTinhDiem.TabIndex = 1;
            this.btnTinhDiem.Text = "Tính Điểm";
            this.btnTinhDiem.UseVisualStyleBackColor = true;
            this.btnTinhDiem.Click += new System.EventHandler(this.btnTinhDiem_Click);
            // 
            // btnNhapMoi
            // 
            this.btnNhapMoi.Location = new System.Drawing.Point(32, 31);
            this.btnNhapMoi.Name = "btnNhapMoi";
            this.btnNhapMoi.Size = new System.Drawing.Size(75, 23);
            this.btnNhapMoi.TabIndex = 0;
            this.btnNhapMoi.Text = "Nhập mới";
            this.btnNhapMoi.UseVisualStyleBackColor = true;
            this.btnNhapMoi.Click += new System.EventHandler(this.btnNhapMoi_Click);
            // 
            // frmBangDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 378);
            this.Controls.Add(this.grbButton);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.cbbHocPhan);
            this.Controls.Add(this.txtDiemGiuKy);
            this.Controls.Add(this.txtDiemThi);
            this.Controls.Add(this.txtDiemKetQua);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.txtMasv);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblHocPhan);
            this.Controls.Add(this.lblDiemGiuKy);
            this.Controls.Add(this.lblDiemThi);
            this.Controls.Add(this.lblDiemKetQua);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.lblMasv);
            this.Controls.Add(this.label1);
            this.Name = "frmBangDiem";
            this.Text = "BẢNG ĐIỂM SINH VIÊN";
            this.grbButton.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMasv;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.Label lblDiemKetQua;
        private System.Windows.Forms.Label lblDiemThi;
        private System.Windows.Forms.Label lblDiemGiuKy;
        private System.Windows.Forms.Label lblHocPhan;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtMasv;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.TextBox txtDiemKetQua;
        private System.Windows.Forms.TextBox txtDiemThi;
        private System.Windows.Forms.TextBox txtDiemGiuKy;
        private System.Windows.Forms.ComboBox cbbHocPhan;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader cloMaSinhVien;
        private System.Windows.Forms.ColumnHeader cloHoTen;
        private System.Windows.Forms.ColumnHeader cloHoPhan;
        private System.Windows.Forms.ColumnHeader cloDiemGiuKy;
        private System.Windows.Forms.ColumnHeader cloDiemThi;
        private System.Windows.Forms.ColumnHeader cloDiemKetQua;
        private System.Windows.Forms.GroupBox grbButton;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnTinhDiem;
        private System.Windows.Forms.Button btnNhapMoi;
    }
}