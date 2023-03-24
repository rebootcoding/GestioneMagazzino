using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GestioneMagazzino
{
    public partial class Add_Product_in_Store : Form
    {
        public db_a967b2_dblogintestEntities ctx;
        public Add_Product_in_Store()
        {
            InitializeComponent();
            ctx = new db_a967b2_dblogintestEntities();
        }

        private void Add_Product_in_Store_Load(object sender, EventArgs e)
        {
            cbx_select_store.DataSource = ctx.stores.ToList();
            cbx_select_store.DisplayMember = "store_name";
            //var idstore = ((store)cbx_select_store.SelectedItem);
            cbx_select_product.DataSource = ctx.products.OrderBy(x => x.product_name).ToList(); //errore rimane!
            cbx_select_product.DisplayMember = "product_name";
        }

        private void Save_Stock_Click(object sender, EventArgs e)
        {
            var productSelect = ((product)cbx_select_product.SelectedItem);
            var ID = productSelect.product_id;
            //var ProductSelect = ctx.products.Where(x => x.product_name == productSelect.product_name).Select(x => x.product_id).ToString();
            //var IDProductSelect = int.Parse(ProductSelect);
            var storeSelect = ((store)cbx_select_store.SelectedItem);
            var quantità = (int)num_quantity.Value;


            InsertStock(storeSelect.store_id, ID,  quantità);
            var res = MessageBox.Show(this, $"The data entered are: {Environment.NewLine}{Environment.NewLine}PRODUCT NAME:{Environment.NewLine}{productSelect.product_name}{Environment.NewLine}{Environment.NewLine}STORE NAME:{Environment.NewLine}{storeSelect.store_name}{Environment.NewLine}{Environment.NewLine}QUANTITY:{Environment.NewLine}{quantità}{Environment.NewLine}{Environment.NewLine}Confirm?", "Warning",
                       MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (res != DialogResult.Yes)
            {
                return;
            }
            ctx.SaveChanges();
            MessageBox.Show("Data have been saved correctly");
            num_quantity.Value = 0;
        }

        public void InsertStock(int idStore, int idProduct, int quantity)
        {

            //usiamo FirstoOrDefault perché la chiave univoca è composta da product_id e store_id quindi non è possibile avere doppioni!
            var stock2 = ctx.stocks.FirstOrDefault(b => b.product_id == idProduct && b.store_id == idStore);
            if (stock2 != null)
            {
                stock2.quantity = stock2.quantity + quantity;
            }
            else
            {
                ctx.stocks.Add(new stock { product_id = idProduct, store_id = idStore, quantity = quantity }
                );
            }
        }

        //message box 
        private void Add_Product_in_Store_FormClosing(object sender, FormClosingEventArgs e)
        {
            var res = MessageBox.Show(this, "You really want to quit?", "Exit",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            //se no la form add_product non viene chiusa
            if (res != DialogResult.Yes)
            {
                e.Cancel = true;
                return;
            }
        }
    }
}

