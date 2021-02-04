
namespace Client.UI.Other.UIComps
{
    partial class A_SendData
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(A_SendData));
            this.Elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.labelDataSend = new Bunifu.UI.WinForms.BunifuLabel();
            this.progressValue = new Bunifu.UI.WinForms.BunifuProgressBar();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Elipse
            // 
            this.Elipse.ElipseRadius = 20;
            this.Elipse.TargetControl = this;
            // 
            // labelDataSend
            // 
            this.labelDataSend.AllowParentOverrides = false;
            this.labelDataSend.AutoEllipsis = false;
            this.labelDataSend.AutoSize = false;
            this.labelDataSend.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelDataSend.CursorType = System.Windows.Forms.Cursors.Default;
            this.labelDataSend.Font = new System.Drawing.Font("Segoe UI", 17F);
            this.labelDataSend.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.labelDataSend.Location = new System.Drawing.Point(0, 46);
            this.labelDataSend.Name = "labelDataSend";
            this.labelDataSend.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelDataSend.Size = new System.Drawing.Size(337, 31);
            this.labelDataSend.TabIndex = 6;
            this.labelDataSend.Text = "...";
            this.labelDataSend.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDataSend.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // progressValue
            // 
            this.progressValue.AllowAnimations = false;
            this.progressValue.Animation = 0;
            this.progressValue.AnimationSpeed = 220;
            this.progressValue.AnimationStep = 10;
            this.progressValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.progressValue.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("progressValue.BackgroundImage")));
            this.progressValue.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.progressValue.BorderRadius = 9;
            this.progressValue.BorderThickness = 1;
            this.progressValue.Location = new System.Drawing.Point(26, 97);
            this.progressValue.Maximum = 100;
            this.progressValue.MaximumValue = 100;
            this.progressValue.Minimum = 0;
            this.progressValue.MinimumValue = 0;
            this.progressValue.Name = "progressValue";
            this.progressValue.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.progressValue.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.progressValue.ProgressColorLeft = System.Drawing.Color.DodgerBlue;
            this.progressValue.ProgressColorRight = System.Drawing.Color.DodgerBlue;
            this.progressValue.Size = new System.Drawing.Size(285, 16);
            this.progressValue.TabIndex = 7;
            this.progressValue.Value = 0;
            this.progressValue.ValueByTransition = 0;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 30;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // A_SendData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.Controls.Add(this.progressValue);
            this.Controls.Add(this.labelDataSend);
            this.Name = "A_SendData";
            this.Size = new System.Drawing.Size(337, 189);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse Elipse;
        public Bunifu.UI.WinForms.BunifuLabel labelDataSend;
        private Bunifu.UI.WinForms.BunifuProgressBar progressValue;
        private System.Windows.Forms.Timer timer;
    }
}
