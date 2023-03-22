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
            cbx_select_product.DataSource = ctx.products.ToList();
            cbx_select_product.DisplayMember = "product_name";
        }

        private void Save_Stock_Click(object sender, EventArgs e)
        {
            var idProdotto = ((product)cbx_select_product.SelectedItem).product_id;
            var idStore = ((store)cbx_select_store.SelectedItem).store_id;
            var quantità = (int)num_quantity.Value; 


            InsertStock(idProdotto, idStore, quantità);
            ctx.SaveChanges();
            this.Close();

        }

        public void InsertStock(int idStore, int idProduct, int quantity)
        {

            //usiamo First perché la chiave univoca è composta da product_id e store_id quindi non è possibile avere doppioni!
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
    }
}
