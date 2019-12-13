using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoubleMilkTea
{
    public partial class TuyChon : Form
    {
        public TuyChon()
        {
            InitializeComponent();
        }

        private void btn_ThongKe_Click(object sender, EventArgs e)
        {
            ThongKeDoanhSo thongKe = new ThongKeDoanhSo();
            this.Hide();
            thongKe.Show();
        }

        private void btn_PhanQuyen_Click(object sender, EventArgs e)
        {
            PhanQuyen phanQuyen = new PhanQuyen();
            this.Hide();
            phanQuyen.Show();
        }

        private void btn_NhanOrder_Click(object sender, EventArgs e)
        {
            Order nhanOrder = new Order();
            this.Hide();
            nhanOrder.Show();
        }

        private void btn_QuanLyKho_Click(object sender, EventArgs e)
        {
            QuanLyKho qlKho = new QuanLyKho();
            this.Hide();
            qlKho.Show();
        }

        private void btn_KM_Click(object sender, EventArgs e)
        {
            SetKhuyenMai setKhuyenMai = new SetKhuyenMai();
            this.Hide();
            setKhuyenMai.Show();
        }
    }
}
