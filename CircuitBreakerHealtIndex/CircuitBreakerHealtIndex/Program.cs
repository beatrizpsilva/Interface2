using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircuitBreakerHealtIndex
{
    class Program
    {
        private static Double HealtIndex;
        private static int OperationScore;

        static void Main(string[] args)
        {
            Double IdleTimeScor;
            int xAge;
            int xTrip ;
            int xOper;
            int xIdle ;
            int MaxTrips;
            int MaxOper;
            int AgeScore;
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

                AgeScore = (xAge/30);
            }
            else
            {
                AgeScore = 1;
            }

            Console.WriteLine("The AgeSocre is: {0}", AgeScore);

            if (OperationTripScore < 0.1 && OperationNomScore < 0.1)
            {
                Double OperationScore = 0.1f;
            }
            else
            {
                if (OperationTripScore < 0.25 && OperationNomScore < 0.25)
                {
                    Double OperationScore = 0.25f;
                }
                else
                {
                    if (OperationTripScore < 0.5 && OperationNomScore < 0.5)
                    {
                        Double OperationScore = 0.5;
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
              IdleTimeScor = xIdle/6;
            }
            Console.WriteLine("The xIdle is: {0}", IdleTimeScor);

            HealtIndex = ((2 * AgeScore + 3 * OperationScore + IdleTimeScor) / 6) * 100;



            Console.WriteLine("The HealtIndex is: {0}", HealtIndex);
            Console.ReadLine();
        }

    }
}
