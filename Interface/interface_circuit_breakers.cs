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
    public partial class interface_circuit_breakers : UserControl
    {
        int Time_c;
        public interface_circuit_breakers()
        {
            InitializeComponent();
            Time_c = 1;
        }

        private void lifetime_Click(object sender, EventArgs e)
        {
            label_result2.Text = Time_c.ToString();
        }
    }
}
