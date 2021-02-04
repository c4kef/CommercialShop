
namespace Client.UI.Other.UIComps
{
    partial class A_StatusSender
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(A_StatusSender));
            this.Elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.labelStatus = new Bunifu.UI.WinForms.BunifuLabel();
            this.iconStatus = new Bunifu.UI.WinForms.BunifuPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.iconStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // Elipse
            // 
            this.Elipse.ElipseRadius = 20;
            this.Elipse.TargetControl = this;
            // 
            // labelStatus
            // 
            this.labelStatus.AllowParentOverrides = false;
            this.labelStatus.AutoEllipsis = false;
            this.labelStatus.AutoSize = false;
            this.labelStatus.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelStatus.CursorType = System.Windows.Forms.Cursors.Default;
            this.labelStatus.Font = new System.Drawing.Font("Segoe UI", 17F);
            this.labelStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.labelStatus.Location = new System.Drawing.Point(3, 109);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelStatus.Size = new System.Drawing.Size(337, 31);
            this.labelStatus.TabIndex = 7;
            this.labelStatus.Text = "...";
            this.labelStatus.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelStatus.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // iconStatus
            // 
            this.iconStatus.AllowFocused = false;
            this.iconStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconStatus.AutoSizeHeight = false;
            this.iconStatus.BorderRadius = 0;
            this.iconStatus.Image = global::Client.Properties.Resources.fi_sr_cloud;
            this.iconStatus.IsCircle = false;
            this.iconStatus.Location = new System.Drawing.Point(132, 35);
            this.iconStatus.Name = "iconStatus";
            this.iconStatus.Size = new System.Drawing.Size(78, 78);
            this.iconStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconStatus.TabIndex = 0;
            this.iconStatus.TabStop = false;
            this.iconStatus.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Custom;
            // 
            // A_StatusSender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.iconStatus);
            this.Name = "A_StatusSender";
            this.Size = new System.Drawing.Size(337, 189);
            ((System.ComponentModel.ISupportInitialize)(this.iconStatus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse Elipse;
        private Bunifu.UI.WinForms.BunifuPictureBox iconStatus;
        private Bunifu.UI.WinForms.BunifuLabel labelStatus;
    }
}
