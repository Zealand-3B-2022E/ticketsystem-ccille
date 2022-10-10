using Microsoft.VisualStudio.TestTools.UnitTesting;
using StoreBaeltTicketLibrary_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreBaeltTicketLibrary_.Tests
{
    [TestClass()]
    public class StoreBaeltCarTests
    {
        private StoreBaeltCar stcar = null;

        [TestInitialize]
        public void BeforeEachTest()
        {
            stcar = new StoreBaeltCar();
        }

        [TestMethod()]
        [DataRow(0.9)]
        public void CarPrice_SchouldBe_With_Saturday_Or_Sunday_Discount_And_BroBizz(double delta)
        {
            //Arrange
            double expected = 183;

            //Act
            double actual = stcar.Price(true);

            //Assert
            Assert.AreEqual(expected, actual, delta);
        }


        [TestMethod()]
        public void CarPrice_SchouldBe_Without_Saturday_Or_Sunday_Discount()
        {
            //Arrange
            double expected = 240;

            //Act
            double actual = stcar.Price(false);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}