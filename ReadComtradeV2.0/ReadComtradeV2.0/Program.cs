//****************************************************************//
//                      Read Comtrade  v_1.0                      //  
//  Ficheiros de Teste fornecidos pelo professor Helder Leite     //
//****************************************************************//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GSF; // Lib. Comtrades  - Se não instalado - Ir ao NutGet - GSF.COMTRADE
using System.IO; // lib. Para  I/O ficheiros


namespace ReadComtradeV2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variavies auxiliares
            int version_date, i;
            // Definição da localização dos ficheiros
            string pathcfg = @"C:\Users\Pedro Breda\Desktop\Comtrade\Comtrade Dados\Comtrade files\Comtrade files\CT000000.cfg";
            string pathdat = @"C:\Users\Pedro Breda\Desktop\Comtrade\Comtrade Dados\Comtrade files\Comtrade files\CT000000.dat";
            // Tamanho dos ficheiros
            System.IO.FileInfo cfg = new System.IO.FileInfo(pathcfg);
            System.IO.FileInfo dat = new System.IO.FileInfo(pathdat);
            long sizecfg = cfg.Length;
            long sizedat = dat.Length;
            //Ler para Arrays 
            string[] linescfg = System.IO.File.ReadAllLines(pathcfg);
            string[] linesdat = System.IO.File.ReadAllLines(pathdat);
            // Decode Data 
            linescfg.GetLength(0);
            linesdat.GetLength(0);
            // Conversão Para Matrizes
            var datacfg = File.ReadLines(pathcfg).Select(x => x.Split(',')).ToArray();
            var datadat = File.ReadLines(pathdat).Select(x => x.Split(',')).ToArray();
            // Conversão para Int
            //int[] intArray = (int) Array.ConvertAll(datacfg, Int32.Parse);
            //int[] myInts = (int) datacfg.Select(int.Parse).ToArray();
            // Verificar a versão da Norma
            version_date = 0;
            if (datacfg[0][2].Contains("1997"))
            {
                version_date = 1997;
            }
            else
            {
                //     version_date = datacfg[0][2]
                version_date = 2013;
            }
            // Titulo
            string id_title = datacfg[0][0];
            // Canais
            int N_Channels = (int)int.Parse(datacfg[1][0]);
            // Analogicos 
            datacfg[1][1] = datacfg[1][1].Remove(datacfg[1][1].Length - 1);
            int NA_Channels = (int)int.Parse(datacfg[1][1]);
            // Digitais
            datacfg[1][2] = datacfg[1][2].Remove(datacfg[1][2].Length - 1);
            int ND_Channels = (int)int.Parse(datacfg[1][2]);
            // Tamano de informação no of samples
            int dat_len = (int)int.Parse(datacfg[4 + N_Channels][0]); ;
            // Frequencia 
            int frequency = (int)int.Parse(datacfg[2 + N_Channels][0]);
            // Sampling rate
            int samp_rate = (int)int.Parse(datacfg[4 + N_Channels][0]);

            // Inicio 
            string start_date = datacfg[5 + N_Channels][0];
            string start_time = datacfg[5 + N_Channels][1];
            // Final
            string end_date = datacfg[6 + N_Channels][0];
            string end_time = datacfg[6 + N_Channels][0];

            // .Dat file analisys
            // Conversão do array de dados para double

            //double[] Datdouble = datadat.Select(double.Parse).ToArray();
           
            // extract the timestamps, scaled to seconds from microseconds  
            double[,] Time = new double[linesdat.GetLength(0), 1];
            double prod = 1e-3;
           // foreach (double value in Time)
           // {
           //     prod *= value;
           // }
            Console.WriteLine("{0}", linesdat.GetLength(0));
            Console.ReadLine();

        }
    }
}
