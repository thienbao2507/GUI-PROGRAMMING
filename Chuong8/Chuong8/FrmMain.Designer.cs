
namespace Chuong8
{
    partial class FrmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDrawMouse = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDrawText = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDrawImage = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(739, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menu
            // 
            this.menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDrawMouse,
            this.menuDrawText,
            this.menuDrawImage,
            this.toolStripSeparator1,
            this.menuExit});
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(46, 26);
            this.menu.Text = "File";
            // 
            // menuDrawMouse
            // 
            this.menuDrawMouse.Name = "menuDrawMouse";
            this.menuDrawMouse.Size = new System.Drawing.Size(224, 26);
            this.menuDrawMouse.Text = "Draw By Mouse";
            // 
            // menuDrawText
            // 
            this.menuDrawText.Name = "menuDrawText";
            this.menuDrawText.Size = new System.Drawing.Size(224, 26);
            this.menuDrawText.Text = "Draw Text";
            this.menuDrawText.Click += new System.EventHandler(this.menuDrawText_Click);
            // 
            // menuDrawImage
            // 
            this.menuDrawImage.Name = "menuDrawImage";
            this.menuDrawImage.Size = new System.Drawing.Size(224, 26);
            this.menuDrawImage.Text = "Draw Image";
            this.menuDrawImage.Click += new System.EventHandler(this.menuDrawImage_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(221, 6);
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(224, 26);
            this.menuExit.Text = "Exit";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 558);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menu;
        private System.Windows.Forms.ToolStripMenuItem menuDrawMouse;
        private System.Windows.Forms.ToolStripMenuItem menuDrawText;
        private System.Windows.Forms.ToolStripMenuItem menuDrawImage;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
    }
}

