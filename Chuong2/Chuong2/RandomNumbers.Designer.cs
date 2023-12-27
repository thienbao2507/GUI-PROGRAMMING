
namespace Chuong2
{
    partial class RandomNumbers
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
            this.IbSo1 = new System.Windows.Forms.Label();
            this.IbSo2 = new System.Windows.Forms.Label();
            this.Ibso3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt2 = new System.Windows.Forms.RadioButton();
            this.bt1 = new System.Windows.Forms.RadioButton();
            this.btRandom = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.IbDiem = new System.Windows.Forms.Label();
            this.IbSum = new System.Windows.Forms.Label();
            this.BtReset = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // IbSo1
            // 
            this.IbSo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.IbSo1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.IbSo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IbSo1.Location = new System.Drawing.Point(173, 29);
            this.IbSo1.Name = "IbSo1";
            this.IbSo1.Size = new System.Drawing.Size(136, 130);
            this.IbSo1.TabIndex = 0;
            this.IbSo1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IbSo2
            // 
            this.IbSo2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.IbSo2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.IbSo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IbSo2.Location = new System.Drawing.Point(332, 29);
            this.IbSo2.Name = "IbSo2";
            this.IbSo2.Size = new System.Drawing.Size(136, 130);
            this.IbSo2.TabIndex = 0;
            this.IbSo2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Ibso3
            // 
            this.Ibso3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Ibso3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Ibso3.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ibso3.Location = new System.Drawing.Point(491, 29);
            this.Ibso3.Name = "Ibso3";
            this.Ibso3.Size = new System.Drawing.Size(136, 130);
            this.Ibso3.TabIndex = 0;
            this.Ibso3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt2);
            this.groupBox1.Controls.Add(this.bt1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.groupBox1.Location = new System.Drawing.Point(62, 208);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(692, 147);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn";
            // 
            // bt2
            // 
            this.bt2.Appearance = System.Windows.Forms.Appearance.Button;
            this.bt2.AutoSize = true;
            this.bt2.BackColor = System.Drawing.Color.Red;
            this.bt2.ForeColor = System.Drawing.Color.Black;
            this.bt2.Location = new System.Drawing.Point(464, 59);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(107, 41);
            this.bt2.TabIndex = 0;
            this.bt2.Text = "11 - 18";
            this.bt2.UseVisualStyleBackColor = false;
            // 
            // bt1
            // 
            this.bt1.Appearance = System.Windows.Forms.Appearance.Button;
            this.bt1.AutoSize = true;
            this.bt1.BackColor = System.Drawing.Color.Red;
            this.bt1.Checked = true;
            this.bt1.ForeColor = System.Drawing.Color.Black;
            this.bt1.Location = new System.Drawing.Point(122, 59);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(92, 41);
            this.bt1.TabIndex = 0;
            this.bt1.TabStop = true;
            this.bt1.Text = "3 - 10";
            this.bt1.UseVisualStyleBackColor = false;
            // 
            // btRandom
            // 
            this.btRandom.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRandom.Location = new System.Drawing.Point(103, 375);
            this.btRandom.Name = "btRandom";
            this.btRandom.Size = new System.Drawing.Size(189, 67);
            this.btRandom.TabIndex = 2;
            this.btRandom.Text = "Quay Số";
            this.btRandom.UseVisualStyleBackColor = true;
            this.btRandom.Click += new System.EventHandler(this.btRandom_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(435, 395);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Điểm:";
            // 
            // IbDiem
            // 
            this.IbDiem.BackColor = System.Drawing.Color.SteelBlue;
            this.IbDiem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.IbDiem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.IbDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IbDiem.ForeColor = System.Drawing.Color.Cyan;
            this.IbDiem.Location = new System.Drawing.Point(508, 375);
            this.IbDiem.Name = "IbDiem";
            this.IbDiem.Size = new System.Drawing.Size(195, 67);
            this.IbDiem.TabIndex = 4;
            this.IbDiem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IbSum
            // 
            this.IbSum.BackColor = System.Drawing.Color.DodgerBlue;
            this.IbSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IbSum.Location = new System.Drawing.Point(252, 172);
            this.IbSum.Name = "IbSum";
            this.IbSum.Size = new System.Drawing.Size(307, 48);
            this.IbSum.TabIndex = 5;
            this.IbSum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtReset
            // 
            this.BtReset.Location = new System.Drawing.Point(332, 441);
            this.BtReset.Name = "BtReset";
            this.BtReset.Size = new System.Drawing.Size(109, 33);
            this.BtReset.TabIndex = 6;
            this.BtReset.Text = "Reset";
            this.BtReset.UseVisualStyleBackColor = true;
            this.BtReset.Click += new System.EventHandler(this.BtReset_Click);
            // 
            // RandomNumbers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(800, 486);
            this.Controls.Add(this.BtReset);
            this.Controls.Add(this.IbSum);
            this.Controls.Add(this.IbDiem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btRandom);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Ibso3);
            this.Controls.Add(this.IbSo2);
            this.Controls.Add(this.IbSo1);
            this.MaximizeBox = false;
            this.Name = "RandomNumbers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RandomNumbers";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IbSo1;
        private System.Windows.Forms.Label IbSo2;
        private System.Windows.Forms.Label Ibso3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton bt2;
        private System.Windows.Forms.RadioButton bt1;
        private System.Windows.Forms.Button btRandom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label IbDiem;
        private System.Windows.Forms.Label IbSum;
        private System.Windows.Forms.Button BtReset;
    }
}