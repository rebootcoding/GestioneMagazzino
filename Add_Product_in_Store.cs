﻿using System;
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
            var productSelect = ((product)cbx_select_product.SelectedItem);
            var storeSelect = ((store)cbx_select_store.SelectedItem);
            var quantità = (int)num_quantity.Value;


            InsertStock(productSelect.product_id, storeSelect.store_id, quantità);
            var res = MessageBox.Show(this, $"The data entered are: {Environment.NewLine} Product name: {productSelect.product_name},{Environment.NewLine} Store name{storeSelect.store_name},{Environment.NewLine} quantità: {quantità}. Confirm?", "Warning",
                       MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (res != DialogResult.Yes)
            {

                return;
            }
            ctx.SaveChanges();
            num_quantity.Value = 0;
          //  this.Close();

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

