
namespace Client.UI
{
    partial class Awake
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Awake));
            this.Elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pleaseWait = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuCircleProgress1 = new Bunifu.UI.WinForms.BunifuCircleProgress();
            this.SuspendLayout();
            // 
            // Elipse
            // 
            this.Elipse.ElipseRadius = 20;
            this.Elipse.TargetControl = this;
            // 
            // pleaseWait
            // 
            this.pleaseWait.AllowParentOverrides = false;
            this.pleaseWait.AutoEllipsis = false;
            this.pleaseWait.AutoSize = false;
            this.pleaseWait.Cursor = System.Windows.Forms.Cursors.Default;
            this.pleaseWait.CursorType = System.Windows.Forms.Cursors.Default;
            this.pleaseWait.Font = new System.Drawing.Font("Segoe UI", 17F);
            this.pleaseWait.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.pleaseWait.Location = new System.Drawing.Point(0, 28);
            this.pleaseWait.Name = "pleaseWait";
            this.pleaseWait.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pleaseWait.Size = new System.Drawing.Size(337, 31);
            this.pleaseWait.TabIndex = 3;
            this.pleaseWait.Text = "...";
            this.pleaseWait.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.pleaseWait.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuCircleProgress1
            // 
            this.bunifuCircleProgress1.Animated = true;
            this.bunifuCircleProgress1.AnimationInterval = 1;
            this.bunifuCircleProgress1.AnimationSpeed = 4;
            this.bunifuCircleProgress1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCircleProgress1.CircleMargin = 10;
            this.bunifuCircleProgress1.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F, System.Drawing.FontStyle.Bold);
            this.bunifuCircleProgress1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCircleProgress1.IsPercentage = true;
            this.bunifuCircleProgress1.LineProgressThickness = 10;
            this.bunifuCircleProgress1.LineThickness = 10;
            this.bunifuCircleProgress1.Location = new System.Drawing.Point(118, 65);
            this.bunifuCircleProgress1.Name = "bunifuCircleProgress1";
            this.bunifuCircleProgress1.ProgressAnimationSpeed = 200;
            this.bunifuCircleProgress1.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.bunifuCircleProgress1.ProgressColor = System.Drawing.Color.DodgerBlue;
            this.bunifuCircleProgress1.ProgressColor2 = System.Drawing.Color.DodgerBlue;
            this.bunifuCircleProgress1.ProgressEndCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Round;
            this.bunifuCircleProgress1.ProgressFillStyle = Bunifu.UI.WinForms.BunifuCircleProgress.FillStyles.Solid;
            this.bunifuCircleProgress1.ProgressStartCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Round;
            this.bunifuCircleProgress1.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 1F);
            this.bunifuCircleProgress1.Size = new System.Drawing.Size(104, 104);
            this.bunifuCircleProgress1.SubScriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.bunifuCircleProgress1.SubScriptMargin = new System.Windows.Forms.Padding(5, -20, 0, 0);
            this.bunifuCircleProgress1.SubScriptText = ".00";
            this.bunifuCircleProgress1.SuperScriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.bunifuCircleProgress1.SuperScriptMargin = new System.Windows.Forms.Padding(5, 50, 0, 0);
            this.bunifuCircleProgress1.SuperScriptText = "";
            this.bunifuCircleProgress1.TabIndex = 16;
            this.bunifuCircleProgress1.Text = "30";
            this.bunifuCircleProgress1.TextMargin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.bunifuCircleProgress1.Value = 30;
            this.bunifuCircleProgress1.ValueByTransition = 30;
            this.bunifuCircleProgress1.ValueMargin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            // 
            // Awake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.Controls.Add(this.bunifuCircleProgress1);
            this.Controls.Add(this.pleaseWait);
            this.Name = "Awake";
            this.Size = new System.Drawing.Size(337, 189);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse Elipse;
        public Bunifu.UI.WinForms.BunifuLabel pleaseWait;
        private Bunifu.UI.WinForms.BunifuCircleProgress bunifuCircleProgress1;
    }
}
