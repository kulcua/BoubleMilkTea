namespace BoubleMilkTea
{
    partial class QuanLyKho
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
            this.tbTenThucUong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbMaThucUong = new System.Windows.Forms.Label();
            this.gridThucUong = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaThucUong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenThucUong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sua = new System.Windows.Forms.DataGridViewButtonColumn();
            this.xoa = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_ThemThucUong = new System.Windows.Forms.Button();
            this.tbGiaThucUong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbMaTopping = new System.Windows.Forms.Label();
            this.gridTopping = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaTopping = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTopping = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_ThemTopping = new System.Windows.Forms.Button();
            this.tbGiaTopping = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbTenTopping = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridThucUong)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTopping)).BeginInit();
            this.SuspendLayout();
            // 
            // tbTenThucUong
            // 
            this.tbTenThucUong.BackColor = System.Drawing.Color.White;
            this.tbTenThucUong.Enabled = false;
            this.tbTenThucUong.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTenThucUong.Location = new System.Drawing.Point(208, 44);
            this.tbTenThucUong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbTenThucUong.Name = "tbTenThucUong";
            this.tbTenThucUong.Size = new System.Drawing.Size(298, 32);
            this.tbTenThucUong.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(30, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 24);
            this.label1.TabIndex = 22;
            this.label1.Text = "Tên thức uống:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbMaThucUong);
            this.groupBox1.Controls.Add(this.gridThucUong);
            this.groupBox1.Controls.Add(this.btn_ThemThucUong);
            this.groupBox1.Controls.Add(this.tbGiaThucUong);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbTenThucUong);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(2, 60);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(609, 409);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TRÀ SỮA";
            // 
            // tbMaThucUong
            // 
            this.tbMaThucUong.AutoSize = true;
            this.tbMaThucUong.Location = new System.Drawing.Point(203, 12);
            this.tbMaThucUong.Name = "tbMaThucUong";
            this.tbMaThucUong.Size = new System.Drawing.Size(0, 17);
            this.tbMaThucUong.TabIndex = 34;
            this.tbMaThucUong.Visible = false;
            // 
            // gridThucUong
            // 
            this.gridThucUong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridThucUong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridThucUong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaThucUong,
            this.TenThucUong,
            this.Gia,
            this.sua,
            this.xoa});
            this.gridThucUong.Location = new System.Drawing.Point(10, 173);
            this.gridThucUong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridThucUong.Name = "gridThucUong";
            this.gridThucUong.RowHeadersWidth = 51;
            this.gridThucUong.Size = new System.Drawing.Size(576, 187);
            this.gridThucUong.TabIndex = 33;
            this.gridThucUong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridThucUong_CellClick);
            this.gridThucUong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridThucUong_CellContentClick);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            // 
            // MaThucUong
            // 
            this.MaThucUong.HeaderText = "Mã thức uống";
            this.MaThucUong.MinimumWidth = 6;
            this.MaThucUong.Name = "MaThucUong";
            // 
            // TenThucUong
            // 
            this.TenThucUong.HeaderText = "Tên thức uống";
            this.TenThucUong.MinimumWidth = 6;
            this.TenThucUong.Name = "TenThucUong";
            // 
            // Gia
            // 
            this.Gia.HeaderText = "Giá";
            this.Gia.MinimumWidth = 6;
            this.Gia.Name = "Gia";
            // 
            // sua
            // 
            this.sua.HeaderText = "Sửa";
            this.sua.MinimumWidth = 6;
            this.sua.Name = "sua";
            // 
            // xoa
            // 
            this.xoa.HeaderText = "Xóa";
            this.xoa.MinimumWidth = 6;
            this.xoa.Name = "xoa";
            // 
            // btn_ThemThucUong
            // 
            this.btn_ThemThucUong.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_ThemThucUong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ThemThucUong.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemThucUong.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_ThemThucUong.Location = new System.Drawing.Point(533, 93);
            this.btn_ThemThucUong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_ThemThucUong.Name = "btn_ThemThucUong";
            this.btn_ThemThucUong.Size = new System.Drawing.Size(40, 37);
            this.btn_ThemThucUong.TabIndex = 32;
            this.btn_ThemThucUong.Text = "+";
            this.btn_ThemThucUong.UseVisualStyleBackColor = false;
            this.btn_ThemThucUong.Click += new System.EventHandler(this.btn_ThemThucUong_Click);
            // 
            // tbGiaThucUong
            // 
            this.tbGiaThucUong.BackColor = System.Drawing.Color.White;
            this.tbGiaThucUong.Enabled = false;
            this.tbGiaThucUong.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGiaThucUong.Location = new System.Drawing.Point(208, 93);
            this.tbGiaThucUong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbGiaThucUong.Name = "tbGiaThucUong";
            this.tbGiaThucUong.Size = new System.Drawing.Size(298, 32);
            this.tbGiaThucUong.TabIndex = 25;
            this.tbGiaThucUong.Text = " 0.00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(30, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 24);
            this.label2.TabIndex = 24;
            this.label2.Text = "Giá:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbMaTopping);
            this.groupBox2.Controls.Add(this.gridTopping);
            this.groupBox2.Controls.Add(this.btn_ThemTopping);
            this.groupBox2.Controls.Add(this.tbGiaTopping);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tbTenTopping);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(619, 60);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(601, 409);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "TOPPING";
            // 
            // tbMaTopping
            // 
            this.tbMaTopping.AutoSize = true;
            this.tbMaTopping.Location = new System.Drawing.Point(191, 12);
            this.tbMaTopping.Name = "tbMaTopping";
            this.tbMaTopping.Size = new System.Drawing.Size(0, 17);
            this.tbMaTopping.TabIndex = 27;
            this.tbMaTopping.Visible = false;
            // 
            // gridTopping
            // 
            this.gridTopping.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridTopping.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTopping.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.MaTopping,
            this.TenTopping,
            this.dataGridViewTextBoxColumn4});
            this.gridTopping.Location = new System.Drawing.Point(10, 173);
            this.gridTopping.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridTopping.Name = "gridTopping";
            this.gridTopping.RowHeadersWidth = 51;
            this.gridTopping.Size = new System.Drawing.Size(576, 187);
            this.gridTopping.TabIndex = 33;
            this.gridTopping.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridTopping_CellClick);
            this.gridTopping.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridTopping_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "STT";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // MaTopping
            // 
            this.MaTopping.HeaderText = "Mã topping";
            this.MaTopping.MinimumWidth = 6;
            this.MaTopping.Name = "MaTopping";
            // 
            // TenTopping
            // 
            this.TenTopping.HeaderText = "Tên topping";
            this.TenTopping.MinimumWidth = 6;
            this.TenTopping.Name = "TenTopping";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Giá";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // btn_ThemTopping
            // 
            this.btn_ThemTopping.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_ThemTopping.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ThemTopping.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemTopping.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_ThemTopping.Location = new System.Drawing.Point(525, 97);
            this.btn_ThemTopping.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_ThemTopping.Name = "btn_ThemTopping";
            this.btn_ThemTopping.Size = new System.Drawing.Size(40, 37);
            this.btn_ThemTopping.TabIndex = 32;
            this.btn_ThemTopping.Text = "+";
            this.btn_ThemTopping.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ThemTopping.UseVisualStyleBackColor = false;
            this.btn_ThemTopping.Click += new System.EventHandler(this.btn_ThemTopping_Click);
            // 
            // tbGiaTopping
            // 
            this.tbGiaTopping.BackColor = System.Drawing.Color.White;
            this.tbGiaTopping.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGiaTopping.Location = new System.Drawing.Point(195, 94);
            this.tbGiaTopping.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbGiaTopping.Name = "tbGiaTopping";
            this.tbGiaTopping.Size = new System.Drawing.Size(298, 32);
            this.tbGiaTopping.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label5.Location = new System.Drawing.Point(17, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 24);
            this.label5.TabIndex = 24;
            this.label5.Text = "Giá:";
            // 
            // tbTenTopping
            // 
            this.tbTenTopping.BackColor = System.Drawing.Color.White;
            this.tbTenTopping.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTenTopping.Location = new System.Drawing.Point(195, 45);
            this.tbTenTopping.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbTenTopping.Name = "tbTenTopping";
            this.tbTenTopping.Size = new System.Drawing.Size(298, 32);
            this.tbTenTopping.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label7.Location = new System.Drawing.Point(17, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 24);
            this.label7.TabIndex = 22;
            this.label7.Text = "Tên topping:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(2, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 40);
            this.button1.TabIndex = 27;
            this.button1.Text = "BACK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // QuanLyKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(1238, 485);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "QuanLyKho";
            this.Text = "Quản lý kho";
            this.Load += new System.EventHandler(this.QuanLyKho_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridThucUong)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTopping)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox tbTenThucUong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbGiaThucUong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gridThucUong;
        private System.Windows.Forms.Button btn_ThemThucUong;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView gridTopping;
        private System.Windows.Forms.Button btn_ThemTopping;
        private System.Windows.Forms.TextBox tbGiaTopping;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbTenTopping;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTopping;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTopping;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaThucUong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenThucUong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private System.Windows.Forms.DataGridViewButtonColumn sua;
        private System.Windows.Forms.DataGridViewButtonColumn xoa;
        private System.Windows.Forms.Label tbMaThucUong;
        private System.Windows.Forms.Label tbMaTopping;
        private System.Windows.Forms.Button button1;
    }
}