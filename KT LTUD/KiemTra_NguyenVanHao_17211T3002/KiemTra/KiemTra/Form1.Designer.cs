namespace KiemTra
{
    partial class frmThi
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblLop = new System.Windows.Forms.Label();
            this.lblSomay = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.chươngTrìnhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLíSinhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhậpĐiểmSinhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(172, 77);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(235, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Họ và Tên: Nguyễn Văn Hảo";
            // 
            // lblLop
            // 
            this.lblLop.AutoSize = true;
            this.lblLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLop.Location = new System.Drawing.Point(86, 134);
            this.lblLop.Name = "lblLop";
            this.lblLop.Size = new System.Drawing.Size(124, 20);
            this.lblLop.TabIndex = 1;
            this.lblLop.Text = "Lớp: CD17TT7";
            // 
            // lblSomay
            // 
            this.lblSomay.AutoSize = true;
            this.lblSomay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSomay.Location = new System.Drawing.Point(359, 134);
            this.lblSomay.Name = "lblSomay";
            this.lblSomay.Size = new System.Drawing.Size(98, 20);
            this.lblSomay.TabIndex = 2;
            this.lblSomay.Text = "Số Máy: 30";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chươngTrìnhToolStripMenuItem,
            this.chứcNăngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(623, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // chươngTrìnhToolStripMenuItem
            // 
            this.chươngTrìnhToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngNhậpToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.chươngTrìnhToolStripMenuItem.Name = "chươngTrìnhToolStripMenuItem";
            this.chươngTrìnhToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.chươngTrìnhToolStripMenuItem.Text = "Chương Trình";
            // 
            // đăngNhậpToolStripMenuItem
            // 
            this.đăngNhậpToolStripMenuItem.Name = "đăngNhậpToolStripMenuItem";
            this.đăngNhậpToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.đăngNhậpToolStripMenuItem.Text = "Đăng Nhập";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng Xuất";
            // 
            // chứcNăngToolStripMenuItem
            // 
            this.chứcNăngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLíSinhViênToolStripMenuItem,
            this.nhậpĐiểmSinhViênToolStripMenuItem});
            this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.chứcNăngToolStripMenuItem.Text = "Chức Năng";
            // 
            // quảnLíSinhViênToolStripMenuItem
            // 
            this.quảnLíSinhViênToolStripMenuItem.Name = "quảnLíSinhViênToolStripMenuItem";
            this.quảnLíSinhViênToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.quảnLíSinhViênToolStripMenuItem.Text = "Quản Lí Sinh Viên";
            // 
            // nhậpĐiểmSinhViênToolStripMenuItem
            // 
            this.nhậpĐiểmSinhViênToolStripMenuItem.Name = "nhậpĐiểmSinhViênToolStripMenuItem";
            this.nhậpĐiểmSinhViênToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.nhậpĐiểmSinhViênToolStripMenuItem.Text = "Nhập Điểm Sinh Viên";
            this.nhậpĐiểmSinhViênToolStripMenuItem.Click += new System.EventHandler(this.nhậpĐiểmSinhViênToolStripMenuItem_Click);
            // 
            // frmThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 262);
            this.Controls.Add(this.lblSomay);
            this.Controls.Add(this.lblLop);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmThi";
            this.Text = "THI MON LAP TRINH UNG DUNG C#";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblLop;
        private System.Windows.Forms.Label lblSomay;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chươngTrìnhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngNhậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLíSinhViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhậpĐiểmSinhViênToolStripMenuItem;
    }
}

