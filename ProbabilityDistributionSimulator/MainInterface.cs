using System;
using System.Windows.Forms;

namespace ProbabilityDistributionSimulator
{
    public partial class MainInterface : Form
    {
        GraphDrawer graphDrawer;
        public MainInterface()
        {
            InitializeComponent();
            graphDrawer = new GraphDrawer(pbGraph);
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            int average = Convert.ToInt32(nUpDownAverage.Value);
            int interval = Convert.ToInt32(nUpDownInterval.Value);
            int events = Convert.ToInt32(nUpDownEvents.Value);

            graphDrawer.Poisson = new PoissonGenerator(average, interval);
            graphDrawer.Exponential = new ExponentialGenerator(average, events);

            ExponentialGenerator exponentialGenerator = new ExponentialGenerator((double)interval / average, events);
            double[] simulatedEvents = exponentialGenerator.GenerateEvents(interval);
            graphDrawer.Simulation = simulatedEvents;

            pbGraph.Refresh();

            //Poisson
            double sampleMean = ArrayHelper.CalculatePoissonSampleMean(graphDrawer.PoissonExperiments);
            lblPoissonMean.Text = "Mean: " + sampleMean + " (Expected: " + graphDrawer.Poisson.CalculateExpectedMean() + ")";
            lblPoissonVariance.Text = "Variance: " + sampleMean + " (Expected: " + graphDrawer.Poisson.CalculateExpectedVariance() + ")";
            double sampleStandardDeviation = ArrayHelper.CalculatePoissonStandardDeviation(graphDrawer.PoissonExperiments);
            lblPoissonStandardDeviation.Text = "Standard deviation: " + Math.Round(sampleStandardDeviation, 5)
                + "\n(Expected: " + graphDrawer.Poisson.CalculateExpectedStandardDeviation() + ")";
            lblPoissonProbability.Text = "Poisson: " + Math.Round(graphDrawer.Poisson.CalculatePoisson(1), 6).ToString();

            //Exponential
            sampleMean = ArrayHelper.CalculateExponentialSampleMean(graphDrawer.ExponentialDistribution);
            lblExponentialMean.Text = "Mean: " + Math.Round(sampleMean, 5) + " (Expected: " + graphDrawer.Exponential.CalculateExpectedMean() + ")";
            double sampleVariance = ArrayHelper.CalculateExponentialVariance(graphDrawer.ExponentialDistribution);
            lblExponentialVariance.Text = "Variance: " + Math.Round(sampleVariance, 5) + " (Expected: " + graphDrawer.Exponential.CalculateExpectedVariance() + ")";
            lblExponentialStandardDeviation.Text = "Standard deviation: " + Math.Round(sampleMean, 5)
                + "\n(Expected: " + graphDrawer.Exponential.CalculateExpectedStandardDeviation() + ")";
            lblExponentialProbability.Text = "Exponential: " + Math.Round(graphDrawer.Exponential.CalculateExponential(1), 6).ToString();

            //Simulation
            average = Convert.ToInt32(nUpDownAverage.Value);
            interval = Convert.ToInt32(nUpDownInterval.Value);
            events = Convert.ToInt32(nUpDownEvents.Value);

            int expectedMean = interval / average;

            sampleMean = ArrayHelper.CalculateExponentialSampleMean(simulatedEvents);
            sampleVariance = ArrayHelper.CalculateVariance(simulatedEvents, sampleMean);
            lblSimulationMean.Text = "Mean: " + Math.Round(sampleMean, 5) + " (Expected: " + expectedMean + ")";
            lblSimulationVariance.Text = "Variance: " + Math.Round(sampleVariance, 5) + " (Expected: " + expectedMean + ")";
            lblSimulationStandardDeviation.Text = "Standard deviation: " + Math.Sqrt(sampleVariance)
                + "\n(Expected: " + Math.Sqrt(expectedMean) + ")";
        }
    }
}
