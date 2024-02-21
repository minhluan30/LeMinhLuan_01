using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeMinhLuan_01
{
    class Program
    {
        static void Main(string[] args)
        {
            menu();
        }
        static void menu()
        {
            QLNV ql = new QLNV();
            int chon = 0;
            do
            {
                Console.WriteLine("1.Nhap danh sach nhan vien: ");
                Console.WriteLine("2.Xuat danh sach nhan vien: ");
                Console.WriteLine("3.Thong ke tien luong phai tra cho nhan vien: ");
                Console.WriteLine("4.Tinh tien luong trung binh nhan vien: ");
                Console.WriteLine("0.Thoat chuong trinh: ");

                Console.Write("Ban chon chuc nang: ");
                chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        ql.Nhap();
                        break;
                    case 2:
                        ql.Xuat();
                        break;
                    case 3:
                        Console.WriteLine($"tong tien luong nhan vien{ql.TongLuong()}");
                        break;
                    case 4:
                        Console.WriteLine($"trung binh luong nhan vien {ql.Tinhtrungbinh()}");
                        break;
                    case 5:
                        Console.ReadLine();
                        break;

                }
            } while (chon != 5);
        }
    }
}