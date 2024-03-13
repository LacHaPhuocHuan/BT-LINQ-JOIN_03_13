using PhanPhuocHuan_21115053120315_13_3_24;
using System;
using System.Linq;
namespace LINQDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<SinhVien> SinhViens = new List<SinhVien>();
            Khoa k1 = new Khoa("1", "01");
            Khoa k2 = new Khoa("2", "02");
            Khoa k3 = new Khoa("3", "03");


            SinhVien sv1 = new SinhVien("01", "huan", 8.7f, k1);
            SinhVien sv2 = new SinhVien("02", "huy", 4f, k2);
            SinhVien sv3 = new SinhVien("03", "khoa", 3f, k3);
            SinhVien sv4 = new SinhVien("04", "minh", 8.7f, k1);
            SinhVien sv5 = new SinhVien("05", "phu", 8.7f, k2);
            SinhVien sv6 = new SinhVien("06", "hoang", 8.7f, k3);

            SinhViens.Add(sv1);
            SinhViens.Add(sv2);
            SinhViens.Add(sv3);
            SinhViens.Add(sv4);
            SinhViens.Add(sv5);
            SinhViens.Add(sv6);




            int option = 1;
            while (true)
            {
                Console.WriteLine("Chon : \n0.Thoat\n1.In danh sach sinh vien theo khoa, sap xep theo ten.\n2.In ds sinh vien co " +
                    "diem trung binh lon hon 7\n3.In DS SV co diem trung binh <4" +
                    "\n4.Kiem tra sinh vien co tien khoa." +
                    "\n5.In danh sach sinh vien co thong tin khoa." +
                    "\n6.In sinh vien gioi nhat khoa.");
                option = Int32.Parse(Console.ReadLine());
                if (option == 1)
                {
                    Console.WriteLine("\nIn danh sach sinh vien theo khoa, sap xep theo ma sinh vien");

                    foreach (var group in SinhViens.GroupBy(s => s.Khoa))
                    {
                        Console.WriteLine($"\nKHOA: {group.Key.tenKhoa}");

                        // Order the students within each group by maSinhVien
                        var sortedStudents = group.OrderBy(s => s.maSinhVien);

                        foreach (SinhVien sv in sortedStudents)
                        {
                            sv.show();
                        }
                    }

                }
                else if (option == 2)
                {
                    Console.WriteLine("\nIn danh sach sinh vien diem trung binh lon hon 7");

                    List<SinhVien> list = SinhViens.Where(s => s.diemTB > 7).ToList();
                    foreach (SinhVien sv in list)
                    {
                        sv.show();
                    }
                }
                else if (option == 3)
                {
                    Console.WriteLine("\nIn danh sach sinh vien diem trung binh be hon 4");

                    List<SinhVien> list = SinhViens.Where(s => s.diemTB < 7).ToList();
                    foreach (SinhVien sv in list)
                    {
                        sv.show();
                    }
                }
                else if (option == 4)
                {
                    Console.WriteLine("\nKiem tra sinh vien co tien khoa.");
                    List<SinhVien> list = SinhViens.Where(s => s.tenSinhVien.ToLower().Contains(("Khoa").ToLower())).ToList();
                    if (list.Count < 0) Console
                            .WriteLine("Khong co sinh vien nao co te la khoa.");
                    else
                        foreach (SinhVien sv in list)
                        {
                            sv.show();
                        }
                }
                else if (option == 5)
                {
                    Console.WriteLine("\nIn danh sach sinh vien co thong tin khoa.");
                    List<SinhVien> list = SinhViens.Where(s => s.Khoa != null).ToList();
                    if (list.Count < 0) Console
                            .WriteLine("Tat ca cac sinh vien chua duoc them vao khoa.");
                    else
                        foreach (SinhVien sv in list)
                        {
                            sv.showAndKhoa();
                        }
                }
                else if (option == 6)
                {
                    Console.WriteLine("\n.In sinh vien gioi nhat khoa.");
                    SinhVien sv = SinhViens.OrderBy(s => s.diemTB).Last();
                    sv.show();

                }

                if (option == 0) break;


            }
        }
    }
}