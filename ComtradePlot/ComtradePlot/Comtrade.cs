using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ComtradePlot
{
    class Comtrade
    {
        public string fileCfg;
        public string fileDat;
        private int versionDate;

        // Data
        public double[] time;
        public double[,] analog;

        public Comtrade (string file)
        {
            // Copy of cfg file path to the object
            fileCfg = String.Copy(file);

            // Copy the dat file path to the object
            fileDat = file.Replace(".cfg", ".dat");

            // Read COMTRADE data files to matrix
            Read();
        }

        private void Read ()
        {
            int j;

            // Tamanho dos ficheiros
            System.IO.FileInfo cfg = new System.IO.FileInfo(fileCfg);
            System.IO.FileInfo dat = new System.IO.FileInfo(fileDat);

            long sizecfg = cfg.Length;
            long sizedat = dat.Length;
            //Ler para Arrays 
            string[] linescfg = System.IO.File.ReadAllLines(fileCfg);
            string[] linesdat = System.IO.File.ReadAllLines(fileDat);
            // Decode Data 
            linescfg.GetLength(0);
            linesdat.GetLength(0);
            // Conversão Para Matrizes
            var datacfg = File.ReadLines(fileCfg).Select(x => x.Split(',')).ToArray();
            var datadat = File.ReadLines(fileDat).Select(x => x.Split(',')).ToArray();
            // Conversão para Int
            //int[] intArray = (int) Array.ConvertAll(datacfg, Int32.Parse);
            //int[] myInts = (int) datacfg.Select(int.Parse).ToArray();
            // Verificar a versão da Norma

            versionDate = 0;
            if (datacfg[0][2].Contains("1997"))
            {
                versionDate = 1997;
            }
            else
            {
                versionDate = (int)int.Parse(datacfg[0][2]);
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
            // Conversão do array de dados para double, extract the timestamps, scaled to seconds from microseconds  
            double[,] Time = new double[linesdat.GetLength(0), 1];
            for (int i = 0; i <= (linesdat.GetLength(0) - 1); i++)
            {
                Time[i, 0] = (double)double.Parse(datadat[i][0]) * 1e-6;
            }
            // Criar um cell com informação do .dat
            string[][] Datanalsys = new string[N_Channels][];
            for (int i = 0; i <= (N_Channels - 1); i++)
            {
                Datanalsys[i] = new string[1];
                j = i + 2;
                Datanalsys[i][0] = datacfg[j][1];
                /*  % If the first character is not a letter, replace with an 'x'*/
                bool isValid = char.IsLetter(Datanalsys[i][0].FirstOrDefault());
                if (isValid == true)
                {
                    Datanalsys[i][0] = 'X' + Datanalsys[i][0].Substring(1);
                }
                // If any character is not a letter or number, replace with an '_'.
                bool result = Datanalsys[i][0].All(Char.IsLetterOrDigit);
                if (result == false)
                {
                    Datanalsys[i][0] = new string(Datanalsys[i][0].Where(c => char.IsLetterOrDigit(c) || char.IsWhiteSpace(c) || c == '_').ToArray());
                }
            }
            // Pos processamento para cosntruir as forma de onda
            // Conversão e correção de valores
            double[,] DataDouble = new double[datadat.GetLength(0), 35];
            for (int i = 0; i <= (datadat.GetLength(0) - 1); i++)
            {
                for (j = 1; j <= 34; j++)
                {
                    if (datadat[i][j].Contains("9999999999"))
                    {
                        datadat[i][j] = "0";
                    }
                    DataDouble[i, j] = (double)double.Parse(datadat[i][j]);
                }
            }
            j = 0;
            // Canais analogicos
            if (NA_Channels >= 1)
            {
                for (int i = 0; i <= (NA_Channels - 1); i++)
                {
                    j = i + 2;
                    double min_level = (double)double.Parse(datacfg[j][8]);
                    double max_level = (double)double.Parse(datacfg[j][9]);
                    double multiplier = (double)double.Parse(datacfg[j][5], System.Globalization.NumberStyles.AllowDecimalPoint, System.Globalization.NumberFormatInfo.InvariantInfo);
                    double offset = (double)double.Parse(datacfg[j][6], System.Globalization.NumberStyles.AllowDecimalPoint, System.Globalization.NumberFormatInfo.InvariantInfo);
                    // Verificar o limite inferior
                    for (int k = 0; k <= (datadat.GetLength(0) - 1); k++)
                    {
                        if (DataDouble[k, j] <= min_level)
                        {
                            DataDouble[k, j] = min_level;
                        }
                    }
                    // Verificar o limite Superior
                    for (int k = 0; k <= (datadat.GetLength(0) - 1); k++)
                    {
                        if (DataDouble[k, j] >= max_level)
                        {
                            DataDouble[k, j] = max_level;
                        }
                    }

                    // Scaling do valor Segundo equação [ax+b]
                    double[,] ProstDat = new double[datadat.GetLength(0), 35];

                    for (int k = 0; k <= (datadat.GetLength(0) - 1); k++)
                    {
                        ProstDat[k, i] = DataDouble[k, j] * multiplier + offset;
                    }
                    /* If the Primary and Secondary scaling information is present,
                    apply that too*/
                    if (datacfg[j].Length >= 10)
                    {
                        double pri_scaling = (double)double.Parse(datacfg[j][10], System.Globalization.NumberStyles.AllowDecimalPoint, System.Globalization.NumberFormatInfo.InvariantInfo);
                        double sec_scaling = (double)double.Parse(datacfg[j][11], System.Globalization.NumberStyles.AllowDecimalPoint, System.Globalization.NumberFormatInfo.InvariantInfo);
                        char pri_sec = (char)char.Parse(datacfg[j][12]);
                        if (pri_sec == 'P')
                        {
                            for (int k = 0; k <= (datadat.GetLength(0) - 1); k++)
                            {
                                ProstDat[k, i] = DataDouble[k, i] * pri_scaling;
                            }
                        }
                        else
                        {
                            for (int k = 0; k <= (datadat.GetLength(0) - 1); k++)
                            {
                                ProstDat[k, i] = DataDouble[k, i] * sec_scaling;
                            }
                        }
                    }

//                    DataDouble = (double[,])ProstDat.Clone();
                }
            }

            // Return values

            //for (int i=0; i < Time.GetLength())
            time = Time.Cast<double>().ToArray();
            analog = (double[,])DataDouble.Clone();
        }

        public double[] AnalogGetColumn(int i)
        {
            double[] vector = new double[analog.GetLength(0)];

            if (i > analog.GetLength(1))
            {
                return vector;
            }

            for (int j = 0; j < analog.GetLength(0); j++)
            {
                vector[j] = analog[j, i];
            }

            return vector;
        }
    }
}
