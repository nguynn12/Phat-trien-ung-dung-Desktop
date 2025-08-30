using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2312704_Bai2
{
    internal class TinhToan
    {
        public static void NoiChuoi(string ho, string ten, ref string s)
        {
            s = string.Concat(ho, " ", ten);
        }

        public static long GiaiThua(int n)
        {
            long giaiThua = 1;

            for (int i = 1; i <= n; i++)

                giaiThua *= i;

            return giaiThua;
        }
    }
}
