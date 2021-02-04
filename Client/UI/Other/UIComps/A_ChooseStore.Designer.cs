
namespace Client.UI.Other.UIComps
{
    partial class A_ChooseStore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(A_ChooseStore));
            this.Elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnNextStep = new Bunifu.UI.WinForms.BunifuImageButton();
            this.dropdownStore = new Bunifu.UI.WinForms.BunifuDropdown();
            this.SuspendLayout();
            // 
            // Elipse
            // 
            this.Elipse.ElipseRadius = 20;
            this.Elipse.TargetControl = this;
            // 
            // btnNextStep
            // 
            this.btnNextStep.ActiveImage = null;
            this.btnNextStep.AllowAnimations = true;
            this.btnNextStep.AllowBuffering = false;
            this.btnNextStep.AllowToggling = false;
            this.btnNextStep.AllowZooming = true;
            this.btnNextStep.AllowZoomingOnFocus = false;
            this.btnNextStep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnNextStep.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnNextStep.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnNextStep.ErrorImage")));
            this.btnNextStep.FadeWhenInactive = false;
            this.btnNextStep.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnNextStep.Image = global::Client.Properties.Resources.fi_sr_angle_down;
            this.btnNextStep.ImageActive = null;
            this.btnNextStep.ImageLocation = null;
            this.btnNextStep.ImageMargin = 10;
            this.btnNextStep.ImageSize = new System.Drawing.Size(47, 24);
            this.btnNextStep.ImageZoomSize = new System.Drawing.Size(57, 34);
            this.btnNextStep.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnNextStep.InitialImage")));
            this.btnNextStep.Location = new System.Drawing.Point(137, 122);
            this.btnNextStep.Name = "btnNextStep";
            this.btnNextStep.Rotation = 0;
            this.btnNextStep.ShowActiveImage = true;
            this.btnNextStep.ShowCursorChanges = true;
            this.btnNextStep.ShowImageBorders = true;
            this.btnNextStep.ShowSizeMarkers = false;
            this.btnNextStep.Size = new System.Drawing.Size(57, 34);
            this.btnNextStep.TabIndex = 20;
            this.btnNextStep.ToolTipText = "";
            this.btnNextStep.WaitOnLoad = false;
            this.btnNextStep.Zoom = 10;
            this.btnNextStep.ZoomSpeed = 10;
            this.btnNextStep.Click += new System.EventHandler(this.btnNextStep_Click);
            // 
            // dropdownStore
            // 
            this.dropdownStore.BackColor = System.Drawing.Color.Transparent;
            this.dropdownStore.BackgroundColor = System.Drawing.Color.White;
            this.dropdownStore.BorderColor = System.Drawing.Color.Transparent;
            this.dropdownStore.BorderRadius = 8;
            this.dropdownStore.Color = System.Drawing.Color.Transparent;
            this.dropdownStore.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.dropdownStore.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dropdownStore.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.dropdownStore.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dropdownStore.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.dropdownStore.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.dropdownStore.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.dropdownStore.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.dropdownStore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropdownStore.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.dropdownStore.FillDropDown = true;
            this.dropdownStore.FillIndicator = false;
            this.dropdownStore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dropdownStore.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dropdownStore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.dropdownStore.FormattingEnabled = true;
            this.dropdownStore.Icon = null;
            this.dropdownStore.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.dropdownStore.IndicatorColor = System.Drawing.Color.Gray;
            this.dropdownStore.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.dropdownStore.ItemBackColor = System.Drawing.Color.White;
            this.dropdownStore.ItemBorderColor = System.Drawing.Color.White;
            this.dropdownStore.ItemForeColor = System.Drawing.Color.Black;
            this.dropdownStore.ItemHeight = 26;
            this.dropdownStore.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.dropdownStore.ItemHighLightForeColor = System.Drawing.Color.White;
            this.dropdownStore.Items.AddRange(new object[] {
            "Steam",
            "UPlay",
            "Origin",
            "EpicGames",
            "Microsoft"});
            this.dropdownStore.ItemTopMargin = 3;
            this.dropdownStore.Location = new System.Drawing.Point(38, 69);
            this.dropdownStore.Name = "dropdownStore";
            this.dropdownStore.Size = new System.Drawing.Size(260, 32);
            this.dropdownStore.TabIndex = 21;
            this.dropdownStore.Text = "...";
            this.dropdownStore.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.dropdownStore.TextLeftMargin = 5;
            // 
            // A_ChooseStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.Controls.Add(this.dropdownStore);
            this.Controls.Add(this.btnNextStep);
            this.Name = "A_ChooseStore";
            this.Size = new System.Drawing.Size(337, 189);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse Elipse;
        private Bunifu.UI.WinForms.BunifuImageButton btnNextStep;
        public Bunifu.UI.WinForms.BunifuDropdown dropdownStore;
    }
}
