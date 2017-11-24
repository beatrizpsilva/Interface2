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
    public partial class interface_alarms : UserControl
    {
        public interface_alarms()
        {
            InitializeComponent();

            led_green.Visible = false;
            led_red.Visible = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void led_red_Click(object sender, EventArgs e)
        {

        }

        private void led_green_Click(object sender, EventArgs e)
        {

        }

        private void stop_alarm_Click(object sender, EventArgs e)
        {
            led_green.Visible = true;
            led_red.Visible = false;
        }
    }
}
