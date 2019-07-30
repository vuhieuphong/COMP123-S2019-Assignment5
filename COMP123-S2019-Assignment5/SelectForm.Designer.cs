namespace COMP123_S2019_Assignment5
{
    partial class SelectForm
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
            this.SelectLabel = new System.Windows.Forms.Label();
            this.HardwareSelectGridView = new System.Windows.Forms.DataGridView();
            this.YourSelectionLabel = new System.Windows.Forms.Label();
            this.SelectedHardwareTextBox = new System.Windows.Forms.TextBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.HardwareSelectGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SelectLabel
            // 
            this.SelectLabel.AutoSize = true;
            this.SelectLabel.Font = new System.Drawing.Font("Arial", 20F);
            this.SelectLabel.Location = new System.Drawing.Point(17, 9);
            this.SelectLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.SelectLabel.Name = "SelectLabel";
            this.SelectLabel.Size = new System.Drawing.Size(286, 32);
            this.SelectLabel.TabIndex = 0;
            this.SelectLabel.Text = "Select Your Hardware:";
            // 
            // HardwareSelectGridView
            // 
            this.HardwareSelectGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HardwareSelectGridView.Location = new System.Drawing.Point(23, 44);
            this.HardwareSelectGridView.Name = "HardwareSelectGridView";
            this.HardwareSelectGridView.ReadOnly = true;
            this.HardwareSelectGridView.Size = new System.Drawing.Size(731, 394);
            this.HardwareSelectGridView.TabIndex = 1;
            // 
            // YourSelectionLabel
            // 
            this.YourSelectionLabel.BackColor = System.Drawing.SystemColors.Control;
            this.YourSelectionLabel.Font = new System.Drawing.Font("Arial", 18F);
            this.YourSelectionLabel.Location = new System.Drawing.Point(12, 463);
            this.YourSelectionLabel.Name = "YourSelectionLabel";
            this.YourSelectionLabel.Size = new System.Drawing.Size(175, 37);
            this.YourSelectionLabel.TabIndex = 2;
            this.YourSelectionLabel.Text = "Your Selection:";
            // 
            // SelectedHardwareTextBox
            // 
            this.SelectedHardwareTextBox.BackColor = System.Drawing.Color.White;
            this.SelectedHardwareTextBox.Font = new System.Drawing.Font("Arial", 18F);
            this.SelectedHardwareTextBox.Location = new System.Drawing.Point(189, 463);
            this.SelectedHardwareTextBox.Name = "SelectedHardwareTextBox";
            this.SelectedHardwareTextBox.ReadOnly = true;
            this.SelectedHardwareTextBox.Size = new System.Drawing.Size(565, 35);
            this.SelectedHardwareTextBox.TabIndex = 3;
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Arial", 18F);
            this.CancelButton.Location = new System.Drawing.Point(429, 511);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(112, 38);
            this.CancelButton.TabIndex = 4;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Font = new System.Drawing.Font("Arial", 18F);
            this.NextButton.Location = new System.Drawing.Point(573, 511);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(112, 38);
            this.NextButton.TabIndex = 5;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // SelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.ControlBox = false;
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SelectedHardwareTextBox);
            this.Controls.Add(this.YourSelectionLabel);
            this.Controls.Add(this.HardwareSelectGridView);
            this.Controls.Add(this.SelectLabel);
            this.Font = new System.Drawing.Font("Arial", 20F);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "SelectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Form";
            ((System.ComponentModel.ISupportInitialize)(this.HardwareSelectGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SelectLabel;
        private System.Windows.Forms.DataGridView HardwareSelectGridView;
        private System.Windows.Forms.Label YourSelectionLabel;
        private System.Windows.Forms.TextBox SelectedHardwareTextBox;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button NextButton;
    }
}