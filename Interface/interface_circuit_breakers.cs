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
            int xAge, xTrip, xOper, xIdle, MaxTrips, MaxOper;
            Double OperationScore, HealtIndex, IdleTimeScor, AgeScore;
            xAge = 40;
            xTrip = 20;
            xOper = 20;
            xIdle = 40;
            MaxTrips = 20;
            MaxOper = 20;
            float OperationTripScore = xTrip / MaxTrips;
            float OperationNomScore = xOper / MaxOper;

            if (xAge < 30)
            {

                AgeScore = (xAge / 30);
            }
            else
            {
                AgeScore = 1;
            }

            Console.WriteLine("The AgeScore is: {0}", AgeScore);
            OperationScore = 0;

            if (OperationTripScore < 0.1 && OperationNomScore < 0.1)
            {
                OperationScore = 0.1;
            }
            else
            {
                if (OperationTripScore < 0.25 && OperationNomScore < 0.25)
                {
                    OperationScore = 0.25;
                }
                else
                {
                    if (OperationTripScore < 0.5 && OperationNomScore < 0.5)
                    {
                        OperationScore = 0.5;
                    }
                }
            }

            Console.WriteLine("The OperationScore is: {0}", OperationScore);

            if (xIdle >= 6)
            {
                IdleTimeScor = 1;
            }

            else
            {
                IdleTimeScor = xIdle / 6;
            }
            
            HealtIndex = ((2 * AgeScore + 3 * OperationScore + IdleTimeScor) / 6) * 100;
            label_result2.Text = HealtIndex.ToString();
        }

        private void Table_Flaws_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }

    }
