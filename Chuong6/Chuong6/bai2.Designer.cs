
namespace Chuong6
{
    partial class bai2
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
            this.txtSoPT = new System.Windows.Forms.TextBox();
            this.btRandom = new System.Windows.Forms.Button();
            this.btSort = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtInt = new System.Windows.Forms.TextBox();
            this.txtTang = new System.Windows.Forms.TextBox();
            this.txtGiam = new System.Windows.Forms.TextBox();
            this.txtDao = new System.Windows.Forms.TextBox();
            this.txtChanLe = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số Phần Tử";
            // 
            // txtSoPT
            // 
            this.txtSoPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoPT.Location = new System.Drawing.Point(182, 31);
            this.txtSoPT.Name = "txtSoPT";
            this.txtSoPT.Size = new System.Drawing.Size(108, 38);
            this.txtSoPT.TabIndex = 1;
            // 
            // btRandom
            // 
            this.btRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRandom.Location = new System.Drawing.Point(377, 22);
            this.btRandom.Name = "btRandom";
            this.btRandom.Size = new System.Drawing.Size(322, 55);
            this.btRandom.TabIndex = 2;
            this.btRandom.Text = "Tạo Mảng Ngẫu Nhiên";
            this.btRandom.UseVisualStyleBackColor = true;
            this.btRandom.Click += new System.EventHandler(this.btRandom_Click);
            // 
            // btSort
            // 
            this.btSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSort.Location = new System.Drawing.Point(832, 22);
            this.btSort.Name = "btSort";
            this.btSort.Size = new System.Drawing.Size(191, 55);
            this.btSort.TabIndex = 2;
            this.btSort.Text = "Sắp Xếp";
            this.btSort.UseVisualStyleBackColor = true;
            this.btSort.Click += new System.EventHandler(this.btSort_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mảng ban đầu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mảng tăng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 32);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mảng giảm:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 368);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 32);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mảng đảo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 454);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(333, 32);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mảng chẵn tăng, lẻ giảm:";
            // 
            // txtInt
            // 
            this.txtInt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInt.Location = new System.Drawing.Point(356, 104);
            this.txtInt.Name = "txtInt";
            this.txtInt.Size = new System.Drawing.Size(667, 38);
            this.txtInt.TabIndex = 3;
            // 
            // txtTang
            // 
            this.txtTang.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTang.Location = new System.Drawing.Point(356, 190);
            this.txtTang.Name = "txtTang";
            this.txtTang.Size = new System.Drawing.Size(667, 38);
            this.txtTang.TabIndex = 3;
            // 
            // txtGiam
            // 
            this.txtGiam.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiam.Location = new System.Drawing.Point(356, 276);
            this.txtGiam.Name = "txtGiam";
            this.txtGiam.Size = new System.Drawing.Size(667, 38);
            this.txtGiam.TabIndex = 3;
            // 
            // txtDao
            // 
            this.txtDao.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDao.Location = new System.Drawing.Point(356, 362);
            this.txtDao.Name = "txtDao";
            this.txtDao.Size = new System.Drawing.Size(667, 38);
            this.txtDao.TabIndex = 3;
            // 
            // txtChanLe
            // 
            this.txtChanLe.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChanLe.Location = new System.Drawing.Point(356, 448);
            this.txtChanLe.Name = "txtChanLe";
            this.txtChanLe.Size = new System.Drawing.Size(667, 38);
            this.txtChanLe.TabIndex = 3;
            // 
            // bai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 517);
            this.Controls.Add(this.txtChanLe);
            this.Controls.Add(this.txtDao);
            this.Controls.Add(this.txtGiam);
            this.Controls.Add(this.txtTang);
            this.Controls.Add(this.txtInt);
            this.Controls.Add(this.btSort);
            this.Controls.Add(this.btRandom);
            this.Controls.Add(this.txtSoPT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "bai2";
            this.Text = "bai2";
            this.Load += new System.EventHandler(this.bai2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoPT;
        private System.Windows.Forms.Button btRandom;
        private System.Windows.Forms.Button btSort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtInt;
        private System.Windows.Forms.TextBox txtTang;
        private System.Windows.Forms.TextBox txtGiam;
        private System.Windows.Forms.TextBox txtDao;
        private System.Windows.Forms.TextBox txtChanLe;
    }
}