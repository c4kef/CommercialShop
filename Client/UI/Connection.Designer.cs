
namespace Client.UI
{
    partial class Connection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Connection));
            this.Elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.labelInfo = new Bunifu.UI.WinForms.BunifuLabel();
            this.statusConnection = new Bunifu.UI.WinForms.BunifuPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.statusConnection)).BeginInit();
            this.SuspendLayout();
            // 
            // Elipse
            // 
            this.Elipse.ElipseRadius = 20;
            this.Elipse.TargetControl = this;
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
            this.labelInfo.Location = new System.Drawing.Point(6, 104);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelInfo.Size = new System.Drawing.Size(331, 36);
            this.labelInfo.TabIndex = 6;
            this.labelInfo.Text = "...";
            this.labelInfo.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelInfo.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // statusConnection
            // 
            this.statusConnection.AllowFocused = false;
            this.statusConnection.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.statusConnection.AutoSizeHeight = false;
            this.statusConnection.BorderRadius = 0;
            this.statusConnection.Image = global::Client.Properties.Resources.fi_sr_signal_alt;
            this.statusConnection.IsCircle = false;
            this.statusConnection.Location = new System.Drawing.Point(137, 23);
            this.statusConnection.Name = "statusConnection";
            this.statusConnection.Size = new System.Drawing.Size(75, 75);
            this.statusConnection.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.statusConnection.TabIndex = 5;
            this.statusConnection.TabStop = false;
            this.statusConnection.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Custom;
            // 
            // Connection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.statusConnection);
            this.Name = "Connection";
            this.Size = new System.Drawing.Size(337, 189);
            ((System.ComponentModel.ISupportInitialize)(this.statusConnection)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse Elipse;
        private Bunifu.UI.WinForms.BunifuLabel labelInfo;
        private Bunifu.UI.WinForms.BunifuPictureBox statusConnection;
    }
}
