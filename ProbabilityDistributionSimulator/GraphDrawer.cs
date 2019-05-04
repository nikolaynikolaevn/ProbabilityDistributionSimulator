using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProbabilityDistributionSimulator
{
    public class GraphDrawer
    {
        private PictureBox pb;
        public PoissonGenerator Poisson { get; set; }
        public ExponentialGenerator Exponential { get; set; }
        public int[] PoissonExperiments { get; private set; }
        public double[] ExponentialDistribution { get; private set; }
        public double[] Simulation { get; set; }
        private Font font;
        private Brush verticalLineBrush;
        private Brush blackBrush;
        private Brush pointsBrush;
        private Pen PDFLinePen;
        public GraphDrawer(PictureBox pictureBox)
        {
            this.pb = pictureBox;
            this.pb.Paint += Draw;
        }
        public void Draw(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            font = SystemFonts.DefaultFont;
            verticalLineBrush = Brushes.Gray;
            blackBrush = Brushes.Black;
            pointsBrush = Brushes.LightGreen;
            PDFLinePen = Pens.Red;
            DrawPoisson(g);
            DrawExponential(g);
            DrawSimulation(g);
        }
        private void DrawPoisson(Graphics g)
        {
            if (Poisson != null)
            {
                PoissonExperiments = Poisson.GeneratePoissonExperiments();
                float all = PoissonExperiments.Length;
                for (int i = 40; i < 10000; i += 20)
                {
                    int count = ArrayHelper.CountNumber(PoissonExperiments, (i / 20 - 2));
                    float percantage = (count / all) * 200;
                    g.FillRectangle(blackBrush, i, 206 - percantage, 10, percantage);
                    g.DrawString((i / 20 - 2) + "", font, blackBrush, i, 216);
                }
                for (int i = 206; i >= 6; i -= 40)
                {
                    g.FillRectangle(verticalLineBrush, 40, i, pb.Width - 40, 1);
                    g.DrawString(((206 - i) / 2) + "%", font, blackBrush, 0, i - 6);
                }

                float[] points = new float[2];
                for (int i = 40; i < 10000; i += 20)
                {
                    double count = Poisson.CalculatePoisson((i / 20 - 2));
                    float percantage = (float)count * 200;
                    points[1] = points[0];
                    points[0] = 206 - percantage;
                    if (percantage >= 1)
                    {
                        if (i != 40) { g.DrawLine(PDFLinePen, i + 4, 206 - percantage, i - 16, points[1]); }
                        g.FillRectangle(pointsBrush, i + 2, 204 - percantage, 4, 4);
                    }
                }
            }
        }
        private void DrawExponential(Graphics g)
        {
            if (Exponential != null)
            {
                ExponentialDistribution = Exponential.GenerateExponentialDistribution();
                float all = ExponentialDistribution.Length;
                for (int i = 40; i < 10000; i += 20)
                {
                    int count = ArrayHelper.CountNumbersBetween(ExponentialDistribution, 0.1 * (i / 20 - 2), 0.1 * (i / 20 - 1));
                    float percantage = (count / all) * 200;
                    g.FillRectangle(blackBrush, i, 456 - percantage, 10, percantage);
                    g.DrawString(Math.Round(0.1 * (i / 20 - 2), 1) + "", font, blackBrush, i, 466);
                }
                for (int i = 456; i >= 256; i -= 40)
                {
                    g.FillRectangle(verticalLineBrush, 40, i, pb.Width - 40, 1);
                    g.DrawString(((456 - i) / 2) + "%", font, blackBrush, 0, i - 6);
                }

                float[] points = new float[2];
                for (int i = 40; i < 10000; i += 20)
                {
                    double count = Exponential.CalculateExponential(0.1 * (i / 20 - 2)) - Exponential.CalculateExponential(0.1 * (i / 20 - 1));
                    float percantage = (float)count * 200;
                    points[1] = points[0];
                    points[0] = 456 - percantage;
                    if (percantage >= 1)
                    {
                        if (i != 40) { g.DrawLine(PDFLinePen, i + 4, 456 - percantage, i - 16, points[1]); }
                        g.FillRectangle(pointsBrush, i + 2, 454 - percantage, 4, 4);
                    }
                }
            }
        }

        private void DrawSimulation(Graphics g)
        {
            if (Simulation != null)
            {
                float all = Simulation.Length;
                for (int i = 40; i < 10000; i += 20)
                {
                    int count = ArrayHelper.CountNumber(Simulation, (i / 20 - 2));
                    float percantage = (count / all) * 200;
                    g.FillRectangle(blackBrush, i, 706 - percantage, 10, percantage);
                    g.DrawString((i / 20 - 2) + "", font, blackBrush, i, 716);
                }
                for (int i = 706; i >= 506; i -= 40)
                {
                    g.FillRectangle(verticalLineBrush, 40, i, pb.Width - 40, 1);
                    g.DrawString(((706 - i) / 2) + "%", font, blackBrush, 0, i - 6);
                }

                float[] points = new float[2];
                for (int i = 40; i < 10000; i += 20)
                {
                    double count = Poisson.CalculatePoissonSimulation((i / 20 - 2));
                    float percantage = (float)count * 200;
                    points[1] = points[0];
                    points[0] = 706 - percantage;
                    if (percantage >= 1)
                    {
                        if (i != 40) { g.DrawLine(PDFLinePen, i + 4, 706 - percantage, i - 16, points[1]); }
                        g.FillRectangle(pointsBrush, i + 2, 704 - percantage, 4, 4);
                    }
                }
            }
        }
    }
}
