using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
/// APP NAME: Dollar Computer
/// AUTHOR'S NAME: Vu Hieu Phong
/// STUDENT ID: 301049781
/// APP CREATION DATE: August 13th 2018
/// APP DESCRIPTION: This app helps to develop a hardware buying UI
/// this is the form that displays the user's order
/// </summary>
namespace COMP123_S2019_Assignment5
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// this is the event handler for the click event of print tool strip menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductPrintForm.PrintAction = PrintAction.PrintToPreview;
            ProductPrintForm.Print();
        }
        /// <summary>
        /// this is the event handler for the click event of about tool strip menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.Forms[FormNames.ABOUT_FORM].ShowDialog();
        }

        /// <summary>
        /// this is the event handler for the click event of the back button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButton_Click(object sender, EventArgs e)
        {
            Program.Forms[FormNames.PRODUCT_INFO_FORM].Show();
            this.Hide();
        }

        /// <summary>
        /// this is the event handler for the click event of the cancel button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// this  is the event handler for the click event of the finish button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FinishButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for ordering with us!\n\n" +
                "Your order will arrive in 7-10 business days."
                , "Thank You!", MessageBoxButtons.OK);
            Application.Exit();
        }

        /// <summary>
        /// this is the event handler for the activated event of the order form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
