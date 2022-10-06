using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicketSystemClassLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSystemClassLibrary.Model.Tests
{
    [TestClass()]
    public class MCTests
    {
        private MC mc = null;

        [TestInitialize]
        public void BeforeEachTest()
        {
            mc = new MC();
        }

        [TestMethod()]
        public void MC_Price_Without_Discont()
        {
            //Arrange
            double expected = 125;

            //Act
            double actual = mc.Price(false);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MC_Price_With_Brobiz_Discont()
        {
            //Arrange
            double expected = 125 * 0.95;

            //Act
            double actual = mc.Price(true);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MC_VehicleType_Success()
        {
            //Arrange
            string expected = "MC";

            //Act
            string actual = mc.VehicleType();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [DataRow("")]
        [DataRow("1234")]
        [DataRow("12345AD")]
        public void Vehicle_MC_Licensplate_7_CharchtersLong(string plate)
        {
            //Arrange


            //Act
            mc.LicensPlate = plate;

            //Assert
            Assert.IsTrue(7 >= mc.LicensPlate.Length);

        }
    }
}