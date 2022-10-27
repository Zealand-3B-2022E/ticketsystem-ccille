using Microsoft.VisualStudio.TestTools.UnitTesting;
using Oresundbron;
using Oresundbron.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSystemClassLibraryTests.Model
{
    [TestClass()]
    public class OresundCarTest
    {
        private OresundCar ocar = null;

        [TestInitialize]
        public void BeforeEachTest()
        {
            ocar = new OresundCar();
        }

        [TestMethod()]
        public void Oresund_CarPrice_SchouldBe_With_BroBizz_Discount()
        {
            //Arrange
            double expected = 161;

            //Act
            double actual = ocar.Price(true);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Oresund_CarPrice_SchouldBe_Without_Brobiz_Discount()
        {
            //Arrange
            double expected = 410;

            //Act
            double actual = ocar.Price(false);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Oresund_Car_Type_string_OresundCar()
        {
            //Arrange
            string expected = "Oresund Car";

            //Act
            string actual = ocar.VehicleType();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
