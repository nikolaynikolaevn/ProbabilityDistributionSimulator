using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProbabilityDistributionSimulator;
using System.Windows.Forms;

namespace ProbabilityDistributionSimulatorTests
{
    [TestClass]
    public class GraphDrawerTests
    {
        [TestMethod]
        public void GenerateGraphs()
        {
            //Arrange
            PictureBox pictureBox = new PictureBox();
            GraphDrawer graphDrawer = new GraphDrawer(pictureBox);

            //Act
            pictureBox.Refresh();

            //Assert
        }
    }
}
