namespace thuchanh3
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();

            this.lblNhap = new System.Windows.Forms.Label();
            this.txtSo = new System.Windows.Forms.TextBox();
            this.btnNhapSo = new System.Windows.Forms.Button();

            this.lsbDaySo = new System.Windows.Forms.ListBox();
            this.grpChucNang = new System.Windows.Forms.GroupBox();
            this.btnTang2 = new System.Windows.Forms.Button();
            this.btnChonChanDau = new System.Windows.Forms.Button();
            this.btnChonLeCuoi = new System.Windows.Forms.Button();
            this.btnXoaChon = new System.Windows.Forms.Button();
            this.btnXoaDau = new System.Windows.Forms.Button();
            this.btnXoaCuoi = new System.Windows.Forms.Button();

            this.btnKetThuc = new System.Windows.Forms.Button();
            this.btnXoaDaySo = new System.Windows.Forms.Button();

            this.pnlHeader.SuspendLayout();
            this.grpChucNang.SuspendLayout();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(0, 170, 170);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(480, 60);
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.Text = "Ứng dụng xử lý dãy số";
            // 
            // Nhập số
            // 
            this.lblNhap.AutoSize = true;
            this.lblNhap.Location = new System.Drawing.Point(12, 72);
            this.lblNhap.Name = "lblNhap";
            this.lblNhap.Size = new System.Drawing.Size(74, 15);
            this.lblNhap.Text = "Nhập số nguyên:";
            // 
            this.txtSo.Location = new System.Drawing.Point(120, 69);
            this.txtSo.Name = "txtSo";
            this.txtSo.Size = new System.Drawing.Size(150, 23);
            // 
            this.btnNhapSo.Location = new System.Drawing.Point(290, 67);
            this.btnNhapSo.Name = "btnNhapSo";
            this.btnNhapSo.Size = new System.Drawing.Size(85, 27);
            this.btnNhapSo.Text = "Nhập số";
            // 
            // ListBox
            // 
            this.lsbDaySo.Font = new System.Drawing.Font("Consolas", 10F);
            this.lsbDaySo.ItemHeight = 15;
            this.lsbDaySo.Location = new System.Drawing.Point(15, 110);
            this.lsbDaySo.Name = "lsbDaySo";
            this.lsbDaySo.Size = new System.Drawing.Size(220, 214);
            // 
            // Group chức năng
            // 
            this.grpChucNang.Text = "Chức năng:";
            this.grpChucNang.Location = new System.Drawing.Point(245, 110);
            this.grpChucNang.Name = "grpChucNang";
            this.grpChucNang.Size = new System.Drawing.Size(220, 214);
            this.grpChucNang.Controls.Add(this.btnTang2);
            this.grpChucNang.Controls.Add(this.btnChonChanDau);
            this.grpChucNang.Controls.Add(this.btnChonLeCuoi);
            this.grpChucNang.Controls.Add(this.btnXoaChon);
            this.grpChucNang.Controls.Add(this.btnXoaDau);
            this.grpChucNang.Controls.Add(this.btnXoaCuoi);
            // 
            int w = 180, h = 30, x = 20, y = 25, gap = 8;
            // btnTang2
            this.btnTang2.Location = new System.Drawing.Point(x, y);
            this.btnTang2.Name = "btnTang2";
            this.btnTang2.Size = new System.Drawing.Size(w, h);
            this.btnTang2.Text = "Tăng mỗi phần tử lên 2";
            // btnChonChanDau
            this.btnChonChanDau.Location = new System.Drawing.Point(x, y += (h + gap));
            this.btnChonChanDau.Name = "btnChonChanDau";
            this.btnChonChanDau.Size = new System.Drawing.Size(w, h);
            this.btnChonChanDau.Text = "Chọn số chẵn đầu";
            // btnChonLeCuoi
            this.btnChonLeCuoi.Location = new System.Drawing.Point(x, y += (h + gap));
            this.btnChonLeCuoi.Name = "btnChonLeCuoi";
            this.btnChonLeCuoi.Size = new System.Drawing.Size(w, h);
            this.btnChonLeCuoi.Text = "Chọn số lẻ cuối";
            // btnXoaChon
            this.btnXoaChon.Location = new System.Drawing.Point(x, y += (h + gap));
            this.btnXoaChon.Name = "btnXoaChon";
            this.btnXoaChon.Size = new System.Drawing.Size(w, h);
            this.btnXoaChon.Text = "Xóa phần tử đang chọn";
            // btnXoaDau
            this.btnXoaDau.Location = new System.Drawing.Point(x, y += (h + gap));
            this.btnXoaDau.Name = "btnXoaDau";
            this.btnXoaDau.Size = new System.Drawing.Size(w, h);
            this.btnXoaDau.Text = "Xóa phần tử đầu";
            // btnXoaCuoi
            this.btnXoaCuoi.Location = new System.Drawing.Point(x, y += (h + gap));
            this.btnXoaCuoi.Name = "btnXoaCuoi";
            this.btnXoaCuoi.Size = new System.Drawing.Size(w, h);
            this.btnXoaCuoi.Text = "Xóa phần tử cuối";
            // 
            // Nút dưới cùng
            // 
            this.btnKetThuc.BackColor = System.Drawing.Color.IndianRed;
            this.btnKetThuc.ForeColor = System.Drawing.Color.White;
            this.btnKetThuc.Location = new System.Drawing.Point(15, 335);
            this.btnKetThuc.Name = "btnKetThuc";
            this.btnKetThuc.Size = new System.Drawing.Size(220, 32);
            this.btnKetThuc.Text = "Kết thúc ứng dụng";

            this.btnXoaDaySo.BackColor = System.Drawing.Color.DimGray;
            this.btnXoaDaySo.ForeColor = System.Drawing.Color.White;
            this.btnXoaDaySo.Location = new System.Drawing.Point(245, 335);
            this.btnXoaDaySo.Name = "btnXoaDaySo";
            this.btnXoaDaySo.Size = new System.Drawing.Size(220, 32);
            this.btnXoaDaySo.Text = "Xóa dãy số";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnNhapSo;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 380);
            this.Controls.Add(this.btnXoaDaySo);
            this.Controls.Add(this.btnKetThuc);
            this.Controls.Add(this.grpChucNang);
            this.Controls.Add(this.lsbDaySo);
            this.Controls.Add(this.btnNhapSo);
            this.Controls.Add(this.txtSo);
            this.Controls.Add(this.lblNhap);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Name = "Form1";
            this.Text = "Form1";

            this.pnlHeader.ResumeLayout(false);
            this.grpChucNang.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblNhap;
        private System.Windows.Forms.TextBox txtSo;
        private System.Windows.Forms.Button btnNhapSo;
        private System.Windows.Forms.ListBox lsbDaySo;
        private System.Windows.Forms.GroupBox grpChucNang;
        private System.Windows.Forms.Button btnTang2;
        private System.Windows.Forms.Button btnChonChanDau;
        private System.Windows.Forms.Button btnChonLeCuoi;
        private System.Windows.Forms.Button btnXoaChon;
        private System.Windows.Forms.Button btnXoaDau;
        private System.Windows.Forms.Button btnXoaCuoi;
        private System.Windows.Forms.Button btnKetThuc;
        private System.Windows.Forms.Button btnXoaDaySo;
    }
}
