using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Conections;
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
            Conections.dbconnection ligacao = new dbconnection();
            

            try {
                Console.WriteLine("Openning Connection ...");
                ligacao.OpenConn();
                Console.WriteLine("Connection successful!");
                label_result2.Text = Time_c.ToString();
            }


            catch(Exception)
            {
                Console.WriteLine("Error: ");
                Time_c = 5;
                label_result2.Text = Time_c.ToString();

            }

            ligacao.CloseConn();

            //label_result2.Text = Time_c.ToString();
        }

        private void Table_Flaws_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
