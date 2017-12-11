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
using CircuitBreakerHealtIndex;
using System.Threading;

namespace Interface
{
    public partial class interface_circuit_breakers : UserControl
    {
        int Time_c;
        
        public interface_circuit_breakers()
        {
            InitializeComponent();
            Time_c = 50;
            circularProgressBar1.Value = 100;
            circularProgressBar1.Update();
            circularProgressBar1.Text = circularProgressBar1.Value.ToString() + ('%');
        }

        public void lifetime_Click(object sender, EventArgs e)
        { /*
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


            ligacao.CloseConn();*/
          //CircuitBreakerHealtIndex.Program CBHI = new Program();
          // label_result2.Text = CBHI.funcaoCBHI(40, 20, 20, 40, 20, 20).ToString();
            label_result2.Text = Time_c.ToString();
            for (int i = 100; i >= Time_c; i--)
            {
                Thread.Sleep(10);
                circularProgressBar1.Value = i;
                circularProgressBar1.Update();
                circularProgressBar1.Text = i.ToString() + ('%');

            }
        }

        private void Table_Flaws_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void circularProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void label_result2_Click(object sender, EventArgs e)
        {

        }
    }

    }
