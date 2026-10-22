namespace QuanLyBanHang.Forms
{
    partial class frmHoaDonBan
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
            this.lblMaHDBan = new System.Windows.Forms.Label();
            this.txtMaHDBan = new System.Windows.Forms.TextBox();
            this.lblHoaDonBan = new System.Windows.Forms.Label();
            this.grpThongTinChung = new System.Windows.Forms.GroupBox();
            this.grpThongTinHang = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.dtpNgayBan = new System.Windows.Forms.DateTimePicker();
            this.cboMaNhanVien = new System.Windows.Forms.ComboBox();
            this.cboMaKhach = new System.Windows.Forms.ComboBox();
            this.lblNgayBan = new System.Windows.Forms.Label();
            this.lblMaNhanVien = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblTenNhanVien = new System.Windows.Forms.Label();
            this.lblMaKhach = new System.Windows.Forms.Label();
            this.txtTenKhach = new System.Windows.Forms.TextBox();
            this.lblTenKhach = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.lblSDT = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lblMaHang = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.lblTenHang = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.lblGiamGia = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.grpThongTinChung.SuspendLayout();
            this.grpThongTinHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMaHDBan
            // 
            this.lblMaHDBan.AutoSize = true;
            this.lblMaHDBan.Location = new System.Drawing.Point(29, 49);
            this.lblMaHDBan.Name = "lblMaHDBan";
            this.lblMaHDBan.Size = new System.Drawing.Size(78, 16);
            this.lblMaHDBan.TabIndex = 0;
            this.lblMaHDBan.Text = "Mã hóa đơn";
            this.lblMaHDBan.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtMaHDBan
            // 
            this.txtMaHDBan.Location = new System.Drawing.Point(128, 46);
            this.txtMaHDBan.Name = "txtMaHDBan";
            this.txtMaHDBan.ReadOnly = true;
            this.txtMaHDBan.Size = new System.Drawing.Size(229, 22);
            this.txtMaHDBan.TabIndex = 1;
            // 
            // lblHoaDonBan
            // 
            this.lblHoaDonBan.AutoSize = true;
            this.lblHoaDonBan.Location = new System.Drawing.Point(410, 25);
            this.lblHoaDonBan.Name = "lblHoaDonBan";
            this.lblHoaDonBan.Size = new System.Drawing.Size(85, 16);
            this.lblHoaDonBan.TabIndex = 0;
            this.lblHoaDonBan.Text = "Hóa đơn bán";
            // 
            // grpThongTinChung
            // 
            this.grpThongTinChung.Controls.Add(this.cboMaKhach);
            this.grpThongTinChung.Controls.Add(this.cboMaNhanVien);
            this.grpThongTinChung.Controls.Add(this.dtpNgayBan);
            this.grpThongTinChung.Controls.Add(this.lblMaNhanVien);
            this.grpThongTinChung.Controls.Add(this.lblNgayBan);
            this.grpThongTinChung.Controls.Add(this.lblSDT);
            this.grpThongTinChung.Controls.Add(this.lblMaKhach);
            this.grpThongTinChung.Controls.Add(this.txtSDT);
            this.grpThongTinChung.Controls.Add(this.lblDiaChi);
            this.grpThongTinChung.Controls.Add(this.txtDiaChi);
            this.grpThongTinChung.Controls.Add(this.lblTenKhach);
            this.grpThongTinChung.Controls.Add(this.txtTenKhach);
            this.grpThongTinChung.Controls.Add(this.lblTenNhanVien);
            this.grpThongTinChung.Controls.Add(this.textBox2);
            this.grpThongTinChung.Controls.Add(this.lblMaHDBan);
            this.grpThongTinChung.Controls.Add(this.txtMaHDBan);
            this.grpThongTinChung.Location = new System.Drawing.Point(29, 66);
            this.grpThongTinChung.Name = "grpThongTinChung";
            this.grpThongTinChung.Size = new System.Drawing.Size(841, 240);
            this.grpThongTinChung.TabIndex = 2;
            this.grpThongTinChung.TabStop = false;
            this.grpThongTinChung.Text = "Thông tin chung";
            // 
            // grpThongTinHang
            // 
            this.grpThongTinHang.Controls.Add(this.button6);
            this.grpThongTinHang.Controls.Add(this.button5);
            this.grpThongTinHang.Controls.Add(this.button4);
            this.grpThongTinHang.Controls.Add(this.button3);
            this.grpThongTinHang.Controls.Add(this.button2);
            this.grpThongTinHang.Controls.Add(this.comboBox4);
            this.grpThongTinHang.Controls.Add(this.dataGridView1);
            this.grpThongTinHang.Controls.Add(this.lblMaHang);
            this.grpThongTinHang.Controls.Add(this.label18);
            this.grpThongTinHang.Controls.Add(this.label17);
            this.grpThongTinHang.Controls.Add(this.label16);
            this.grpThongTinHang.Controls.Add(this.textBox11);
            this.grpThongTinHang.Controls.Add(this.label15);
            this.grpThongTinHang.Controls.Add(this.textBox10);
            this.grpThongTinHang.Controls.Add(this.label14);
            this.grpThongTinHang.Controls.Add(this.textBox9);
            this.grpThongTinHang.Controls.Add(this.lblGiamGia);
            this.grpThongTinHang.Controls.Add(this.textBox8);
            this.grpThongTinHang.Controls.Add(this.lblTenHang);
            this.grpThongTinHang.Controls.Add(this.textBox7);
            this.grpThongTinHang.Controls.Add(this.lblSoLuong);
            this.grpThongTinHang.Controls.Add(this.textBox6);
            this.grpThongTinHang.Location = new System.Drawing.Point(12, 333);
            this.grpThongTinHang.Name = "grpThongTinHang";
            this.grpThongTinHang.Size = new System.Drawing.Size(883, 429);
            this.grpThongTinHang.TabIndex = 2;
            this.grpThongTinHang.TabStop = false;
            this.grpThongTinHang.Text = "Thông tin các mặt hàng";
            this.grpThongTinHang.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 110);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(841, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(313, 775);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtpNgayBan
            // 
            this.dtpNgayBan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayBan.Location = new System.Drawing.Point(128, 83);
            this.dtpNgayBan.Name = "dtpNgayBan";
            this.dtpNgayBan.Size = new System.Drawing.Size(229, 22);
            this.dtpNgayBan.TabIndex = 2;
            // 
            // cboMaNhanVien
            // 
            this.cboMaNhanVien.FormattingEnabled = true;
            this.cboMaNhanVien.Location = new System.Drawing.Point(128, 132);
            this.cboMaNhanVien.Name = "cboMaNhanVien";
            this.cboMaNhanVien.Size = new System.Drawing.Size(121, 24);
            this.cboMaNhanVien.TabIndex = 3;
            this.cboMaNhanVien.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cboMaKhach
            // 
            this.cboMaKhach.FormattingEnabled = true;
            this.cboMaKhach.Location = new System.Drawing.Point(531, 46);
            this.cboMaKhach.Name = "cboMaKhach";
            this.cboMaKhach.Size = new System.Drawing.Size(141, 24);
            this.cboMaKhach.TabIndex = 3;
            // 
            // lblNgayBan
            // 
            this.lblNgayBan.AutoSize = true;
            this.lblNgayBan.Location = new System.Drawing.Point(29, 88);
            this.lblNgayBan.Name = "lblNgayBan";
            this.lblNgayBan.Size = new System.Drawing.Size(66, 16);
            this.lblNgayBan.TabIndex = 0;
            this.lblNgayBan.Text = "Ngày bán";
            this.lblNgayBan.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblMaNhanVien
            // 
            this.lblMaNhanVien.AutoSize = true;
            this.lblMaNhanVien.Location = new System.Drawing.Point(29, 135);
            this.lblMaNhanVien.Name = "lblMaNhanVien";
            this.lblMaNhanVien.Size = new System.Drawing.Size(86, 16);
            this.lblMaNhanVien.TabIndex = 0;
            this.lblMaNhanVien.Text = "Mã nhân viên";
            this.lblMaNhanVien.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(128, 181);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(229, 22);
            this.textBox2.TabIndex = 1;
            // 
            // lblTenNhanVien
            // 
            this.lblTenNhanVien.AutoSize = true;
            this.lblTenNhanVien.Location = new System.Drawing.Point(29, 184);
            this.lblTenNhanVien.Name = "lblTenNhanVien";
            this.lblTenNhanVien.Size = new System.Drawing.Size(91, 16);
            this.lblTenNhanVien.TabIndex = 0;
            this.lblTenNhanVien.Text = "Tên nhân viên";
            this.lblTenNhanVien.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblMaKhach
            // 
            this.lblMaKhach.AutoSize = true;
            this.lblMaKhach.Location = new System.Drawing.Point(450, 49);
            this.lblMaKhach.Name = "lblMaKhach";
            this.lblMaKhach.Size = new System.Drawing.Size(65, 16);
            this.lblMaKhach.TabIndex = 0;
            this.lblMaKhach.Text = "Mã khách";
            this.lblMaKhach.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtTenKhach
            // 
            this.txtTenKhach.Location = new System.Drawing.Point(531, 86);
            this.txtTenKhach.Name = "txtTenKhach";
            this.txtTenKhach.ReadOnly = true;
            this.txtTenKhach.Size = new System.Drawing.Size(254, 22);
            this.txtTenKhach.TabIndex = 1;
            // 
            // lblTenKhach
            // 
            this.lblTenKhach.AutoSize = true;
            this.lblTenKhach.Location = new System.Drawing.Point(450, 89);
            this.lblTenKhach.Name = "lblTenKhach";
            this.lblTenKhach.Size = new System.Drawing.Size(70, 16);
            this.lblTenKhach.TabIndex = 0;
            this.lblTenKhach.Text = "Tên khách";
            this.lblTenKhach.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(531, 127);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.ReadOnly = true;
            this.txtDiaChi.Size = new System.Drawing.Size(254, 60);
            this.txtDiaChi.TabIndex = 1;
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(450, 130);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(47, 16);
            this.lblDiaChi.TabIndex = 0;
            this.lblDiaChi.Text = "Địa chỉ";
            this.lblDiaChi.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(531, 193);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.ReadOnly = true;
            this.txtSDT.Size = new System.Drawing.Size(254, 22);
            this.txtSDT.TabIndex = 1;
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Location = new System.Drawing.Point(450, 196);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(35, 16);
            this.lblSDT.TabIndex = 0;
            this.lblSDT.Text = "SDT";
            this.lblSDT.Click += new System.EventHandler(this.label1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(269, 347);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 35);
            this.button2.TabIndex = 3;
            this.button2.Text = "button1";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblMaHang
            // 
            this.lblMaHang.AutoSize = true;
            this.lblMaHang.Location = new System.Drawing.Point(24, 38);
            this.lblMaHang.Name = "lblMaHang";
            this.lblMaHang.Size = new System.Drawing.Size(59, 16);
            this.lblMaHang.TabIndex = 0;
            this.lblMaHang.Text = "Mã hàng";
            this.lblMaHang.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(105, 35);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 24);
            this.comboBox4.TabIndex = 3;
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(105, 72);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(193, 22);
            this.textBox6.TabIndex = 1;
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Location = new System.Drawing.Point(24, 75);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(60, 16);
            this.lblSoLuong.TabIndex = 0;
            this.lblSoLuong.Text = "Số lượng";
            this.lblSoLuong.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(391, 32);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(193, 22);
            this.textBox7.TabIndex = 1;
            // 
            // lblTenHang
            // 
            this.lblTenHang.AutoSize = true;
            this.lblTenHang.Location = new System.Drawing.Point(310, 35);
            this.lblTenHang.Name = "lblTenHang";
            this.lblTenHang.Size = new System.Drawing.Size(64, 16);
            this.lblTenHang.TabIndex = 0;
            this.lblTenHang.Text = "Tên hàng";
            this.lblTenHang.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(391, 72);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(193, 22);
            this.textBox8.TabIndex = 1;
            // 
            // lblGiamGia
            // 
            this.lblGiamGia.AutoSize = true;
            this.lblGiamGia.Location = new System.Drawing.Point(310, 75);
            this.lblGiamGia.Name = "lblGiamGia";
            this.lblGiamGia.Size = new System.Drawing.Size(61, 16);
            this.lblGiamGia.TabIndex = 0;
            this.lblGiamGia.Text = "Giảm giá";
            this.lblGiamGia.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(671, 32);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(193, 22);
            this.textBox9.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(590, 35);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 16);
            this.label14.TabIndex = 0;
            this.label14.Text = "label1";
            this.label14.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(671, 72);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(193, 22);
            this.textBox10.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(590, 75);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 16);
            this.label15.TabIndex = 0;
            this.label15.Text = "label1";
            this.label15.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(640, 284);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(224, 22);
            this.textBox11.TabIndex = 1;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(590, 287);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(44, 16);
            this.label16.TabIndex = 0;
            this.label16.Text = "label1";
            this.label16.Click += new System.EventHandler(this.label1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(400, 347);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 35);
            this.button3.TabIndex = 3;
            this.button3.Text = "button1";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(524, 347);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(105, 35);
            this.button4.TabIndex = 3;
            this.button4.Text = "button1";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button1_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(645, 347);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(105, 35);
            this.button5.TabIndex = 3;
            this.button5.Text = "button1";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button1_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(762, 347);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(105, 35);
            this.button6.TabIndex = 3;
            this.button6.Text = "button1";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button1_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(24, 284);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(44, 16);
            this.label17.TabIndex = 0;
            this.label17.Text = "label1";
            this.label17.Click += new System.EventHandler(this.label1_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(24, 321);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(44, 16);
            this.label18.TabIndex = 0;
            this.label18.Text = "label1";
            this.label18.Click += new System.EventHandler(this.label1_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(26, 778);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(44, 16);
            this.label19.TabIndex = 0;
            this.label19.Text = "label1";
            this.label19.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(99, 775);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(184, 24);
            this.comboBox3.TabIndex = 3;
            // 
            // frmHoaDonBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(907, 806);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grpThongTinHang);
            this.Controls.Add(this.grpThongTinChung);
            this.Controls.Add(this.lblHoaDonBan);
            this.Controls.Add(this.label19);
            this.Name = "frmHoaDonBan";
            this.Text = "frmHoaDonBan";
            this.grpThongTinChung.ResumeLayout(false);
            this.grpThongTinChung.PerformLayout();
            this.grpThongTinHang.ResumeLayout(false);
            this.grpThongTinHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaHDBan;
        private System.Windows.Forms.TextBox txtMaHDBan;
        private System.Windows.Forms.Label lblHoaDonBan;
        private System.Windows.Forms.GroupBox grpThongTinChung;
        private System.Windows.Forms.GroupBox grpThongTinHang;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cboMaKhach;
        private System.Windows.Forms.ComboBox cboMaNhanVien;
        private System.Windows.Forms.DateTimePicker dtpNgayBan;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblNgayBan;
        private System.Windows.Forms.Label lblMaNhanVien;
        private System.Windows.Forms.Label lblTenNhanVien;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label lblTenKhach;
        private System.Windows.Forms.TextBox txtTenKhach;
        private System.Windows.Forms.Label lblMaKhach;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label lblMaHang;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label lblGiamGia;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label lblTenHang;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox comboBox3;
    }
}