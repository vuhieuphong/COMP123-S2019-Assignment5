namespace COMP123_S2019_Assignment5
{
    partial class SplashScreen
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
            this.SplashTimer = new System.Windows.Forms.Timer(this.components);
            this.SplashProgressBar = new System.Windows.Forms.ProgressBar();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.SplashLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SplashTimer
            // 
            this.SplashTimer.Interval = 3000;
            this.SplashTimer.Tick += new System.EventHandler(this.SplashTimer_Tick);
            // 
            // SplashProgressBar
            // 
            this.SplashProgressBar.Location = new System.Drawing.Point(156, 509);
            this.SplashProgressBar.MarqueeAnimationSpeed = 5;
            this.SplashProgressBar.Name = "SplashProgressBar";
            this.SplashProgressBar.Size = new System.Drawing.Size(468, 39);
            this.SplashProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.SplashProgressBar.TabIndex = 0;
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.Image = global::COMP123_S2019_Assignment5.Properties.Resources.computer_repair_489081568_5783c94e3df78c1e1f3e8664;
            this.LogoPictureBox.Location = new System.Drawing.Point(35, 126);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(702, 358);
            this.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoPictureBox.TabIndex = 1;
            this.LogoPictureBox.TabStop = false;
            // 
            // SplashLabel
            // 
            this.SplashLabel.AutoSize = true;
            this.SplashLabel.Font = new System.Drawing.Font("Arial", 30F);
            this.SplashLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SplashLabel.Location = new System.Drawing.Point(235, 439);
            this.SplashLabel.Name = "SplashLabel";
            this.SplashLabel.Size = new System.Drawing.Size(307, 45);
            this.SplashLabel.TabIndex = 2;
            this.SplashLabel.Text = "Dollar Computer";
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.ControlBox = false;
            this.Controls.Add(this.SplashLabel);
            this.Controls.Add(this.LogoPictureBox);
            this.Controls.Add(this.SplashProgressBar);
            this.Font = new System.Drawing.Font("Arial", 20F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "SplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splash Screen";
            this.Load += new System.EventHandler(this.SplashScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer SplashTimer;
        private System.Windows.Forms.ProgressBar SplashProgressBar;
        private System.Windows.Forms.PictureBox LogoPictureBox;
        private System.Windows.Forms.Label SplashLabel;
    }
}