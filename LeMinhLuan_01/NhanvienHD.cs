using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeMinhLuan_01
{
    class NhanvienHD : NhanVien
    {
        private int doanhthu;
        public NhanvienHD() : base() { }
        public NhanvienHD(string maso,string hoten,int luongcung,int doanhthu) : base(maso, hoten, luongcung)
        {
            this.doanhthu = doanhthu;
        }
        public int Doanhthu
        {
            set { doanhthu = value; }
            get { return doanhthu; }
        }
        public virtual void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap doanh thu: ");
            this.doanhthu = int.Parse(Console.ReadLine());
        }
        public override int TinhLuong()
        {
            return (int)0.05 * doanhthu;
        }
    }
}
