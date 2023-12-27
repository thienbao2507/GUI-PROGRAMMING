
namespace BaiThucHanhChuong2
{
    partial class Form2
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
            this.txtKetQua = new System.Windows.Forms.Label();
            this.lbKetQua = new System.Windows.Forms.Label();
            this.btnDong = new System.Windows.Forms.Button();
            this.txtSo2 = new System.Windows.Forms.TextBox();
            this.txtSo1 = new System.Windows.Forms.TextBox();
            this.lbSo2 = new System.Windows.Forms.Label();
            this.lbSo1 = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.btnTinh = new System.Windows.Forms.Button();
            this.calculateBox = new System.Windows.Forms.GroupBox();
            this.radChiaDu = new System.Windows.Forms.RadioButton();
            this.radChia = new System.Windows.Forms.RadioButton();
            this.radNhan = new System.Windows.Forms.RadioButton();
            this.radTru = new System.Windows.Forms.RadioButton();
            this.radCong = new System.Windows.Forms.RadioButton();
            this.calculateBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtKetQua
            // 
            this.txtKetQua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKetQua.Location = new System.Drawing.Point(207, 359);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(323, 65);
            this.txtKetQua.TabIndex = 14;
            // 
            // lbKetQua
            // 
            this.lbKetQua.AutoSize = true;
            this.lbKetQua.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKetQua.Location = new System.Drawing.Point(80, 372);
            this.lbKetQua.Name = "lbKetQua";
            this.lbKetQua.Size = new System.Drawing.Size(121, 32);
            this.lbKetQua.TabIndex = 15;
            this.lbKetQua.Text = "Kết quả:";
            // 
            // btnDong
            // 
            this.btnDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.Location = new System.Drawing.Point(670, 360);
            this.btnDong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(95, 58);
            this.btnDong.TabIndex = 18;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            // 
            // txtSo2
            // 
            this.txtSo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSo2.Location = new System.Drawing.Point(550, 128);
            this.txtSo2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSo2.Name = "txtSo2";
            this.txtSo2.Size = new System.Drawing.Size(100, 30);
            this.txtSo2.TabIndex = 9;
            // 
            // txtSo1
            // 
            this.txtSo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSo1.Location = new System.Drawing.Point(232, 128);
            this.txtSo1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSo1.Name = "txtSo1";
            this.txtSo1.Size = new System.Drawing.Size(100, 30);
            this.txtSo1.TabIndex = 7;
            // 
            // lbSo2
            // 
            this.lbSo2.AutoSize = true;
            this.lbSo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSo2.Location = new System.Drawing.Point(453, 130);
            this.lbSo2.Name = "lbSo2";
            this.lbSo2.Size = new System.Drawing.Size(91, 25);
            this.lbSo2.TabIndex = 10;
            this.lbSo2.Text = "Số thứ 2:";
            // 
            // lbSo1
            // 
            this.lbSo1.AutoSize = true;
            this.lbSo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSo1.Location = new System.Drawing.Point(134, 130);
            this.lbSo1.Name = "lbSo1";
            this.lbSo1.Size = new System.Drawing.Size(91, 25);
            this.lbSo1.TabIndex = 11;
            this.lbSo1.Text = "Số thứ 1:";
            // 
            // title
            // 
            this.title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(-9, -13);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(819, 113);
            this.title.TabIndex = 8;
            this.title.Text = "Calculator";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTinh
            // 
            this.btnTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinh.Location = new System.Drawing.Point(569, 360);
            this.btnTinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(95, 58);
            this.btnTinh.TabIndex = 18;
            this.btnTinh.Text = "Tính";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // calculateBox
            // 
            this.calculateBox.Controls.Add(this.radChiaDu);
            this.calculateBox.Controls.Add(this.radChia);
            this.calculateBox.Controls.Add(this.radNhan);
            this.calculateBox.Controls.Add(this.radTru);
            this.calculateBox.Controls.Add(this.radCong);
            this.calculateBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateBox.Location = new System.Drawing.Point(124, 184);
            this.calculateBox.Name = "calculateBox";
            this.calculateBox.Size = new System.Drawing.Size(552, 147);
            this.calculateBox.TabIndex = 19;
            this.calculateBox.TabStop = false;
            this.calculateBox.Text = "Chọn phép toán";
            // 
            // radChiaDu
            // 
            this.radChiaDu.AutoSize = true;
            this.radChiaDu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radChiaDu.Location = new System.Drawing.Point(464, 66);
            this.radChiaDu.Name = "radChiaDu";
            this.radChiaDu.Size = new System.Drawing.Size(57, 33);
            this.radChiaDu.TabIndex = 0;
            this.radChiaDu.Text = "%";
            this.radChiaDu.UseVisualStyleBackColor = true;
            // 
            // radChia
            // 
            this.radChia.AutoSize = true;
            this.radChia.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radChia.Location = new System.Drawing.Point(360, 66);
            this.radChia.Name = "radChia";
            this.radChia.Size = new System.Drawing.Size(42, 33);
            this.radChia.TabIndex = 0;
            this.radChia.Text = "/";
            this.radChia.UseVisualStyleBackColor = true;
            // 
            // radNhan
            // 
            this.radNhan.AutoSize = true;
            this.radNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radNhan.Location = new System.Drawing.Point(252, 66);
            this.radNhan.Name = "radNhan";
            this.radNhan.Size = new System.Drawing.Size(46, 33);
            this.radNhan.TabIndex = 0;
            this.radNhan.Text = "x";
            this.radNhan.UseVisualStyleBackColor = true;
            // 
            // radTru
            // 
            this.radTru.AutoSize = true;
            this.radTru.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTru.Location = new System.Drawing.Point(147, 66);
            this.radTru.Name = "radTru";
            this.radTru.Size = new System.Drawing.Size(43, 33);
            this.radTru.TabIndex = 0;
            this.radTru.Text = "-";
            this.radTru.UseVisualStyleBackColor = true;
            // 
            // radCong
            // 
            this.radCong.AutoSize = true;
            this.radCong.Checked = true;
            this.radCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radCong.Location = new System.Drawing.Point(37, 66);
            this.radCong.Name = "radCong";
            this.radCong.Size = new System.Drawing.Size(49, 33);
            this.radCong.TabIndex = 0;
            this.radCong.TabStop = true;
            this.radCong.Text = "+";
            this.radCong.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.calculateBox);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.lbKetQua);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.txtSo2);
            this.Controls.Add(this.txtSo1);
            this.Controls.Add(this.lbSo2);
            this.Controls.Add(this.lbSo1);
            this.Controls.Add(this.title);
            this.Name = "Form2";
            this.Text = "Form2";
            this.calculateBox.ResumeLayout(false);
            this.calculateBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtKetQua;
        private System.Windows.Forms.Label lbKetQua;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.TextBox txtSo2;
        private System.Windows.Forms.TextBox txtSo1;
        private System.Windows.Forms.Label lbSo2;
        private System.Windows.Forms.Label lbSo1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.GroupBox calculateBox;
        private System.Windows.Forms.RadioButton radChiaDu;
        private System.Windows.Forms.RadioButton radChia;
        private System.Windows.Forms.RadioButton radNhan;
        private System.Windows.Forms.RadioButton radTru;
        private System.Windows.Forms.RadioButton radCong;
    }
}