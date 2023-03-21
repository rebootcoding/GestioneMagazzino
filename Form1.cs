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

        private void Form1_Load(object sender, EventArgs e)
        {
            cbx_select_store.DataSource = ctx.stores.ToList();
            cbx_select_store.DisplayMember = "store_name";
            cbx_select_store.ValueMember = "store_id";
        }

        private void btn_show_store_info_Click(object sender, EventArgs e)
        {
            var store_name = cbx_select_store.Text;

            dataGridView1.DataSource = ctx.Database.SqlQuery<store>($"SELECT * FROM sales.stores s WHERE s.store_name = '{store_name}' ").ToList();
        }

        private void btn_list_products_Click(object sender, EventArgs e)
        {
            var product_name = cbx_select_store.Text;
            var id_store = cbx_select_store.SelectedValue;
            dataGridView1.DataSource = ctx.Database.SqlQuery<product>($"SELECT *\r\nFROM production.products p JOIN production.stocks s ON p.product_id = s.product_id\r\nJOIN sales.stores s1 ON s.store_id = s1.store_id\r\nJOIN production.stocks s2 ON s1.store_id = s2.store_id\r\nWHERE s.store_id = '{id_store}'").ToList();
            MessageBox.Show(id_store.ToString());
          /*  var query = db.Accounts.Join(db.BankTransactions, acc => acc.AccountID, bank => bank.AccountID, (acc, bank) => new { Account = acc, BankTransaction = bank });*/
        }
    }
}
