using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
/// this is the form that lets user makes his order choice
/// </summary>
namespace COMP123_S2019_Assignment5
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// this is the event handler for the click event of the start order button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartOrderButton_Click(object sender, EventArgs e)
        {
            Program.Forms[FormNames.SELECT_FORM].Show();
            this.Hide();   
        }
        /// <summary>
        /// this is the event handler for the load order button
        /// this will open a product info form and activate the open tool strip menu click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadOrderButton_Click(object sender, EventArgs e)
        {
            var loadedInfoForm = Program.Forms[FormNames.PRODUCT_INFO_FORM] as ProductInfoForm;
            loadedInfoForm.Show();
            this.Hide();
            loadedInfoForm.openToolStripMenuItem_Click(sender, e);   
            
        }

        /// <summary>
        /// this is the event handler for the click button of the exit button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitProgramButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
