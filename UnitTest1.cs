using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WPF_GameOfLife;

namespace GameOfLifeTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSetStatus_2x2_ToteZellen()
        {
            //Arrange
            GameOfLife gol = new GameOfLife();
            int breite = 2;
            int hoehe = 2;
            Feld[,] feld = new Feld[hoehe, breite];
            for (int i = 0; i < hoehe; i++)
            {
                for (int j = 0; j < breite; j++)
                {
                    feld[i, j] = new Feld(new Rectangle(), false);
                    String a = feld[i, j].ToString();
                }
            }
            int[,] soll = { { }, { }, }; //gewünschstes Ergebnis der Methode

            //Act
            int[,] test = gol.Calculate_Cells(feld, hoehe, breite);

            //Assert
            Assert.AreEqual(soll, test);
        }
    }
}
