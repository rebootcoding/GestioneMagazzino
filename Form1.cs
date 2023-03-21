using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace GestioneMagazzino
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Add_product_on_store(object sender, EventArgs e)
        {
            var m = new Add_Product_in_Store();
            m.Show();
        }

        private void Add_new_store(object sender, EventArgs e)
        {
            var m = new Add_Store_Form();
            m.Show();
        }

        private void Update_Stores(object sender, EventArgs e)
        {
            //ctx.SaveChanges();
        }
    }
}
