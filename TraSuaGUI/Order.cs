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

        private List<ThucUongDTO> listThucUong;

        private List<string> listgrid;

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
            gridOrder.Columns.Clear(); //xóa sạch cột trên datagridview
            gridOrder.DataSource = null;

            gridOrder.AutoGenerateColumns = false; //không cho phép tự động tạo cột
            gridOrder.AllowUserToAddRows = false;  //không cho phép người dụng tự động thêm cột
            gridOrder.DataSource = listTopping ;

            DataGridViewTextBoxColumn clMa = new DataGridViewTextBoxColumn();
            clMa.Name = "Ma";
            clMa.HeaderText = "Mã Topping";
            clMa.DataPropertyName = "maTopping"; //kiểu dữ liệu nằm ở lớp DTO
            gridOrder.Columns.Add(clMa);

            DataGridViewTextBoxColumn clTen = new DataGridViewTextBoxColumn();
            clTen.Name = "Ten";
            clTen.HeaderText = "Tên Topping";
            clTen.DataPropertyName = "tenTopping";
            gridOrder.Columns.Add(clTen);

            DataGridViewTextBoxColumn clGia = new DataGridViewTextBoxColumn();
            clGia.Name = "Gia";
            clGia.HeaderText = "Giá Tiền";
            clGia.DataPropertyName = "giaTopping";
            gridOrder.Columns.Add(clGia);

            DataGridViewButtonColumn clChon = new DataGridViewButtonColumn();
            clChon.Name = "btChon";
            clChon.HeaderText = "Sửa";
            clChon.DataPropertyName = "chon";
            gridOrder.Columns.Add(clChon);
        }

        private void LoadThucUong()
        {
            listThucUong = thucUongBUS.select();
            if (listThucUong == null)
            {
                DialogResult kq = MessageBox.Show("Thông báo ", "Hiện tại chưa có dữ liệu ");
            }
            gridOrder.Columns.Clear(); //xóa sạch cột trên datagridview
            gridOrder.DataSource = null;

            gridOrder.AutoGenerateColumns = false; //không cho phép tự động tạo cột
            gridOrder.AllowUserToAddRows = false;  //không cho phép người dụng tự động thêm cột
            gridOrder.DataSource = listThucUong;

            DataGridViewTextBoxColumn clMa = new DataGridViewTextBoxColumn();
            clMa.Name = "Ma";
            clMa.HeaderText = "Mã Thức uống";
            clMa.DataPropertyName = "maThucUong"; //kiểu dữ liệu nằm ở lớp DTO
            gridOrder.Columns.Add(clMa);

            DataGridViewTextBoxColumn clTen = new DataGridViewTextBoxColumn();
            clTen.Name = "Ten";
            clTen.HeaderText = "Tên Thức Uống";
            clTen.DataPropertyName = "tenThucUong";
            gridOrder.Columns.Add(clTen);

            DataGridViewTextBoxColumn clGia = new DataGridViewTextBoxColumn();
            clGia.Name = "Gia";
            clGia.HeaderText = "Giá Tiền";
            clGia.DataPropertyName = "gia";
            gridOrder.Columns.Add(clGia);

            DataGridViewButtonColumn clChon = new DataGridViewButtonColumn();
            clChon.Name = "btChon";
            clChon.HeaderText = "chon";
            clChon.DataPropertyName = "chon";
            gridOrder.Columns.Add(clChon);

        }

        private void btThucUong_Click(object sender, EventArgs e)
        {
            LoadThucUong();
        }

        private void btTopping_Click(object sender, EventArgs e)
        {
            LoadTopping();
        }

        //them truong vao gridLoad
        private void AddGrid(string data)
        {
            listgrid.Add(data);
        }
        //load gird
        private void LoadGrid()
        {

        }

        private void gridOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                int indexRow;
                indexRow = e.RowIndex;
                DataGridViewRow row = gridOrder.Rows[indexRow];
                orderDTO.maThucUong = int.Parse(row.Cells[0].Value.ToString());


            }
        }
    }
}
