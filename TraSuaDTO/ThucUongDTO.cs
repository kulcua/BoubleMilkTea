using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraSuaDTO
{
    public class ThucUongDTO
    {
        private int mathucuong;
        private string tenthucuong;
        private float gia;

        public int Mathucuong { get => mathucuong; set => mathucuong = value; }
        public string Tenthucuong { get => tenthucuong; set => tenthucuong = value; }
        public float Gia { get => gia; set => gia = value; }
    }
}
