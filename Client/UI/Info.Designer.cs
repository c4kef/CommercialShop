
namespace Client.UI
{
    partial class Info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Info));
            this.Elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.labelInfo = new Bunifu.UI.WinForms.BunifuLabel();
            this.labelContacts = new Bunifu.UI.WinForms.BunifuLabel();
            this.iconStore = new Bunifu.UI.WinForms.BunifuPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.iconStore)).BeginInit();
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
            this.labelInfo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.labelInfo.Location = new System.Drawing.Point(3, 84);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelInfo.Size = new System.Drawing.Size(331, 53);
            this.labelInfo.TabIndex = 4;
            this.labelInfo.Text = "...";
            this.labelInfo.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.labelInfo.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // labelContacts
            // 
            this.labelContacts.AllowParentOverrides = false;
            this.labelContacts.AutoEllipsis = false;
            this.labelContacts.AutoSize = false;
            this.labelContacts.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelContacts.CursorType = System.Windows.Forms.Cursors.Default;
            this.labelContacts.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelContacts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.labelContacts.Location = new System.Drawing.Point(0, 164);
            this.labelContacts.Name = "labelContacts";
            this.labelContacts.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelContacts.Size = new System.Drawing.Size(331, 22);
            this.labelContacts.TabIndex = 5;
            this.labelContacts.Text = "...";
            this.labelContacts.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.labelContacts.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // iconStore
            // 
            this.iconStore.AllowFocused = false;
            this.iconStore.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconStore.AutoSizeHeight = false;
            this.iconStore.BorderRadius = 0;
            this.iconStore.IsCircle = false;
            this.iconStore.Location = new System.Drawing.Point(134, 3);
            this.iconStore.Name = "iconStore";
            this.iconStore.Size = new System.Drawing.Size(75, 75);
            this.iconStore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconStore.TabIndex = 3;
            this.iconStore.TabStop = false;
            this.iconStore.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Custom;
            // 
            // Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.Controls.Add(this.labelContacts);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.iconStore);
            this.Name = "Info";
            this.Size = new System.Drawing.Size(337, 189);
            this.Load += new System.EventHandler(this.Info_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconStore)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse Elipse;
        public Bunifu.UI.WinForms.BunifuLabel labelInfo;
        private Bunifu.UI.WinForms.BunifuPictureBox iconStore;
        public Bunifu.UI.WinForms.BunifuLabel labelContacts;
    }
}
