namespace thuchanh2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblTen = new System.Windows.Forms.Label();
            this.txtTenK = new System.Windows.Forms.TextBox();
            this.errTen = new System.Windows.Forms.ErrorProvider(this.components);

            this.grpDichVu = new System.Windows.Forms.GroupBox();
            this.chkLayCao = new System.Windows.Forms.CheckBox();
            this.chkTayTrang = new System.Windows.Forms.CheckBox();
            this.chkHan = new System.Windows.Forms.CheckBox();
            this.chkBe = new System.Windows.Forms.CheckBox();
            this.chkBoc = new System.Windows.Forms.CheckBox();
            this.lblLayCao = new System.Windows.Forms.Label();
            this.lblTayTrang = new System.Windows.Forms.Label();
            this.lblHan = new System.Windows.Forms.Label();
            this.lblBe = new System.Windows.Forms.Label();
            this.lblBoc = new System.Windows.Forms.Label();
            this.nupHan = new System.Windows.Forms.NumericUpDown();
            this.nupBe = new System.Windows.Forms.NumericUpDown();
            this.nupBoc = new System.Windows.Forms.NumericUpDown();

            this.grpChucNang = new System.Windows.Forms.GroupBox();
            this.btnTinhTien = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtThanhTien = new System.Windows.Forms.TextBox();

            ((System.ComponentModel.ISupportInitialize)(this.errTen)).BeginInit();
            this.grpDichVu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupHan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupBe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupBoc)).BeginInit();
            this.grpChucNang.SuspendLayout();
            this.SuspendLayout();

            // lblHeader
            this.lblHeader.BackColor = System.Drawing.Color.LimeGreen;
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHeader.Location = new System.Drawing.Point(0, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(640, 55);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "PHÒNG KHÁM NHA KHOA HẢI ÂU";

            // lblTen
            this.lblTen.AutoSize = true;
            this.lblTen.Location = new System.Drawing.Point(12, 68);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(90, 15);
            this.lblTen.Text = "Tên khách hàng:";

            // txtTenK
            this.txtTenK.Location = new System.Drawing.Point(120, 64);
            this.txtTenK.Name = "txtTenK";
            this.txtTenK.Size = new System.Drawing.Size(300, 23);
            this.txtTenK.TabIndex = 1;

            // errTen
            this.errTen.ContainerControl = this;

            // grpDichVu
            this.grpDichVu.Text = "Dịch vụ tại phòng khám:";
            this.grpDichVu.Location = new System.Drawing.Point(15, 100);
            this.grpDichVu.Name = "grpDichVu";
            this.grpDichVu.Size = new System.Drawing.Size(610, 155);
            this.grpDichVu.TabIndex = 2;
            this.grpDichVu.TabStop = true;

            // Checkboxes
            this.chkLayCao.AutoSize = true;
            this.chkLayCao.Location = new System.Drawing.Point(20, 28);
            this.chkLayCao.Name = "chkLayCao";
            this.chkLayCao.Size = new System.Drawing.Size(90, 19);
            this.chkLayCao.Text = "Lấy cao răng";

            this.chkTayTrang.AutoSize = true;
            this.chkTayTrang.Location = new System.Drawing.Point(20, 55);
            this.chkTayTrang.Name = "chkTayTrang";
            this.chkTayTrang.Size = new System.Drawing.Size(97, 19);
            this.chkTayTrang.Text = "Tẩy trắng răng";

            this.chkHan.AutoSize = true;
            this.chkHan.Location = new System.Drawing.Point(20, 82);
            this.chkHan.Name = "chkHan";
            this.chkHan.Size = new System.Drawing.Size(73, 19);
            this.chkHan.Text = "Hàn răng";

            this.chkBe.AutoSize = true;
            this.chkBe.Location = new System.Drawing.Point(20, 109);
            this.chkBe.Name = "chkBe";
            this.chkBe.Size = new System.Drawing.Size(71, 19);
            this.chkBe.Text = "Bẻ răng";

            this.chkBoc.AutoSize = true;
            this.chkBoc.Location = new System.Drawing.Point(20, 136);
            this.chkBoc.Name = "chkBoc";
            this.chkBoc.Size = new System.Drawing.Size(75, 19);
            this.chkBoc.Text = "Bọc răng";

            // Labels đơn giá (bên phải)
            this.lblLayCao.AutoSize = true;
            this.lblLayCao.Location = new System.Drawing.Point(180, 29);
            this.lblLayCao.Text = "50.000đ/2 hàm";

            this.lblTayTrang.AutoSize = true;
            this.lblTayTrang.Location = new System.Drawing.Point(180, 56);
            this.lblTayTrang.Text = "100.000đ/2 hàm";

            this.lblHan.AutoSize = true;
            this.lblHan.Location = new System.Drawing.Point(180, 83);
            this.lblHan.Text = "100.000đ/1 răng";

            this.lblBe.AutoSize = true;
            this.lblBe.Location = new System.Drawing.Point(180, 110);
            this.lblBe.Text = "10.000đ/1 răng";

            this.lblBoc.AutoSize = true;
            this.lblBoc.Location = new System.Drawing.Point(180, 137);
            this.lblBoc.Text = "1.000.000đ/1 răng";

            // NumericUpDowns (bên phải mỗi dịch vụ tính theo răng)
            this.nupHan.Location = new System.Drawing.Point(300, 81);
            this.nupHan.Minimum = 1;
            this.nupHan.Maximum = 20;
            this.nupHan.Value = 1;
            this.nupHan.Size = new System.Drawing.Size(50, 23);
            this.nupHan.Enabled = false;

            this.nupBe.Location = new System.Drawing.Point(300, 108);
            this.nupBe.Minimum = 1;
            this.nupBe.Maximum = 20;
            this.nupBe.Value = 1;
            this.nupBe.Size = new System.Drawing.Size(50, 23);
            this.nupBe.Enabled = false;

            this.nupBoc.Location = new System.Drawing.Point(300, 135);
            this.nupBoc.Minimum = 1;
            this.nupBoc.Maximum = 20;
            this.nupBoc.Value = 1;
            this.nupBoc.Size = new System.Drawing.Size(50, 23);
            this.nupBoc.Enabled = false;

            // add controls vào grpDichVu
            this.grpDichVu.Controls.Add(this.chkLayCao);
            this.grpDichVu.Controls.Add(this.chkTayTrang);
            this.grpDichVu.Controls.Add(this.chkHan);
            this.grpDichVu.Controls.Add(this.chkBe);
            this.grpDichVu.Controls.Add(this.chkBoc);
            this.grpDichVu.Controls.Add(this.lblLayCao);
            this.grpDichVu.Controls.Add(this.lblTayTrang);
            this.grpDichVu.Controls.Add(this.lblHan);
            this.grpDichVu.Controls.Add(this.lblBe);
            this.grpDichVu.Controls.Add(this.lblBoc);
            this.grpDichVu.Controls.Add(this.nupHan);
            this.grpDichVu.Controls.Add(this.nupBe);
            this.grpDichVu.Controls.Add(this.nupBoc);

            // grpChucNang
            this.grpChucNang.Text = "Chức năng:";
            this.grpChucNang.Location = new System.Drawing.Point(15, 265);
            this.grpChucNang.Name = "grpChucNang";
            this.grpChucNang.Size = new System.Drawing.Size(610, 80);

            // btnTinhTien
            this.btnTinhTien.Location = new System.Drawing.Point(30, 30);
            this.btnTinhTien.Name = "btnTinhTien";
            this.btnTinhTien.Size = new System.Drawing.Size(100, 30);
            this.btnTinhTien.Text = "Tính tiền";

            // txtThanhTien
            this.txtThanhTien.Location = new System.Drawing.Point(180, 34);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.ReadOnly = true;
            this.txtThanhTien.Size = new System.Drawing.Size(220, 23);
            this.txtThanhTien.TabStop = false;
            this.txtThanhTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

            // btnThoat
            this.btnThoat.Location = new System.Drawing.Point(440, 30);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 30);
            this.btnThoat.Text = "Thoát";

            this.grpChucNang.Controls.Add(this.btnTinhTien);
            this.grpChucNang.Controls.Add(this.txtThanhTien);
            this.grpChucNang.Controls.Add(this.btnThoat);

            // Form1
            this.AcceptButton = this.btnTinhTien;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 360);
            this.Controls.Add(this.grpChucNang);
            this.Controls.Add(this.grpDichVu);
            this.Controls.Add(this.txtTenK);
            this.Controls.Add(this.lblTen);
            this.Controls.Add(this.lblHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Name = "Form1";
            this.Text = "Form1";

            ((System.ComponentModel.ISupportInitialize)(this.errTen)).EndInit();
            this.grpDichVu.ResumeLayout(false);
            this.grpDichVu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupHan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupBe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupBoc)).EndInit();
            this.grpChucNang.ResumeLayout(false);
            this.grpChucNang.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.TextBox txtTenK;
        private System.Windows.Forms.ErrorProvider errTen;

        private System.Windows.Forms.GroupBox grpDichVu;
        private System.Windows.Forms.CheckBox chkLayCao;
        private System.Windows.Forms.CheckBox chkTayTrang;
        private System.Windows.Forms.CheckBox chkHan;
        private System.Windows.Forms.CheckBox chkBe;
        private System.Windows.Forms.CheckBox chkBoc;
        private System.Windows.Forms.Label lblLayCao;
        private System.Windows.Forms.Label lblTayTrang;
        private System.Windows.Forms.Label lblHan;
        private System.Windows.Forms.Label lblBe;
        private System.Windows.Forms.Label lblBoc;
        private System.Windows.Forms.NumericUpDown nupHan;
        private System.Windows.Forms.NumericUpDown nupBe;
        private System.Windows.Forms.NumericUpDown nupBoc;

        private System.Windows.Forms.GroupBox grpChucNang;
        private System.Windows.Forms.Button btnTinhTien;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtThanhTien;
    }
}
