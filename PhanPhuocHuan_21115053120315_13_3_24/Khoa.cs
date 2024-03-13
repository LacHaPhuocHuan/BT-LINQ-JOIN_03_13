using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanPhuocHuan_21115053120315_13_3_24
{
    internal class Khoa
    {
        public String tenKhoa {  get; set; }
        public String maKhoa { get; set; }

        public Khoa() { }

        public Khoa(string tenKhoa, string maKhoa)
        {
            this.tenKhoa = tenKhoa;
            this.maKhoa = maKhoa;
        }
    }
}
