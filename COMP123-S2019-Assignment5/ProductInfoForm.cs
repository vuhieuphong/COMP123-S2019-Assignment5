using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        }

        private void ProductInfoForm_Activated(object sender, EventArgs e)
        {
            ProductIDButton.Text = Program.product.productID.ToString();
            ConditionButton.Text = Program.product.condition;
            CostButton.Text = "$"+Program.product.cost.ToString();

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
    }
}
