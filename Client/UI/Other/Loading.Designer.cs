
namespace Client.UI.Other
{
    partial class Loading
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loading));
            this.Elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.userImage = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.labelInfo = new Bunifu.UI.WinForms.BunifuLabel();
            this.progressValue = new Bunifu.UI.WinForms.BunifuProgressBar();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.animateProgress = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.userImage)).BeginInit();
            this.bunifuPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Elipse
            // 
            this.Elipse.ElipseRadius = 20;
            this.Elipse.TargetControl = this;
            // 
            // userImage
            // 
            this.userImage.AllowFocused = false;
            this.userImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userImage.AutoSizeHeight = true;
            this.userImage.BorderRadius = 44;
            this.userImage.Image = global::Client.Properties.Resources.userImage;
            this.userImage.IsCircle = true;
            this.userImage.Location = new System.Drawing.Point(254, 8);
            this.userImage.Name = "userImage";
            this.userImage.Size = new System.Drawing.Size(88, 88);
            this.userImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userImage.TabIndex = 2;
            this.userImage.TabStop = false;
            this.userImage.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // labelInfo
            // 
            this.labelInfo.AllowParentOverrides = false;
            this.labelInfo.AutoEllipsis = false;
            this.labelInfo.AutoSize = false;
            this.labelInfo.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelInfo.CursorType = System.Windows.Forms.Cursors.Default;
            this.labelInfo.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.labelInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.labelInfo.Location = new System.Drawing.Point(28, 107);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelInfo.Size = new System.Drawing.Size(545, 154);
            this.labelInfo.TabIndex = 7;
            this.labelInfo.Text = "...";
            this.labelInfo.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.labelInfo.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // progressValue
            // 
            this.progressValue.AllowAnimations = false;
            this.progressValue.Animation = 0;
            this.progressValue.AnimationSpeed = 220;
            this.progressValue.AnimationStep = 10;
            this.progressValue.BackColor = System.Drawing.Color.White;
            this.progressValue.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("progressValue.BackgroundImage")));
            this.progressValue.BorderColor = System.Drawing.Color.White;
            this.progressValue.BorderRadius = 9;
            this.progressValue.BorderThickness = 1;
            this.progressValue.Location = new System.Drawing.Point(21, 282);
            this.progressValue.Maximum = 100;
            this.progressValue.MaximumValue = 100;
            this.progressValue.Minimum = 0;
            this.progressValue.MinimumValue = 0;
            this.progressValue.Name = "progressValue";
            this.progressValue.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.progressValue.ProgressBackColor = System.Drawing.Color.White;
            this.progressValue.ProgressColorLeft = System.Drawing.Color.DodgerBlue;
            this.progressValue.ProgressColorRight = System.Drawing.Color.DodgerBlue;
            this.progressValue.Size = new System.Drawing.Size(552, 13);
            this.progressValue.TabIndex = 8;
            this.progressValue.Value = 0;
            this.progressValue.ValueByTransition = 0;
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 50;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.labelInfo);
            this.bunifuPanel1.Controls.Add(this.progressValue);
            this.bunifuPanel1.Controls.Add(this.userImage);
            this.bunifuPanel1.Location = new System.Drawing.Point(300, 146);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = false;
            this.bunifuPanel1.Size = new System.Drawing.Size(595, 329);
            this.bunifuPanel1.TabIndex = 9;
            // 
            // animateProgress
            // 
            this.animateProgress.Enabled = true;
            this.animateProgress.Interval = 30;
            this.animateProgress.Tick += new System.EventHandler(this.animateProgress_Tick);
            // 
            // Loading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.bunifuPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Loading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "...";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Loading_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userImage)).EndInit();
            this.bunifuPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse Elipse;
        private Bunifu.UI.WinForms.BunifuPictureBox userImage;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Bunifu.UI.WinForms.BunifuLabel labelInfo;
        public Bunifu.UI.WinForms.BunifuProgressBar progressValue;
        private System.Windows.Forms.Timer animateProgress;
    }
}