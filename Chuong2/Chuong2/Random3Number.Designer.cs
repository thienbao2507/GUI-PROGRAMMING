
namespace Chuong2
{
    partial class Random3Number
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
            this.IbScore = new System.Windows.Forms.Label();
            this.btRandom = new System.Windows.Forms.Button();
            this.IbSo3 = new System.Windows.Forms.Label();
            this.IbSo2 = new System.Windows.Forms.Label();
            this.IbSo1 = new System.Windows.Forms.Label();
            this.btExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IbScore
            // 
            this.IbScore.BackColor = System.Drawing.Color.DodgerBlue;
            this.IbScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IbScore.Location = new System.Drawing.Point(294, 259);
            this.IbScore.Name = "IbScore";
            this.IbScore.Size = new System.Drawing.Size(307, 48);
            this.IbScore.TabIndex = 14;
            this.IbScore.Text = "0";
            this.IbScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btRandom
            // 
            this.btRandom.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRandom.Location = new System.Drawing.Point(193, 344);
            this.btRandom.Name = "btRandom";
            this.btRandom.Size = new System.Drawing.Size(189, 67);
            this.btRandom.TabIndex = 11;
            this.btRandom.Text = "Play";
            this.btRandom.UseVisualStyleBackColor = true;
            this.btRandom.Click += new System.EventHandler(this.btRandom_Click);
            // 
            // IbSo3
            // 
            this.IbSo3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.IbSo3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.IbSo3.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IbSo3.Location = new System.Drawing.Point(566, 72);
            this.IbSo3.Name = "IbSo3";
            this.IbSo3.Size = new System.Drawing.Size(187, 165);
            this.IbSo3.TabIndex = 7;
            this.IbSo3.Text = "0";
            this.IbSo3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IbSo2
            // 
            this.IbSo2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.IbSo2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.IbSo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IbSo2.Location = new System.Drawing.Point(353, 72);
            this.IbSo2.Name = "IbSo2";
            this.IbSo2.Size = new System.Drawing.Size(187, 165);
            this.IbSo2.TabIndex = 8;
            this.IbSo2.Text = "0";
            this.IbSo2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IbSo1
            // 
            this.IbSo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.IbSo1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.IbSo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IbSo1.Location = new System.Drawing.Point(140, 72);
            this.IbSo1.Name = "IbSo1";
            this.IbSo1.Size = new System.Drawing.Size(187, 165);
            this.IbSo1.TabIndex = 9;
            this.IbSo1.Text = "0";
            this.IbSo1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btExit
            // 
            this.btExit.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.Location = new System.Drawing.Point(508, 344);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(189, 67);
            this.btExit.TabIndex = 11;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // Random3Number
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 517);
            this.Controls.Add(this.IbScore);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btRandom);
            this.Controls.Add(this.IbSo3);
            this.Controls.Add(this.IbSo2);
            this.Controls.Add(this.IbSo1);
            this.Name = "Random3Number";
            this.Text = "Random3Number";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label IbScore;
        private System.Windows.Forms.Button btRandom;
        private System.Windows.Forms.Label IbSo3;
        private System.Windows.Forms.Label IbSo2;
        private System.Windows.Forms.Label IbSo1;
        private System.Windows.Forms.Button btExit;
    }
}