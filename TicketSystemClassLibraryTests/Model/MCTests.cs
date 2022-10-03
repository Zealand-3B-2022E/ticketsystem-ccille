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
        public void MC_Price()
        {
            //Arrange
            double expected = 125;

            //Act
            double actual = mc.Price();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MC_VehicleTest()
        {
            //Arrange
            string expected = "MC";

            //Act
            string actual = mc.VehicleType();

            //Assert
            Assert.AreEqual(expected, actual);
        }

    }
}