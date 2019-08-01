﻿using System;
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
    }
}
