
namespace Client.UI.Other
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.FormBG = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.userName = new Bunifu.UI.WinForms.BunifuLabel();
            this.notify = new System.Windows.Forms.NotifyIcon(this.components);
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.btnConnection = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnInfo = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnActivation = new Bunifu.UI.WinForms.BunifuImageButton();
            this.userImage = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.hideBtn = new Bunifu.UI.WinForms.BunifuSeparator();
            this.awake1 = new Client.UI.Awake();
            this.activation1 = new Client.UI.Activation();
            this.info1 = new Client.UI.Info();
            this.connection1 = new Client.UI.Connection();
            this.bunifuPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userImage)).BeginInit();
            this.SuspendLayout();
            // 
            // FormBG
            // 
            this.FormBG.ElipseRadius = 10;
            this.FormBG.TargetControl = this;
            // 
            // userName
            // 
            this.userName.AllowParentOverrides = false;
            this.userName.AutoEllipsis = false;
            this.userName.AutoSize = false;
            this.userName.Cursor = System.Windows.Forms.Cursors.Default;
            this.userName.CursorType = System.Windows.Forms.Cursors.Default;
            this.userName.Font = new System.Drawing.Font("Segoe UI", 17F);
            this.userName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.userName.Location = new System.Drawing.Point(1, 92);
            this.userName.Name = "userName";
            this.userName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.userName.Size = new System.Drawing.Size(604, 31);
            this.userName.TabIndex = 2;
            this.userName.Text = "...";
            this.userName.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.userName.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // notify
            // 
            this.notify.BalloonTipText = "Активатор скрыт в трей, Вы всегда можете его открыть и продолжить работу.";
            this.notify.BalloonTipTitle = "Информация";
            this.notify.Icon = ((System.Drawing.Icon)(resources.GetObject("notify.Icon")));
            this.notify.Text = "Активатор";
            this.notify.Visible = true;
            this.notify.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notify_MouseDoubleClick);
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.White;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 30;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.btnConnection);
            this.bunifuPanel1.Controls.Add(this.btnInfo);
            this.bunifuPanel1.Controls.Add(this.btnActivation);
            this.bunifuPanel1.Location = new System.Drawing.Point(167, 354);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(270, 54);
            this.bunifuPanel1.TabIndex = 3;
            // 
            // btnConnection
            // 
            this.btnConnection.ActiveImage = null;
            this.btnConnection.AllowAnimations = true;
            this.btnConnection.AllowBuffering = false;
            this.btnConnection.AllowToggling = false;
            this.btnConnection.AllowZooming = true;
            this.btnConnection.AllowZoomingOnFocus = false;
            this.btnConnection.BackColor = System.Drawing.Color.White;
            this.btnConnection.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnConnection.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnConnection.ErrorImage")));
            this.btnConnection.FadeWhenInactive = false;
            this.btnConnection.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnConnection.Image = ((System.Drawing.Image)(resources.GetObject("btnConnection.Image")));
            this.btnConnection.ImageActive = null;
            this.btnConnection.ImageLocation = null;
            this.btnConnection.ImageMargin = 10;
            this.btnConnection.ImageSize = new System.Drawing.Size(30, 30);
            this.btnConnection.ImageZoomSize = new System.Drawing.Size(40, 40);
            this.btnConnection.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnConnection.InitialImage")));
            this.btnConnection.Location = new System.Drawing.Point(203, 8);
            this.btnConnection.Name = "btnConnection";
            this.btnConnection.Rotation = 0;
            this.btnConnection.ShowActiveImage = true;
            this.btnConnection.ShowCursorChanges = true;
            this.btnConnection.ShowImageBorders = true;
            this.btnConnection.ShowSizeMarkers = false;
            this.btnConnection.Size = new System.Drawing.Size(40, 40);
            this.btnConnection.TabIndex = 7;
            this.btnConnection.ToolTipText = "";
            this.btnConnection.WaitOnLoad = false;
            this.btnConnection.Zoom = 10;
            this.btnConnection.ZoomSpeed = 10;
            this.btnConnection.Click += new System.EventHandler(this.btnConnection_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.ActiveImage = null;
            this.btnInfo.AllowAnimations = true;
            this.btnInfo.AllowBuffering = false;
            this.btnInfo.AllowToggling = false;
            this.btnInfo.AllowZooming = true;
            this.btnInfo.AllowZoomingOnFocus = false;
            this.btnInfo.BackColor = System.Drawing.Color.White;
            this.btnInfo.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnInfo.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnInfo.ErrorImage")));
            this.btnInfo.FadeWhenInactive = false;
            this.btnInfo.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnInfo.Image")));
            this.btnInfo.ImageActive = null;
            this.btnInfo.ImageLocation = null;
            this.btnInfo.ImageMargin = 10;
            this.btnInfo.ImageSize = new System.Drawing.Size(30, 30);
            this.btnInfo.ImageZoomSize = new System.Drawing.Size(40, 40);
            this.btnInfo.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnInfo.InitialImage")));
            this.btnInfo.Location = new System.Drawing.Point(112, 8);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Rotation = 0;
            this.btnInfo.ShowActiveImage = true;
            this.btnInfo.ShowCursorChanges = true;
            this.btnInfo.ShowImageBorders = true;
            this.btnInfo.ShowSizeMarkers = false;
            this.btnInfo.Size = new System.Drawing.Size(40, 40);
            this.btnInfo.TabIndex = 6;
            this.btnInfo.ToolTipText = "";
            this.btnInfo.WaitOnLoad = false;
            this.btnInfo.Zoom = 10;
            this.btnInfo.ZoomSpeed = 10;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnActivation
            // 
            this.btnActivation.ActiveImage = null;
            this.btnActivation.AllowAnimations = true;
            this.btnActivation.AllowBuffering = false;
            this.btnActivation.AllowToggling = false;
            this.btnActivation.AllowZooming = true;
            this.btnActivation.AllowZoomingOnFocus = false;
            this.btnActivation.BackColor = System.Drawing.Color.White;
            this.btnActivation.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnActivation.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnActivation.ErrorImage")));
            this.btnActivation.FadeWhenInactive = false;
            this.btnActivation.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnActivation.Image = ((System.Drawing.Image)(resources.GetObject("btnActivation.Image")));
            this.btnActivation.ImageActive = null;
            this.btnActivation.ImageLocation = null;
            this.btnActivation.ImageMargin = 10;
            this.btnActivation.ImageSize = new System.Drawing.Size(30, 30);
            this.btnActivation.ImageZoomSize = new System.Drawing.Size(40, 40);
            this.btnActivation.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnActivation.InitialImage")));
            this.btnActivation.Location = new System.Drawing.Point(25, 8);
            this.btnActivation.Name = "btnActivation";
            this.btnActivation.Rotation = 0;
            this.btnActivation.ShowActiveImage = true;
            this.btnActivation.ShowCursorChanges = true;
            this.btnActivation.ShowImageBorders = true;
            this.btnActivation.ShowSizeMarkers = false;
            this.btnActivation.Size = new System.Drawing.Size(40, 40);
            this.btnActivation.TabIndex = 5;
            this.btnActivation.ToolTipText = "";
            this.btnActivation.WaitOnLoad = false;
            this.btnActivation.Zoom = 10;
            this.btnActivation.ZoomSpeed = 10;
            this.btnActivation.Click += new System.EventHandler(this.btnActivation_Click);
            // 
            // userImage
            // 
            this.userImage.AllowFocused = false;
            this.userImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userImage.AutoSizeHeight = true;
            this.userImage.BorderRadius = 37;
            this.userImage.Image = ((System.Drawing.Image)(resources.GetObject("userImage.Image")));
            this.userImage.IsCircle = true;
            this.userImage.Location = new System.Drawing.Point(269, 12);
            this.userImage.Name = "userImage";
            this.userImage.Size = new System.Drawing.Size(75, 75);
            this.userImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userImage.TabIndex = 1;
            this.userImage.TabStop = false;
            this.userImage.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // hideBtn
            // 
            this.hideBtn.BackColor = System.Drawing.Color.Transparent;
            this.hideBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hideBtn.BackgroundImage")));
            this.hideBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hideBtn.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.hideBtn.LineColor = System.Drawing.Color.White;
            this.hideBtn.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.hideBtn.LineThickness = 2;
            this.hideBtn.Location = new System.Drawing.Point(566, 12);
            this.hideBtn.Name = "hideBtn";
            this.hideBtn.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.hideBtn.Size = new System.Drawing.Size(23, 21);
            this.hideBtn.TabIndex = 0;
            this.hideBtn.Click += new System.EventHandler(this.hideBtn_Click);
            // 
            // awake1
            // 
            this.awake1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.awake1.Location = new System.Drawing.Point(132, 148);
            this.awake1.Name = "awake1";
            this.awake1.Size = new System.Drawing.Size(337, 189);
            this.awake1.TabIndex = 7;
            // 
            // activation1
            // 
            this.activation1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.activation1.Location = new System.Drawing.Point(132, 148);
            this.activation1.Name = "activation1";
            this.activation1.Size = new System.Drawing.Size(337, 189);
            this.activation1.TabIndex = 4;
            this.activation1.Visible = false;
            // 
            // info1
            // 
            this.info1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.info1.Location = new System.Drawing.Point(132, 148);
            this.info1.Name = "info1";
            this.info1.Size = new System.Drawing.Size(337, 189);
            this.info1.TabIndex = 6;
            this.info1.Visible = false;
            // 
            // connection1
            // 
            this.connection1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.connection1.Location = new System.Drawing.Point(132, 148);
            this.connection1.Name = "connection1";
            this.connection1.Size = new System.Drawing.Size(337, 189);
            this.connection1.TabIndex = 5;
            this.connection1.Visible = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(605, 420);
            this.Controls.Add(this.awake1);
            this.Controls.Add(this.activation1);
            this.Controls.Add(this.bunifuPanel1);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.userImage);
            this.Controls.Add(this.hideBtn);
            this.Controls.Add(this.info1);
            this.Controls.Add(this.connection1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "...";
            this.Load += new System.EventHandler(this.Main_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.bunifuPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse FormBG;
        public System.Windows.Forms.NotifyIcon notify;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        public Bunifu.UI.WinForms.BunifuImageButton btnConnection;
        public Bunifu.UI.WinForms.BunifuImageButton btnInfo;
        public Bunifu.UI.WinForms.BunifuImageButton btnActivation;
        public Bunifu.UI.WinForms.BunifuLabel userName;
        private Bunifu.UI.WinForms.BunifuPictureBox userImage;
        public Bunifu.UI.WinForms.BunifuSeparator hideBtn;
        public Awake awake1;
        public Activation activation1;
        public Info info1;
        public Connection connection1;
    }
}

