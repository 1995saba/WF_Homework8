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
    public partial class AdditionalForm : Form
    {
        public List<Item> Items = new List<Item>();
        private double price;

        public AdditionalForm()
        {
            InitializeComponent();
        }

        private void CreateNewButton_Click(object sender, EventArgs e)
        {
            bool resPrice = Double.TryParse(textBoxPrice.Text, out price);
            Item item = new Item()
            {
                Name = textBoxName.Text,
                Characteristic = textBoxCharac.Text,
                Description = textBoxDescrirtion.Text,
                Price = price
            };
            items.Add(item);
        }
    }
}
