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
    public class CarTests
    {
        private Car ca = null;

        [TestInitialize]
        public void BeforeEachTest()
        {
            ca = new Car();
        }

        /// <summary>
        /// Test for car prise at 240
        /// </summary>
        [TestMethod()]
        public void CarPrice_SchouldBe_240()
        {
            //Arrange
            double expected = 240;

            //Act
            double actual = ca.Price();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test for vechile car
        /// </summary>
        [TestMethod()]
        public void Vehicle_string_car()
        {
            //Arrange
            string expected = "Car";

            //Act
            string actual = ca.VehicleType();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}