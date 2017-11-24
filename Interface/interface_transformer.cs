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
            label_result1.Text = Time_t.ToString();
        }

        private void interface_transformer_Load(object sender, EventArgs e)
        {

        }

        private void Result_Click(object sender, EventArgs e)
        {

        }
    }
}
