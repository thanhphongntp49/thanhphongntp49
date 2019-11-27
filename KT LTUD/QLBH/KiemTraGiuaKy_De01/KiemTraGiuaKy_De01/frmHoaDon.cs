using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KiemTraGiuaKy_De01
{
    public partial class frmHoadon : Form
    {
        public frmHoadon()
        {
            InitializeComponent();
        }

        private void btnNhapmoi_Click(object sender, EventArgs e)
        {
            dtpNgayxuathd.Enabled = true;
            txtMahoadon.Enabled = true;
            cboLoaikh.Enabled = true;
            txtHotenkh.Enabled = true;
            txtThanhtien.Enabled = true;
            btnLuu.Enabled = true;
            btnThoat.Enabled = true;
            btnLuufile.Enabled = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult rs;
            rs = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                this.Close();
            }
        }
        List<clsHoadon> dsHoadon = new List<clsHoadon>();
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (dtpNgayxuathd.Text != string.Empty && txtMahoadon.Text != string.Empty
                && cboLoaikh.Text != string.Empty && txtHotenkh.Text != string.Empty 
                && txtThanhtien.Text != string.Empty)
            {
                if(cboLoaikh.Text == "Khách hàng thành viên")
                {
                    int iThanhtien = int.Parse(txtThanhtien.Text);
                    txtTienthanhtoan.Text = (iThanhtien * (1 - 0.05)).ToString();
                }
                else if (cboLoaikh.Text == "Khách hàng thân thiết")
                {
                    int iThanhtien = int.Parse(txtThanhtien.Text);
                    txtTienthanhtoan.Text = (iThanhtien * (1 - 0.1)).ToString();
                }
                else if (cboLoaikh.Text == "Khách hàng VIP")
                {
                    int iThanhtien = int.Parse(txtThanhtien.Text);
                    txtTienthanhtoan.Text = (iThanhtien * (1 - 0.2)).ToString();
                }
                else
                {
                    txtTienthanhtoan.Text = txtThanhtien.Text;
                }
                clsHoadon hoaDon = new clsHoadon(txtMahoadon.Text, txtHotenkh.Text,
                                                   dtpNgayxuathd.Text, cboLoaikh.Text, int.Parse(txtThanhtien.Text));
                dsHoadon.Add(hoaDon);

                ListViewItem item = new ListViewItem();
                item.Text = txtMahoadon.Text;

                ListViewItem.ListViewSubItem itemHotenkh = new ListViewItem.ListViewSubItem();
                itemHotenkh.Text = txtHotenkh.Text;
                item.SubItems.Add(itemHotenkh);

                ListViewItem.ListViewSubItem itemNgayxuathd = new ListViewItem.ListViewSubItem();
                itemNgayxuathd.Text = dtpNgayxuathd.Text;
                item.SubItems.Add(itemNgayxuathd);

                ListViewItem.ListViewSubItem itemLoaiKH = new ListViewItem.ListViewSubItem();
                itemLoaiKH.Text = cboLoaikh.Text;
                item.SubItems.Add(itemLoaiKH);

                ListViewItem.ListViewSubItem itemThanhTien = new ListViewItem.ListViewSubItem();
                itemThanhTien.Text = txtThanhtien.Text;
                item.SubItems.Add(itemThanhTien);

                lvHoadon.Items.Add(item);

                TreeNode node = new TreeNode();
                node.Text = txtMahoadon.Text;
                tvHoadon.Nodes.Add(node);
                //them root con
                TreeNode subNode = new TreeNode()
                {
                    Text = "Ten: " + txtHotenkh.Text + "-" + "Date: " + dtpNgayxuathd.Text + "-" + "Tien: " + txtThanhtien.Text
                };
                node.Nodes.Add(subNode);
            }
        }

        private void btnLuufile_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter("hotensinhvien.txt", true))
            {
                for(int i = 0; i < dsHoadon.Count; i++)
                {
                    sw.WriteLine(dsHoadon[i].toString());
                }
            }
        }
    }
}
