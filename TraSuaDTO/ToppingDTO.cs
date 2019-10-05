using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraSuaDTO
{
    class ToppingDTO
    {
        private int matopping;
        private string topping;
        private float giatopping;

        public int Matopping { get => matopping; set => matopping = value; }
        public string Topping { get => topping; set => topping = value; }
        public float Giatopping { get => giatopping; set => giatopping = value; }
    }
}
