using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2312704_TaNhatNguyen_De02
{
    public delegate int SoSanh(object ncc1, object ncc2);

    public enum KieuSoSanh
    {
        TheoMa,
        TheoTen,
        TheoSDT
    }

    public class QuanLyNCC
    {
        public List<NhaCungCap> dsNhaCC = new List<NhaCungCap>();

        public QuanLyNCC()
        {
            dsNhaCC = new List<NhaCungCap>();
        }

        public NhaCungCap this[int index]
        {
            get { return dsNhaCC[index]; }

            set { dsNhaCC[index] = value; }
        }

        public void Them(NhaCungCap ncc)
        {
            dsNhaCC.Add(ncc);
        }

        public void Xoa(object obj, SoSanh ss)
        {
            for (int i = dsNhaCC.Count - 1; i >= 0; i--)
            {
                if (ss(obj, this[i]) == 0)

                    dsNhaCC.RemoveAt(i);
            }
        }

        public bool Sua(NhaCungCap nccmoi, object obj, SoSanh ss)
        {
            bool kq = false;

            for (int i = 0; i < dsNhaCC.Count; i++)
            {
                if (ss(obj, this[i]) == 0)
                {
                    this[i] = nccmoi;
                    kq = true;
                    break;
                }
            }

            return kq;
        }

        public NhaCungCap Tim(object obj, SoSanh ss)
        {
            NhaCungCap kq = null;

            foreach (NhaCungCap ncc in dsNhaCC)
            {
                if (ss(obj, ncc) == 0)
                {
                    kq = ncc;
                    break;
                }
            }

            return kq;
        }

        public List<NhaCungCap> TimTatCa(object obj, SoSanh ss)
        {
            List<NhaCungCap> kq = new List<NhaCungCap>();

            foreach (NhaCungCap ncc in dsNhaCC)
            {
                if (ss(obj, ncc) == 0)
                {
                    kq.Add(ncc);
                }
            }

            return kq;
        }
    }
}
