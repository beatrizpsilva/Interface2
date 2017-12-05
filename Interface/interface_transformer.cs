using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelation;

namespace Interface
{
    public partial class interface_transformer : UserControl
    { int Time_t;
        public interface_transformer()
        {
            InitializeComponent();
            Time_t = 1;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lifetime_Click(object sender, EventArgs e)
        {
            Health_index HI_TR_off = new Health_index();
            label_result1.Text =HI_TR_off.Health_Index_Tr_Offline(4,50,1,0,'A').ToString();
        }

        private void interface_transformer_Load(object sender, EventArgs e)
        {

        }

        private void Result_Click(object sender, EventArgs e)
        {

        }

        private void label_result1_Click(object sender, EventArgs e)
        {

        }
    }
}
