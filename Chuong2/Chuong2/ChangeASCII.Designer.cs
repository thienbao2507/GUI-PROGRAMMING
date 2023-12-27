
namespace Chuong2
{
    partial class ChangeASCII
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
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btChangeASCtoChar = new System.Windows.Forms.Button();
            this.txtASC = new System.Windows.Forms.TextBox();
            this.lbChar = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btChangeCharToASC = new System.Windows.Forms.Button();
            this.txtChar = new System.Windows.Forms.TextBox();
            this.lbASC = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Blue;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1165, 116);
            this.label4.TabIndex = 0;
            this.label4.Text = "Chuyển mã ASCII";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btChangeASCtoChar);
            this.groupBox3.Controls.Add(this.txtASC);
            this.groupBox3.Controls.Add(this.lbChar);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(48, 166);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(449, 309);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chuyển ASCII sang mã ký tự";
            // 
            // btChangeASCtoChar
            // 
            this.btChangeASCtoChar.Location = new System.Drawing.Point(197, 123);
            this.btChangeASCtoChar.Name = "btChangeASCtoChar";
            this.btChangeASCtoChar.Size = new System.Drawing.Size(214, 39);
            this.btChangeASCtoChar.TabIndex = 2;
            this.btChangeASCtoChar.Text = "Chuyển";
            this.btChangeASCtoChar.UseVisualStyleBackColor = true;
            this.btChangeASCtoChar.Click += new System.EventHandler(this.btChangeASCtoChar_Click_1);
            // 
            // txtASC
            // 
            this.txtASC.Location = new System.Drawing.Point(197, 73);
            this.txtASC.Name = "txtASC";
            this.txtASC.Size = new System.Drawing.Size(214, 31);
            this.txtASC.TabIndex = 1;
            // 
            // lbChar
            // 
            this.lbChar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbChar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChar.Location = new System.Drawing.Point(197, 185);
            this.lbChar.Name = "lbChar";
            this.lbChar.Size = new System.Drawing.Size(214, 31);
            this.lbChar.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(31, 185);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 31);
            this.label8.TabIndex = 0;
            this.label8.Text = "Mã Ký Tự:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(31, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 31);
            this.label7.TabIndex = 0;
            this.label7.Text = "Mã ASCII:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btChangeCharToASC);
            this.groupBox4.Controls.Add(this.txtChar);
            this.groupBox4.Controls.Add(this.lbASC);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(668, 166);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(449, 309);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chuyển mã ký tự sang ASCII ";
            // 
            // btChangeCharToASC
            // 
            this.btChangeCharToASC.Location = new System.Drawing.Point(197, 123);
            this.btChangeCharToASC.Name = "btChangeCharToASC";
            this.btChangeCharToASC.Size = new System.Drawing.Size(214, 39);
            this.btChangeCharToASC.TabIndex = 2;
            this.btChangeCharToASC.Text = "Chuyển";
            this.btChangeCharToASC.UseVisualStyleBackColor = true;
            this.btChangeCharToASC.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtChar
            // 
            this.txtChar.Location = new System.Drawing.Point(197, 73);
            this.txtChar.Name = "txtChar";
            this.txtChar.Size = new System.Drawing.Size(214, 31);
            this.txtChar.TabIndex = 1;
            // 
            // lbASC
            // 
            this.lbASC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbASC.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbASC.Location = new System.Drawing.Point(197, 185);
            this.lbASC.Name = "lbASC";
            this.lbASC.Size = new System.Drawing.Size(214, 31);
            this.lbASC.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(31, 185);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(138, 31);
            this.label10.TabIndex = 0;
            this.label10.Text = "Mã ASCII:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(31, 73);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(137, 31);
            this.label11.TabIndex = 0;
            this.label11.Text = "Mã Ký Tự:";
            // 
            // ChangeASCII
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1165, 670);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label4);
            this.Name = "ChangeASCII";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button changeAscToChar;
        private System.Windows.Forms.Label ResultChar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button changeCharToAsc;
        private System.Windows.Forms.Label ResultASC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btChangeASCtoChar;
        private System.Windows.Forms.TextBox txtASC;
        private System.Windows.Forms.Label lbChar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btChangeCharToASC;
        private System.Windows.Forms.TextBox txtChar;
        private System.Windows.Forms.Label lbASC;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}