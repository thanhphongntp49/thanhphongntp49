using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KiemTraGiuaKy_De01
{
    class clsHoadon
    {
        private string _Mahoadon;
        private string _Hotenkhachang;
        private string _NgayxuatHD;
        private string _LoaiKH;
        private int _ThanhTien;

        public string Mahoadon
        {
            get
            {
                return _Mahoadon;
            }

            set
            {
                _Mahoadon = value;
            }
        }

        public string Hotenkhachang
        {
            get
            {
                return _Hotenkhachang;
            }

            set
            {
                _Hotenkhachang = value;
            }
        }

        public string NgayxuatHD
        {
            get
            {
                return _NgayxuatHD;
            }

            set
            {
                _NgayxuatHD = value;
            }
        }

        public string LoaiKH
        {
            get
            {
                return _LoaiKH;
            }

            set
            {
                _LoaiKH = value;
            }
        }

        public int ThanhTien
        {
            get
            {
                return _ThanhTien;
            }

            set
            {
                _ThanhTien = value;
            }
        }

        public clsHoadon(string maHD, string hoTenKH, string ngayXuatHD, string loaiKH, int thanhTien)
        {
            Mahoadon = maHD;
            Hotenkhachang = hoTenKH;
            NgayxuatHD = ngayXuatHD;
            LoaiKH = loaiKH;
            ThanhTien = thanhTien;
        }

        public string toString()
        {
            return Mahoadon + "#" + Hotenkhachang + "#" + ThanhTien;
        }
    }

}
