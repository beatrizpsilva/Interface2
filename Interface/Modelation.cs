using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelation
{
    class Health_index
    {
        public double Health_Index_CB(int xAge, int xTrip, int xOper, int xIdle, int MaxTrips, int MaxOper)
        {
            Double OperationScore, HealtIndex, IdleTimeScor, AgeScore;
            //xAge = 40;
            //xTrip = 20;
            //xOper = 20;
            //xIdle = 40;
            //MaxTrips = 20;
            //MaxOper = 20;
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
            Console.WriteLine("The xIdle is: {0}", IdleTimeScor);
            HealtIndex = ((2 * AgeScore + 3 * OperationScore + IdleTimeScor) / 6) * 100;
            Console.WriteLine("The HealtIndex is: {0}", HealtIndex);
            Console.ReadLine();

            return HealtIndex;

        }

        public double Health_Index_Tr_Offline(int xAge, int Avg_Load, int mpa, int type, char location)
        {

            /**********************Notes*****************/
            //Age is a int
            //Avg_load is in percentage
            //mpa is number of maintenances per year, should be a integer
            //type of transformer is a integer that says how many times the transformer has been repaired
            //Location A=> Agricultural load, B=> Business , I=> Industrial, R=> Residential
            int[] S = new int[5];
            //Ordem no vector S
            // S_age, S_Avg_Load, S_mpa, S_type, S_location = 0;
            /*******************Age S selection*****************/
            if (xAge >= 0 && xAge <= 5)
            {
                S[0] = 4;
            }
            else if (xAge >= 6 && xAge <= 10)
            {
                S[0] = 3;
            }
            else if (xAge >= 11 && xAge <= 15)
            {
                S[0] = 2;
            }
            else if (xAge >= 16)
            {
                S[0] = 1;
            }
            /***************Avg_Loading S selection*****************/
            if (Avg_Load < 60)
            {
                S[1] = 4;
            }
            else if (Avg_Load >= 61 && Avg_Load <= 75)
            {
                S[1] = 3;
            }
            else if (Avg_Load >= 76 && Avg_Load <= 85)
            {
                S[1] = 2;
            }
            else if (Avg_Load > 85)
            {
                S[1] = 1;
            }
            /***************maintenance per annum*****************/
            if (mpa <= 1)
            {
                S[2] = 4;
            }
            else if (mpa == 2)
            {
                S[2] = 3;
            }
            else if (mpa == 3)
            {
                S[2] = 2;
            }
            else if (mpa > 3)
            {
                S[2] = 1;
            }
            /***************Type of transformer*****************/
            if (type == 0)
            {
                S[3] = 4;
            }
            else if (type == 1)
            {
                S[3] = 3;
            }
            else if (type == 2)
            {
                S[3] = 2;
            }
            else if (type > 2)
            {
                S[3] = 1;
            }
            /***************Location*****************/
            if (location == 'A' || location == 'a')
            {
                S[4] = 4;
            }
            else if (location == 'I' || location == 'i')
            {
                S[4] = 3;
            }
            else if (location == 'R' || location == 'r')
            {
                S[4] = 2;
            }
            else if (location == 'B' || location == 'b')
            {
                S[4] = 1;
            }
            int S_max = S.Max();

            /*******Calculo*************/
            // Ver paper "Online condition monitoring system for substation and service transformers"
         
            
            for(int i = 0;i<=4;i++)
            {
                if (i == 0)
                {
                    S[0] = S[0] * 4;
                }
                if (i == 1)
                {
                    S[1]= S[1] * 2;
                }
                if (i == 2)
                {
                    S[2] = S[2] * 3;
                }
                if (i == 3)
                {
                    S[3] = S[3] * 4;
                }
                if (i == 4)
                {
                    S[4] = S[4] * 1;
                }
            }

            int Wpi = 4 + 4 + 2 + 3 + 1;
            double HI_TR = S.Sum();
            HI_TR = S.Sum()/Wpi;
            HI_TR = (HI_TR / S_max)*100;

            return HI_TR;

        }

        public double Health_Index_Tr_Online() { return 1; }
    }
}
