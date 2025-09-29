// Form1.Designer.cs
namespace apdung1
{
    partial class Form1
    {
        /// <summary>Required designer variable.</summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>Clean up any resources being used.</summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.grpNhap = new System.Windows.Forms.GroupBox();
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();

            this.grpTuyChon = new System.Windows.Forms.GroupBox();
            this.rdoUSCLN = new System.Windows.Forms.RadioButton();
            this.rdoBSCNN = new System.Windows.Forms.RadioButton();

            this.grpKetQua = new System.Windows.Forms.GroupBox();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();

            this.grpNhap.SuspendLayout();
            this.grpTuyChon.SuspendLayout();
            this.grpKetQua.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpNhap
            // 
            this.grpNhap.BackColor = System.Drawing.Color.FromArgb(204, 255, 204); // xanh nhạt
            this.grpNhap.Controls.Add(this.txtB);
            this.grpNhap.Controls.Add(this.txtA);
            this.grpNhap.Controls.Add(this.lblB);
            this.grpNhap.Controls.Add(this.lblA);
            this.grpNhap.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpNhap.Location = new System.Drawing.Point(12, 12);
            this.grpNhap.Name = "grpNhap";
            this.grpNhap.Size = new System.Drawing.Size(355, 110);
            this.grpNhap.TabIndex = 0;
            this.grpNhap.TabStop = false;
            this.grpNhap.Text = "Nhập dữ liệu:";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblA.Location = new System.Drawing.Point(14, 30);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(78, 15);
            this.lblA.TabIndex = 0;
            this.lblA.Text = "Số nguyên a:";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblB.Location = new System.Drawing.Point(14, 69);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(79, 15);
            this.lblB.TabIndex = 2;
            this.lblB.Text = "Số nguyên b:";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(115, 27);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(216, 23);
            this.txtA.TabIndex = 1;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(115, 66);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(216, 23);
            this.txtB.TabIndex = 3;
            // 
            // grpTuyChon
            // 
            this.grpTuyChon.BackColor = System.Drawing.Color.FromArgb(224, 224, 224); // xám nhạt
            this.grpTuyChon.Controls.Add(this.rdoBSCNN);
            this.grpTuyChon.Controls.Add(this.rdoUSCLN);
            this.grpTuyChon.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpTuyChon.Location = new System.Drawing.Point(373, 12);
            this.grpTuyChon.Name = "grpTuyChon";
            this.grpTuyChon.Size = new System.Drawing.Size(160, 110);
            this.grpTuyChon.TabIndex = 1;
            this.grpTuyChon.TabStop = false;
            this.grpTuyChon.Text = "Tùy chọn:";
            // 
            // rdoUSCLN
            // 
            this.rdoUSCLN.AutoSize = true;
            this.rdoUSCLN.Checked = true;
            this.rdoUSCLN.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdoUSCLN.Location = new System.Drawing.Point(20, 32);
            this.rdoUSCLN.Name = "rdoUSCLN";
            this.rdoUSCLN.Size = new System.Drawing.Size(65, 19);
            this.rdoUSCLN.TabIndex = 0;
            this.rdoUSCLN.TabStop = true;
            this.rdoUSCLN.Text = "USCLN";
            this.rdoUSCLN.UseVisualStyleBackColor = true;
            // 
            // rdoBSCNN
            // 
            this.rdoBSCNN.AutoSize = true;
            this.rdoBSCNN.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdoBSCNN.Location = new System.Drawing.Point(20, 68);
            this.rdoBSCNN.Name = "rdoBSCNN";
            this.rdoBSCNN.Size = new System.Drawing.Size(64, 19);
            this.rdoBSCNN.TabIndex = 1;
            this.rdoBSCNN.Text = "BSCNN";
            this.rdoBSCNN.UseVisualStyleBackColor = true;
            // 
            // grpKetQua
            // 
            this.grpKetQua.Controls.Add(this.txtKetQua);
            this.grpKetQua.Controls.Add(this.btnTim);
            this.grpKetQua.Controls.Add(this.btnThoat);
            this.grpKetQua.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpKetQua.Location = new System.Drawing.Point(12, 128);
            this.grpKetQua.Name = "grpKetQua";
            this.grpKetQua.Size = new System.Drawing.Size(521, 92);
            this.grpKetQua.TabIndex = 2;
            this.grpKetQua.TabStop = false;
            this.grpKetQua.Text = "Kết quả:";
            // 
            // txtKetQua
            // 
            this.txtKetQua.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtKetQua.Location = new System.Drawing.Point(21, 38);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.ReadOnly = true;
            this.txtKetQua.Size = new System.Drawing.Size(280, 23);
            this.txtKetQua.TabIndex = 0;
            this.txtKetQua.TabStop = false;
            // 
            // btnTim
            // 
            this.btnTim.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTim.Location = new System.Drawing.Point(323, 26);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(85, 35);
            this.btnTim.TabIndex = 1;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnThoat.Location = new System.Drawing.Point(420, 26);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(85, 35);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnTim;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 233);
            this.Controls.Add(this.grpKetQua);
            this.Controls.Add(this.grpTuyChon);
            this.Controls.Add(this.grpNhap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm USCLN và BSCNN của số nguyên a và b";

            this.grpNhap.ResumeLayout(false);
            this.grpNhap.PerformLayout();
            this.grpTuyChon.ResumeLayout(false);
            this.grpTuyChon.PerformLayout();
            this.grpKetQua.ResumeLayout(false);
            this.grpKetQua.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox grpNhap;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;

        private System.Windows.Forms.GroupBox grpTuyChon;
        private System.Windows.Forms.RadioButton rdoUSCLN;
        private System.Windows.Forms.RadioButton rdoBSCNN;

        private System.Windows.Forms.GroupBox grpKetQua;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnThoat;
    }
}
