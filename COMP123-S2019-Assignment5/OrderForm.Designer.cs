namespace COMP123_S2019_Assignment5
{
    partial class OrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            this.OrderMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductPrintForm = new Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(this.components);
            this.BackButton = new System.Windows.Forms.Button();
            this.OrderCancelButton = new System.Windows.Forms.Button();
            this.FinishButton = new System.Windows.Forms.Button();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.PriceButton = new System.Windows.Forms.Button();
            this.SalesTaxButton = new System.Windows.Forms.Button();
            this.SalesTaxLabel = new System.Windows.Forms.Label();
            this.TotalPriceButton = new System.Windows.Forms.Button();
            this.TotalPriceLabel = new System.Windows.Forms.Label();
            this.YourPriceLineShape = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.YourPriceGroupBox = new System.Windows.Forms.GroupBox();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.ProductPictureBox = new System.Windows.Forms.PictureBox();
            this.SystemComponentsGroupBox = new System.Windows.Forms.GroupBox();
            this.CPUSpeedLabel = new System.Windows.Forms.Label();
            this.CPUNumberLabel = new System.Windows.Forms.Label();
            this.CPUTypeLabel = new System.Windows.Forms.Label();
            this.ScreenSizeLabel = new System.Windows.Forms.Label();
            this.DisplayTypeLabel = new System.Windows.Forms.Label();
            this.SystemComponentsButton = new System.Windows.Forms.Button();
            this.ModelButton = new System.Windows.Forms.Button();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.PlatformButton = new System.Windows.Forms.Button();
            this.PlatformLabel = new System.Windows.Forms.Label();
            this.ManufacturerButton = new System.Windows.Forms.Button();
            this.ManufacturerLabel = new System.Windows.Forms.Label();
            this.ConditionButton = new System.Windows.Forms.Button();
            this.ConditionLabel = new System.Windows.Forms.Label();
            this.HDDSizeLabel = new System.Windows.Forms.Label();
            this.HDDSpeedLabel = new System.Windows.Forms.Label();
            this.GPUTypeLabel = new System.Windows.Forms.Label();
            this.WebcamLabel = new System.Windows.Forms.Label();
            this.OSLabel = new System.Windows.Forms.Label();
            this.OrderMenuStrip.SuspendLayout();
            this.YourPriceGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductPictureBox)).BeginInit();
            this.SystemComponentsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // OrderMenuStrip
            // 
            this.OrderMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.OrderMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.OrderMenuStrip.Name = "OrderMenuStrip";
            this.OrderMenuStrip.Size = new System.Drawing.Size(984, 24);
            this.OrderMenuStrip.TabIndex = 0;
            this.OrderMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.backToolStripMenuItem.Text = "Back";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // ProductPrintForm
            // 
            this.ProductPrintForm.DocumentName = "document";
            this.ProductPrintForm.Form = this;
            this.ProductPrintForm.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter;
            this.ProductPrintForm.PrinterSettings = ((System.Drawing.Printing.PrinterSettings)(resources.GetObject("ProductPrintForm.PrinterSettings")));
            this.ProductPrintForm.PrintFileName = null;
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Arial", 20F);
            this.BackButton.Location = new System.Drawing.Point(556, 637);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(121, 44);
            this.BackButton.TabIndex = 1;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // OrderCancelButton
            // 
            this.OrderCancelButton.Font = new System.Drawing.Font("Arial", 20F);
            this.OrderCancelButton.Location = new System.Drawing.Point(704, 637);
            this.OrderCancelButton.Name = "OrderCancelButton";
            this.OrderCancelButton.Size = new System.Drawing.Size(121, 44);
            this.OrderCancelButton.TabIndex = 2;
            this.OrderCancelButton.Text = "Cancel";
            this.OrderCancelButton.UseVisualStyleBackColor = true;
            this.OrderCancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // FinishButton
            // 
            this.FinishButton.Font = new System.Drawing.Font("Arial", 20F);
            this.FinishButton.Location = new System.Drawing.Point(848, 637);
            this.FinishButton.Name = "FinishButton";
            this.FinishButton.Size = new System.Drawing.Size(121, 44);
            this.FinishButton.TabIndex = 3;
            this.FinishButton.Text = "Finish";
            this.FinishButton.UseVisualStyleBackColor = true;
            this.FinishButton.Click += new System.EventHandler(this.FinishButton_Click);
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Font = new System.Drawing.Font("Arial", 14F);
            this.PriceLabel.Location = new System.Drawing.Point(149, 39);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(59, 22);
            this.PriceLabel.TabIndex = 4;
            this.PriceLabel.Text = "Price:";
            // 
            // PriceButton
            // 
            this.PriceButton.BackColor = System.Drawing.Color.White;
            this.PriceButton.Enabled = false;
            this.PriceButton.Font = new System.Drawing.Font("Arial", 14F);
            this.PriceButton.Location = new System.Drawing.Point(248, 28);
            this.PriceButton.Name = "PriceButton";
            this.PriceButton.Size = new System.Drawing.Size(121, 33);
            this.PriceButton.TabIndex = 5;
            this.PriceButton.UseVisualStyleBackColor = false;
            // 
            // SalesTaxButton
            // 
            this.SalesTaxButton.BackColor = System.Drawing.Color.White;
            this.SalesTaxButton.Enabled = false;
            this.SalesTaxButton.Font = new System.Drawing.Font("Arial", 14F);
            this.SalesTaxButton.Location = new System.Drawing.Point(248, 83);
            this.SalesTaxButton.Name = "SalesTaxButton";
            this.SalesTaxButton.Size = new System.Drawing.Size(121, 33);
            this.SalesTaxButton.TabIndex = 7;
            this.SalesTaxButton.UseVisualStyleBackColor = false;
            // 
            // SalesTaxLabel
            // 
            this.SalesTaxLabel.AutoSize = true;
            this.SalesTaxLabel.Font = new System.Drawing.Font("Arial", 14F);
            this.SalesTaxLabel.Location = new System.Drawing.Point(55, 88);
            this.SalesTaxLabel.Name = "SalesTaxLabel";
            this.SalesTaxLabel.Size = new System.Drawing.Size(153, 22);
            this.SalesTaxLabel.TabIndex = 6;
            this.SalesTaxLabel.Text = "Sales Tax (13%):";
            // 
            // TotalPriceButton
            // 
            this.TotalPriceButton.BackColor = System.Drawing.Color.White;
            this.TotalPriceButton.Enabled = false;
            this.TotalPriceButton.Font = new System.Drawing.Font("Arial", 14F);
            this.TotalPriceButton.Location = new System.Drawing.Point(246, 159);
            this.TotalPriceButton.Name = "TotalPriceButton";
            this.TotalPriceButton.Size = new System.Drawing.Size(121, 33);
            this.TotalPriceButton.TabIndex = 9;
            this.TotalPriceButton.UseVisualStyleBackColor = false;
            // 
            // TotalPriceLabel
            // 
            this.TotalPriceLabel.AutoSize = true;
            this.TotalPriceLabel.Font = new System.Drawing.Font("Arial", 14F);
            this.TotalPriceLabel.Location = new System.Drawing.Point(104, 170);
            this.TotalPriceLabel.Name = "TotalPriceLabel";
            this.TotalPriceLabel.Size = new System.Drawing.Size(104, 22);
            this.TotalPriceLabel.TabIndex = 8;
            this.TotalPriceLabel.Text = "Total Price:";
            // 
            // YourPriceLineShape
            // 
            this.YourPriceLineShape.BorderWidth = 2;
            this.YourPriceLineShape.Name = "YourPriceLineShape";
            this.YourPriceLineShape.X1 = 23;
            this.YourPriceLineShape.X2 = 364;
            this.YourPriceLineShape.Y1 = 116;
            this.YourPriceLineShape.Y2 = 116;
            // 
            // YourPriceGroupBox
            // 
            this.YourPriceGroupBox.Controls.Add(this.TotalPriceButton);
            this.YourPriceGroupBox.Controls.Add(this.PriceButton);
            this.YourPriceGroupBox.Controls.Add(this.TotalPriceLabel);
            this.YourPriceGroupBox.Controls.Add(this.PriceLabel);
            this.YourPriceGroupBox.Controls.Add(this.SalesTaxButton);
            this.YourPriceGroupBox.Controls.Add(this.SalesTaxLabel);
            this.YourPriceGroupBox.Controls.Add(this.shapeContainer2);
            this.YourPriceGroupBox.Font = new System.Drawing.Font("Arial", 14F);
            this.YourPriceGroupBox.Location = new System.Drawing.Point(576, 361);
            this.YourPriceGroupBox.Name = "YourPriceGroupBox";
            this.YourPriceGroupBox.Size = new System.Drawing.Size(384, 223);
            this.YourPriceGroupBox.TabIndex = 11;
            this.YourPriceGroupBox.TabStop = false;
            this.YourPriceGroupBox.Text = "Your Price";
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(3, 25);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.YourPriceLineShape});
            this.shapeContainer2.Size = new System.Drawing.Size(378, 195);
            this.shapeContainer2.TabIndex = 10;
            this.shapeContainer2.TabStop = false;
            // 
            // ProductPictureBox
            // 
            this.ProductPictureBox.Location = new System.Drawing.Point(576, 82);
            this.ProductPictureBox.Name = "ProductPictureBox";
            this.ProductPictureBox.Size = new System.Drawing.Size(384, 235);
            this.ProductPictureBox.TabIndex = 12;
            this.ProductPictureBox.TabStop = false;
            // 
            // SystemComponentsGroupBox
            // 
            this.SystemComponentsGroupBox.Controls.Add(this.OSLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.WebcamLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.GPUTypeLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.HDDSpeedLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.HDDSizeLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.CPUSpeedLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.CPUNumberLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.CPUTypeLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.ScreenSizeLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.DisplayTypeLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.SystemComponentsButton);
            this.SystemComponentsGroupBox.Controls.Add(this.ModelButton);
            this.SystemComponentsGroupBox.Controls.Add(this.ModelLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.PlatformButton);
            this.SystemComponentsGroupBox.Controls.Add(this.PlatformLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.ManufacturerButton);
            this.SystemComponentsGroupBox.Controls.Add(this.ManufacturerLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.ConditionButton);
            this.SystemComponentsGroupBox.Controls.Add(this.ConditionLabel);
            this.SystemComponentsGroupBox.Font = new System.Drawing.Font("Arial", 14F);
            this.SystemComponentsGroupBox.Location = new System.Drawing.Point(25, 70);
            this.SystemComponentsGroupBox.Name = "SystemComponentsGroupBox";
            this.SystemComponentsGroupBox.Size = new System.Drawing.Size(525, 646);
            this.SystemComponentsGroupBox.TabIndex = 13;
            this.SystemComponentsGroupBox.TabStop = false;
            this.SystemComponentsGroupBox.Text = "SystemComponents";
            // 
            // CPUSpeedLabel
            // 
            this.CPUSpeedLabel.AutoSize = true;
            this.CPUSpeedLabel.Location = new System.Drawing.Point(8, 344);
            this.CPUSpeedLabel.Name = "CPUSpeedLabel";
            this.CPUSpeedLabel.Size = new System.Drawing.Size(117, 22);
            this.CPUSpeedLabel.TabIndex = 23;
            this.CPUSpeedLabel.Text = "CPU Speed:";
            // 
            // CPUNumberLabel
            // 
            this.CPUNumberLabel.AutoSize = true;
            this.CPUNumberLabel.Location = new System.Drawing.Point(1, 300);
            this.CPUNumberLabel.Name = "CPUNumberLabel";
            this.CPUNumberLabel.Size = new System.Drawing.Size(127, 22);
            this.CPUNumberLabel.TabIndex = 22;
            this.CPUNumberLabel.Text = "CPU Number:";
            // 
            // CPUTypeLabel
            // 
            this.CPUTypeLabel.AutoSize = true;
            this.CPUTypeLabel.Location = new System.Drawing.Point(26, 257);
            this.CPUTypeLabel.Name = "CPUTypeLabel";
            this.CPUTypeLabel.Size = new System.Drawing.Size(102, 22);
            this.CPUTypeLabel.TabIndex = 21;
            this.CPUTypeLabel.Text = "CPU Type:";
            // 
            // ScreenSizeLabel
            // 
            this.ScreenSizeLabel.AutoSize = true;
            this.ScreenSizeLabel.Location = new System.Drawing.Point(10, 211);
            this.ScreenSizeLabel.Name = "ScreenSizeLabel";
            this.ScreenSizeLabel.Size = new System.Drawing.Size(118, 22);
            this.ScreenSizeLabel.TabIndex = 20;
            this.ScreenSizeLabel.Text = "Screen Size:";
            // 
            // DisplayTypeLabel
            // 
            this.DisplayTypeLabel.AutoSize = true;
            this.DisplayTypeLabel.Location = new System.Drawing.Point(4, 170);
            this.DisplayTypeLabel.Name = "DisplayTypeLabel";
            this.DisplayTypeLabel.Size = new System.Drawing.Size(124, 22);
            this.DisplayTypeLabel.TabIndex = 19;
            this.DisplayTypeLabel.Text = "Display Type:";
            // 
            // SystemComponentsButton
            // 
            this.SystemComponentsButton.BackColor = System.Drawing.Color.White;
            this.SystemComponentsButton.Enabled = false;
            this.SystemComponentsButton.Font = new System.Drawing.Font("Arial", 14F);
            this.SystemComponentsButton.Location = new System.Drawing.Point(131, 166);
            this.SystemComponentsButton.Name = "SystemComponentsButton";
            this.SystemComponentsButton.Size = new System.Drawing.Size(378, 445);
            this.SystemComponentsButton.TabIndex = 18;
            this.SystemComponentsButton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.SystemComponentsButton.UseVisualStyleBackColor = false;
            // 
            // ModelButton
            // 
            this.ModelButton.BackColor = System.Drawing.Color.White;
            this.ModelButton.Enabled = false;
            this.ModelButton.Font = new System.Drawing.Font("Arial", 14F);
            this.ModelButton.Location = new System.Drawing.Point(364, 98);
            this.ModelButton.Name = "ModelButton";
            this.ModelButton.Size = new System.Drawing.Size(121, 33);
            this.ModelButton.TabIndex = 17;
            this.ModelButton.UseVisualStyleBackColor = false;
            // 
            // ModelLabel
            // 
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.Location = new System.Drawing.Point(291, 103);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(67, 22);
            this.ModelLabel.TabIndex = 16;
            this.ModelLabel.Text = "Model:";
            // 
            // PlatformButton
            // 
            this.PlatformButton.BackColor = System.Drawing.Color.White;
            this.PlatformButton.Enabled = false;
            this.PlatformButton.Font = new System.Drawing.Font("Arial", 14F);
            this.PlatformButton.Location = new System.Drawing.Point(107, 98);
            this.PlatformButton.Name = "PlatformButton";
            this.PlatformButton.Size = new System.Drawing.Size(121, 33);
            this.PlatformButton.TabIndex = 15;
            this.PlatformButton.UseVisualStyleBackColor = false;
            // 
            // PlatformLabel
            // 
            this.PlatformLabel.AutoSize = true;
            this.PlatformLabel.Location = new System.Drawing.Point(15, 103);
            this.PlatformLabel.Name = "PlatformLabel";
            this.PlatformLabel.Size = new System.Drawing.Size(86, 22);
            this.PlatformLabel.TabIndex = 14;
            this.PlatformLabel.Text = "Platform:";
            // 
            // ManufacturerButton
            // 
            this.ManufacturerButton.BackColor = System.Drawing.Color.White;
            this.ManufacturerButton.Enabled = false;
            this.ManufacturerButton.Font = new System.Drawing.Font("Arial", 14F);
            this.ManufacturerButton.Location = new System.Drawing.Point(364, 49);
            this.ManufacturerButton.Name = "ManufacturerButton";
            this.ManufacturerButton.Size = new System.Drawing.Size(121, 33);
            this.ManufacturerButton.TabIndex = 13;
            this.ManufacturerButton.UseVisualStyleBackColor = false;
            // 
            // ManufacturerLabel
            // 
            this.ManufacturerLabel.AutoSize = true;
            this.ManufacturerLabel.Location = new System.Drawing.Point(234, 54);
            this.ManufacturerLabel.Name = "ManufacturerLabel";
            this.ManufacturerLabel.Size = new System.Drawing.Size(124, 22);
            this.ManufacturerLabel.TabIndex = 12;
            this.ManufacturerLabel.Text = "Manufacturer:";
            // 
            // ConditionButton
            // 
            this.ConditionButton.BackColor = System.Drawing.Color.White;
            this.ConditionButton.Enabled = false;
            this.ConditionButton.Font = new System.Drawing.Font("Arial", 14F);
            this.ConditionButton.Location = new System.Drawing.Point(107, 49);
            this.ConditionButton.Name = "ConditionButton";
            this.ConditionButton.Size = new System.Drawing.Size(121, 33);
            this.ConditionButton.TabIndex = 11;
            this.ConditionButton.UseVisualStyleBackColor = false;
            // 
            // ConditionLabel
            // 
            this.ConditionLabel.AutoSize = true;
            this.ConditionLabel.Location = new System.Drawing.Point(6, 54);
            this.ConditionLabel.Name = "ConditionLabel";
            this.ConditionLabel.Size = new System.Drawing.Size(95, 22);
            this.ConditionLabel.TabIndex = 0;
            this.ConditionLabel.Text = "Condition:";
            // 
            // HDDSizeLabel
            // 
            this.HDDSizeLabel.AutoSize = true;
            this.HDDSizeLabel.Location = new System.Drawing.Point(30, 385);
            this.HDDSizeLabel.Name = "HDDSizeLabel";
            this.HDDSizeLabel.Size = new System.Drawing.Size(98, 22);
            this.HDDSizeLabel.TabIndex = 24;
            this.HDDSizeLabel.Text = "HDD Size:";
            // 
            // HDDSpeedLabel
            // 
            this.HDDSpeedLabel.AutoSize = true;
            this.HDDSpeedLabel.Location = new System.Drawing.Point(10, 432);
            this.HDDSpeedLabel.Name = "HDDSpeedLabel";
            this.HDDSpeedLabel.Size = new System.Drawing.Size(118, 22);
            this.HDDSpeedLabel.TabIndex = 25;
            this.HDDSpeedLabel.Text = "HDD Speed:";
            // 
            // GPUTypeLabel
            // 
            this.GPUTypeLabel.AutoSize = true;
            this.GPUTypeLabel.Location = new System.Drawing.Point(25, 479);
            this.GPUTypeLabel.Name = "GPUTypeLabel";
            this.GPUTypeLabel.Size = new System.Drawing.Size(103, 22);
            this.GPUTypeLabel.TabIndex = 26;
            this.GPUTypeLabel.Text = "GPU Type:";
            // 
            // WebcamLabel
            // 
            this.WebcamLabel.AutoSize = true;
            this.WebcamLabel.Location = new System.Drawing.Point(36, 521);
            this.WebcamLabel.Name = "WebcamLabel";
            this.WebcamLabel.Size = new System.Drawing.Size(92, 22);
            this.WebcamLabel.TabIndex = 27;
            this.WebcamLabel.Text = "Webcam:";
            // 
            // OSLabel
            // 
            this.OSLabel.AutoSize = true;
            this.OSLabel.Location = new System.Drawing.Point(82, 567);
            this.OSLabel.Name = "OSLabel";
            this.OSLabel.Size = new System.Drawing.Size(43, 22);
            this.OSLabel.TabIndex = 28;
            this.OSLabel.Text = "OS:";
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.ControlBox = false;
            this.Controls.Add(this.SystemComponentsGroupBox);
            this.Controls.Add(this.ProductPictureBox);
            this.Controls.Add(this.FinishButton);
            this.Controls.Add(this.OrderCancelButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.OrderMenuStrip);
            this.Controls.Add(this.YourPriceGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.OrderMenuStrip;
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderForm";
            this.Activated += new System.EventHandler(this.OrderForm_Activated);
            this.OrderMenuStrip.ResumeLayout(false);
            this.OrderMenuStrip.PerformLayout();
            this.YourPriceGroupBox.ResumeLayout(false);
            this.YourPriceGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductPictureBox)).EndInit();
            this.SystemComponentsGroupBox.ResumeLayout(false);
            this.SystemComponentsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip OrderMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private Microsoft.VisualBasic.PowerPacks.Printing.PrintForm ProductPrintForm;
        private System.Windows.Forms.Button OrderCancelButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button FinishButton;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Button PriceButton;
        private System.Windows.Forms.Button SalesTaxButton;
        private System.Windows.Forms.Label SalesTaxLabel;
        private System.Windows.Forms.Button TotalPriceButton;
        private System.Windows.Forms.Label TotalPriceLabel;
        private Microsoft.VisualBasic.PowerPacks.LineShape YourPriceLineShape;
        private System.Windows.Forms.GroupBox YourPriceGroupBox;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private System.Windows.Forms.PictureBox ProductPictureBox;
        private System.Windows.Forms.GroupBox SystemComponentsGroupBox;
        private System.Windows.Forms.Label ConditionLabel;
        private System.Windows.Forms.Button ConditionButton;
        private System.Windows.Forms.Button ManufacturerButton;
        private System.Windows.Forms.Label ManufacturerLabel;
        private System.Windows.Forms.Button PlatformButton;
        private System.Windows.Forms.Label PlatformLabel;
        private System.Windows.Forms.Button ModelButton;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.Button SystemComponentsButton;
        private System.Windows.Forms.Label DisplayTypeLabel;
        private System.Windows.Forms.Label ScreenSizeLabel;
        private System.Windows.Forms.Label CPUTypeLabel;
        private System.Windows.Forms.Label CPUNumberLabel;
        private System.Windows.Forms.Label CPUSpeedLabel;
        private System.Windows.Forms.Label HDDSizeLabel;
        private System.Windows.Forms.Label HDDSpeedLabel;
        private System.Windows.Forms.Label GPUTypeLabel;
        private System.Windows.Forms.Label WebcamLabel;
        private System.Windows.Forms.Label OSLabel;
    }
}