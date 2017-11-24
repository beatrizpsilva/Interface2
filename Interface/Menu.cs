using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    public partial class Menu : UserControl
    {
        public Menu()
        {
            InitializeComponent();
            label2.Visible = true;
            label3.Visible = true;
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            label3.Visible = false;
        }
    }
}
