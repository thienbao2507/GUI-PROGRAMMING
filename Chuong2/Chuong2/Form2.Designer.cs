
namespace Chuong2
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
            this.button1 = new System.Windows.Forms.Button();
            this.btSum = new System.Windows.Forms.Button();
            this.textSo2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textSo1 = new System.Windows.Forms.TextBox();
            this.IbKetQua = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rSum = new System.Windows.Forms.RadioButton();
            this.rSub = new System.Windows.Forms.RadioButton();
            this.rMul = new System.Windows.Forms.RadioButton();
            this.rDiv = new System.Windows.Forms.RadioButton();
            this.rDivDu = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(328, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 35);
            this.button1.TabIndex = 18;
            this.button1.Text = "Đóng";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btSum
            // 
            this.btSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSum.Location = new System.Drawing.Point(512, 330);
            this.btSum.Name = "btSum";
            this.btSum.Size = new System.Drawing.Size(78, 42);
            this.btSum.TabIndex = 14;
            this.btSum.Text = "Tính";
            this.btSum.UseVisualStyleBackColor = true;
            this.btSum.Click += new System.EventHandler(this.btSum_Click);
            // 
            // textSo2
            // 
            this.textSo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSo2.Location = new System.Drawing.Point(524, 171);
            this.textSo2.Name = "textSo2";
            this.textSo2.Size = new System.Drawing.Size(163, 31);
            this.textSo2.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(402, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Số thứ hai: ";
            // 
            // textSo1
            // 
            this.textSo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSo1.Location = new System.Drawing.Point(163, 171);
            this.textSo1.Name = "textSo1";
            this.textSo1.Size = new System.Drawing.Size(163, 31);
            this.textSo1.TabIndex = 7;
            // 
            // IbKetQua
            // 
            this.IbKetQua.BackColor = System.Drawing.Color.White;
            this.IbKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IbKetQua.Location = new System.Drawing.Point(193, 330);
            this.IbKetQua.Name = "IbKetQua";
            this.IbKetQua.Size = new System.Drawing.Size(300, 42);
            this.IbKetQua.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(101, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Kết quả";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Số thứ nhất: ";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 80);
            this.label1.TabIndex = 8;
            this.label1.Text = "Các phép tính đơn giản";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rDivDu);
            this.groupBox1.Controls.Add(this.rDiv);
            this.groupBox1.Controls.Add(this.rMul);
            this.groupBox1.Controls.Add(this.rSub);
            this.groupBox1.Controls.Add(this.rSum);
            this.groupBox1.Location = new System.Drawing.Point(116, 223);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(570, 94);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Các phép tính";
            // 
            // rSum
            // 
            this.rSum.AutoSize = true;
            this.rSum.Checked = true;
            this.rSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rSum.Location = new System.Drawing.Point(116, 42);
            this.rSum.Name = "rSum";
            this.rSum.Size = new System.Drawing.Size(42, 29);
            this.rSum.TabIndex = 0;
            this.rSum.TabStop = true;
            this.rSum.Text = "+";
            this.rSum.UseVisualStyleBackColor = true;
            // 
            // rSub
            // 
            this.rSub.AutoSize = true;
            this.rSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rSub.Location = new System.Drawing.Point(191, 42);
            this.rSub.Name = "rSub";
            this.rSub.Size = new System.Drawing.Size(37, 29);
            this.rSub.TabIndex = 0;
            this.rSub.Text = "-";
            this.rSub.UseVisualStyleBackColor = true;
            // 
            // rMul
            // 
            this.rMul.AutoSize = true;
            this.rMul.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rMul.Location = new System.Drawing.Point(261, 42);
            this.rMul.Name = "rMul";
            this.rMul.Size = new System.Drawing.Size(41, 29);
            this.rMul.TabIndex = 0;
            this.rMul.Text = "x";
            this.rMul.UseVisualStyleBackColor = true;
            // 
            // rDiv
            // 
            this.rDiv.AutoSize = true;
            this.rDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rDiv.Location = new System.Drawing.Point(335, 42);
            this.rDiv.Name = "rDiv";
            this.rDiv.Size = new System.Drawing.Size(36, 29);
            this.rDiv.TabIndex = 0;
            this.rDiv.Text = "/";
            this.rDiv.UseVisualStyleBackColor = true;
            // 
            // rDivDu
            // 
            this.rDivDu.AutoSize = true;
            this.rDivDu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rDivDu.Location = new System.Drawing.Point(404, 42);
            this.rDivDu.Name = "rDivDu";
            this.rDivDu.Size = new System.Drawing.Size(49, 29);
            this.rDivDu.TabIndex = 0;
            this.rDivDu.Text = "%";
            this.rDivDu.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btSum);
            this.Controls.Add(this.textSo2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textSo1);
            this.Controls.Add(this.IbKetQua);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btSum;
        private System.Windows.Forms.TextBox textSo2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textSo1;
        private System.Windows.Forms.Label IbKetQua;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rDiv;
        private System.Windows.Forms.RadioButton rMul;
        private System.Windows.Forms.RadioButton rSub;
        private System.Windows.Forms.RadioButton rSum;
        private System.Windows.Forms.RadioButton rDivDu;
    }
}