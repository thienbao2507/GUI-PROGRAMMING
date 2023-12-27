
namespace BaiThucHanhChuong2
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
            this.num1 = new System.Windows.Forms.Label();
            this.num2 = new System.Windows.Forms.Label();
            this.num3 = new System.Windows.Forms.Label();
            this.selectBox = new System.Windows.Forms.GroupBox();
            this.run = new System.Windows.Forms.Button();
            this.lbDiem = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.TextBox();
            this.choice1 = new System.Windows.Forms.RadioButton();
            this.choice2 = new System.Windows.Forms.RadioButton();
            this.selectBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // num1
            // 
            this.num1.AutoSize = true;
            this.num1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.num1.Font = new System.Drawing.Font("Arial", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num1.Location = new System.Drawing.Point(139, 28);
            this.num1.Name = "num1";
            this.num1.Padding = new System.Windows.Forms.Padding(10);
            this.num1.Size = new System.Drawing.Size(148, 161);
            this.num1.TabIndex = 0;
            this.num1.Text = "1";
            // 
            // num2
            // 
            this.num2.AutoSize = true;
            this.num2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.num2.Font = new System.Drawing.Font("Arial", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num2.Location = new System.Drawing.Point(326, 28);
            this.num2.Name = "num2";
            this.num2.Padding = new System.Windows.Forms.Padding(10);
            this.num2.Size = new System.Drawing.Size(148, 161);
            this.num2.TabIndex = 1;
            this.num2.Text = "1";
            // 
            // num3
            // 
            this.num3.AutoSize = true;
            this.num3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.num3.Font = new System.Drawing.Font("Arial", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num3.Location = new System.Drawing.Point(513, 28);
            this.num3.Name = "num3";
            this.num3.Padding = new System.Windows.Forms.Padding(10);
            this.num3.Size = new System.Drawing.Size(148, 161);
            this.num3.TabIndex = 2;
            this.num3.Text = "1";
            // 
            // selectBox
            // 
            this.selectBox.BackColor = System.Drawing.Color.White;
            this.selectBox.Controls.Add(this.choice2);
            this.selectBox.Controls.Add(this.choice1);
            this.selectBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectBox.ForeColor = System.Drawing.Color.Red;
            this.selectBox.Location = new System.Drawing.Point(139, 213);
            this.selectBox.Name = "selectBox";
            this.selectBox.Size = new System.Drawing.Size(522, 100);
            this.selectBox.TabIndex = 3;
            this.selectBox.TabStop = false;
            this.selectBox.Text = "Chọn:";
            this.selectBox.Enter += new System.EventHandler(this.selectBox_Enter);
            // 
            // run
            // 
            this.run.AutoSize = true;
            this.run.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.run.Location = new System.Drawing.Point(139, 369);
            this.run.Name = "run";
            this.run.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.run.Size = new System.Drawing.Size(130, 52);
            this.run.TabIndex = 4;
            this.run.Text = "Quay số";
            this.run.UseVisualStyleBackColor = true;
            this.run.Click += new System.EventHandler(this.run_Click);
            // 
            // lbDiem
            // 
            this.lbDiem.AutoSize = true;
            this.lbDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiem.Location = new System.Drawing.Point(507, 369);
            this.lbDiem.Name = "lbDiem";
            this.lbDiem.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.lbDiem.Size = new System.Drawing.Size(92, 44);
            this.lbDiem.TabIndex = 5;
            this.lbDiem.Text = "ĐIỂM:";
            this.lbDiem.Click += new System.EventHandler(this.lbDiem_Click);
            // 
            // result
            // 
            this.result.BackColor = System.Drawing.Color.Silver;
            this.result.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.ForeColor = System.Drawing.Color.Red;
            this.result.Location = new System.Drawing.Point(605, 345);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(151, 76);
            this.result.TabIndex = 6;
            this.result.Text = "0";
            this.result.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // choice1
            // 
            this.choice1.AutoSize = true;
            this.choice1.Checked = true;
            this.choice1.Location = new System.Drawing.Point(98, 50);
            this.choice1.Name = "choice1";
            this.choice1.Size = new System.Drawing.Size(85, 33);
            this.choice1.TabIndex = 0;
            this.choice1.TabStop = true;
            this.choice1.Text = "3-10";
            this.choice1.UseVisualStyleBackColor = true;
            // 
            // choice2
            // 
            this.choice2.AutoSize = true;
            this.choice2.Location = new System.Drawing.Point(325, 50);
            this.choice2.Name = "choice2";
            this.choice2.Size = new System.Drawing.Size(99, 33);
            this.choice2.TabIndex = 1;
            this.choice2.Text = "11-18";
            this.choice2.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.result);
            this.Controls.Add(this.lbDiem);
            this.Controls.Add(this.run);
            this.Controls.Add(this.selectBox);
            this.Controls.Add(this.num3);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Name = "Form3";
            this.Text = "Random Number";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.selectBox.ResumeLayout(false);
            this.selectBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label num1;
        private System.Windows.Forms.Label num2;
        private System.Windows.Forms.Label num3;
        private System.Windows.Forms.GroupBox selectBox;
        private System.Windows.Forms.Button run;
        private System.Windows.Forms.Label lbDiem;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.RadioButton choice2;
        private System.Windows.Forms.RadioButton choice1;
    }
}