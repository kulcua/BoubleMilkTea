namespace BoubleMilkTea
{
    partial class NhanOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lb_TenNV = new System.Windows.Forms.Label();
            this.tb_TenNV = new System.Windows.Forms.TextBox();
            this.lb_ThoiGian = new System.Windows.Forms.Label();
            this.dt_ThoiGian = new System.Windows.Forms.DateTimePicker();
            this.btn_Them = new System.Windows.Forms.Button();
            this.lb2 = new System.Windows.Forms.Label();
            this.lb_TongTien = new System.Windows.Forms.Label();
            this.dgv_Order = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thucuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.topping = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.da = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_InHoaDon = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tab_Order = new System.Windows.Forms.TabControl();
            this.lb_TenKH = new System.Windows.Forms.Label();
            this.tb_TenKH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_Duong = new System.Windows.Forms.ComboBox();
            this.cb_Da = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_MaHD = new System.Windows.Forms.Label();
            this.cb_MaKM = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Order)).BeginInit();
            this.tab_Order.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_TenNV
            // 
            this.lb_TenNV.AutoSize = true;
            this.lb_TenNV.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TenNV.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lb_TenNV.Location = new System.Drawing.Point(442, 22);
            this.lb_TenNV.Name = "lb_TenNV";
            this.lb_TenNV.Size = new System.Drawing.Size(72, 24);
            this.lb_TenNV.TabIndex = 2;
            this.lb_TenNV.Text = "Tên NV:";
            // 
            // tb_TenNV
            // 
            this.tb_TenNV.BackColor = System.Drawing.Color.White;
            this.tb_TenNV.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_TenNV.Location = new System.Drawing.Point(506, 14);
            this.tb_TenNV.Name = "tb_TenNV";
            this.tb_TenNV.ReadOnly = true;
            this.tb_TenNV.Size = new System.Drawing.Size(224, 32);
            this.tb_TenNV.TabIndex = 3;
            this.tb_TenNV.Text = "nhanvien";
            // 
            // lb_ThoiGian
            // 
            this.lb_ThoiGian.AutoSize = true;
            this.lb_ThoiGian.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ThoiGian.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lb_ThoiGian.Location = new System.Drawing.Point(426, 60);
            this.lb_ThoiGian.Name = "lb_ThoiGian";
            this.lb_ThoiGian.Size = new System.Drawing.Size(93, 24);
            this.lb_ThoiGian.TabIndex = 4;
            this.lb_ThoiGian.Text = "Thời gian:";
            // 
            // dt_ThoiGian
            // 
            this.dt_ThoiGian.CalendarMonthBackground = System.Drawing.SystemColors.InactiveCaption;
            this.dt_ThoiGian.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_ThoiGian.Location = new System.Drawing.Point(506, 54);
            this.dt_ThoiGian.Name = "dt_ThoiGian";
            this.dt_ThoiGian.Size = new System.Drawing.Size(224, 30);
            this.dt_ThoiGian.TabIndex = 5;
            this.dt_ThoiGian.Value = new System.DateTime(2019, 11, 27, 19, 46, 10, 0);
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Them.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.Location = new System.Drawing.Point(695, 273);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(35, 35);
            this.btn_Them.TabIndex = 7;
            this.btn_Them.Text = "+";
            this.btn_Them.UseVisualStyleBackColor = false;
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lb2.Location = new System.Drawing.Point(744, 320);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(76, 29);
            this.lb2.TabIndex = 12;
            this.lb2.Text = "TỔNG";
            // 
            // lb_TongTien
            // 
            this.lb_TongTien.AutoSize = true;
            this.lb_TongTien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_TongTien.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TongTien.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lb_TongTien.Location = new System.Drawing.Point(810, 317);
            this.lb_TongTien.Name = "lb_TongTien";
            this.lb_TongTien.Size = new System.Drawing.Size(120, 31);
            this.lb_TongTien.TabIndex = 16;
            this.lb_TongTien.Text = "1.000.000";
            // 
            // dgv_Order
            // 
            this.dgv_Order.AllowUserToOrderColumns = true;
            this.dgv_Order.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgv_Order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Order.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.thucuong,
            this.topping,
            this.da,
            this.duong,
            this.gia});
            this.dgv_Order.Location = new System.Drawing.Point(56, 320);
            this.dgv_Order.Name = "dgv_Order";
            this.dgv_Order.RowHeadersWidth = 51;
            this.dgv_Order.Size = new System.Drawing.Size(670, 170);
            this.dgv_Order.TabIndex = 17;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.Width = 125;
            // 
            // thucuong
            // 
            this.thucuong.HeaderText = "Thức uống";
            this.thucuong.MinimumWidth = 6;
            this.thucuong.Name = "thucuong";
            this.thucuong.Width = 125;
            // 
            // topping
            // 
            this.topping.HeaderText = "Topping";
            this.topping.MinimumWidth = 6;
            this.topping.Name = "topping";
            this.topping.Width = 125;
            // 
            // da
            // 
            this.da.HeaderText = "Đá";
            this.da.MinimumWidth = 6;
            this.da.Name = "da";
            this.da.Width = 125;
            // 
            // duong
            // 
            this.duong.HeaderText = "Đường";
            this.duong.MinimumWidth = 6;
            this.duong.Name = "duong";
            this.duong.Width = 125;
            // 
            // gia
            // 
            this.gia.HeaderText = "Giá";
            this.gia.MinimumWidth = 6;
            this.gia.Name = "gia";
            this.gia.Width = 125;
            // 
            // btn_InHoaDon
            // 
            this.btn_InHoaDon.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_InHoaDon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_InHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_InHoaDon.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_InHoaDon.Location = new System.Drawing.Point(775, 385);
            this.btn_InHoaDon.Name = "btn_InHoaDon";
            this.btn_InHoaDon.Size = new System.Drawing.Size(100, 69);
            this.btn_InHoaDon.TabIndex = 18;
            this.btn_InHoaDon.Text = "In Hoá Đơn";
            this.btn_InHoaDon.UseVisualStyleBackColor = false;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(532, 195);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Topping";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tabPage1.Font = new System.Drawing.Font("Georgia", 12.75F);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(532, 195);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Thức Uống";
            // 
            // tab_Order
            // 
            this.tab_Order.Controls.Add(this.tabPage1);
            this.tab_Order.Controls.Add(this.tabPage2);
            this.tab_Order.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_Order.Location = new System.Drawing.Point(52, 85);
            this.tab_Order.Name = "tab_Order";
            this.tab_Order.SelectedIndex = 0;
            this.tab_Order.Size = new System.Drawing.Size(540, 227);
            this.tab_Order.TabIndex = 6;
            // 
            // lb_TenKH
            // 
            this.lb_TenKH.AutoSize = true;
            this.lb_TenKH.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TenKH.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lb_TenKH.Location = new System.Drawing.Point(52, 22);
            this.lb_TenKH.Name = "lb_TenKH";
            this.lb_TenKH.Size = new System.Drawing.Size(103, 24);
            this.lb_TenKH.TabIndex = 0;
            this.lb_TenKH.Text = "Tên khách: ";
            // 
            // tb_TenKH
            // 
            this.tb_TenKH.BackColor = System.Drawing.Color.White;
            this.tb_TenKH.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_TenKH.Location = new System.Drawing.Point(140, 14);
            this.tb_TenKH.Name = "tb_TenKH";
            this.tb_TenKH.Size = new System.Drawing.Size(224, 32);
            this.tb_TenKH.TabIndex = 19;
            this.tb_TenKH.Text = "khach";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(598, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 24);
            this.label1.TabIndex = 20;
            this.label1.Text = "Đường:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(598, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 24);
            this.label2.TabIndex = 21;
            this.label2.Text = "Đá:";
            // 
            // cb_Duong
            // 
            this.cb_Duong.FormattingEnabled = true;
            this.cb_Duong.Location = new System.Drawing.Point(661, 114);
            this.cb_Duong.Name = "cb_Duong";
            this.cb_Duong.Size = new System.Drawing.Size(68, 27);
            this.cb_Duong.TabIndex = 22;
            this.cb_Duong.Text = "70%";
            // 
            // cb_Da
            // 
            this.cb_Da.FormattingEnabled = true;
            this.cb_Da.Location = new System.Drawing.Point(661, 158);
            this.cb_Da.Name = "cb_Da";
            this.cb_Da.Size = new System.Drawing.Size(68, 27);
            this.cb_Da.TabIndex = 23;
            this.cb_Da.Text = "100%";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label3.Location = new System.Drawing.Point(783, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 24);
            this.label3.TabIndex = 24;
            this.label3.Text = "Mã order";
            // 
            // lb_MaHD
            // 
            this.lb_MaHD.AutoSize = true;
            this.lb_MaHD.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MaHD.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lb_MaHD.Location = new System.Drawing.Point(786, 54);
            this.lb_MaHD.Name = "lb_MaHD";
            this.lb_MaHD.Size = new System.Drawing.Size(80, 24);
            this.lb_MaHD.TabIndex = 25;
            this.lb_MaHD.Text = "1222111";
            // 
            // cb_MaKM
            // 
            this.cb_MaKM.FormattingEnabled = true;
            this.cb_MaKM.Location = new System.Drawing.Point(605, 234);
            this.cb_MaKM.Name = "cb_MaKM";
            this.cb_MaKM.Size = new System.Drawing.Size(125, 27);
            this.cb_MaKM.TabIndex = 27;
            this.cb_MaKM.Text = "NOEL2019";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label4.Location = new System.Drawing.Point(601, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 24);
            this.label4.TabIndex = 26;
            this.label4.Text = "Mã KM (nếu có):";
            // 
            // NhanOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(957, 540);
            this.Controls.Add(this.cb_MaKM);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lb_MaHD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_Da);
            this.Controls.Add(this.cb_Duong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.tb_TenKH);
            this.Controls.Add(this.btn_InHoaDon);
            this.Controls.Add(this.dgv_Order);
            this.Controls.Add(this.lb_TongTien);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.tab_Order);
            this.Controls.Add(this.dt_ThoiGian);
            this.Controls.Add(this.lb_ThoiGian);
            this.Controls.Add(this.tb_TenNV);
            this.Controls.Add(this.lb_TenNV);
            this.Controls.Add(this.lb_TenKH);
            this.Enabled = false;
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Name = "NhanOrder";
            this.Text = "Nhận Order";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Order)).EndInit();
            this.tab_Order.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_TenNV;
        private System.Windows.Forms.TextBox tb_TenNV;
        private System.Windows.Forms.Label lb_ThoiGian;
        private System.Windows.Forms.DateTimePicker dt_ThoiGian;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label lb_TongTien;
        private System.Windows.Forms.DataGridView dgv_Order;
        private System.Windows.Forms.Button btn_InHoaDon;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn thucuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn topping;
        private System.Windows.Forms.DataGridViewTextBoxColumn da;
        private System.Windows.Forms.DataGridViewTextBoxColumn duong;
        private System.Windows.Forms.DataGridViewTextBoxColumn gia;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tab_Order;
        private System.Windows.Forms.Label lb_TenKH;
        private System.Windows.Forms.TextBox tb_TenKH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_Duong;
        private System.Windows.Forms.ComboBox cb_Da;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_MaHD;
        private System.Windows.Forms.ComboBox cb_MaKM;
        private System.Windows.Forms.Label label4;
    }
}

