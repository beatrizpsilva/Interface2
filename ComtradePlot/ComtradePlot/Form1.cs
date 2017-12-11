using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace ComtradePlot
{
    public partial class Form1 : Form
    {
        /*
         * Initialize the form - Constructor
         */
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Setup the graph
            CreateGraph(zedGraphControl1);

            // Size the control to fill the form with a margin
            SetSize();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            SetSize();
        }

        private void SetSize()
        {
            zedGraphControl1.Location = new Point(10, 25);
            // Leave a small margin around the outside of the control
            zedGraphControl1.Size = new Size(ClientRectangle.Width - 20,
                                             ClientRectangle.Height - 35);
        }

        // Build the chart
        private void CreateGraph(ZedGraphControl zgc)
        {
            // Get a reference to the GraphPane
            GraphPane myPane = zgc.GraphPane;

            // Set the titles 
            myPane.Title.Text = "COMTRADE Analog - Voltage";
            myPane.XAxis.Title.Text = "Time (s)";
            myPane.YAxis.Title.Text = "Voltage (V)";
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            String fname = "";

            // Filter the file
            file.Filter = "Configure file only | *.cfg";

            // Read the path to the file
            if (file.ShowDialog().Equals(DialogResult.OK))
            {
                fname = file.FileName;
            }

            // Read Comtrades
            Comtrade comtrade = new Comtrade(fname);

            // Clear chart data
            zedGraphControl1.GraphPane.CurveList.Clear();
            zedGraphControl1.GraphPane.GraphObjList.Clear();

            // Plot data
            for (int i = 2; i < 6 /*comtrade.analog.GetLength(1)*/; i++)
            {
                GraphPane pane = zedGraphControl1.GraphPane;

                // Receive eache vector from COMTRADES
                double[] analog = comtrade.AnalogGetColumn(i);

                // Add line to plot
                if (i == 2)
                    pane.AddCurve("", comtrade.time, analog, Color.Red, SymbolType.None);
                else if (i == 3)
                    pane.AddCurve("", comtrade.time, analog, Color.Green, SymbolType.None);
                else if (i == 4)
                    pane.AddCurve("", comtrade.time, analog, Color.Orange, SymbolType.None);
                else if (i == 5)
                    pane.AddCurve("", comtrade.time, analog, Color.Blue, SymbolType.None);
                else
                    pane.AddCurve("", comtrade.time, analog, Color.DarkCyan, SymbolType.None);
            }

            // Set axis
            zedGraphControl1.GraphPane.XAxis.Scale.Min = 0;
            zedGraphControl1.GraphPane.XAxis.Scale.Max = comtrade.time[comtrade.time.GetLength(0)-1];
            zedGraphControl1.GraphPane.YAxis.Scale.Min = -1000;
            zedGraphControl1.GraphPane.YAxis.Scale.Max = 1000;

            // Update plot chart
            zedGraphControl1.AxisChange();
            zedGraphControl1.Refresh();
        }
    }
}
