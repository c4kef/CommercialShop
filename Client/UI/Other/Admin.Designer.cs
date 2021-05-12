
namespace Client.UI.Other
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.userName = new Bunifu.UI.WinForms.BunifuLabel();
            this.firstStep = new Bunifu.UI.WinForms.BunifuShapes();
            this.secondStep = new Bunifu.UI.WinForms.BunifuShapes();
            this.thirdStep = new Bunifu.UI.WinForms.BunifuShapes();
            this.bunifuSeparator2 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.userImage = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.hideBtn = new Bunifu.UI.WinForms.BunifuSeparator();
            this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.a_StatusSender1 = new Client.UI.Other.UIComps.A_StatusSender();
            this.a_SendData1 = new Client.UI.Other.UIComps.A_SendData();
            this.a_Mail1 = new Client.UI.Other.UIComps.A_Mail();
            this.a_ChooseStore1 = new Client.UI.Other.UIComps.A_ChooseStore();
            this.a_Account1 = new Client.UI.Other.UIComps.A_Account();
            ((System.ComponentModel.ISupportInitialize)(this.userImage)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
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
            this.userName.Location = new System.Drawing.Point(1, 93);
            this.userName.Name = "userName";
            this.userName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.userName.Size = new System.Drawing.Size(604, 31);
            this.userName.TabIndex = 5;
            this.userName.Text = "...";
            this.userName.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.userName.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // firstStep
            // 
            this.firstStep.Angle = 0F;
            this.firstStep.BackColor = System.Drawing.Color.Transparent;
            this.firstStep.BorderColor = System.Drawing.Color.White;
            this.firstStep.BorderThickness = 2;
            this.firstStep.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(223)))));
            this.firstStep.FillShape = true;
            this.firstStep.Location = new System.Drawing.Point(12, 135);
            this.firstStep.Name = "firstStep";
            this.firstStep.Shape = Bunifu.UI.WinForms.BunifuShapes.Shapes.Circle;
            this.firstStep.Sides = 5;
            this.firstStep.Size = new System.Drawing.Size(21, 21);
            this.firstStep.TabIndex = 6;
            this.firstStep.Text = "bunifuShapes1";
            this.firstStep.Click += new System.EventHandler(this.firstStep_Click);
            // 
            // secondStep
            // 
            this.secondStep.Angle = 0F;
            this.secondStep.BackColor = System.Drawing.Color.Transparent;
            this.secondStep.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.secondStep.BorderThickness = 2;
            this.secondStep.FillColor = System.Drawing.Color.Transparent;
            this.secondStep.FillShape = true;
            this.secondStep.Location = new System.Drawing.Point(12, 199);
            this.secondStep.Name = "secondStep";
            this.secondStep.Shape = Bunifu.UI.WinForms.BunifuShapes.Shapes.Circle;
            this.secondStep.Sides = 5;
            this.secondStep.Size = new System.Drawing.Size(21, 21);
            this.secondStep.TabIndex = 8;
            this.secondStep.Text = "bunifuShapes2";
            this.secondStep.Click += new System.EventHandler(this.secondStep_Click);
            // 
            // thirdStep
            // 
            this.thirdStep.Angle = 0F;
            this.thirdStep.BackColor = System.Drawing.Color.Transparent;
            this.thirdStep.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.thirdStep.BorderThickness = 2;
            this.thirdStep.FillColor = System.Drawing.Color.Transparent;
            this.thirdStep.FillShape = true;
            this.thirdStep.Location = new System.Drawing.Point(12, 263);
            this.thirdStep.Name = "thirdStep";
            this.thirdStep.Shape = Bunifu.UI.WinForms.BunifuShapes.Shapes.Circle;
            this.thirdStep.Sides = 5;
            this.thirdStep.Size = new System.Drawing.Size(21, 21);
            this.thirdStep.TabIndex = 10;
            this.thirdStep.Text = "bunifuShapes3";
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator2.BackgroundImage")));
            this.bunifuSeparator2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator2.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.White;
            this.bunifuSeparator2.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(12, 220);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Vertical;
            this.bunifuSeparator2.Size = new System.Drawing.Size(21, 46);
            this.bunifuSeparator2.TabIndex = 9;
            // 
            // userImage
            // 
            this.userImage.AllowFocused = false;
            this.userImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userImage.AutoSizeHeight = true;
            this.userImage.BorderRadius = 37;
            this.userImage.Image = ((System.Drawing.Image)(resources.GetObject("userImage.Image")));
            this.userImage.IsCircle = true;
            this.userImage.Location = new System.Drawing.Point(269, 13);
            this.userImage.Name = "userImage";
            this.userImage.Size = new System.Drawing.Size(75, 75);
            this.userImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userImage.TabIndex = 4;
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
            this.hideBtn.Location = new System.Drawing.Point(566, 13);
            this.hideBtn.Name = "hideBtn";
            this.hideBtn.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.hideBtn.Size = new System.Drawing.Size(23, 21);
            this.hideBtn.TabIndex = 3;
            this.hideBtn.Click += new System.EventHandler(this.hideBtn_Click);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator1.BackgroundImage")));
            this.bunifuSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator1.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.White;
            this.bunifuSeparator1.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(12, 156);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Vertical;
            this.bunifuSeparator1.Size = new System.Drawing.Size(21, 46);
            this.bunifuSeparator1.TabIndex = 7;
            // 
            // a_StatusSender1
            // 
            this.a_StatusSender1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.a_StatusSender1.Location = new System.Drawing.Point(137, 152);
            this.a_StatusSender1.Name = "a_StatusSender1";
            this.a_StatusSender1.Size = new System.Drawing.Size(337, 189);
            this.a_StatusSender1.TabIndex = 15;
            this.a_StatusSender1.Visible = false;
            // 
            // a_SendData1
            // 
            this.a_SendData1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.a_SendData1.Location = new System.Drawing.Point(137, 152);
            this.a_SendData1.Name = "a_SendData1";
            this.a_SendData1.Size = new System.Drawing.Size(337, 189);
            this.a_SendData1.TabIndex = 14;
            this.a_SendData1.Visible = false;
            // 
            // a_Mail1
            // 
            this.a_Mail1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.a_Mail1.Location = new System.Drawing.Point(137, 152);
            this.a_Mail1.Name = "a_Mail1";
            this.a_Mail1.Size = new System.Drawing.Size(337, 189);
            this.a_Mail1.TabIndex = 13;
            this.a_Mail1.Visible = false;
            // 
            // a_ChooseStore1
            // 
            this.a_ChooseStore1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.a_ChooseStore1.Location = new System.Drawing.Point(137, 152);
            this.a_ChooseStore1.Name = "a_ChooseStore1";
            this.a_ChooseStore1.Size = new System.Drawing.Size(337, 189);
            this.a_ChooseStore1.TabIndex = 12;
            this.a_ChooseStore1.Visible = false;
            // 
            // a_Account1
            // 
            this.a_Account1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.a_Account1.Location = new System.Drawing.Point(137, 152);
            this.a_Account1.Name = "a_Account1";
            this.a_Account1.Size = new System.Drawing.Size(337, 189);
            this.a_Account1.TabIndex = 11;
            this.a_Account1.Visible = false;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(605, 420);
            this.Controls.Add(this.a_StatusSender1);
            this.Controls.Add(this.a_SendData1);
            this.Controls.Add(this.a_Mail1);
            this.Controls.Add(this.a_ChooseStore1);
            this.Controls.Add(this.a_Account1);
            this.Controls.Add(this.thirdStep);
            this.Controls.Add(this.secondStep);
            this.Controls.Add(this.bunifuSeparator2);
            this.Controls.Add(this.firstStep);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.userImage);
            this.Controls.Add(this.hideBtn);
            this.Controls.Add(this.bunifuSeparator1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "...";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Admin_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.userImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuLabel userName;
        private Bunifu.UI.WinForms.BunifuPictureBox userImage;
        public Bunifu.UI.WinForms.BunifuSeparator hideBtn;
        private Bunifu.UI.WinForms.BunifuShapes thirdStep;
        private Bunifu.UI.WinForms.BunifuShapes secondStep;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator2;
        private Bunifu.UI.WinForms.BunifuShapes firstStep;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1;
        public UIComps.A_Account a_Account1;
        public UIComps.A_ChooseStore a_ChooseStore1;
        public UIComps.A_Mail a_Mail1;
        public UIComps.A_SendData a_SendData1;
        public UIComps.A_StatusSender a_StatusSender1;
    }
}