using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Assignment5
{
    public partial class ProductInfoForm : Form
    {
        public ProductInfoForm()
        {
            InitializeComponent();
        }
        
        private void SelectAnotherProductButton_Click(object sender, EventArgs e)
        {
            Program.Forms[FormNames.SELECT_FORM].Show();
            this.Hide();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            Program.Forms[FormNames.ORDER_FORM].Show();
            this.Hide();
            ReminderLabel.Text = "Save or Load File to Continue!";
            NextButton.Enabled = false;
        }

        private void ProductInfoForm_Activated(object sender, EventArgs e)
        {
            ProductIDButton.Text = Program.product.productID.ToString();
            ConditionButton.Text = Program.product.condition;
            CostButton.Text = "$" + Program.product.cost.ToString();

            PlatformButton.Text = Program.product.platform;
            OSButton.Text = Program.product.OS;
            ManufacturerButton.Text = Program.product.manufacturer;
            ModelButton.Text = Program.product.model;
            WidthButton.Text = Program.product.width;
            HeightButton.Text = Program.product.height;
            WeightButton.Text = Program.product.weight;
            DepthButton.Text = Program.product.depth;
            PowerButton.Text = Program.product.power;
            WebcamButton.Text = Program.product.webcam;
            LANButton.Text = Program.product.LAN;
            WIFIButton.Text = Program.product.WIFI;
            DisplayTypeButton.Text = Program.product.displaytype;
            ScreenSizeButton.Text = Program.product.screensize;
            ResolutionButton.Text = Program.product.resolution;
            MouseTypeButton.Text = Program.product.moust_type;

            HDDSizeButton.Text = Program.product.HDD_size;
            HDDSpeedButton.Text = Program.product.HDD_speed;
            CPUClassButton.Text = Program.product.CPU_Class;
            CPUBrandButton.Text = Program.product.CPU_brand;
            CPUNumberButton.Text = Program.product.CPU_number;
            CPUTypeButton.Text = Program.product.CPU_type;
            CPUSpeedButton.Text = Program.product.CPU_speed;
            RAMSizeButton.Text = Program.product.RAM_size;
            RAMTypeButton.Text = Program.product.RAM_type;
            GPUTypeButton.Text = Program.product.GPU_Type;
            OpticalDriveButton.Text = Program.product.optical_drive;
            AudioTypeButton.Text = Program.product.Audio_type;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // configure the file dialog

            ProductSaveFileDialog.FileName = "Product.txt";
            ProductSaveFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            ProductSaveFileDialog.Filter = "Text Files (*.txt)|*.txt| All Files (*.*)|*.*";
            // open file dialog - Modal Form

            var result = ProductSaveFileDialog.ShowDialog();
            if (result != DialogResult.Cancel)
            {
                // open file to write
                using (StreamWriter outputStream = new StreamWriter(
                    File.Open(ProductSaveFileDialog.FileName, FileMode.Create)))
                {
                    // write stuff to the file
                    outputStream.WriteLine(Program.product.productID);
                    outputStream.WriteLine(Program.product.cost);
                    outputStream.WriteLine(Program.product.manufacturer);
                    outputStream.WriteLine(Program.product.model);
                    outputStream.WriteLine(Program.product.RAM_type);
                    outputStream.WriteLine(Program.product.RAM_size);
                    outputStream.WriteLine(Program.product.displaytype);
                    outputStream.WriteLine(Program.product.screensize);
                    outputStream.WriteLine(Program.product.resolution);
                    outputStream.WriteLine(Program.product.CPU_Class);
                    outputStream.WriteLine(Program.product.CPU_brand);
                    outputStream.WriteLine(Program.product.CPU_type);
                    outputStream.WriteLine(Program.product.CPU_speed);
                    outputStream.WriteLine(Program.product.CPU_number);
                    outputStream.WriteLine(Program.product.condition);
                    outputStream.WriteLine(Program.product.OS);
                    outputStream.WriteLine(Program.product.platform);
                    outputStream.WriteLine(Program.product.HDD_size);
                    outputStream.WriteLine(Program.product.HDD_speed);
                    outputStream.WriteLine(Program.product.GPU_Type);
                    outputStream.WriteLine(Program.product.optical_drive);
                    outputStream.WriteLine(Program.product.Audio_type);
                    outputStream.WriteLine(Program.product.LAN);
                    outputStream.WriteLine(Program.product.WIFI);
                    outputStream.WriteLine(Program.product.width);
                    outputStream.WriteLine(Program.product.height);
                    outputStream.WriteLine(Program.product.depth);
                    outputStream.WriteLine(Program.product.weight);
                    outputStream.WriteLine(Program.product.moust_type);
                    outputStream.WriteLine(Program.product.power);
                    outputStream.WriteLine(Program.product.webcam);
                    // close the file
                    outputStream.Close();
                    // dispose of the memory
                    outputStream.Dispose();
                }
                MessageBox.Show("File Saved", "Saving...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ReminderLabel.Text = string.Empty;
                NextButton.Enabled = true;
            }
        }
        
        public void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // configure the file dialog

            ProductOpenFileDialog.FileName = "Product.txt";
            ProductOpenFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            ProductOpenFileDialog.Filter = "Text Files (*.txt)|*.txt| All Files (*.*)|*.*";

            // open the file dialog
            var result = ProductOpenFileDialog.ShowDialog();
            if (result != DialogResult.Cancel)
            {
                try
                {
                    // Open your stream to read
                    using (StreamReader inputStream = new StreamReader(
                        File.Open(ProductOpenFileDialog.FileName, FileMode.Open)))
                    {
                        // Read stuff into the Student class
                        Program.product.productID = short.Parse(inputStream.ReadLine());
                        Program.product.cost = decimal.Parse(inputStream.ReadLine());
                        Program.product.manufacturer = inputStream.ReadLine();
                        Program.product.model = inputStream.ReadLine();
                        Program.product.RAM_type = inputStream.ReadLine();
                        Program.product.RAM_size = inputStream.ReadLine();
                        Program.product.displaytype = inputStream.ReadLine();
                        Program.product.screensize = inputStream.ReadLine();
                        Program.product.resolution = inputStream.ReadLine();
                        Program.product.CPU_Class = inputStream.ReadLine();
                        Program.product.CPU_brand = inputStream.ReadLine();
                        Program.product.CPU_type = inputStream.ReadLine();
                        Program.product.CPU_speed = inputStream.ReadLine();
                        Program.product.CPU_number = inputStream.ReadLine();
                        Program.product.condition = inputStream.ReadLine();
                        Program.product.OS = inputStream.ReadLine();
                        Program.product.platform = inputStream.ReadLine();
                        Program.product.HDD_size = inputStream.ReadLine(); 
                        Program.product.HDD_speed = inputStream.ReadLine();
                        Program.product.GPU_Type = inputStream.ReadLine();
                        Program.product.optical_drive = inputStream.ReadLine();
                        Program.product.Audio_type = inputStream.ReadLine();
                        Program.product.LAN = inputStream.ReadLine();
                        Program.product.WIFI = inputStream.ReadLine();
                        Program.product.width = inputStream.ReadLine();
                        Program.product.height = inputStream.ReadLine();
                        Program.product.depth = inputStream.ReadLine();
                        Program.product.weight = inputStream.ReadLine();
                        Program.product.moust_type = inputStream.ReadLine();
                        Program.product.power = inputStream.ReadLine();
                        Program.product.webcam = inputStream.ReadLine();

                        // cleanup
                        inputStream.Close();
                        inputStream.Dispose();
                        //automatically click next to next form
                        NextButton_Click(sender, e);
                    }
                }
                catch (IOException exception)
                {
                    MessageBox.Show("Error: " + exception.Message, "File I/O Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if(ProductIDButton.Text=="0")
                {
                    MessageBox.Show("Please restart your order!");
                    Program.Forms[FormNames.START_FORM].Show();
                    this.Hide();
                }
            }
        }
    }
}

