using System;
using System.Collections.Generic;

namespace ProbabilityDistributionSimulator
{
    public class ExponentialGenerator
    {
        private double average;
        private int events;
        private Random rnd;
        public ExponentialGenerator(double average, int events = 20)
        {
            this.average = average;
            this.events = events;
            rnd = new Random();
        }
        public double[] GenerateExponentialDistribution()
        {
            double[] values = new double[events];
            for (int i = 0; i < values.Length; i++)
            {
                values[i] = (Math.Log(1 - rnd.NextDouble()) / (-average));
            }
            return values;
        }
        public double[] GenerateEvents(int interval)
        {
            List<double> events = new List<double>();
            double momentTime = 0;
            int eventsCount = 0;
            double[] samples = GenerateExponentialDistribution();

            foreach (double sample in samples)
            {
                if (momentTime >= interval)
                {
                    events.Add(eventsCount);
                    momentTime -= interval;
                    eventsCount = 0;
                }
                else
                {
                    eventsCount++;
                    momentTime += sample * interval;
                }
            }
            return events.ToArray();
        }
        public double CalculateExponential(double smallerOrEqual)
        {
            return Math.Exp(-smallerOrEqual * average);
        }
        public double CalculateExpectedMean()
        {
            return (double)1 / average;
        }
        public double CalculateExpectedVariance()
        {
            return 1 / Math.Pow(average, 2);
        }
        public double CalculateExpectedStandardDeviation()
        {
            return CalculateExpectedMean();
        }
    }
}
