
namespace Chuong6
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtS1 = new System.Windows.Forms.TextBox();
            this.txtS2 = new System.Windows.Forms.TextBox();
            this.txtS3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPos = new System.Windows.Forms.TextBox();
            this.btReplace = new System.Windows.Forms.Button();
            this.btDelS2inS1 = new System.Windows.Forms.Button();
            this.btReverse = new System.Windows.Forms.Button();
            this.btChuanHoa = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1067, 82);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chương Trình Minh Họa Xử Lý Chuỗi  ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 138);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chuỗi s1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 226);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "Chuỗi s2:";
            // 
            // txtS1
            // 
            this.txtS1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtS1.Location = new System.Drawing.Point(161, 129);
            this.txtS1.Margin = new System.Windows.Forms.Padding(4);
            this.txtS1.Name = "txtS1";
            this.txtS1.Size = new System.Drawing.Size(676, 37);
            this.txtS1.TabIndex = 2;
            // 
            // txtS2
            // 
            this.txtS2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtS2.Location = new System.Drawing.Point(161, 222);
            this.txtS2.Margin = new System.Windows.Forms.Padding(4);
            this.txtS2.Name = "txtS2";
            this.txtS2.Size = new System.Drawing.Size(260, 37);
            this.txtS2.TabIndex = 2;
            // 
            // txtS3
            // 
            this.txtS3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtS3.Location = new System.Drawing.Point(577, 222);
            this.txtS3.Margin = new System.Windows.Forms.Padding(4);
            this.txtS3.Name = "txtS3";
            this.txtS3.Size = new System.Drawing.Size(260, 37);
            this.txtS3.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(451, 226);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 29);
            this.label4.TabIndex = 1;
            this.label4.Text = "Chuỗi s3:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btAdd);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtPos);
            this.groupBox1.Location = new System.Drawing.Point(56, 300);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(365, 208);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chèn chuỗi 2 vào 1";
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(209, 81);
            this.btAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(101, 38);
            this.btAdd.TabIndex = 3;
            this.btAdd.Text = "Chèn";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 86);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 29);
            this.label5.TabIndex = 1;
            this.label5.Text = "Vị trí:";
            // 
            // txtPos
            // 
            this.txtPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPos.Location = new System.Drawing.Point(84, 81);
            this.txtPos.Margin = new System.Windows.Forms.Padding(4);
            this.txtPos.Name = "txtPos";
            this.txtPos.Size = new System.Drawing.Size(85, 37);
            this.txtPos.TabIndex = 2;
            // 
            // btReplace
            // 
            this.btReplace.Location = new System.Drawing.Point(468, 314);
            this.btReplace.Margin = new System.Windows.Forms.Padding(4);
            this.btReplace.Name = "btReplace";
            this.btReplace.Size = new System.Drawing.Size(216, 38);
            this.btReplace.TabIndex = 3;
            this.btReplace.Text = "Thay thế s2 bằng s3";
            this.btReplace.UseVisualStyleBackColor = true;
            this.btReplace.Click += new System.EventHandler(this.btReplace_Click);
            // 
            // btDelS2inS1
            // 
            this.btDelS2inS1.Location = new System.Drawing.Point(468, 405);
            this.btDelS2inS1.Margin = new System.Windows.Forms.Padding(4);
            this.btDelS2inS1.Name = "btDelS2inS1";
            this.btDelS2inS1.Size = new System.Drawing.Size(216, 38);
            this.btDelS2inS1.TabIndex = 3;
            this.btDelS2inS1.Text = "Xóa s2 trong s1";
            this.btDelS2inS1.UseVisualStyleBackColor = true;
            this.btDelS2inS1.Click += new System.EventHandler(this.btDelS2inS1_Click);
            // 
            // btReverse
            // 
            this.btReverse.Location = new System.Drawing.Point(725, 314);
            this.btReverse.Margin = new System.Windows.Forms.Padding(4);
            this.btReverse.Name = "btReverse";
            this.btReverse.Size = new System.Drawing.Size(216, 38);
            this.btReverse.TabIndex = 3;
            this.btReverse.Text = "Đảo từ trong s1";
            this.btReverse.UseVisualStyleBackColor = true;
            this.btReverse.Click += new System.EventHandler(this.btReverse_Click);
            // 
            // btChuanHoa
            // 
            this.btChuanHoa.Location = new System.Drawing.Point(725, 405);
            this.btChuanHoa.Margin = new System.Windows.Forms.Padding(4);
            this.btChuanHoa.Name = "btChuanHoa";
            this.btChuanHoa.Size = new System.Drawing.Size(216, 38);
            this.btChuanHoa.TabIndex = 3;
            this.btChuanHoa.Text = "Chuẩn hóa chuỗi";
            this.btChuanHoa.UseVisualStyleBackColor = true;
            this.btChuanHoa.Click += new System.EventHandler(this.btChuanHoa_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btChuanHoa);
            this.Controls.Add(this.btDelS2inS1);
            this.Controls.Add(this.btReverse);
            this.Controls.Add(this.btReplace);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtS3);
            this.Controls.Add(this.txtS2);
            this.Controls.Add(this.txtS1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtS1;
        private System.Windows.Forms.TextBox txtS2;
        private System.Windows.Forms.TextBox txtS3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPos;
        private System.Windows.Forms.Button btReplace;
        private System.Windows.Forms.Button btDelS2inS1;
        private System.Windows.Forms.Button btReverse;
        private System.Windows.Forms.Button btChuanHoa;
        private System.Windows.Forms.Timer timer1;
    }
}

