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

        private void Add_product_on_store(object sender, EventArgs e)
        {
            var m = new Add_Product_in_Store();
            m.ShowDialog();         //non fa accedere alla finestra secondaria
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

        private void Form1_Load(object sender, EventArgs e)
        {
            cbx_select_store.DataSource = ctx.stores.ToList();
            cbx_select_store.DisplayMember = "store_name";
            cbx_select_store.ValueMember = "store_id";
        }

        private void btn_show_store_info_Click(object sender, EventArgs e)
        {
            var store_name = cbx_select_store.Text;

            //dataGridView1.DataSource = ctx.Database.SqlQuery<store>($"SELECT * FROM sales.stores s WHERE s.store_name = '{store_name}' ").ToList();
            listBox1.DataSource = ctx.stores.Where(x => x.store_name == store_name).Select( x => new
            {
                x.store_id, x.store_name, x.email, x.phone, x.city, x.state, x.street
            }).ToList();
        }

        private void btn_list_products_Click(object sender, EventArgs e)
        {
            var product_name = cbx_select_store.Text;

            var store_id = ((store)cbx_select_store.SelectedItem).store_id;
            //var store_id = int.Parse(cbx_select_store.SelectedValue.ToString());

            //anonimous type
            var table = from store in ctx.stocks.Where(x => x.store_id == store_id)
                        select new
                        {
                            nomeStore = store.store.store_name,
                            nomeProdotto = store.product.product_name,
                            quantitaProdotto = store.quantity,
                            prezzoProdotto = store.product.list_price,
                            cognome = ""
                        };

            //linq query syntax
            
            var table3 = from store in ctx.stocks
                         where store.store_id == store_id
                         select new
                         {
                             nomeStore = store.store.store_name,
                             nomeProdotto = store.product.product_name,
                             quantitaProdotto = store.quantity,
                             prezzoProdotto = store.product.list_price,
                             cognome = ""
                         };
            

            //linq method syntax
            
            var table2 = ctx.stocks.Where(x => x.store_id == store_id).Select(x => new
            {
                nomeStore = x.store.store_name,
                nomeProdotto = x.product.product_name,
                quantitaProdotto = x.quantity,          //nullable int?
                prezzoProdotto = x.product.list_price,
                cognome = ""
            });
            

            dataGridView1.DataSource = table.ToList();
        }
    }
}
