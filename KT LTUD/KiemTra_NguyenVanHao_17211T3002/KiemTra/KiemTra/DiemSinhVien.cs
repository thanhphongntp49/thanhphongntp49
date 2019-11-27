using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KiemTra
{
    class DiemSinhVien
    {
        private string maSinhVien;
        private string hoSinhVien;
        private string tenSinhVien;
        private string hocPhan;
        private string diemGiuKy;
        private string diemThi;
        private string diemKetQua;
        private string ketQua;
        //Get/set Ma sinh vien
        public string MaSinhVien
        {
            get
            {
                return maSinhVien;
            }

            set
            {
                maSinhVien = value;
            }
        }
        //Get/set Ho sinh vien
        public string HoSinhVien
        {
            get
            {
                return hoSinhVien;
            }

            set
            {
                hoSinhVien = value;
            }
        }
        //Get/set Ten Sinh Vien
        public string TenSinhVien
        {
            get
            {
                return tenSinhVien;
            }

            set
            {
                tenSinhVien = value;
            }
        }
        //Get/set Ho Phan
        public string HocPhan
        {
            get
            {
                return hocPhan;
            }

            set
            {
                hocPhan = value;
            }
        }
        //Get/set Diem Giu Ky
        public string DiemGiuKy
        {
            get
            {
                return diemGiuKy;
            }

            set
            {
                diemGiuKy = value;
            }
        }
        //Get/set Diem thi
        public string DiemThi
        {
            get
            {
                return diemThi;
            }

            set
            {
                diemThi = value;
            }
        }
        //Get/set Diem Ket Qua
        public string DiemKetQua
        {
            get
            {
                return diemKetQua;
            }

            set
            {
                diemKetQua = value;
            }
        }
        //Get/set Ket Qua
        public string KetQua
        {
            get
            {
                return ketQua;
            }

            set
            {
                ketQua = value;
            }
        }

        //Contructor co tham so
        public DiemSinhVien(string maSinhVien, string hoSinhVien, string tenSinhVien, string hocPhan, string diemGiuKy, string diemThi, string diemKetQua, string ketQua)
        {
            this.MaSinhVien = maSinhVien;
            this.HoSinhVien = hoSinhVien;
            this.TenSinhVien = tenSinhVien;
            this.HocPhan = hocPhan;
            this.DiemGiuKy = diemGiuKy;
            this.DiemThi = diemThi;
            this.DiemKetQua = diemKetQua;
            this.KetQua = ketQua;
        }
        //Contructor khon tham so
        public DiemSinhVien()
        {
            this.MaSinhVien = "";
            this.HoSinhVien = "";
            this.TenSinhVien = "";
            this.HocPhan = "";
            this.DiemGiuKy = "";
            this.DiemThi = "";
            this.DiemKetQua = "";
            this.KetQua = "";
        }

    }
}
