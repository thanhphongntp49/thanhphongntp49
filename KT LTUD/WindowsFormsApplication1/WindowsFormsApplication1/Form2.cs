using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        string select = " ";
        public Form2()
        {
            InitializeComponent();
            txtKetQua.Enabled = false;
            txtDiemKiemTra.Enabled = false;
        }
        //Nhap mơi:
        private void btnNhapMoi_Click(object sender, EventArgs e)
        {
            txtMaSV.Clear();
            txtHoTenSV.Clear();
            txtDiemGiuaKy.Clear();
            txtDiemThi.Clear();
            cbHocPhan.Text = select;
        }
        //Thoat:
        private void btnThoat_Click(object sender, EventArgs e)
        {
            {
                DialogResult dr;
                dr = MessageBox.Show("Ban co muon thoat khong!!!", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    this.Close();
                }
            }
        }
        //Tao list view
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (listView1.SelectedItems.Count > 0)
                {
                    ListViewItem item = listView1.SelectedItems[0];
                    //cot ma
                    txtMaSV.Text = item.SubItems[0].Text;
                    //cot ho ten:
                    txtHoTenSV.Text = item.SubItems[1].Text;
                    //cot hoc phan:
                    cbHocPhan.Text = item.SubItems[2].Text;
                    //cot diem giua ky:
                    txtDiemGiuaKy.Text = item.SubItems[3].Text;
                    //cot diem thi:
                    txtDiemThi.Text = item.SubItems[4].Text;
                    //cot kiem tra:
                    txtDiemKiemTra.Text = item.SubItems[5].Text;
                    //cot ket qua:
                    txtKetQua.Text = item.SubItems[6].Text;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Tinh diem
        private void btnTinhDiem_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtMaSV.Text != string.Empty && txtHoTenSV.Text != string.Empty && cbHocPhan.Text != string.Empty && txtDiemGiuaKy.Text != string.Empty && txtDiemThi.Text != string.Empty)
                {
                    string kq;
                    ListViewItem itemMaSV = new ListViewItem();
                    itemMaSV.Text = txtMaSV.Text;
                    //item ma
                    ListViewItem.ListViewSubItem itemTenSV = new ListViewItem.ListViewSubItem();
                    itemTenSV.Text = txtHoTenSV.Text;
                    itemMaSV.SubItems.Add(itemTenSV);
                    //item ten
                    ListViewItem.ListViewSubItem itemHP = new ListViewItem.ListViewSubItem();
                    itemTenSV.Text = cbHocPhan.Text;
                    itemMaSV.SubItems.Add(itemHP);
                    //item diem giua ky
                    ListViewItem.ListViewSubItem itemDGK = new ListViewItem.ListViewSubItem();
                    itemDGK.Text = txtDiemGiuaKy.Text;
                    itemMaSV.SubItems.Add(itemDGK);
                    //item diem thi
                    ListViewItem.ListViewSubItem itemDT = new ListViewItem.ListViewSubItem();
                    itemDT.Text = txtDiemThi.Text;
                    itemMaSV.SubItems.Add(itemDT);
                    //Tinh diem:
                    double diemkt = 0;
                    if(cbHocPhan.Text == "Lap trinh ung dung")
                    {
                        diemkt = (Int16.Parse(txtDiemGiuaKy.Text) * 0.3) + (Int16.Parse(txtDiemThi.Text) * 0.7);
                    }
                    else if (cbHocPhan.Text == "Lap trinh c# co ban")
                    {
                        diemkt = (Int16.Parse(txtDiemGiuaKy.Text) * 0.4) + (Int16.Parse(txtDiemThi.Text) * 0.6);
                    }
                    else if (cbHocPhan.Text == "Lap trinh java")
                    {
                        diemkt = (Int16.Parse(txtDiemGiuaKy.Text) * 0.5) + (Int16.Parse(txtDiemThi.Text) * 0.5);
                    }
                    //Dinh dang:
                    txtDiemKiemTra.Text = diemkt + "";
                    ListViewItem.ListViewSubItem itemDiemKiemTra = new ListViewItem.ListViewSubItem();
                    itemDiemKiemTra.Text = txtDiemKiemTra.Text;
                    itemMaSV.SubItems.Add(itemDiemKiemTra);
                    //Ket qua:
                    if (diemkt >= 4)
                    {
                        kq = "Dau";
                    }
                    else
                    {
                        kq = "Rot";
                    }
                    //Dinh dang:
                    txtKetQua.Text = kq + "";
                    ListViewItem.ListViewSubItem itemKetQua = new ListViewItem.ListViewSubItem();
                    itemKetQua.Text = txtKetQua.Text;
                    itemMaSV.SubItems.Add(itemKetQua);
                    //
                    listView1.Items.Add(itemMaSV);
                }
                else
                {
                    MessageBox.Show("Ban phai nhap lai!");
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        //Save file:
        private void btnLuuFile_Click(object sender, EventArgs e)
        { 
            //Tao bien sv:
            SaveFileDialog sv = new SaveFileDialog();
            sv.Filter = "(*.txt)|*.txt)";//dinh dang txt
            if (sv.ShowDialog() == DialogResult.OK)
            {
                string path = sv.FileName;
                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    File.AppendAllText(path, 
                          listView1.Items[i].SubItems[0].Text + " ; "
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
        //
    }
}
