
namespace Chuong2
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.textSo1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textSo2 = new System.Windows.Forms.TextBox();
            this.btSum = new System.Windows.Forms.Button();
            this.btSub = new System.Windows.Forms.Button();
            this.btMul = new System.Windows.Forms.Button();
            this.btDiv = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.IbKetQua = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 80);
            this.label1.TabIndex = 0;
            this.label1.Text = "Các phép tính đơn giản";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số thứ nhất: ";
            // 
            // textSo1
            // 
            this.textSo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSo1.Location = new System.Drawing.Point(163, 142);
            this.textSo1.Name = "textSo1";
            this.textSo1.Size = new System.Drawing.Size(163, 31);
            this.textSo1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(402, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Số thứ hai: ";
            // 
            // textSo2
            // 
            this.textSo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSo2.Location = new System.Drawing.Point(524, 142);
            this.textSo2.Name = "textSo2";
            this.textSo2.Size = new System.Drawing.Size(163, 31);
            this.textSo2.TabIndex = 1;
            // 
            // btSum
            // 
            this.btSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSum.Location = new System.Drawing.Point(172, 248);
            this.btSum.Name = "btSum";
            this.btSum.Size = new System.Drawing.Size(78, 52);
            this.btSum.TabIndex = 2;
            this.btSum.Text = "+";
            this.btSum.UseVisualStyleBackColor = true;
            this.btSum.Click += new System.EventHandler(this.btSum_Click);
            // 
            // btSub
            // 
            this.btSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSub.Location = new System.Drawing.Point(298, 248);
            this.btSub.Name = "btSub";
            this.btSub.Size = new System.Drawing.Size(78, 52);
            this.btSub.TabIndex = 3;
            this.btSub.Text = "-";
            this.btSub.UseVisualStyleBackColor = true;
            this.btSub.Click += new System.EventHandler(this.btSub_Click);
            // 
            // btMul
            // 
            this.btMul.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMul.Location = new System.Drawing.Point(424, 248);
            this.btMul.Name = "btMul";
            this.btMul.Size = new System.Drawing.Size(78, 52);
            this.btMul.TabIndex = 4;
            this.btMul.Text = "x";
            this.btMul.UseVisualStyleBackColor = true;
            this.btMul.Click += new System.EventHandler(this.btMul_Click);
            // 
            // btDiv
            // 
            this.btDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDiv.Location = new System.Drawing.Point(550, 248);
            this.btDiv.Name = "btDiv";
            this.btDiv.Size = new System.Drawing.Size(78, 52);
            this.btDiv.TabIndex = 5;
            this.btDiv.Text = "/";
            this.btDiv.UseVisualStyleBackColor = true;
            this.btDiv.Click += new System.EventHandler(this.btDiv_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(131, 361);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Kết quả";
            // 
            // IbKetQua
            // 
            this.IbKetQua.BackColor = System.Drawing.Color.White;
            this.IbKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IbKetQua.Location = new System.Drawing.Point(223, 351);
            this.IbKetQua.Name = "IbKetQua";
            this.IbKetQua.Size = new System.Drawing.Size(300, 42);
            this.IbKetQua.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(540, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 35);
            this.button1.TabIndex = 6;
            this.button1.Text = "Đóng";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btDiv);
            this.Controls.Add(this.btMul);
            this.Controls.Add(this.btSub);
            this.Controls.Add(this.btSum);
            this.Controls.Add(this.textSo2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textSo1);
            this.Controls.Add(this.IbKetQua);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textSo1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textSo2;
        private System.Windows.Forms.Button btSum;
        private System.Windows.Forms.Button btSub;
        private System.Windows.Forms.Button btMul;
        private System.Windows.Forms.Button btDiv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label IbKetQua;
        private System.Windows.Forms.Button button1;
    }
}

