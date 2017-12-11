using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    public partial class Form1 : Form
    {
        public object CircularProgressBar1 { get; private set; }

        public Form1()
        {
            InitializeComponent();
            menu1.BringToFront();
        }

        private void Balarms_Click(object sender, EventArgs e)
        {
            interface_alarms1.BringToFront();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Bmenu_Click(object sender, EventArgs e)
        {
            menu1.BringToFront();
            
        }

        private void Btransformer_Click(object sender, EventArgs e)
        {
            interface_transformer1.BringToFront();
        }

        private void Bdisconnector_Click(object sender, EventArgs e)
        {
            interface_disconnector1.BringToFront();
        }

        private void Bcircuitbreaker_Click(object sender, EventArgs e)
        {
            interface_circuit_breakers1.BringToFront();
            
        }

        private void interface_transformer1_Load(object sender, EventArgs e)
        {

        }

        public void Form1_Load(object sender, EventArgs e)
        {
            

        }
    }
}
