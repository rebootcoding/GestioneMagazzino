using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace GestioneMagazzino
{
    public partial class Form1 : Form
    {
        public db_a967b2_dblogintestEntities ctx;
        public Form1()
        {
            InitializeComponent();
            ctx = new db_a967b2_dblogintestEntities();
        }

        private void Add_product_on_store_Click(object sender, EventArgs e)
        {
            var m = new Add_Product_in_Store();
            m.ShowDialog();         //non fa accedere alla finestra secondaria
        }

        private void Add_new_store_Click(object sender, EventArgs e)
        {
            var m = new Add_Store_Form();
            m.ShowDialog();
        }

        private void Update_Stores_Click(object sender, EventArgs e)
        {
            ctx.SaveChanges();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbx_select_store.DataSource = ctx.stores.ToList();
            cbx_select_store.DisplayMember = "store_name";
            cbx_select_store.ValueMember = "store_id";
            
        }

        private void btn_show_store_info_Click(object sender, EventArgs e)
        {
            // variabili per attributi di tabella store
            var store_id = ((store)cbx_select_store.SelectedItem).store_id;
            var storeName = ((store)cbx_select_store.SelectedItem).store_name;
            var storePhone = ((store)cbx_select_store.SelectedItem).phone;
            var storeCity = ((store)cbx_select_store.SelectedItem).city;
            var storeState = ((store)cbx_select_store.SelectedItem).state;
            var storeStreet = ((store)cbx_select_store.SelectedItem).street;
            var completa = $" StoreID = {store_id} , {storeName} , {storePhone} , {storeCity} , {storeState} , {storeStreet}";
            //visualizzazione informazioni sostituiscono Text di label 
            lbl_store_info.Text = completa;

        }


        private void btn_list_products_Click(object sender, EventArgs e)
        {
            var product_name = cbx_select_store.Text;

            var store_id = ((store)cbx_select_store.SelectedItem).store_id;

            //crea un nuovo tipo incrociando informazioni da tabella store e tabella prodotto - uso di "linq method syntax"
            var product_list = ctx.stocks.Where(x => x.store_id == store_id).Select(x => new
            {
                StoreId = x.store.store_id,
                StoreName = x.store.store_name,
                ProductName = x.product.product_name,
                Quantity = x.quantity,         
                Price = x.product.list_price,
            });
            dataGridView1.DataSource = product_list.ToList();
        }

    }
}
