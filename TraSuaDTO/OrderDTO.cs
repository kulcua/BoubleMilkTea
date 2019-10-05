using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraSuaDTO
{
    public class OrderDTO
    {
        private int maorder;
        private int manv;
        private string tenkh;
        private DateTime thoigian;
        private int mathucuong;
        private int mada;
        private int maduong;
        private int matopping;
        private int soluong;

        public int Maorder { get => maorder; set => maorder = value; }
        public int Manv { get => manv; set => manv = value; }
        public string Tenkh { get => tenkh; set => tenkh = value; }
        public DateTime Thoigian { get => thoigian; set => thoigian = value; }
        public int Mathucuong { get => mathucuong; set => mathucuong = value; }
        public int Mada { get => mada; set => mada = value; }
        public int Maduong { get => maduong; set => maduong = value; }
        public int Matopping { get => matopping; set => matopping = value; }
        public int Soluong { get => soluong; set => soluong = value; }
    }
}
