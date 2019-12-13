using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BoubleMilkTea
{
    public partial class ThongKeDoanhSo : Form
    {
        public ThongKeDoanhSo()
        {
            InitializeComponent();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=DESKTOP-BOSN45B\SQLEXPRESS;Initial Catalog=TraSua;Integrated Security=True";

            if (comboBox1.Text == "month")
            {
                con.Open();
                string query = String.Empty;
                query += "   select MONTH(tgbd) as thang,sum(TONGTIEN) as tongtien from HOADON ";
                query += " group by MONTH(TGBD)";

                DataTable ds = new DataTable();

                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                adapter.Fill(ds);


                dgv_ThongKe.Columns.Clear();
                dgv_ThongKe.Columns.Clear();
                dgv_ThongKe.DataSource = null;

                dgv_ThongKe.AutoGenerateColumns = false;
                dgv_ThongKe.AllowUserToAddRows = false;
                dgv_ThongKe.DataSource = ds;

                DataGridViewTextBoxColumn clMonth = new DataGridViewTextBoxColumn();
                clMonth.Name = "thang";
                clMonth.HeaderText = "Tháng";
                clMonth.DataPropertyName = "thang";
                dgv_ThongKe.Columns.Add(clMonth);

                DataGridViewTextBoxColumn clDoanhThu = new DataGridViewTextBoxColumn();
                clDoanhThu.Name = "tongtien";
                clDoanhThu.HeaderText = "Doanh Thu";
                clDoanhThu.DataPropertyName = "tongtien";
                dgv_ThongKe.Columns.Add(clDoanhThu);



                CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dgv_ThongKe.DataSource];
                myCurrencyManager.Refresh();
            }
            else
            {
                con.Open();
                string query = String.Empty;
                query += " select year(tgbd) as nam,sum(TONGTIEN) as tongtien from HOADON ";
                query += " group by YEAR(TGBD)";

                DataTable ds = new DataTable();

                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                adapter.Fill(ds);


                dgv_ThongKe.Columns.Clear();
                dgv_ThongKe.Columns.Clear();
                dgv_ThongKe.DataSource = null;

                dgv_ThongKe.AutoGenerateColumns = false;
                dgv_ThongKe.AllowUserToAddRows = false;
                dgv_ThongKe.DataSource = ds;

                DataGridViewTextBoxColumn clMonth = new DataGridViewTextBoxColumn();
                clMonth.Name = "nam";
                clMonth.HeaderText = "Năm";
                clMonth.DataPropertyName = "nam";
                dgv_ThongKe.Columns.Add(clMonth);

                DataGridViewTextBoxColumn clDoanhThu = new DataGridViewTextBoxColumn();
                clDoanhThu.Name = "tongtien";
                clDoanhThu.HeaderText = "Doanh Thu";
                clDoanhThu.DataPropertyName = "tongtien";
                dgv_ThongKe.Columns.Add(clDoanhThu);


                CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dgv_ThongKe.DataSource];
                myCurrencyManager.Refresh();
            }
        }

    }
}
