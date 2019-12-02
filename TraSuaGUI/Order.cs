using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TraSuaDTO;
using TraSuaBUS;

namespace BoubleMilkTea
{
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
        }

        ThucUongDTO thucUongDTO = new ThucUongDTO();
        ToppingDTO toppingDTO = new ToppingDTO();

        ThucUongBUS thucUongBUS = new ThucUongBUS();
        ToppingBUS toppingBUS = new ToppingBUS();

        OrderDTO orderDTO = new OrderDTO();
        OrderBUS orderBUS = new OrderBUS();

        HoaDonDTO hoaDonDTO = new HoaDonDTO();
        HoaDonBUS hoaDonBUS = new HoaDonBUS();

        //private List<OrderDTO> listLoad = new List<OrderDTO>();
        private List<HoaDonDTO> listHoaDon = new List<HoaDonDTO>();


        private void Order_Load(object sender, EventArgs e)
        {
            LoadThucUong();
        }

        private void LoadTopping()
        {
            List<ToppingDTO> listTopping  = toppingBUS.select();
            if (listTopping  == null)
            {
                DialogResult kq = MessageBox.Show("Thông báo ", "Hiện tại chưa có dữ liệu ");
            }
            gridTopping.Columns.Clear(); //xóa sạch cột trên datagridview
            gridTopping.DataSource = null;

            gridTopping.AutoGenerateColumns = false; //không cho phép tự động tạo cột
            gridTopping.AllowUserToAddRows = false;  //không cho phép người dụng tự động thêm cột
            gridTopping.DataSource = listTopping ;

            DataGridViewTextBoxColumn clMa = new DataGridViewTextBoxColumn();
            clMa.Name = "Ma";
            clMa.HeaderText = "Mã Topping";
            clMa.DataPropertyName = "maTopping"; //kiểu dữ liệu nằm ở lớp DTO
            gridTopping.Columns.Add(clMa);

            DataGridViewTextBoxColumn clTen = new DataGridViewTextBoxColumn();
            clTen.Name = "Ten";
            clTen.HeaderText = "Tên Topping";
            clTen.DataPropertyName = "tenTopping";
            gridTopping.Columns.Add(clTen);

            DataGridViewTextBoxColumn clGia = new DataGridViewTextBoxColumn();
            clGia.Name = "Gia";
            clGia.HeaderText = "Giá Tiền";
            clGia.DataPropertyName = "giaTopping";
            gridTopping.Columns.Add(clGia);

            DataGridViewButtonColumn clChon = new DataGridViewButtonColumn();
            clChon.Name = "btChon";
            clChon.HeaderText = "Sửa";
            clChon.DataPropertyName = "chon";
            gridTopping.Columns.Add(clChon);
        }

        private void LoadThucUong()
        {
            List<ThucUongDTO> listThucUong = thucUongBUS.select();
            if (listThucUong == null)
            {
                DialogResult kq = MessageBox.Show("Thông báo ", "Hiện tại chưa có dữ liệu ");
            }
            gridThucAn.Columns.Clear(); //xóa sạch cột trên datagridview
            gridThucAn.DataSource = null;

            gridThucAn.AutoGenerateColumns = false; //không cho phép tự động tạo cột
            gridThucAn.AllowUserToAddRows = false;  //không cho phép người dụng tự động thêm cột
            gridThucAn.DataSource = listThucUong;

            DataGridViewTextBoxColumn clMa = new DataGridViewTextBoxColumn();
            clMa.Name = "maThucUong";
            clMa.HeaderText = "Mã Thức Uống";
            clMa.DataPropertyName = "maThucUong";
            gridThucAn.Columns.Add(clMa);

            DataGridViewTextBoxColumn clTen = new DataGridViewTextBoxColumn();
            clTen.Name = "Ten";
            clTen.HeaderText = "Tên Thức Uống";
            clTen.DataPropertyName = "tenThucUong";
            gridThucAn.Columns.Add(clTen);

            DataGridViewTextBoxColumn clGia = new DataGridViewTextBoxColumn();
            clGia.Name = "Gia";
            clGia.HeaderText = "Giá Tiền";
            clGia.DataPropertyName = "gia";
            gridThucAn.Columns.Add(clGia);

            DataGridViewButtonColumn clChon = new DataGridViewButtonColumn();
            clChon.Name = "btChon";
            clChon.HeaderText = "chon";
            clChon.DataPropertyName = "chon";
            gridThucAn.Columns.Add(clChon);

        }

        private void btThucUong_Click(object sender, EventArgs e)
        {
            LoadThucUong();
            gridTopping.Visible = false;
            gridTopping.Columns.Clear();
            gridThucAn.Visible = true;
        }

        private void btTopping_Click(object sender, EventArgs e)
        {
            LoadTopping();
            gridThucAn.Visible = false;
            gridThucAn.Columns.Clear();
            gridTopping.Visible = true;
        }


        //sự kiện của gridThucUong chưa đổi tên 
        private void gridOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                int indexRow;
                indexRow = e.RowIndex;
                DataGridViewRow row = gridThucAn.Rows[indexRow];
                orderDTO.maThucUong = int.Parse(row.Cells[0].Value.ToString());
                orderDTO.tenThucUong = row.Cells[1].Value.ToString();
                insertThucUong();
                LoadGridThucUong();
            }
        }

        private void LoadGridThucUong()
        {
            List<OrderDTO> listThucUongOrder = orderBUS.selectThucUongOrder(orderDTO.maHoaDon);
            if (listThucUongOrder == null)
            {
                DialogResult kq = MessageBox.Show("Thông báo ", "Hiện tại chưa có dữ liệu ");
            }
            gridLoadThucUong.Columns.Clear(); //xóa sạch cột trên datagridview
            gridLoadThucUong.DataSource = null;

            gridLoadThucUong.AutoGenerateColumns = false; //không cho phép tự động tạo cột
            gridLoadThucUong.AllowUserToAddRows = false;  //không cho phép người dụng tự động thêm cột
            gridLoadThucUong.DataSource = listThucUongOrder;

            DataGridViewTextBoxColumn clTen = new DataGridViewTextBoxColumn();
            clTen.Name = "Ten";
            clTen.HeaderText = "Tên Thức Uống";
            clTen.DataPropertyName = "tenThucUong";
            gridLoadThucUong.Columns.Add(clTen);

            DataGridViewTextBoxColumn clGia = new DataGridViewTextBoxColumn();
            clGia.Name = "Gia";
            clGia.HeaderText = "Giá Tiền";
            clGia.DataPropertyName = "giaThucUong";
            gridLoadThucUong.Columns.Add(clGia);
        }

        private void gridTopping_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                int indexRow;
                indexRow = e.RowIndex;
                DataGridViewRow row = gridTopping.Rows[indexRow];
                orderDTO.maTopping = int.Parse(row.Cells[0].Value.ToString());
                orderDTO.tenTopping = row.Cells[1].Value.ToString();
                insertTopping();
            }
        }

        private void insertTopping()
        {
            //lbMaCTHD.Text = Convert.ToString(gridAnCTHD.Rows[0].Cells["maHD"].Value);
            orderDTO.maHoaDon = int.Parse(lbMaHD.Text);
            orderBUS.insertTopping(orderDTO);
        }

        private void insertThucUong()
        {
            //lbMaCTHD.Text = Convert.ToString(gridAnCTHD.Rows[0].Cells["maHD"].Value);
            orderDTO.maHoaDon = int.Parse(lbMaHD.Text);
            orderBUS.insertThuocUong(orderDTO);
        }



        private void btn_ThemThucUong_Click(object sender, EventArgs e)
        {
            gridThucAn.Visible = true;
            InsertHoaDon();
            LoadGriAnHD();
            InsertCTHD();
            LoadGridAnCTHD();
        }

        

        private void InsertHoaDon()
        {
            hoaDonDTO.maNV = int.Parse(tbMaNhanVien.Text);
            hoaDonDTO.tenKH = tbTenKH.Text;
            hoaDonDTO.TGBD = DateTime.Parse(dateTimePicker1.Value.ToString());
            hoaDonBUS.Add(hoaDonDTO);
        }

        private void LoadGriAnHD()
        {
            listHoaDon = hoaDonBUS.selectTop1();

            // load thong tin hoa don len ban ban
            gridAnHD.Columns.Clear(); //xóa sạch cột trên datagridview
            gridAnHD.DataSource = null;

            gridAnHD.AutoGenerateColumns = false; //không cho phép tự động tạo cột
            gridAnHD.AllowUserToAddRows = false;  //không cho phép người dụng tự động thêm cột
            gridAnHD.DataSource = listHoaDon;

            DataGridViewTextBoxColumn clMaHD = new DataGridViewTextBoxColumn();
            clMaHD.Name = "maHoaDon";
            clMaHD.HeaderText = "Mã hóa đơn";
            clMaHD.DataPropertyName = "maHoaDon"; //kiểu dữ liệu nằm ở lớp DTO
            gridAnHD.Columns.Add(clMaHD);
        }

        private void InsertCTHD()
        {
            lbMaHD.Text = Convert.ToString(gridAnHD.Rows[0].Cells["maHoaDon"].Value);
            orderDTO.duong = int.Parse(cbMucDuong.Text);
            orderDTO.da = int.Parse(cbMucDa.Text);
            orderDTO.maHoaDon = int.Parse(lbMaHD.Text);
            orderBUS.Add(orderDTO);
        }

        private void LoadGridAnCTHD()
        {
            List<OrderDTO> listOrder = orderBUS.SelectTop1();
            // load thong tin hoa don len ban ban
            gridAnCTHD.Columns.Clear(); //xóa sạch cột trên datagridview
            gridAnCTHD.DataSource = null;

            gridAnCTHD.AutoGenerateColumns = false; //không cho phép tự động tạo cột
            gridAnCTHD.AllowUserToAddRows = false;  //không cho phép người dụng tự động thêm cột
            gridAnCTHD.DataSource = listOrder;

            DataGridViewTextBoxColumn clMaHD = new DataGridViewTextBoxColumn();
            clMaHD.Name = "maCTHD";
            clMaHD.HeaderText = "Mã hóa đơn";
            clMaHD.DataPropertyName = "maCTHD"; //kiểu dữ liệu nằm ở lớp DTO
            gridAnCTHD.Columns.Add(clMaHD);

            lbMaCTHD.Text = Convert.ToString(gridAnCTHD.Rows[0].Cells["maCTHD"].Value);

        }

    }
}
