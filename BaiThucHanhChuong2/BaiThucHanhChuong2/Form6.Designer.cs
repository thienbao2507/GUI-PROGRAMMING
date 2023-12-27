
namespace BaiThucHanhChuong2
{
    partial class Form6
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtChuoi = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.radThemDau = new System.Windows.Forms.RadioButton();
            this.radThemCuoi = new System.Windows.Forms.RadioButton();
            this.radXoaTrai = new System.Windows.Forms.RadioButton();
            this.radXoaPhai = new System.Windows.Forms.RadioButton();
            this.toRight = new System.Windows.Forms.Button();
            this.toLeft = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập chuỗi";
            // 
            // txtChuoi
            // 
            this.txtChuoi.Location = new System.Drawing.Point(169, 41);
            this.txtChuoi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtChuoi.Name = "txtChuoi";
            this.txtChuoi.Size = new System.Drawing.Size(76, 20);
            this.txtChuoi.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(90, 214);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox1.Size = new System.Drawing.Size(151, 82);
            this.listBox1.TabIndex = 2;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(362, 214);
            this.listBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(151, 82);
            this.listBox2.TabIndex = 3;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            this.listBox2.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.listBox2_ControlAdded);
            // 
            // btnThem
            // 
            this.btnThem.AutoSize = true;
            this.btnThem.Location = new System.Drawing.Point(253, 93);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(82, 23);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.AutoSize = true;
            this.btnXoa.Location = new System.Drawing.Point(253, 132);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(71, 23);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // radThemDau
            // 
            this.radThemDau.AutoSize = true;
            this.radThemDau.Location = new System.Drawing.Point(122, 93);
            this.radThemDau.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radThemDau.Name = "radThemDau";
            this.radThemDau.Size = new System.Drawing.Size(74, 17);
            this.radThemDau.TabIndex = 5;
            this.radThemDau.TabStop = true;
            this.radThemDau.Text = "Thêm đầu";
            this.radThemDau.UseVisualStyleBackColor = true;
            // 
            // radThemCuoi
            // 
            this.radThemCuoi.AutoSize = true;
            this.radThemCuoi.Location = new System.Drawing.Point(122, 132);
            this.radThemCuoi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radThemCuoi.Name = "radThemCuoi";
            this.radThemCuoi.Size = new System.Drawing.Size(75, 17);
            this.radThemCuoi.TabIndex = 6;
            this.radThemCuoi.TabStop = true;
            this.radThemCuoi.Text = "Thêm cuối";
            this.radThemCuoi.UseVisualStyleBackColor = true;
            // 
            // radXoaTrai
            // 
            this.radXoaTrai.AutoSize = true;
            this.radXoaTrai.Location = new System.Drawing.Point(402, 93);
            this.radXoaTrai.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radXoaTrai.Name = "radXoaTrai";
            this.radXoaTrai.Size = new System.Drawing.Size(61, 17);
            this.radXoaTrai.TabIndex = 5;
            this.radXoaTrai.TabStop = true;
            this.radXoaTrai.Text = "Xóa trái";
            this.radXoaTrai.UseVisualStyleBackColor = true;
            // 
            // radXoaPhai
            // 
            this.radXoaPhai.AutoSize = true;
            this.radXoaPhai.Location = new System.Drawing.Point(402, 132);
            this.radXoaPhai.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radXoaPhai.Name = "radXoaPhai";
            this.radXoaPhai.Size = new System.Drawing.Size(67, 17);
            this.radXoaPhai.TabIndex = 6;
            this.radXoaPhai.TabStop = true;
            this.radXoaPhai.Text = "Xóa phải";
            this.radXoaPhai.UseVisualStyleBackColor = true;
            // 
            // toRight
            // 
            this.toRight.AutoSize = true;
            this.toRight.Location = new System.Drawing.Point(274, 214);
            this.toRight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.toRight.Name = "toRight";
            this.toRight.Size = new System.Drawing.Size(56, 23);
            this.toRight.TabIndex = 7;
            this.toRight.Text = "to right";
            this.toRight.UseVisualStyleBackColor = true;
            this.toRight.Click += new System.EventHandler(this.toRight_Click);
            // 
            // toLeft
            // 
            this.toLeft.AutoSize = true;
            this.toLeft.Location = new System.Drawing.Point(274, 271);
            this.toLeft.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.toLeft.Name = "toLeft";
            this.toLeft.Size = new System.Drawing.Size(56, 23);
            this.toLeft.TabIndex = 8;
            this.toLeft.Text = "to left";
            this.toLeft.UseVisualStyleBackColor = true;
            this.toLeft.Click += new System.EventHandler(this.toLeft_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.toLeft);
            this.Controls.Add(this.toRight);
            this.Controls.Add(this.radXoaPhai);
            this.Controls.Add(this.radXoaTrai);
            this.Controls.Add(this.radThemCuoi);
            this.Controls.Add(this.radThemDau);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtChuoi);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtChuoi;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.RadioButton radThemDau;
        private System.Windows.Forms.RadioButton radThemCuoi;
        private System.Windows.Forms.RadioButton radXoaTrai;
        private System.Windows.Forms.RadioButton radXoaPhai;
        private System.Windows.Forms.Button toRight;
        private System.Windows.Forms.Button toLeft;
    }
}