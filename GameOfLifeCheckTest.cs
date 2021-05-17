using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WPF_GameOfLife;

namespace GameOfLifeTests
{
    [TestClass]
    public class GameOfLifeCheckTest
    {
        [TestMethod]
        public void setAbove1()
        {
            //Arrange
            GameOfLife gol = new GameOfLife(3,3);

            //Act
            gol.setAbove(1);

            //Assert
            Assert.AreEqual(gol.getAbove(), 1);
        }

        [TestMethod]
        public void setBelow12()
        {
            //Arrange
            GameOfLife gol = new GameOfLife(14, 14);

            //Act
            gol.setBelow(12);

            //Assert
            Assert.AreEqual(gol.getBelow(), 12);
        }

        [TestMethod]
        public void setLeft45()
        {
            //Arrange
            GameOfLife gol = new GameOfLife(50, 50);

            //Act
            gol.setLeft(45);

            //Assert
            Assert.AreEqual(gol.getLeft(), 45);
        }
    }
}
