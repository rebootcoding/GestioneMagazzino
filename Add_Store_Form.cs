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
        public Add_Store_Form()
        {
            InitializeComponent();
        }

        private void Save_Store_Click(object sender, EventArgs e)
        {
            //salvataggio dei dati
            this.Close();
        }

        private void Add_Store_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
