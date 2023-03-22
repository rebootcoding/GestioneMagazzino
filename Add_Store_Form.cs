using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestioneMagazzino
{
    public partial class Add_Store_Form : Form
    {
        public db_a967b2_dblogintestEntities ctx;
        public Add_Store_Form()
        {
            InitializeComponent();
            ctx = new db_a967b2_dblogintestEntities();
        }

        private void Save_Store_Click(object sender, EventArgs e)
        {
            var name = tbx_Name.Text;
            var phone = tbx_Phone.Text; 
            var email = tbx_Email.Text; 
            var street = tbx_Street.Text;   
            var city = tbx_City.Text;   
            var state = tbx_State.Text;
            var stringZipCode = tbx_zipCode.Text;
            var zipCode = Int32.TryParse(stringZipCode,out int result);

            if(zipCode == true )
            {
                if (email.Contains("@"))
                {
                    if(name != null)
                    {

                        Insert_New_Store(name, phone, email, street, city, state, result.ToString());
                    }
                    else
                    {
                        MessageBox.Show("You didn't enter your name");
                    }
                }
                else
                {
                    MessageBox.Show("you did not enter the email correctly");
                }
            }
            else 
            {
                MessageBox.Show("You did not enter the zip code correctly");
            }
            //salvataggio dei dati
            this.Close();
        }

        private void Insert_New_Store(string name, string phone, string email,string city,string street, string zipCode, string state)
        {
            ctx.stores.Add(new store { store_name = name , phone = phone, email = email, street = street, city = city, state = state, zip_code = zipCode}
                );
        }

        private void Add_Store_Form_Load(object sender, EventArgs e)
        {


        }
    }
}
