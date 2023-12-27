
namespace chuong5
{
    partial class GameTangBong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameTangBong));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pillow = new System.Windows.Forms.PictureBox();
            this.cat = new System.Windows.Forms.PictureBox();
            this.lbToaDo = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pillow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cat)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pillow
            // 
            this.pillow.Image = global::chuong5.Properties.Resources._5a38229fbf78a7_3322606515136283197843;
            this.pillow.Location = new System.Drawing.Point(249, 556);
            this.pillow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pillow.Name = "pillow";
            this.pillow.Size = new System.Drawing.Size(400, 123);
            this.pillow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pillow.TabIndex = 1;
            this.pillow.TabStop = false;
            // 
            // cat
            // 
            this.cat.Image = ((System.Drawing.Image)(resources.GetObject("cat.Image")));
            this.cat.Location = new System.Drawing.Point(297, 89);
            this.cat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cat.Name = "cat";
            this.cat.Size = new System.Drawing.Size(133, 123);
            this.cat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cat.TabIndex = 0;
            this.cat.TabStop = false;
            // 
            // lbToaDo
            // 
            this.lbToaDo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbToaDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbToaDo.Location = new System.Drawing.Point(1, 11);
            this.lbToaDo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbToaDo.Name = "lbToaDo";
            this.lbToaDo.Size = new System.Drawing.Size(351, 57);
            this.lbToaDo.TabIndex = 2;
            this.lbToaDo.Text = "Bấm S để bắt đầu";
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // GameTangBong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 814);
            this.Controls.Add(this.lbToaDo);
            this.Controls.Add(this.pillow);
            this.Controls.Add(this.cat);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GameTangBong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameTangBong";
            this.Load += new System.EventHandler(this.GameTangBong_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameTangBong_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pillow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox cat;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pillow;
        private System.Windows.Forms.Label lbToaDo;
        private System.Windows.Forms.Timer timer2;
    }
}