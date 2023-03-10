using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapWindowsForm
{
    internal class TinhToan
    {
        public static void CongHaiSo(int a, int b, ref int c)
        {
            c = a + b;
        }
        public static void TongCacDaySo(int n)
        {
            int Tong = 0;
            for (int i = 1; i < n; i++)
            {
                Tong += i;
            }
            return ;
        }

    }
}
