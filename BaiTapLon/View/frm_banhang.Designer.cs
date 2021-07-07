namespace BaiTapLon.View
{
    partial class frm_banhang
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.btnsearch = new System.Windows.Forms.Button();
            this.txtmahd = new System.Windows.Forms.TextBox();
            this.txttksp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbotkkh = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnhuydonhang = new System.Windows.Forms.Button();
            this.btndangxuat = new System.Windows.Forms.Button();
            this.lbDateBig = new System.Windows.Forms.Label();
            this.lbNgayThangBig = new System.Windows.Forms.Label();
            this.labelGioBig = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtthanhtien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnthanhtoan = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnxoa = new System.Windows.Forms.Button();
            this.dataGridViewHoaDon = new System.Windows.Forms.DataGridView();
            this.masp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giasp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewSanPham = new System.Windows.Forms.DataGridView();
            this.ma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnthemkh = new System.Windows.Forms.Button();
            this.btncapnhat = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm kiếm sản phẩm: ";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnthemkh);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnsearch);
            this.panel1.Controls.Add(this.txtmahd);
            this.panel1.Controls.Add(this.txttksp);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbotkkh);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(996, 113);
            this.panel1.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(556, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Mã hóa đơn";
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(371, 47);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(75, 28);
            this.btnsearch.TabIndex = 5;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // txtmahd
            // 
            this.txtmahd.Location = new System.Drawing.Point(655, 62);
            this.txtmahd.Name = "txtmahd";
            this.txtmahd.Size = new System.Drawing.Size(203, 26);
            this.txtmahd.TabIndex = 8;
            // 
            // txttksp
            // 
            this.txttksp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttksp.Location = new System.Drawing.Point(173, 47);
            this.txttksp.Name = "txttksp";
            this.txttksp.Size = new System.Drawing.Size(182, 26);
            this.txttksp.TabIndex = 4;
            this.txttksp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttksp_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(483, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tìm kiếm khách hàng: ";
            // 
            // cbotkkh
            // 
            this.cbotkkh.FormattingEnabled = true;
            this.cbotkkh.Location = new System.Drawing.Point(655, 17);
            this.cbotkkh.Name = "cbotkkh";
            this.cbotkkh.Size = new System.Drawing.Size(203, 28);
            this.cbotkkh.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnhuydonhang);
            this.panel2.Controls.Add(this.btndangxuat);
            this.panel2.Controls.Add(this.lbDateBig);
            this.panel2.Controls.Add(this.lbNgayThangBig);
            this.panel2.Controls.Add(this.labelGioBig);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.btnthanhtoan);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(1014, 98);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(344, 520);
            this.panel2.TabIndex = 3;
            // 
            // btnhuydonhang
            // 
            this.btnhuydonhang.Location = new System.Drawing.Point(32, 471);
            this.btnhuydonhang.Name = "btnhuydonhang";
            this.btnhuydonhang.Size = new System.Drawing.Size(123, 35);
            this.btnhuydonhang.TabIndex = 11;
            this.btnhuydonhang.Text = "Hủy đơn hàng";
            this.btnhuydonhang.UseVisualStyleBackColor = true;
            this.btnhuydonhang.Click += new System.EventHandler(this.btnhuydonhang_Click);
            // 
            // btndangxuat
            // 
            this.btndangxuat.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndangxuat.Location = new System.Drawing.Point(195, 470);
            this.btndangxuat.Name = "btndangxuat";
            this.btndangxuat.Size = new System.Drawing.Size(121, 36);
            this.btndangxuat.TabIndex = 5;
            this.btndangxuat.Text = "Đăng xuất";
            this.btndangxuat.UseVisualStyleBackColor = true;
            this.btndangxuat.Click += new System.EventHandler(this.btndangxuat_Click);
            // 
            // lbDateBig
            // 
            this.lbDateBig.AutoSize = true;
            this.lbDateBig.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDateBig.Location = new System.Drawing.Point(69, 36);
            this.lbDateBig.Name = "lbDateBig";
            this.lbDateBig.Size = new System.Drawing.Size(159, 37);
            this.lbDateBig.TabIndex = 10;
            this.lbDateBig.Text = "Thursday";
            // 
            // lbNgayThangBig
            // 
            this.lbNgayThangBig.AutoSize = true;
            this.lbNgayThangBig.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayThangBig.Location = new System.Drawing.Point(81, 105);
            this.lbNgayThangBig.Name = "lbNgayThangBig";
            this.lbNgayThangBig.Size = new System.Drawing.Size(185, 37);
            this.lbNgayThangBig.TabIndex = 9;
            this.lbNgayThangBig.Text = "10/12/2020";
            // 
            // labelGioBig
            // 
            this.labelGioBig.AutoSize = true;
            this.labelGioBig.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGioBig.Location = new System.Drawing.Point(96, 179);
            this.labelGioBig.Name = "labelGioBig";
            this.labelGioBig.Size = new System.Drawing.Size(147, 37);
            this.labelGioBig.TabIndex = 8;
            this.labelGioBig.Text = "14:31:00";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.txtthanhtien);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(15, 261);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(311, 64);
            this.panel4.TabIndex = 7;
            // 
            // txtthanhtien
            // 
            this.txtthanhtien.Location = new System.Drawing.Point(150, 16);
            this.txtthanhtien.Name = "txtthanhtien";
            this.txtthanhtien.Size = new System.Drawing.Size(137, 26);
            this.txtthanhtien.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tổng tiền hàng: ";
            // 
            // btnthanhtoan
            // 
            this.btnthanhtoan.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthanhtoan.Location = new System.Drawing.Point(32, 343);
            this.btnthanhtoan.Name = "btnthanhtoan";
            this.btnthanhtoan.Size = new System.Drawing.Size(284, 72);
            this.btnthanhtoan.TabIndex = 6;
            this.btnthanhtoan.Text = "Thanh toán";
            this.btnthanhtoan.UseVisualStyleBackColor = true;
            this.btnthanhtoan.Click += new System.EventHandler(this.btnthanhtoan_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btncapnhat);
            this.panel3.Controls.Add(this.btnxoa);
            this.panel3.Controls.Add(this.dataGridViewHoaDon);
            this.panel3.Controls.Add(this.dataGridViewSanPham);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(12, 217);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(996, 401);
            this.panel3.TabIndex = 4;
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(857, 353);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(123, 35);
            this.btnxoa.TabIndex = 12;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // dataGridViewHoaDon
            // 
            this.dataGridViewHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masp,
            this.tensp,
            this.sl,
            this.giasp,
            this.tong});
            this.dataGridViewHoaDon.Location = new System.Drawing.Point(374, 3);
            this.dataGridViewHoaDon.Name = "dataGridViewHoaDon";
            this.dataGridViewHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewHoaDon.Size = new System.Drawing.Size(617, 340);
            this.dataGridViewHoaDon.TabIndex = 1;
            // 
            // masp
            // 
            this.masp.DataPropertyName = "masap";
            this.masp.HeaderText = "Mã Sản Phẩm";
            this.masp.Name = "masp";
            this.masp.Width = 130;
            // 
            // tensp
            // 
            this.tensp.DataPropertyName = "tensp";
            this.tensp.HeaderText = "Tên";
            this.tensp.Name = "tensp";
            // 
            // sl
            // 
            this.sl.HeaderText = "Số Lượng";
            this.sl.Name = "sl";
            // 
            // giasp
            // 
            this.giasp.DataPropertyName = "giasp";
            this.giasp.HeaderText = "Giá Sản Phẩm";
            this.giasp.Name = "giasp";
            this.giasp.Width = 130;
            // 
            // tong
            // 
            this.tong.HeaderText = "Tổng Tiền";
            this.tong.Name = "tong";
            this.tong.Width = 150;
            // 
            // dataGridViewSanPham
            // 
            this.dataGridViewSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ma,
            this.name,
            this.Column1});
            this.dataGridViewSanPham.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewSanPham.Name = "dataGridViewSanPham";
            this.dataGridViewSanPham.Size = new System.Drawing.Size(365, 340);
            this.dataGridViewSanPham.TabIndex = 0;
            this.dataGridViewSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewHoaDon_CellContentClick);
            // 
            // ma
            // 
            this.ma.DataPropertyName = "masp";
            this.ma.HeaderText = "Mã";
            this.ma.Name = "ma";
            // 
            // name
            // 
            this.name.DataPropertyName = "tensp";
            this.name.HeaderText = "Tên sản phẩm";
            this.name.Name = "name";
            this.name.Width = 120;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "giatiensp";
            this.Column1.HeaderText = "Giá sản phẩm";
            this.Column1.Name = "Column1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnthemkh
            // 
            this.btnthemkh.Location = new System.Drawing.Point(865, 17);
            this.btnthemkh.Name = "btnthemkh";
            this.btnthemkh.Size = new System.Drawing.Size(115, 28);
            this.btnthemkh.TabIndex = 12;
            this.btnthemkh.Text = "Thêm mới";
            this.btnthemkh.UseVisualStyleBackColor = true;
            this.btnthemkh.Click += new System.EventHandler(this.btnthemkh_Click);
            // 
            // btncapnhat
            // 
            this.btncapnhat.Location = new System.Drawing.Point(704, 353);
            this.btncapnhat.Name = "btncapnhat";
            this.btncapnhat.Size = new System.Drawing.Size(123, 35);
            this.btncapnhat.TabIndex = 13;
            this.btncapnhat.Text = "Cập nhật";
            this.btncapnhat.UseVisualStyleBackColor = true;
            this.btncapnhat.Click += new System.EventHandler(this.btncapnhat_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(555, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(285, 58);
            this.label4.TabIndex = 5;
            this.label4.Text = "BÁN HÀNG";
            // 
            // frm_banhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 662);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frm_banhang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bán hàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_banhang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbotkkh;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtthanhtien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnthanhtoan;
        private System.Windows.Forms.DataGridView dataGridViewSanPham;
        private System.Windows.Forms.DataGridView dataGridViewHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn gia;
        private System.Windows.Forms.TextBox txttksp;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn masp;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensp;
        private System.Windows.Forms.DataGridViewTextBoxColumn sl;
        private System.Windows.Forms.DataGridViewTextBoxColumn giasp;
        private System.Windows.Forms.DataGridViewTextBoxColumn tong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtmahd;
        private System.Windows.Forms.Label lbDateBig;
        private System.Windows.Forms.Label lbNgayThangBig;
        private System.Windows.Forms.Label labelGioBig;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btndangxuat;
        private System.Windows.Forms.Button btnhuydonhang;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnthemkh;
        private System.Windows.Forms.Button btncapnhat;
        private System.Windows.Forms.Label label4;
    }
}