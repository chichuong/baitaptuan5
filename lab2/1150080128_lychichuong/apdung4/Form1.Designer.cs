namespace apdung4
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.lblNguon = new System.Windows.Forms.Label();
            this.lblChon = new System.Windows.Forms.Label();
            this.lsbNguon = new System.Windows.Forms.ListBox();
            this.lsbChon = new System.Windows.Forms.ListBox();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnRightAll = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnLeftAll = new System.Windows.Forms.Button();

            this.SuspendLayout();
            // 
            // labels
            // 
            this.lblNguon.AutoSize = true;
            this.lblNguon.Location = new System.Drawing.Point(14, 9);
            this.lblNguon.Name = "lblNguon";
            this.lblNguon.Size = new System.Drawing.Size(148, 15);
            this.lblNguon.Text = "Danh sách các mặt hàng";

            this.lblChon.AutoSize = true;
            this.lblChon.Location = new System.Drawing.Point(332, 9);
            this.lblChon.Name = "lblChon";
            this.lblChon.Size = new System.Drawing.Size(133, 15);
            this.lblChon.Text = "Các mặt hàng lựa chọn";
            // 
            // listboxes
            // 
            this.lsbNguon.FormattingEnabled = true;
            this.lsbNguon.ItemHeight = 15;
            this.lsbNguon.Location = new System.Drawing.Point(17, 29);
            this.lsbNguon.Name = "lsbNguon";
            this.lsbNguon.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lsbNguon.Size = new System.Drawing.Size(200, 214);

            this.lsbChon.FormattingEnabled = true;
            this.lsbChon.ItemHeight = 15;
            this.lsbChon.Location = new System.Drawing.Point(335, 29);
            this.lsbChon.Name = "lsbChon";
            this.lsbChon.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lsbChon.Size = new System.Drawing.Size(200, 214);
            // 
            // buttons
            // 
            this.btnRight.Location = new System.Drawing.Point(247, 60);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(60, 28);
            this.btnRight.Text = ">";
            this.btnRight.UseVisualStyleBackColor = true;

            this.btnRightAll.Location = new System.Drawing.Point(247, 94);
            this.btnRightAll.Name = "btnRightAll";
            this.btnRightAll.Size = new System.Drawing.Size(60, 28);
            this.btnRightAll.Text = ">>";
            this.btnRightAll.UseVisualStyleBackColor = true;

            this.btnLeft.Location = new System.Drawing.Point(247, 128);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(60, 28);
            this.btnLeft.Text = "<";
            this.btnLeft.UseVisualStyleBackColor = true;

            this.btnLeftAll.Location = new System.Drawing.Point(247, 162);
            this.btnLeftAll.Name = "btnLeftAll";
            this.btnLeftAll.Size = new System.Drawing.Size(60, 28);
            this.btnLeftAll.Text = "<<";
            this.btnLeftAll.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnRight;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 261);
            this.Controls.Add(this.btnLeftAll);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnRightAll);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.lsbChon);
            this.Controls.Add(this.lsbNguon);
            this.Controls.Add(this.lblChon);
            this.Controls.Add(this.lblNguon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bài tập 7";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion

        private System.Windows.Forms.Label lblNguon;
        private System.Windows.Forms.Label lblChon;
        private System.Windows.Forms.ListBox lsbNguon;
        private System.Windows.Forms.ListBox lsbChon;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnRightAll;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnLeftAll;
    }
}
