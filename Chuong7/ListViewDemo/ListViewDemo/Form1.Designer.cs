
namespace ListViewDemo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cbDiaChi = new System.Windows.Forms.ComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.txtFileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtLastAccess = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rTile = new System.Windows.Forms.RadioButton();
            this.rDetails = new System.Windows.Forms.RadioButton();
            this.rList = new System.Windows.Forms.RadioButton();
            this.rSmallIcon = new System.Windows.Forms.RadioButton();
            this.rLargeIcon = new System.Windows.Forms.RadioButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbDiaChi
            // 
            this.cbDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDiaChi.FormattingEnabled = true;
            this.cbDiaChi.Location = new System.Drawing.Point(16, 15);
            this.cbDiaChi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbDiaChi.Name = "cbDiaChi";
            this.cbDiaChi.Size = new System.Drawing.Size(336, 38);
            this.cbDiaChi.TabIndex = 0;
            this.cbDiaChi.SelectedIndexChanged += new System.EventHandler(this.cbDiaChi_SelectedIndexChanged);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.txtFileName,
            this.txtSize,
            this.txtLastAccess});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(20, 73);
            this.listView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(803, 494);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // txtFileName
            // 
            this.txtFileName.Text = "FileName";
            this.txtFileName.Width = 183;
            // 
            // txtSize
            // 
            this.txtSize.Text = "Size";
            this.txtSize.Width = 218;
            // 
            // txtLastAccess
            // 
            this.txtLastAccess.Text = "LastAccess";
            this.txtLastAccess.Width = 131;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rTile);
            this.groupBox1.Controls.Add(this.rDetails);
            this.groupBox1.Controls.Add(this.rList);
            this.groupBox1.Controls.Add(this.rSmallIcon);
            this.groupBox1.Controls.Add(this.rLargeIcon);
            this.groupBox1.Location = new System.Drawing.Point(848, 73);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(247, 494);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "View Mode";
            // 
            // rTile
            // 
            this.rTile.AutoSize = true;
            this.rTile.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rTile.Location = new System.Drawing.Point(27, 386);
            this.rTile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rTile.Name = "rTile";
            this.rTile.Size = new System.Drawing.Size(79, 35);
            this.rTile.TabIndex = 9;
            this.rTile.TabStop = true;
            this.rTile.Text = "Tile";
            this.rTile.UseVisualStyleBackColor = true;
            // 
            // rDetails
            // 
            this.rDetails.AutoSize = true;
            this.rDetails.Checked = true;
            this.rDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rDetails.Location = new System.Drawing.Point(27, 304);
            this.rDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rDetails.Name = "rDetails";
            this.rDetails.Size = new System.Drawing.Size(119, 35);
            this.rDetails.TabIndex = 8;
            this.rDetails.TabStop = true;
            this.rDetails.Text = "Details";
            this.rDetails.UseVisualStyleBackColor = true;
            // 
            // rList
            // 
            this.rList.AutoSize = true;
            this.rList.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rList.Location = new System.Drawing.Point(27, 223);
            this.rList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rList.Name = "rList";
            this.rList.Size = new System.Drawing.Size(78, 35);
            this.rList.TabIndex = 7;
            this.rList.TabStop = true;
            this.rList.Text = "List";
            this.rList.UseVisualStyleBackColor = true;
            // 
            // rSmallIcon
            // 
            this.rSmallIcon.AutoSize = true;
            this.rSmallIcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rSmallIcon.Location = new System.Drawing.Point(27, 140);
            this.rSmallIcon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rSmallIcon.Name = "rSmallIcon";
            this.rSmallIcon.Size = new System.Drawing.Size(154, 35);
            this.rSmallIcon.TabIndex = 6;
            this.rSmallIcon.TabStop = true;
            this.rSmallIcon.Text = "SmallIcon";
            this.rSmallIcon.UseVisualStyleBackColor = true;
            // 
            // rLargeIcon
            // 
            this.rLargeIcon.AutoSize = true;
            this.rLargeIcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rLargeIcon.Location = new System.Drawing.Point(27, 58);
            this.rLargeIcon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rLargeIcon.Name = "rLargeIcon";
            this.rLargeIcon.Size = new System.Drawing.Size(156, 35);
            this.rLargeIcon.TabIndex = 5;
            this.rLargeIcon.TabStop = true;
            this.rLargeIcon.Text = "LargeIcon";
            this.rLargeIcon.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "close.png");
            this.imageList1.Images.SetKeyName(1, "open.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 614);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.cbDiaChi);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "dg";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbDiaChi;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader txtFileName;
        private System.Windows.Forms.ColumnHeader txtSize;
        private System.Windows.Forms.ColumnHeader txtLastAccess;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rTile;
        private System.Windows.Forms.RadioButton rDetails;
        private System.Windows.Forms.RadioButton rList;
        private System.Windows.Forms.RadioButton rSmallIcon;
        private System.Windows.Forms.RadioButton rLargeIcon;
        private System.Windows.Forms.ImageList imageList1;
    }
}

