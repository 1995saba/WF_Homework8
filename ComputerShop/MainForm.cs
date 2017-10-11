using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerShop
{
    public partial class MainForm : Form
    {
        public List<Item> items = new List<Item>();
        public MainForm()
        {
            InitializeComponent();
            AdditionalForm editForm = new AdditionalForm();
            comboBox.DataSource = items;
            comboBox.DisplayMember = "Name";
        }

        private void AddToBasketButton_Click(object sender, EventArgs e)
        {
           
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            AdditionalForm editForm = new AdditionalForm();
            editForm.Show();
        }

        private void CountButton_Click(object sender, EventArgs e)
        {

        }
    }
}
