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

        private int x, count;
        public interface_alarms()
        {
            InitializeComponent();
            x = 1;
            count = 0;
            led_green.Visible = false;
            led_red.Visible = true;
            timer_alarms.Enabled=true;
            timer_alarms.Start();
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
            x = 0;
            timer_alarms.Stop();
        }

        private void timer_alarms_Tick(object sender, EventArgs e)
        {
            if((x==1) && (count<2))
            {
                led_red.Visible = true;
                count = count + 1;
            }

            if ((x == 1) && (count==2))
            {

                led_red.Visible = false;
                count = 0;

            }
        }

    }
}
