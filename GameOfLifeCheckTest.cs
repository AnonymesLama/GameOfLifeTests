using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WPF_GameOfLife;

namespace GameOfLifeTests
{
    [TestClass]
    public class GameOfLifeCheckTest
    {
        [TestMethod]
        public void setAboveOf1()
        {
            //Arrange
            GameOfLife gol = new GameOfLife(3,3);

            //Act
            gol.Above = 2;

            //Assert
            Assert.AreEqual(gol.Above, 1);
        }

        [TestMethod]
        public void setBelowOf14()
        {
            //Arrange
            GameOfLife gol = new GameOfLife(14, 14);

            //Act
            gol.Below = 14;

            //Assert
            Assert.AreEqual(gol.Below, 0);
        }

        [TestMethod]
        public void setLeftOf46()
        {
            //Arrange
            GameOfLife gol = new GameOfLife(50, 50);

            //Act
            gol.Left = 46;

            //Assert
            Assert.AreEqual(gol.Left, 45);
        }
    }
}
