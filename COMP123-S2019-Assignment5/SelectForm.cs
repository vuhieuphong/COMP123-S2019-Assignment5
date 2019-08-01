using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COMP123_S2019_Assignment5.Models;

namespace COMP123_S2019_Assignment5
{
    public partial class SelectForm : Form
    {
        public SelectForm()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            Program.Forms[FormNames.PRODUCT_INFO_FORM].Show();
            this.Hide();
        }

        private void SelectForm_Load(object sender, EventArgs e)
        {
            using(var db = new ProductModel())
            {
                db.products.Load();
                productBindingSource.DataSource = db.products.Local.ToBindingList();
            }
        }

        private void HardwareSelectGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (HardwareSelectGridView.CurrentCell != null)
            {
                var rowIndex = HardwareSelectGridView.CurrentCell.RowIndex;
                var rows = HardwareSelectGridView.Rows;
                var cells = rows[rowIndex].Cells;
                var columnCount = HardwareSelectGridView.ColumnCount;

                HardwareSelectGridView.Rows[rowIndex].Selected = true;

                string outputString = string.Empty;
                outputString = cells[2].Value.ToString()+" "+cells[3].Value.ToString()+" Priced at: $"+cells[1].Value.ToString();

                SelectedHardwareTextBox.Text = outputString;
                Program.product.productID = short.Parse(cells[0].Value.ToString());
                Program.product.cost = decimal.Parse(cells[1].Value.ToString());
                Program.product.manufacturer = cells[2].Value.ToString();
                Program.product.model = cells[3].Value.ToString();
                Program.product.RAM_type = cells[4].Value.ToString();
                Program.product.RAM_size = cells[5].Value.ToString();
                Program.product.displaytype = cells[6].Value.ToString();
                Program.product.screensize = cells[7].Value.ToString();
                Program.product.resolution = cells[8].Value.ToString();
                Program.product.CPU_Class = cells[9].Value.ToString();
                Program.product.CPU_brand = cells[10].Value.ToString();
                Program.product.CPU_type = cells[11].Value.ToString();
                Program.product.CPU_speed = cells[12].Value.ToString();
                Program.product.CPU_number = cells[13].Value.ToString();
                Program.product.condition = cells[14].Value.ToString();
                Program.product.OS = cells[15].Value.ToString();
                Program.product.platform = cells[16].Value.ToString();
                Program.product.HDD_size = cells[17].Value.ToString();
                Program.product.HDD_speed = cells[18].Value.ToString();
                Program.product.GPU_Type = cells[19].Value.ToString();
                Program.product.optical_drive = cells[20].Value.ToString();
                Program.product.Audio_type = cells[21].Value.ToString();
                Program.product.LAN = cells[22].Value.ToString();
                Program.product.WIFI = cells[23].Value.ToString();
                Program.product.width = cells[24].Value.ToString();
                Program.product.height = cells[25].Value.ToString();
                Program.product.depth = cells[26].Value.ToString();
                Program.product.weight = cells[27].Value.ToString();
                Program.product.moust_type = cells[28].Value.ToString();
                Program.product.power = cells[29].Value.ToString();
                Program.product.webcam = cells[30].Value.ToString();
            }           
        }
    }
}
