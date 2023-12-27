
namespace chuong3
{
    partial class triangle
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
            this.txtCanhA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCanhB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCanhC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btCheck = new System.Windows.Forms.Button();
            this.btDT = new System.Windows.Forms.Button();
            this.btChuVi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCanhA
            // 
            this.txtCanhA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCanhA.Location = new System.Drawing.Point(116, 133);
            this.txtCanhA.Name = "txtCanhA";
            this.txtCanhA.Size = new System.Drawing.Size(150, 31);
            this.txtCanhA.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cạnh A:";
            // 
            // txtCanhB
            // 
            this.txtCanhB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCanhB.Location = new System.Drawing.Point(369, 133);
            this.txtCanhB.Name = "txtCanhB";
            this.txtCanhB.Size = new System.Drawing.Size(150, 31);
            this.txtCanhB.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(274, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cạnh B:";
            // 
            // txtCanhC
            // 
            this.txtCanhC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCanhC.Location = new System.Drawing.Point(622, 133);
            this.txtCanhC.Name = "txtCanhC";
            this.txtCanhC.Size = new System.Drawing.Size(150, 31);
            this.txtCanhC.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(527, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Cạnh C:";
            // 
            // btCheck
            // 
            this.btCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCheck.Location = new System.Drawing.Point(324, 268);
            this.btCheck.Name = "btCheck";
            this.btCheck.Size = new System.Drawing.Size(151, 51);
            this.btCheck.TabIndex = 3;
            this.btCheck.Text = "Check";
            this.btCheck.UseVisualStyleBackColor = true;
            this.btCheck.Click += new System.EventHandler(this.btCheck_Click);
            // 
            // btDT
            // 
            this.btDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDT.Location = new System.Drawing.Point(116, 268);
            this.btDT.Name = "btDT";
            this.btDT.Size = new System.Drawing.Size(151, 51);
            this.btDT.TabIndex = 3;
            this.btDT.Text = "Diện tích";
            this.btDT.UseVisualStyleBackColor = true;
            this.btDT.Click += new System.EventHandler(this.btDT_Click);
            // 
            // btChuVi
            // 
            this.btChuVi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btChuVi.Location = new System.Drawing.Point(532, 268);
            this.btChuVi.Name = "btChuVi";
            this.btChuVi.Size = new System.Drawing.Size(151, 51);
            this.btChuVi.TabIndex = 3;
            this.btChuVi.Text = "Chu vi";
            this.btChuVi.UseVisualStyleBackColor = true;
            this.btChuVi.Click += new System.EventHandler(this.btChuVi_Click);
            // 
            // triangle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 587);
            this.Controls.Add(this.btChuVi);
            this.Controls.Add(this.btDT);
            this.Controls.Add(this.btCheck);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCanhC);
            this.Controls.Add(this.txtCanhB);
            this.Controls.Add(this.txtCanhA);
            this.Name = "triangle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "triangle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCanhA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCanhB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCanhC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btCheck;
        private System.Windows.Forms.Button btDT;
        private System.Windows.Forms.Button btChuVi;
    }
}