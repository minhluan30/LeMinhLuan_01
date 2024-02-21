using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeMinhLuan_01
{
    class QLNV
    {
        private List<NhanVien> dsNV;
        public QLNV()
        {
            dsNV = new List<NhanVien>();
        }
        public void Nhap()
        {
            string tieptuc = "y";
            int luachon;
            NhanVien nv;
            do
            {
                Console.Write("Bien che hoac hop dong: ");
                luachon = int.Parse(Console.ReadLine());
                switch (luachon)
                {
                    case 1:
                        nv = new NhanvienBC();
                        nv.Nhap();
                        dsNV.Add(nv);
                        break;
                    case 2:
                        nv = new NhanvienHD();
                        nv.Nhap();
                        dsNV.Add(nv);
                        break;
                    default:
                        Console.Write("Ban chon sai. Vui long chon 1 hoac 2: ");
                        break;
                }
                Console.Write("Ban muon tiep tuc khong,Y/N");
                tieptuc = Console.ReadLine();
            } while (tieptuc.ToLower() == "Y");
        }
        public void Xuat()
        {
            Console.WriteLine($"{"Ma so",-10}{"Ho ten",20}{"Luong cung",20:#,##0 VND}");
            foreach(NhanVien nv in dsNV)
            {
                Console.WriteLine($"{nv.Maso,-10}{nv.Hoten,20}{nv.Luongcung,10:#,##0}");
            }
        }
        public int TongLuong()
        {
            int sum = 0;
            foreach (NhanVien nv in dsNV)
            {
                sum += nv.TinhLuong();
            }
            return sum;
        }
        public Double Tinhtrungbinh()
        {
            int dem = dsNV.Count();
            return TongLuong() / dem;
        } 
    }
}
