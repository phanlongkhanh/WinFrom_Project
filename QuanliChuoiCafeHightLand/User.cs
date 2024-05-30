using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanliChuoiCafeHightLand
{
    static class User
    {
        static int _MaQuyen;
        static string _TenDangNhap;
        static string _MaNV;
        static string _TenNV;
        public static int MaQuyen { get => _MaQuyen; set => _MaQuyen = value; }
        public static string TenDangNhap { get => _TenDangNhap; set => _TenDangNhap = value; }
        public static string MaNV { get => _MaNV; set => _MaNV = value; }
        public static string TenNV { get => _TenNV; set => _TenNV = value; }
    }
}
