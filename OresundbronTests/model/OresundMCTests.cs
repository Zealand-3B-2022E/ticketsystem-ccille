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
        public void MCPrice_SchouldBe_With_BroBizz_Discount()
        {
            //Arrange
            double expected = 73;

            //Act
            double actual = omc.Price(true);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CarPrice_SchouldBe_Without_Discount()
        {
            //Arrange
            double expected = 240;

            //Act
            double actual = ca.Price(false);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}