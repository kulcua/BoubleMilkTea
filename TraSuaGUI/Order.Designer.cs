namespace BoubleMilkTea
{
    partial class Order
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
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tbTenKH = new System.Windows.Forms.TextBox();
            this.btTopping = new System.Windows.Forms.Button();
            this.btThucUong = new System.Windows.Forms.Button();
            this.gridOrder = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_MaHD = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_Duong = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_TenKH = new System.Windows.Forms.Label();
            this.gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.da = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.topping = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thucuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btn_InHoaDon = new System.Windows.Forms.Button();
            this.gridLoad = new System.Windows.Forms.DataGridView();
            this.lb_TongTien = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.lb_ThoiGian = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.tbMaNhanVien = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLoad)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "70%",
            "30%"});
            this.comboBox2.Location = new System.Drawing.Point(617, 293);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(138, 25);
            this.comboBox2.TabIndex = 57;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "70%",
            "30%"});
            this.comboBox1.Location = new System.Drawing.Point(687, 206);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(68, 25);
            this.comboBox1.TabIndex = 56;
            // 
            // tbTenKH
            // 
            this.tbTenKH.Location = new System.Drawing.Point(152, 40);
            this.tbTenKH.Name = "tbTenKH";
            this.tbTenKH.Size = new System.Drawing.Size(166, 25);
            this.tbTenKH.TabIndex = 53;
            // 
            // btTopping
            // 
            this.btTopping.ForeColor = System.Drawing.Color.Black;
            this.btTopping.Location = new System.Drawing.Point(201, 120);
            this.btTopping.Name = "btTopping";
            this.btTopping.Size = new System.Drawing.Size(146, 39);
            this.btTopping.TabIndex = 52;
            this.btTopping.Text = "Topping";
            this.btTopping.UseVisualStyleBackColor = true;
            this.btTopping.Click += new System.EventHandler(this.btTopping_Click);
            // 
            // btThucUong
            // 
            this.btThucUong.ForeColor = System.Drawing.Color.Black;
            this.btThucUong.Location = new System.Drawing.Point(58, 120);
            this.btThucUong.Name = "btThucUong";
            this.btThucUong.Size = new System.Drawing.Size(146, 39);
            this.btThucUong.TabIndex = 51;
            this.btThucUong.Text = "Thức uống";
            this.btThucUong.UseVisualStyleBackColor = true;
            this.btThucUong.Click += new System.EventHandler(this.btThucUong_Click);
            // 
            // gridOrder
            // 
            this.gridOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridOrder.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.gridOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridOrder.Location = new System.Drawing.Point(58, 164);
            this.gridOrder.Name = "gridOrder";
            this.gridOrder.RowHeadersWidth = 51;
            this.gridOrder.RowTemplate.Height = 27;
            this.gridOrder.Size = new System.Drawing.Size(539, 150);
            this.gridOrder.TabIndex = 50;
            this.gridOrder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridOrder_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label4.Location = new System.Drawing.Point(613, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 24);
            this.label4.TabIndex = 49;
            this.label4.Text = "Mã KM (nếu có):";
            // 
            // lb_MaHD
            // 
            this.lb_MaHD.AutoSize = true;
            this.lb_MaHD.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MaHD.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lb_MaHD.Location = new System.Drawing.Point(788, 71);
            this.lb_MaHD.Name = "lb_MaHD";
            this.lb_MaHD.Size = new System.Drawing.Size(80, 24);
            this.lb_MaHD.TabIndex = 48;
            this.lb_MaHD.Text = "1222111";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label3.Location = new System.Drawing.Point(785, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 24);
            this.label3.TabIndex = 47;
            this.label3.Text = "Mã order";
            // 
            // cb_Duong
            // 
            this.cb_Duong.FormattingEnabled = true;
            this.cb_Duong.Items.AddRange(new object[] {
            "70%",
            "30%"});
            this.cb_Duong.Location = new System.Drawing.Point(687, 164);
            this.cb_Duong.Name = "cb_Duong";
            this.cb_Duong.Size = new System.Drawing.Size(68, 25);
            this.cb_Duong.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(610, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 24);
            this.label2.TabIndex = 45;
            this.label2.Text = "Đá:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(610, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 24);
            this.label1.TabIndex = 44;
            this.label1.Text = "Đường:";
            // 
            // lb_TenKH
            // 
            this.lb_TenKH.AutoSize = true;
            this.lb_TenKH.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TenKH.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lb_TenKH.Location = new System.Drawing.Point(54, 39);
            this.lb_TenKH.Name = "lb_TenKH";
            this.lb_TenKH.Size = new System.Drawing.Size(103, 24);
            this.lb_TenKH.TabIndex = 36;
            this.lb_TenKH.Text = "Tên khách: ";
            // 
            // gia
            // 
            this.gia.HeaderText = "Giá";
            this.gia.MinimumWidth = 6;
            this.gia.Name = "gia";
            // 
            // duong
            // 
            this.duong.HeaderText = "Đường";
            this.duong.MinimumWidth = 6;
            this.duong.Name = "duong";
            // 
            // da
            // 
            this.da.HeaderText = "Đá";
            this.da.MinimumWidth = 6;
            this.da.Name = "da";
            // 
            // topping
            // 
            this.topping.HeaderText = "Topping";
            this.topping.MinimumWidth = 6;
            this.topping.Name = "topping";
            // 
            // thucuong
            // 
            this.thucuong.HeaderText = "Thức uống";
            this.thucuong.MinimumWidth = 6;
            this.thucuong.Name = "thucuong";
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(535, 77);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 25);
            this.dateTimePicker1.TabIndex = 55;
            // 
            // btn_InHoaDon
            // 
            this.btn_InHoaDon.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_InHoaDon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_InHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_InHoaDon.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_InHoaDon.Location = new System.Drawing.Point(768, 235);
            this.btn_InHoaDon.Name = "btn_InHoaDon";
            this.btn_InHoaDon.Size = new System.Drawing.Size(100, 69);
            this.btn_InHoaDon.TabIndex = 43;
            this.btn_InHoaDon.Text = "In Hoá Đơn";
            this.btn_InHoaDon.UseVisualStyleBackColor = false;
            // 
            // gridLoad
            // 
            this.gridLoad.AllowUserToOrderColumns = true;
            this.gridLoad.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridLoad.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.gridLoad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridLoad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.thucuong,
            this.topping,
            this.da,
            this.duong,
            this.gia});
            this.gridLoad.Location = new System.Drawing.Point(58, 337);
            this.gridLoad.Name = "gridLoad";
            this.gridLoad.RowHeadersWidth = 51;
            this.gridLoad.Size = new System.Drawing.Size(670, 170);
            this.gridLoad.TabIndex = 42;
            // 
            // lb_TongTien
            // 
            this.lb_TongTien.AutoSize = true;
            this.lb_TongTien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_TongTien.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TongTien.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lb_TongTien.Location = new System.Drawing.Point(828, 335);
            this.lb_TongTien.Name = "lb_TongTien";
            this.lb_TongTien.Size = new System.Drawing.Size(2, 31);
            this.lb_TongTien.TabIndex = 41;
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lb2.Location = new System.Drawing.Point(746, 337);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(76, 29);
            this.lb2.TabIndex = 40;
            this.lb2.Text = "TỔNG";
            // 
            // lb_ThoiGian
            // 
            this.lb_ThoiGian.AutoSize = true;
            this.lb_ThoiGian.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ThoiGian.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lb_ThoiGian.Location = new System.Drawing.Point(428, 77);
            this.lb_ThoiGian.Name = "lb_ThoiGian";
            this.lb_ThoiGian.Size = new System.Drawing.Size(93, 24);
            this.lb_ThoiGian.TabIndex = 38;
            this.lb_ThoiGian.Text = "Thời gian:";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label.Location = new System.Drawing.Point(428, 38);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(135, 24);
            this.label.TabIndex = 37;
            this.label.Text = "Mã nhân viên: ";
            // 
            // tbMaNhanVien
            // 
            this.tbMaNhanVien.AutoSize = true;
            this.tbMaNhanVien.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaNhanVien.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbMaNhanVien.Location = new System.Drawing.Point(569, 38);
            this.tbMaNhanVien.Name = "tbMaNhanVien";
            this.tbMaNhanVien.Size = new System.Drawing.Size(20, 24);
            this.tbMaNhanVien.TabIndex = 58;
            this.tbMaNhanVien.Text = "1";
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 543);
            this.Controls.Add(this.tbMaNhanVien);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.tbTenKH);
            this.Controls.Add(this.btTopping);
            this.Controls.Add(this.btThucUong);
            this.Controls.Add(this.gridOrder);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lb_MaHD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_Duong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_TenKH);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btn_InHoaDon);
            this.Controls.Add(this.gridLoad);
            this.Controls.Add(this.lb_TongTien);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb_ThoiGian);
            this.Controls.Add(this.label);
            this.Name = "Order";
            this.Text = "Order";
            this.Load += new System.EventHandler(this.Order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLoad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox tbTenKH;
        private System.Windows.Forms.Button btTopping;
        private System.Windows.Forms.Button btThucUong;
        private System.Windows.Forms.DataGridView gridOrder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_MaHD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_Duong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn duong;
        private System.Windows.Forms.DataGridViewTextBoxColumn da;
        private System.Windows.Forms.DataGridViewTextBoxColumn topping;
        private System.Windows.Forms.DataGridViewTextBoxColumn thucuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btn_InHoaDon;
        private System.Windows.Forms.DataGridView gridLoad;
        private System.Windows.Forms.Label lb_TongTien;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label lb_ThoiGian;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label tbMaNhanVien;
    }
}