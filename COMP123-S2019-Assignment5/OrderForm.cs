using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Assignment5
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductPrintForm.PrintAction = PrintAction.PrintToPreview;
            ProductPrintForm.Print();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.Forms[FormNames.ABOUT_FORM].ShowDialog();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Program.Forms[FormNames.PRODUCT_INFO_FORM].Show();
            this.Hide();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FinishButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for ordering with us!\n" +
                "Your order will arrive in 7-10 business days."
                , "Thank You!", MessageBoxButtons.OK);
            Application.Exit();
        }

        private void OrderForm_Activated(object sender, EventArgs e)
        {
            PriceButton.Text = "$" + Program.product.cost.ToString();
            SalesTaxButton.Text = "$" + (Program.product.cost * 13 / 100).ToString();
            TotalPriceButton.Text = "$" + (Program.product.cost * 113 / 100).ToString();

            ConditionButton.Text = Program.product.condition;
            ManufacturerButton.Text = Program.product.manufacturer;
            PlatformButton.Text = Program.product.platform;
            ModelButton.Text = Program.product.model;

            SystemComponentsButton.Text = Program.product.displaytype+ "\n\n"
                                        + Program.product.screensize+ "\n\n"
                                        + Program.product.CPU_type + "\n\n"
                                        + Program.product.CPU_number + "\n\n"
                                        + Program.product.CPU_speed + "\n\n"
                                        + Program.product.HDD_size + "\n\n"
                                        + Program.product.HDD_speed + "\n\n"
                                        + Program.product.GPU_Type + "\n\n"
                                        + Program.product.webcam + "\n\n"
                                        + Program.product.OS + "\n\n"
                                        ;
        }
    }
}
