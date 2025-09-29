namespace apdung2
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
            this.grpPassword = new System.Windows.Forms.GroupBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();

            this.grpKeyboard = new System.Windows.Forms.GroupBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnRing = new System.Windows.Forms.Button();

            this.grpLog = new System.Windows.Forms.GroupBox();
            this.dgvLog = new System.Windows.Forms.DataGridView();
            this.colTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colResult = new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.grpPassword.SuspendLayout();
            this.grpKeyboard.SuspendLayout();
            this.grpLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLog)).BeginInit();
            this.SuspendLayout();
            // 
            // grpPassword
            // 
            this.grpPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
            this.grpPassword.BackColor = System.Drawing.Color.Gainsboro;
            this.grpPassword.Controls.Add(this.txtPassword);
            this.grpPassword.Controls.Add(this.lblPassword);
            this.grpPassword.Location = new System.Drawing.Point(12, 7);
            this.grpPassword.Name = "grpPassword";
            this.grpPassword.Size = new System.Drawing.Size(560, 60);
            this.grpPassword.TabIndex = 0;
            this.grpPassword.TabStop = false;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPassword.Location = new System.Drawing.Point(10, 23);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(71, 19);
            this.lblPassword.TabIndex = 0;
            this.lblPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPassword.Location = new System.Drawing.Point(95, 20);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(230, 25);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // grpKeyboard
            // 
            this.grpKeyboard.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grpKeyboard.Controls.Add(this.btn9);
            this.grpKeyboard.Controls.Add(this.btn8);
            this.grpKeyboard.Controls.Add(this.btn7);
            this.grpKeyboard.Controls.Add(this.btn6);
            this.grpKeyboard.Controls.Add(this.btn5);
            this.grpKeyboard.Controls.Add(this.btn4);
            this.grpKeyboard.Controls.Add(this.btn3);
            this.grpKeyboard.Controls.Add(this.btn2);
            this.grpKeyboard.Controls.Add(this.btn1);
            this.grpKeyboard.Controls.Add(this.btnRing);
            this.grpKeyboard.Controls.Add(this.btnEnter);
            this.grpKeyboard.Controls.Add(this.btnClear);
            this.grpKeyboard.Location = new System.Drawing.Point(12, 73);
            this.grpKeyboard.Name = "grpKeyboard";
            this.grpKeyboard.Size = new System.Drawing.Size(560, 150);
            this.grpKeyboard.TabIndex = 1;
            this.grpKeyboard.TabStop = false;
            this.grpKeyboard.Text = "Keyboard:";
            // 
            // number buttons (1..9)
            //
            int cellW = 60, cellH = 40, spacing = 10, startX = 20, startY = 25;
            // btn1
            this.btn1.Location = new System.Drawing.Point(startX, startY);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(cellW, cellH);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            // btn2
            this.btn2.Location = new System.Drawing.Point(startX + (cellW + spacing), startY);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(cellW, cellH);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            // btn3
            this.btn3.Location = new System.Drawing.Point(startX + 2 * (cellW + spacing), startY);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(cellW, cellH);
            this.btn3.TabIndex = 2;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            // btn4
            this.btn4.Location = new System.Drawing.Point(startX, startY + (cellH + spacing));
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(cellW, cellH);
            this.btn4.TabIndex = 3;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            // btn5
            this.btn5.Location = new System.Drawing.Point(startX + (cellW + spacing), startY + (cellH + spacing));
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(cellW, cellH);
            this.btn5.TabIndex = 4;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            // btn6
            this.btn6.Location = new System.Drawing.Point(startX + 2 * (cellW + spacing), startY + (cellH + spacing));
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(cellW, cellH);
            this.btn6.TabIndex = 5;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            // btn7
            this.btn7.Location = new System.Drawing.Point(startX, startY + 2 * (cellH + spacing));
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(cellW, cellH);
            this.btn7.TabIndex = 6;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            // btn8
            this.btn8.Location = new System.Drawing.Point(startX + (cellW + spacing), startY + 2 * (cellH + spacing));
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(cellW, cellH);
            this.btn8.TabIndex = 7;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            // btn9
            this.btn9.Location = new System.Drawing.Point(startX + 2 * (cellW + spacing), startY + 2 * (cellH + spacing));
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(cellW, cellH);
            this.btn9.TabIndex = 8;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Yellow;
            this.btnClear.Location = new System.Drawing.Point(360, 25);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 35);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.Color.Lime;
            this.btnEnter.Location = new System.Drawing.Point(360, 66);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(120, 35);
            this.btnEnter.TabIndex = 10;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = false;
            // 
            // btnRing
            // 
            this.btnRing.BackColor = System.Drawing.Color.Red;
            this.btnRing.ForeColor = System.Drawing.Color.White;
            this.btnRing.Location = new System.Drawing.Point(360, 107);
            this.btnRing.Name = "btnRing";
            this.btnRing.Size = new System.Drawing.Size(120, 35);
            this.btnRing.TabIndex = 11;
            this.btnRing.Text = "RING";
            this.btnRing.UseVisualStyleBackColor = false;
            // 
            // grpLog
            // 
            this.grpLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                   | System.Windows.Forms.AnchorStyles.Left)
                                   | System.Windows.Forms.AnchorStyles.Right)));
            this.grpLog.Controls.Add(this.dgvLog);
            this.grpLog.Location = new System.Drawing.Point(12, 229);
            this.grpLog.Name = "grpLog";
            this.grpLog.Size = new System.Drawing.Size(560, 170);
            this.grpLog.TabIndex = 2;
            this.grpLog.TabStop = false;
            this.grpLog.Text = "Login Log:";
            // 
            // dgvLog
            // 
            this.dgvLog.AllowUserToAddRows = false;
            this.dgvLog.AllowUserToDeleteRows = false;
            this.dgvLog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTime, this.colGroup, this.colResult});
            this.dgvLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLog.Location = new System.Drawing.Point(3, 19);
            this.dgvLog.Name = "dgvLog";
            this.dgvLog.ReadOnly = true;
            this.dgvLog.RowHeadersVisible = false;
            this.dgvLog.RowTemplate.Height = 25;
            this.dgvLog.Size = new System.Drawing.Size(554, 148);
            this.dgvLog.TabIndex = 0;
            // 
            // columns
            // 
            this.colTime.HeaderText = "Ngày giờ";
            this.colTime.Name = "colTime";
            this.colTime.ReadOnly = true;

            this.colGroup.HeaderText = "Nhóm";
            this.colGroup.Name = "colGroup";
            this.colGroup.ReadOnly = true;

            this.colResult.HeaderText = "Kết quả";
            this.colResult.Name = "colResult";
            this.colResult.ReadOnly = true;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.grpLog);
            this.Controls.Add(this.grpKeyboard);
            this.Controls.Add(this.grpPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";

            this.grpPassword.ResumeLayout(false);
            this.grpPassword.PerformLayout();
            this.grpKeyboard.ResumeLayout(false);
            this.grpLog.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLog)).EndInit();
            this.ResumeLayout(false);
        }
        #endregion

        private System.Windows.Forms.GroupBox grpPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;

        private System.Windows.Forms.GroupBox grpKeyboard;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnRing;

        private System.Windows.Forms.GroupBox grpLog;
        private System.Windows.Forms.DataGridView dgvLog;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn colResult;
    }
}
