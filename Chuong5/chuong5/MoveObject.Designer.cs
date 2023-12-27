
namespace chuong5
{
    partial class MoveObject
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
            this.pnBounds = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pnBounds
            // 
            this.pnBounds.AutoScroll = true;
            this.pnBounds.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnBounds.Location = new System.Drawing.Point(588, 33);
            this.pnBounds.Name = "pnBounds";
            this.pnBounds.Size = new System.Drawing.Size(200, 500);
            this.pnBounds.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 516);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // MoveObject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 568);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnBounds);
            this.Name = "MoveObject";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MoveObject_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MoveObject_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnBounds;
        private System.Windows.Forms.Label label1;
    }
}

