
namespace Chuong6
{
    partial class BTLT1
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
            this.txtInt = new System.Windows.Forms.TextBox();
            this.btCal = new System.Windows.Forms.Button();
            this.btRandom = new System.Windows.Forms.Button();
            this.txtSoPT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTongLe = new System.Windows.Forms.TextBox();
            this.txtTongChan = new System.Windows.Forms.TextBox();
            this.txtTBC = new System.Windows.Forms.TextBox();
            this.txtSNT = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtInt
            // 
            this.txtInt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInt.Location = new System.Drawing.Point(340, 102);
            this.txtInt.Margin = new System.Windows.Forms.Padding(2);
            this.txtInt.Name = "txtInt";
            this.txtInt.Size = new System.Drawing.Size(440, 32);
            this.txtInt.TabIndex = 17;
            // 
            // btCal
            // 
            this.btCal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCal.Location = new System.Drawing.Point(636, 36);
            this.btCal.Margin = new System.Windows.Forms.Padding(2);
            this.btCal.Name = "btCal";
            this.btCal.Size = new System.Drawing.Size(143, 45);
            this.btCal.TabIndex = 11;
            this.btCal.Text = "Tính";
            this.btCal.UseVisualStyleBackColor = true;
            this.btCal.Click += new System.EventHandler(this.btCal_Click);
            // 
            // btRandom
            // 
            this.btRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRandom.Location = new System.Drawing.Point(295, 36);
            this.btRandom.Margin = new System.Windows.Forms.Padding(2);
            this.btRandom.Name = "btRandom";
            this.btRandom.Size = new System.Drawing.Size(242, 45);
            this.btRandom.TabIndex = 12;
            this.btRandom.Text = "Tạo Mảng Ngẫu Nhiên";
            this.btRandom.UseVisualStyleBackColor = true;
            this.btRandom.Click += new System.EventHandler(this.btRandom_Click);
            // 
            // txtSoPT
            // 
            this.txtSoPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoPT.Location = new System.Drawing.Point(148, 43);
            this.txtSoPT.Margin = new System.Windows.Forms.Padding(2);
            this.txtSoPT.Name = "txtSoPT";
            this.txtSoPT.Size = new System.Drawing.Size(82, 32);
            this.txtSoPT.TabIndex = 10;
            this.txtSoPT.Text = "10";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 107);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 26);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mảng ban đầu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 26);
            this.label1.TabIndex = 9;
            this.label1.Text = "Số Phần Tử";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 158);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 26);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tổng lẻ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 214);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 26);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tổng chẵn:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 271);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 26);
            this.label5.TabIndex = 8;
            this.label5.Text = "Trung Bình Cộng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 333);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(315, 26);
            this.label6.TabIndex = 8;
            this.label6.Text = "Cách số nguyên tố trong mảng:";
            // 
            // txtTongLe
            // 
            this.txtTongLe.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongLe.Location = new System.Drawing.Point(340, 155);
            this.txtTongLe.Margin = new System.Windows.Forms.Padding(2);
            this.txtTongLe.Name = "txtTongLe";
            this.txtTongLe.Size = new System.Drawing.Size(439, 32);
            this.txtTongLe.TabIndex = 17;
            // 
            // txtTongChan
            // 
            this.txtTongChan.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongChan.Location = new System.Drawing.Point(340, 211);
            this.txtTongChan.Margin = new System.Windows.Forms.Padding(2);
            this.txtTongChan.Name = "txtTongChan";
            this.txtTongChan.Size = new System.Drawing.Size(439, 32);
            this.txtTongChan.TabIndex = 17;
            // 
            // txtTBC
            // 
            this.txtTBC.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTBC.Location = new System.Drawing.Point(340, 268);
            this.txtTBC.Margin = new System.Windows.Forms.Padding(2);
            this.txtTBC.Name = "txtTBC";
            this.txtTBC.Size = new System.Drawing.Size(439, 32);
            this.txtTBC.TabIndex = 17;
            // 
            // txtSNT
            // 
            this.txtSNT.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSNT.Location = new System.Drawing.Point(340, 330);
            this.txtSNT.Margin = new System.Windows.Forms.Padding(2);
            this.txtSNT.Name = "txtSNT";
            this.txtSNT.Size = new System.Drawing.Size(439, 32);
            this.txtSNT.TabIndex = 17;
            // 
            // BTLT1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSNT);
            this.Controls.Add(this.txtTBC);
            this.Controls.Add(this.txtTongChan);
            this.Controls.Add(this.txtTongLe);
            this.Controls.Add(this.txtInt);
            this.Controls.Add(this.btCal);
            this.Controls.Add(this.btRandom);
            this.Controls.Add(this.txtSoPT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BTLT1";
            this.Text = "BTLT1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtInt;
        private System.Windows.Forms.Button btCal;
        private System.Windows.Forms.Button btRandom;
        private System.Windows.Forms.TextBox txtSoPT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTongLe;
        private System.Windows.Forms.TextBox txtTongChan;
        private System.Windows.Forms.TextBox txtTBC;
        private System.Windows.Forms.TextBox txtSNT;
    }
}