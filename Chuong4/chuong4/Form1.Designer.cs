
namespace chuong4
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
            this.lbName = new System.Windows.Forms.Label();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.pic2 = new System.Windows.Forms.PictureBox();
            this.pic3 = new System.Windows.Forms.PictureBox();
            this.lbDiem = new System.Windows.Forms.Label();
            this.btQuay = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).BeginInit();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.BackColor = System.Drawing.Color.Blue;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.White;
            this.lbName.Location = new System.Drawing.Point(55, 7);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(672, 61);
            this.lbName.TabIndex = 0;
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // pic1
            // 
            this.pic1.Location = new System.Drawing.Point(150, 126);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(100, 113);
            this.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic1.TabIndex = 1;
            this.pic1.TabStop = false;
            // 
            // pic2
            // 
            this.pic2.Location = new System.Drawing.Point(344, 126);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(100, 113);
            this.pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic2.TabIndex = 1;
            this.pic2.TabStop = false;
            // 
            // pic3
            // 
            this.pic3.Location = new System.Drawing.Point(535, 126);
            this.pic3.Name = "pic3";
            this.pic3.Size = new System.Drawing.Size(100, 113);
            this.pic3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic3.TabIndex = 1;
            this.pic3.TabStop = false;
            // 
            // lbDiem
            // 
            this.lbDiem.BackColor = System.Drawing.Color.Blue;
            this.lbDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiem.ForeColor = System.Drawing.Color.White;
            this.lbDiem.Location = new System.Drawing.Point(344, 286);
            this.lbDiem.Name = "lbDiem";
            this.lbDiem.Size = new System.Drawing.Size(100, 30);
            this.lbDiem.TabIndex = 0;
            this.lbDiem.Text = "0";
            this.lbDiem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btQuay
            // 
            this.btQuay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btQuay.ForeColor = System.Drawing.Color.Blue;
            this.btQuay.Location = new System.Drawing.Point(211, 368);
            this.btQuay.Name = "btQuay";
            this.btQuay.Size = new System.Drawing.Size(104, 41);
            this.btQuay.TabIndex = 2;
            this.btQuay.Text = "Quay Số";
            this.btQuay.UseVisualStyleBackColor = true;
            this.btQuay.Click += new System.EventHandler(this.btQuay_Click);
            // 
            // btExit
            // 
            this.btExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.ForeColor = System.Drawing.Color.Blue;
            this.btExit.Location = new System.Drawing.Point(484, 368);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(104, 41);
            this.btExit.TabIndex = 2;
            this.btExit.Text = "Đóng";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 481);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btQuay);
            this.Controls.Add(this.pic3);
            this.Controls.Add(this.pic2);
            this.Controls.Add(this.pic1);
            this.Controls.Add(this.lbDiem);
            this.Controls.Add(this.lbName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.PictureBox pic2;
        private System.Windows.Forms.PictureBox pic3;
        private System.Windows.Forms.Label lbDiem;
        private System.Windows.Forms.Button btQuay;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Timer timer1;
    }
}

