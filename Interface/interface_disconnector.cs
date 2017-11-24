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
    public partial class interface_disconnector : UserControl
    {
        int time_d;
        public interface_disconnector()
        {
            InitializeComponent();
             time_d=1;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lifetime_Click(object sender, EventArgs e)
        {
            label_result3.Text = time_d.ToString();
        }
    }
}
