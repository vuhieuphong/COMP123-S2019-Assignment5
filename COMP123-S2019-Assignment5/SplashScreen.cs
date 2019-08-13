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
/// this is the splash form that will appear for 3 seconds
/// </summary>
namespace COMP123_S2019_Assignment5
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        /// <summary>
        /// this is the event handler for the tick event of the splash timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SplashTimer_Tick(object sender, EventArgs e)
        {
            SplashTimer.Enabled = false;
            Program.Forms[FormNames.START_FORM].Show();
            this.Hide();
        }

        /// <summary>
        /// this is the event handler for the load event of the splash screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SplashScreen_Load(object sender, EventArgs e)
        {
            SplashTimer.Enabled = true;
        }
    }
}
