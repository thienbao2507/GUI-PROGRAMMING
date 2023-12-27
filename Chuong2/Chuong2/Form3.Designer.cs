
namespace Chuong2
{
    partial class Form3
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.rLeftDel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rAddTail = new System.Windows.Forms.RadioButton();
            this.addHead = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rRightDel = new System.Windows.Forms.RadioButton();
            this.rLeftList = new System.Windows.Forms.RadioButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btLeftToRight = new System.Windows.Forms.Button();
            this.btRightToLeft = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(57, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập chuỗi";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(128, 41);
            this.txtInput.Margin = new System.Windows.Forms.Padding(2);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(178, 20);
            this.txtInput.TabIndex = 1;
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(354, 43);
            this.btAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(56, 19);
            this.btAdd.TabIndex = 2;
            this.btAdd.Text = "Thêm";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // rLeftDel
            // 
            this.rLeftDel.Location = new System.Drawing.Point(447, 43);
            this.rLeftDel.Margin = new System.Windows.Forms.Padding(2);
            this.rLeftDel.Name = "rLeftDel";
            this.rLeftDel.Size = new System.Drawing.Size(56, 19);
            this.rLeftDel.TabIndex = 2;
            this.rLeftDel.Text = "Xóa";
            this.rLeftDel.UseVisualStyleBackColor = true;
            this.rLeftDel.Click += new System.EventHandler(this.btDel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rAddTail);
            this.groupBox1.Controls.Add(this.addHead);
            this.groupBox1.Location = new System.Drawing.Point(40, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 113);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tùy chọn";
            // 
            // rAddTail
            // 
            this.rAddTail.AutoSize = true;
            this.rAddTail.Location = new System.Drawing.Point(203, 41);
            this.rAddTail.Name = "rAddTail";
            this.rAddTail.Size = new System.Drawing.Size(76, 17);
            this.rAddTail.TabIndex = 0;
            this.rAddTail.Text = "Thêm Cuối";
            this.rAddTail.UseVisualStyleBackColor = true;
            // 
            // addHead
            // 
            this.addHead.AutoSize = true;
            this.addHead.Checked = true;
            this.addHead.Location = new System.Drawing.Point(24, 41);
            this.addHead.Name = "addHead";
            this.addHead.Size = new System.Drawing.Size(74, 17);
            this.addHead.TabIndex = 0;
            this.addHead.TabStop = true;
            this.addHead.Text = "Thêm đầu";
            this.addHead.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rRightDel);
            this.groupBox2.Controls.Add(this.rLeftList);
            this.groupBox2.Location = new System.Drawing.Point(392, 97);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(336, 113);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tùy chọn";
            // 
            // rRightDel
            // 
            this.rRightDel.AutoSize = true;
            this.rRightDel.Location = new System.Drawing.Point(191, 41);
            this.rRightDel.Name = "rRightDel";
            this.rRightDel.Size = new System.Drawing.Size(69, 17);
            this.rRightDel.TabIndex = 0;
            this.rRightDel.Text = "List Right";
            this.rRightDel.UseVisualStyleBackColor = true;
            // 
            // rLeftList
            // 
            this.rLeftList.AutoSize = true;
            this.rLeftList.Checked = true;
            this.rLeftList.Location = new System.Drawing.Point(52, 41);
            this.rLeftList.Name = "rLeftList";
            this.rLeftList.Size = new System.Drawing.Size(59, 17);
            this.rLeftList.TabIndex = 0;
            this.rLeftList.TabStop = true;
            this.rLeftList.Text = "ListLeft";
            this.rLeftList.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(59, 216);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(189, 186);
            this.listBox1.TabIndex = 4;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(521, 216);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(189, 186);
            this.listBox2.TabIndex = 4;
            // 
            // btLeftToRight
            // 
            this.btLeftToRight.Location = new System.Drawing.Point(298, 243);
            this.btLeftToRight.Name = "btLeftToRight";
            this.btLeftToRight.Size = new System.Drawing.Size(173, 46);
            this.btLeftToRight.TabIndex = 5;
            this.btLeftToRight.Text = "==>";
            this.btLeftToRight.UseVisualStyleBackColor = true;
            this.btLeftToRight.Click += new System.EventHandler(this.btLeftToRight_Click);
            // 
            // btRightToLeft
            // 
            this.btRightToLeft.Location = new System.Drawing.Point(298, 323);
            this.btRightToLeft.Name = "btRightToLeft";
            this.btRightToLeft.Size = new System.Drawing.Size(173, 46);
            this.btRightToLeft.TabIndex = 5;
            this.btRightToLeft.Text = "<==";
            this.btRightToLeft.UseVisualStyleBackColor = true;
            this.btRightToLeft.Click += new System.EventHandler(this.btRightToLeft_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 464);
            this.Controls.Add(this.btRightToLeft);
            this.Controls.Add(this.btLeftToRight);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rLeftDel);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form3";
            this.Text = " ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button rLeftDel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rAddTail;
        private System.Windows.Forms.RadioButton addHead;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rRightDel;
        private System.Windows.Forms.RadioButton rLeftList;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btLeftToRight;
        private System.Windows.Forms.Button btRightToLeft;
    }
}