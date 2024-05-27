using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Proiect
{
    public partial class Form2 : Form
    {
        public List<Inchiriere> listaInchirieri;
        public Form2(List<Inchiriere> listaInchirieri)
        {
            InitializeComponent();
            this.listaInchirieri = listaInchirieri;
            AfisareGrafic();
        }

        private void AfisareGrafic()
        {
            var nrGenuri = listaInchirieri
                .SelectMany(i => i.Filme)
                .GroupBy(f => f.Gen)
                .Select(g => new { Gen = g.Key, Count = g.Count() })
                .ToList();

            graficInchirieri.Series.Clear();

            Series series = new Series
            {
                Name = "Filme inchiriate",
                Color = Color.DarkGreen,
                ChartType = SeriesChartType.Column
            };

            graficInchirieri.Series.Add(series);
            graficInchirieri.Titles.Add("Situatia casetelor inchiriate, grupate dupa gen");
            
            foreach (var i in nrGenuri)
            {
                series.Points.AddXY(i.Gen, i.Count);
            }

            graficInchirieri.Invalidate();
        }

        private void PrintChart(object sender, PrintPageEventArgs e)
        {
            Bitmap bmp = new Bitmap(graficInchirieri.Width,graficInchirieri.Height);
            graficInchirieri.DrawToBitmap(bmp, new Rectangle(0, 0, graficInchirieri.Width, graficInchirieri.Height));
            
            e.Graphics.DrawImage(bmp, 0,0);
        } 

        private void pRINTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(PrintChart);
            PrintPreviewDialog pdlg = new PrintPreviewDialog
            {
                Document = printDocument
            };
            pdlg.ShowDialog();
        }

        private void modificareCuloareBarsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if(cd.ShowDialog() == DialogResult.OK)
            {
                if(graficInchirieri.Series.Count > 0)
                {
                    graficInchirieri.Series[0].Color = cd.Color;
                    graficInchirieri.Invalidate();
                }
            }
        }
    }
}
