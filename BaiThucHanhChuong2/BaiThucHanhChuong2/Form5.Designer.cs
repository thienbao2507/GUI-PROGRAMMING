
namespace BaiThucHanhChuong2
{
    partial class Form5
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
            this.title = new System.Windows.Forms.Label();
            this.asciiToChar = new System.Windows.Forms.GroupBox();
            this.convert1 = new System.Windows.Forms.Label();
            this.btnConvert1 = new System.Windows.Forms.Button();
            this.txtASCII = new System.Windows.Forms.TextBox();
            this.lbConvert1 = new System.Windows.Forms.Label();
            this.lbASCII = new System.Windows.Forms.Label();
            this.charToASCII = new System.Windows.Forms.GroupBox();
            this.convert2 = new System.Windows.Forms.Label();
            this.btnCovert2 = new System.Windows.Forms.Button();
            this.txtChar = new System.Windows.Forms.TextBox();
            this.lbConvert2 = new System.Windows.Forms.Label();
            this.lbChar = new System.Windows.Forms.Label();
            this.asciiToChar.SuspendLayout();
            this.charToASCII.SuspendLayout();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.Silver;
            this.title.Dock = System.Windows.Forms.DockStyle.Top;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(0, 0);
            this.title.Name = "title";
            this.title.Padding = new System.Windows.Forms.Padding(200, 30, 200, 30);
            this.title.Size = new System.Drawing.Size(800, 111);
            this.title.TabIndex = 0;
            this.title.Text = "CHUYỂN MÃ ASCII";
            // 
            // asciiToChar
            // 
            this.asciiToChar.Controls.Add(this.convert1);
            this.asciiToChar.Controls.Add(this.btnConvert1);
            this.asciiToChar.Controls.Add(this.txtASCII);
            this.asciiToChar.Controls.Add(this.lbConvert1);
            this.asciiToChar.Controls.Add(this.lbASCII);
            this.asciiToChar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.asciiToChar.Location = new System.Drawing.Point(84, 192);
            this.asciiToChar.Name = "asciiToChar";
            this.asciiToChar.Size = new System.Drawing.Size(300, 200);
            this.asciiToChar.TabIndex = 1;
            this.asciiToChar.TabStop = false;
            this.asciiToChar.Text = "Chuyển mã ASCII sang ký tự";
            // 
            // convert1
            // 
            this.convert1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.convert1.Location = new System.Drawing.Point(166, 140);
            this.convert1.Name = "convert1";
            this.convert1.Size = new System.Drawing.Size(100, 30);
            this.convert1.TabIndex = 4;
            this.convert1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnConvert1
            // 
            this.btnConvert1.Location = new System.Drawing.Point(166, 91);
            this.btnConvert1.Name = "btnConvert1";
            this.btnConvert1.Size = new System.Drawing.Size(100, 40);
            this.btnConvert1.TabIndex = 3;
            this.btnConvert1.Text = "Chuyển";
            this.btnConvert1.UseVisualStyleBackColor = true;
            this.btnConvert1.Click += new System.EventHandler(this.btnConvert1_Click);
            // 
            // txtASCII
            // 
            this.txtASCII.Location = new System.Drawing.Point(166, 55);
            this.txtASCII.Name = "txtASCII";
            this.txtASCII.Size = new System.Drawing.Size(100, 30);
            this.txtASCII.TabIndex = 2;
            this.txtASCII.TextChanged += new System.EventHandler(this.txtASCII_TextChanged_1);
            // 
            // lbConvert1
            // 
            this.lbConvert1.AutoSize = true;
            this.lbConvert1.Location = new System.Drawing.Point(34, 140);
            this.lbConvert1.Name = "lbConvert1";
            this.lbConvert1.Size = new System.Drawing.Size(80, 25);
            this.lbConvert1.TabIndex = 1;
            this.lbConvert1.Text = "Kết quả";
            // 
            // lbASCII
            // 
            this.lbASCII.AutoSize = true;
            this.lbASCII.Location = new System.Drawing.Point(34, 55);
            this.lbASCII.Name = "lbASCII";
            this.lbASCII.Size = new System.Drawing.Size(98, 25);
            this.lbASCII.TabIndex = 0;
            this.lbASCII.Text = "Mã ASCII";
            // 
            // charToASCII
            // 
            this.charToASCII.Controls.Add(this.convert2);
            this.charToASCII.Controls.Add(this.btnCovert2);
            this.charToASCII.Controls.Add(this.txtChar);
            this.charToASCII.Controls.Add(this.lbConvert2);
            this.charToASCII.Controls.Add(this.lbChar);
            this.charToASCII.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.charToASCII.Location = new System.Drawing.Point(416, 192);
            this.charToASCII.Name = "charToASCII";
            this.charToASCII.Size = new System.Drawing.Size(300, 200);
            this.charToASCII.TabIndex = 2;
            this.charToASCII.TabStop = false;
            this.charToASCII.Text = "Chuyển ký tự sang mã ASCII";
            // 
            // convert2
            // 
            this.convert2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.convert2.Location = new System.Drawing.Point(166, 140);
            this.convert2.Name = "convert2";
            this.convert2.Size = new System.Drawing.Size(100, 30);
            this.convert2.TabIndex = 9;
            this.convert2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCovert2
            // 
            this.btnCovert2.Location = new System.Drawing.Point(166, 91);
            this.btnCovert2.Name = "btnCovert2";
            this.btnCovert2.Size = new System.Drawing.Size(100, 40);
            this.btnCovert2.TabIndex = 8;
            this.btnCovert2.Text = "Chuyển";
            this.btnCovert2.UseVisualStyleBackColor = true;
            this.btnCovert2.Click += new System.EventHandler(this.btnCovert2_Click);
            // 
            // txtChar
            // 
            this.txtChar.Location = new System.Drawing.Point(166, 55);
            this.txtChar.Name = "txtChar";
            this.txtChar.Size = new System.Drawing.Size(100, 30);
            this.txtChar.TabIndex = 7;
            this.txtChar.TextChanged += new System.EventHandler(this.txtChar_TextChanged);
            // 
            // lbConvert2
            // 
            this.lbConvert2.AutoSize = true;
            this.lbConvert2.Location = new System.Drawing.Point(34, 140);
            this.lbConvert2.Name = "lbConvert2";
            this.lbConvert2.Size = new System.Drawing.Size(80, 25);
            this.lbConvert2.TabIndex = 6;
            this.lbConvert2.Text = "Kết quả";
            // 
            // lbChar
            // 
            this.lbChar.AutoSize = true;
            this.lbChar.Location = new System.Drawing.Point(34, 55);
            this.lbChar.Name = "lbChar";
            this.lbChar.Size = new System.Drawing.Size(57, 25);
            this.lbChar.TabIndex = 5;
            this.lbChar.Text = "Ký tự";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.charToASCII);
            this.Controls.Add(this.asciiToChar);
            this.Controls.Add(this.title);
            this.Name = "Form5";
            this.Text = "Chuyển mã ASCII";
            this.asciiToChar.ResumeLayout(false);
            this.asciiToChar.PerformLayout();
            this.charToASCII.ResumeLayout(false);
            this.charToASCII.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.GroupBox asciiToChar;
        private System.Windows.Forms.Label convert1;
        private System.Windows.Forms.Button btnConvert1;
        private System.Windows.Forms.TextBox txtASCII;
        private System.Windows.Forms.Label lbConvert1;
        private System.Windows.Forms.Label lbASCII;
        private System.Windows.Forms.GroupBox charToASCII;
        private System.Windows.Forms.Label convert2;
        private System.Windows.Forms.Button btnCovert2;
        private System.Windows.Forms.TextBox txtChar;
        private System.Windows.Forms.Label lbConvert2;
        private System.Windows.Forms.Label lbChar;
    }
}