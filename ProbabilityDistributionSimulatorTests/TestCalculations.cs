using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProbabilityDistributionSimulator;

namespace ProbabilityDistributionSimulatorTests
{
    [TestClass]
    public class TestCalculations
    {
        [TestMethod]
        public void CountTrueTest()
        {
            //Arrange
            bool[] bools = { true, false, false, true, true, true, false };

            //Act
            int count = ArrayHelper.CountTrue(bools);

            //Assert
            Assert.AreEqual(count, 4);
        }

        [TestMethod]
        public void CountNumberTest()
        {
            //Arrange
            int[] numbers = new int[7] { 1, 2, 5, 4, 2, 1, 5 };

            //Act
            int count = ArrayHelper.CountNumber(numbers, 5);

            //Assert
            Assert.AreEqual(count, 2);
        }

        [TestMethod]
        public void CountNumbersBetweenTest()
        {
            //Arrange
            double[] numbers = new double[7] { 1.5, 2.2, 5, 4.2252, 2, 1, 5 };

            //Act
            int count = ArrayHelper.CountNumbersBetween(numbers, 2, 5);

            //Assert
            Assert.AreEqual(count, 3);
        }

        [TestMethod]
        public void CalculatePoissonSampleMeanTest()
        {
            //Arrange
            int[] numbers = new int[7] { 1, 5, 5, 4, 2, 1, 5 };

            //Act
            double result = ArrayHelper.CalculatePoissonSampleMean(numbers);

            //Assert
            Assert.AreEqual(Math.Round(result, 4), 3.2857);
        }

        [TestMethod]
        public void CalculateExponentialSampleMeanTest()
        {
            //Arrange
            double[] numbers = new double[7] { 1, 5, 5, 4, 2, 1, 5 };

            //Act
            double result = ArrayHelper.CalculateExponentialSampleMean(numbers);

            //Assert
            Assert.AreEqual(Math.Round(result, 4), 3.2857);
        }

        [TestMethod]
        public void CalculatePoissonStandardDeviationTest()
        {
            //Arrange
            int[] numbers = new int[7] { 1, 5, 5, 4, 2, 1, 5 };

            //Act
            double result = ArrayHelper.CalculatePoissonStandardDeviation(numbers);

            //Assert
            Assert.AreEqual(Math.Round(result, 4), 1.8127);
        }

        [TestMethod]
        public void CalculateExponentialVarianceTest()
        {
            //Arrange
            double[] numbers = new double[7] { 1, 5, 5, 4, 2, 1, 5 };

            //Act
            double result = ArrayHelper.CalculateExponentialVariance(numbers);

            //Assert
            Assert.AreEqual(Math.Round(result, 4), 10.7959);
        }

        [TestMethod]
        public void GenerateExponentialDistributionTest()
        {
            //Arrange
            ExponentialGenerator exponentialGenerator = new ExponentialGenerator(20, 100);

            //Act
            double[] distribution = exponentialGenerator.GenerateExponentialDistribution();

            //Assert
            foreach (double number in distribution)
            {
                Assert.AreEqual(0, Math.Round(number));
            }
        }

        [TestMethod]
        public void CalculateExponentialTest()
        {
            //Arrange
            ExponentialGenerator exponentialGenerator = new ExponentialGenerator(4, 100);

            //Act
            double probability = exponentialGenerator.CalculateExponential(1);

            //Assert
            Assert.AreEqual(0.0183, Math.Round(probability, 4));
        }

        [TestMethod]
        public void CalculateExponentialExpectedMeanTest()
        {
            //Arrange
            ExponentialGenerator exponentialGenerator = new ExponentialGenerator(4, 100);

            //Act
            double number = exponentialGenerator.CalculateExpectedMean();

            //Assert
            Assert.AreEqual(0.25, number);
        }

        [TestMethod]
        public void CalculateExponentialExpectedVarianceTest()
        {
            //Arrange
            ExponentialGenerator exponentialGenerator = new ExponentialGenerator(4, 100);

            //Act
            double number = exponentialGenerator.CalculateExpectedVariance();

            //Assert
            Assert.AreEqual(0.0625, number);
        }

        [TestMethod]
        public void CalculateExponentialExpectedStandardDeviation()
        {
            //Arrange
            ExponentialGenerator exponentialGenerator = new ExponentialGenerator(4, 100);

            //Act
            double number = exponentialGenerator.CalculateExpectedStandardDeviation();

            //Assert
            Assert.AreEqual(0.25, number);
        }

        [TestMethod]
        public void GeneratePoissonExperimentsTest()
        {
            //Arrange
            PoissonGenerator poissonGenerator = new PoissonGenerator(4, 10000);

            //Act
            int[] values = poissonGenerator.GeneratePoissonExperiments();
            int count1 = ArrayHelper.CountNumber(values, 1);
            int count2 = ArrayHelper.CountNumber(values, 4);
            int count3 = ArrayHelper.CountNumber(values, 5);

            //Assert
            Assert.IsTrue(count1 < count2);
            Assert.IsTrue(count2 > count3);
        }

        [TestMethod]
        public void CalculatePoissonTest()
        {
            //Arrange
            PoissonGenerator poissonGenerator = new PoissonGenerator(4, 10000);

            //Act
            double probability = poissonGenerator.CalculatePoisson(1);

            //Assert
            Assert.AreEqual(0.0733, Math.Round(probability, 4));
        }

        [TestMethod]
        public void CalculatePoissonExpectedMeanTest()
        {
            //Arrange
            PoissonGenerator poissonGenerator = new PoissonGenerator(4, 10);

            //Act
            double number = poissonGenerator.CalculateExpectedMean();

            //Assert
            Assert.AreEqual(4, number);
        }

        [TestMethod]
        public void CalculatePoissonExpectedVarianceTest()
        {
            //Arrange
            PoissonGenerator poissonGenerator = new PoissonGenerator(4, 10);

            //Act
            double number = poissonGenerator.CalculateExpectedVariance();

            //Assert
            Assert.AreEqual(4, number);
        }

        [TestMethod]
        public void CalculatePoissonExpectedStandardDeviation()
        {
            //Arrange
            PoissonGenerator poissonGenerator = new PoissonGenerator(4, 10);

            //Act
            double number = poissonGenerator.CalculateExpectedStandardDeviation();

            //Assert
            Assert.AreEqual(2, number);
        }

        [TestMethod]
        public void GenerateBernoulliTrialsTest()
        {
            //Arrange
            UniformGenerator uniformGenerator = new UniformGenerator(4, 80);

            //Act
            int trials = uniformGenerator.GenerateBernoulliTrials();

            //Assert
            Assert.IsTrue(trials < 80);
        }
    }
}
