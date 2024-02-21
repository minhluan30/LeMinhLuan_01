using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeMinhLuan_01
{
    class NhanvienBC : NhanVien
    {
        private string mucxeploai;
        public NhanvienBC(): base() { }
        public NhanvienBC(string maso, string hoten, int luongcung,string mucxeploai)
        {
            this.mucxeploai = mucxeploai;
        }
        public string Mucxeploai
        {
            set { mucxeploai = value; }
            get { return mucxeploai; }
        }
        public virtual void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap muc xep loai: ");
            mucxeploai = Console.ReadLine();
        }
        public override int TinhLuong()
        {
            int Luong;
            if (mucxeploai == "A")
                return Luong = (int)1.8 * Luongcung;
            else if (mucxeploai == "B")
                return Luong = (int)1.2 * Luongcung;
            else return Luong = (int)0.8 * Luongcung;
        }
    }
}
