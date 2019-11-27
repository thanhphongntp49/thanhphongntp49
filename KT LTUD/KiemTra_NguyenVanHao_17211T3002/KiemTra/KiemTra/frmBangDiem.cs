using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KiemTra
{
    public partial class frmBangDiem : Form
    {
        public frmBangDiem()
        {
            InitializeComponent();
        }
        //Button thoat
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Bạn có muốn thoát không!!!", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }
        //button nhap moi
        private void btnNhapMoi_Click(object sender, EventArgs e)
        {
            string select = "";
            txtMasv.Clear();
            txtName.Clear();
            txtDiemKetQua.Clear();
            txtDiemGiuKy.Clear();
            txtDiemThi.Clear();
            cbbHocPhan.Text = select;
        }
        //button Tinh Diem
        private void btnTinhDiem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMasv.Text != string.Empty && txtName.Text != string.Empty && cbbHocPhan.Text != string.Empty && (Int32.Parse(txtDiemGiuKy.Text) < 10) && (Int32.Parse(txtDiemThi.Text) < 10))
                {
                    ListViewItem itemMSV = new ListViewItem();
                    itemMSV.Text = txtMasv.Text;

                    ListViewItem.ListViewSubItem itemName = new ListViewItem.ListViewSubItem();
                    itemName.Text = txtName.Text;
                    itemMSV.SubItems.Add(itemName);

                    ListViewItem.ListViewSubItem itemHocPhan = new ListViewItem.ListViewSubItem();
                    itemHocPhan.Text = cbbHocPhan.Text;
                    itemMSV.SubItems.Add(itemHocPhan);

                    ListViewItem.ListViewSubItem itemDiemGiuaKy = new ListViewItem.ListViewSubItem();
                    itemDiemGiuaKy.Text = txtDiemGiuKy.Text;
                    itemMSV.SubItems.Add(itemDiemGiuaKy);

                    ListViewItem.ListViewSubItem itemDiemThi = new ListViewItem.ListViewSubItem();
                    itemDiemThi.Text = txtDiemThi.Text;
                    itemMSV.SubItems.Add(itemDiemThi);
                    double kq = 0;
                    //tinh diem
                    if (cbbHocPhan.Text == "Lập trình hướng đối tượng")
                    {

                        kq = (Int32.Parse(txtDiemGiuKy.Text) * 0.3) + (Int32.Parse(txtDiemThi.Text) * 0.7);
                    }
                    else if (cbbHocPhan.Text == "Lập  trình C# căn bản")
                    {
                        kq = (Int32.Parse(txtDiemGiuKy.Text) * 0.4) + (Int32.Parse(txtDiemThi.Text) * 0.6);
                    }
                    else if (cbbHocPhan.Text == "Lập trình C# nâng cao")
                    {
                        kq = (Int32.Parse(txtDiemGiuKy.Text) * 0.4) + (Int32.Parse(txtDiemThi.Text) * 0.6);
                    }
                    txtDiemKetQua.Text = kq + "";
                    ListViewItem.ListViewSubItem itemdiemkq = new ListViewItem.ListViewSubItem();
                    itemdiemkq.Text = txtDiemKetQua.Text;
                    itemMSV.SubItems.Add(itemdiemkq);
                    string DiemKq = "";
                    //ketqua
                    if (kq < 4)
                    {
                        DiemKq = "Rớt";
                    }
                    else
                    {
                        DiemKq = "Đậu";
                    }
                    txtKetQua.Text = DiemKq + "";
                    ListViewItem.ListViewSubItem itemKetquaHocphan = new ListViewItem.ListViewSubItem();
                    itemKetquaHocphan.Text = txtKetQua.Text;
                    itemMSV.SubItems.Add(itemKetquaHocphan);
                    listView1.Items.Add(itemMSV);
                }
                else
                {

                    MessageBox.Show("Bạn cần nhập đầy đủ thông tin và điểm giữ kì và điểm của thi của bạn phải nhỏ hơn 10");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        //List View Sinh vien
        private void lvSinhvien_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (listView1.SelectedItems.Count > 0)
                {
                    ListViewItem item = listView1.SelectedItems[0];
                    txtMasv.Text = item.SubItems[0].Text;
                    txtName.Text = item.SubItems[1].Text;
                    cbbHocPhan.Text = item.SubItems[2].Text;
                    txtDiemGiuKy.Text = item.SubItems[3].Text;
                    txtDiemThi.Text = item.SubItems[4].Text;
                    txtDiemKetQua.Text = item.SubItems[5].Text;
                    txtKetQua.Text = item.SubItems[5].Text;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.FileName = "hotensinhvien.txt";
            if (save.ShowDialog() == DialogResult.OK)
            {
                string path = save.FileName;
                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    File.AppendAllText(path, listView1.Items[i].SubItems[0].Text + " ; "
                        + listView1.Items[i].SubItems[1].Text + " ; "
                        + listView1.Items[i].SubItems[2].Text + " ; "
                        + listView1.Items[i].SubItems[3].Text + " ; "
                        + listView1.Items[i].SubItems[4].Text + " ; "
                        + listView1.Items[i].SubItems[5].Text + " ; "
                        + listView1.Items[i].SubItems[6].Text + " ; "
                        + Environment.NewLine);
                }
            }
        }
    }
}
