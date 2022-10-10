using Microsoft.VisualStudio.TestTools.UnitTesting;
using Oresundbron.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oresundbron.model.Tests
{
    [TestClass()]
    public class OresundMCTests
    {
        private OresundMC omc = null;

        [TestInitialize]
        public void BeforeEachTest()
        {
            omc = new OresundMC();
        }

        [TestMethod()]
        public void Oresund_MCPrice_SchouldBe_With_BroBizz_Discount()
        {
            //Arrange
            double expected = 73;

            //Act
            double actual = omc.Price(true);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Oresund_MCPrice_SchouldBe_Without_Brobiz_Discount()
        {
            //Arrange
            double expected = 210;

            //Act
            double actual = omc.Price(false);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Oresund_MC_Type_string_OresundMC()
        {
            //Arrange
            string expected = "Oresund MC";

            //Act
            string actual = omc.VehicleType();

            //Assert
            Assert.AreEqual(expected, actual);
        }

       
    }
}