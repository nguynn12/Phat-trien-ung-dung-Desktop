using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyForm2
{
    public delegate int SoSanh(object a, object b);

    enum KieuTim
    {
        TheoMa,
        TheoHoTen,
        TheoSDT
    }

    public class QuanLyGiangVien
    {
        public List<GiangVien> dsGiangVien;

        public QuanLyGiangVien()
        {
            dsGiangVien = new List<GiangVien>();
        }

        public GiangVien this[int index]
        {
            get { return dsGiangVien[index]; }

            set { dsGiangVien[index] = value; }
        }

        public void SapXep(SoSanh ss)
        {
            for (int i = 0; i <  dsGiangVien.Count - 1; i++)
            {
                for (int j = i + 1; j < dsGiangVien.Count; j++)
                {
                    if (ss(this[i], this[j]) == 1)
                    {
                        GiangVien temp = this[i];

                        this[i] = this[j];

                        this[j] = temp;
                    }
                }
            }
        }

        public bool Them(GiangVien gv)
        {
            dsGiangVien.Add(gv);

            return true;
        }

        public GiangVien Tim(object temp, SoSanh ss)
        {
            GiangVien gvkq = null;

            foreach (GiangVien gv in dsGiangVien)

                if (ss(temp, gv) == 0)
                {
                    gvkq = gv;

                    break;
                }

            return gvkq;
        }

        public void Xoa(object temp, SoSanh ss)
        {
            int i = dsGiangVien.Count - 1;

            for (; i >= 0; i--)

                if (ss(temp, this[i]) == 0)

                    this.dsGiangVien.RemoveAt(i);
        }
    }
}
