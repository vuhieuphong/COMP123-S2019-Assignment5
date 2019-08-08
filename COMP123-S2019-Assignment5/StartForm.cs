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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void StartOrderButton_Click(object sender, EventArgs e)
        {
            Program.Forms[FormNames.SELECT_FORM].Show();
            this.Hide();   
        }

        private void LoadOrderButton_Click(object sender, EventArgs e)
        {
            var myInfoForm = Program.Forms[FormNames.PRODUCT_INFO_FORM] as ProductInfoForm;
            myInfoForm.Show();
            this.Hide();
            myInfoForm.openToolStripMenuItem_Click(sender, e);   
            
        }

        private void ExitProgramButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
