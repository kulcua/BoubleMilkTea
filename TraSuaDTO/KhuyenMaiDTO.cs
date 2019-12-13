using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraSuaDTO
{
    public class KhuyenMaiDTO
    {
        //cua boi
        public int maKhuyenMai { get; set; }
        public string tenKhuyenMai { get; set; }

        public DateTime ngayBD { get; set; }

        public DateTime ngayKT { get; set; }

        public int mucKhuyenMai { get; set; }

        //cua tho
        private int makm;
        private string tenkm;
        private DateTime tgBD;
        private DateTime tgKT;
        private int mucgiamgia;


        public int Makm { get => makm; set => makm = value; }
        public string Tenkm { get => tenkm; set => tenkm = value; }
        public DateTime TgBD { get => tgBD; set => tgBD = value; }
        public DateTime TgKT { get => tgKT; set => tgKT = value; }
        public int Mucgiamgia { get => mucgiamgia; set => mucgiamgia = value; }

    }
}
