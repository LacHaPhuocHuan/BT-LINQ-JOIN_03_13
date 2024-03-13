using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanPhuocHuan_21115053120315_13_3_24
{
    internal class SinhVien
    {
        public String maSinhVien {  get; set; }
        public String tenSinhVien {  set; get; }
        public float diemTB {  get; set; }
        public Khoa Khoa { get; set; }
        public SinhVien(string maSinhVien, string tenSinhVien, float diemTB, Khoa khoa)
        {
            this.maSinhVien = maSinhVien;
            this.tenSinhVien = tenSinhVien;
            this.diemTB = diemTB;
            this.Khoa = khoa;
        }

        public void show()
        {
            Console.WriteLine("Ma sinh vien: " + maSinhVien);
            Console.WriteLine("Ten sinh vien: " + tenSinhVien);
            Console.WriteLine("Diem trung binh: " + diemTB);
            Console.WriteLine("Khoa: " + Khoa.tenKhoa);

        }

        internal void showAndKhoa()
        {
            this.show();
            Console.WriteLine("Ma Khoa " + Khoa.maKhoa);
        }
    }
}
