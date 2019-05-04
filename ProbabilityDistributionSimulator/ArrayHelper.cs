using System;

namespace ProbabilityDistributionSimulator
{
    public static class ArrayHelper
    {
        static public int CountTrue(bool[] array)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                count += array[i] ? 1 : 0;
            }
            return count;
        }
        static public int CountNumber(int[] array, int number)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                count += array[i] == number ? 1 : 0;
            }
            return count;
        }
        static public int CountNumber(double[] array, int number)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                count += array[i] == number ? 1 : 0;
            }
            return count;
        }
        static public int CountNumbersBetween(double[] array, double min, double max)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                count += array[i] >= min ? (array[i] < max ? 1 : 0) : 0;
            }
            return count;
        }
        static public double CalculatePoissonSampleMean(int[] experiments)
        {
            double sum = 0;
            foreach (int count in experiments)
            {
                sum += count;
            }
            return sum / experiments.Length;
        }
        static public double CalculateExponentialSampleMean(double[] distribution)
        {
            double sum = 0;
            foreach (double value in distribution)
            {
                sum += value;
            }
            return sum / distribution.Length;
        }
        static public double CalculatePoissonStandardDeviation(int[] experiments)
        {
            return Math.Sqrt(CalculatePoissonSampleMean(experiments));
        }
        static public double CalculateExponentialVariance(double[] distribution)
        {
            return Math.Pow(CalculateExponentialSampleMean(distribution), 2);
        }
        static public double CalculateVariance(double[] distribution, double mean)
        {
            double sum = 0;
            double difference = 0;
            foreach (double value in distribution)
            {
                difference = value - mean;
                sum += Math.Pow(difference, 2);
            }
            return sum / distribution.Length;
        }
    }
}
