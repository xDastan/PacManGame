using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pacman;


namespace PacmanTests
{
    [TestClass]
    public class GameTests
    {
        private Game game;

        [TestInitialize]
        public void TestSetup()
        {
            game = new Game();
            game.SetPlayerPosition(new Point(10, 20));
        }

        [TestMethod]
        public void GameCanMovePlayerLeft()
        {
            game.MovePlayer(Direction.Left);
            AssertPlayerPositionIs(new Point(9, 20));
        }

        [TestMethod]
        public void GameCanMovePlayerRight()
        {
            game.MovePlayer(Direction.Right);
            AssertPlayerPositionIs(new Point(11, 20));
        }

        [TestMethod]
        public void GameCanMovePlayerUp()
        {
            game.MovePlayer(Direction.Up);
            AssertPlayerPositionIs(new Point(10, 19));
        }

        [TestMethod]
        public void GameCanMovePlayerDown()
        {
            game.MovePlayer(Direction.Down);
            AssertPlayerPositionIs(new Point(10, 21));
        }

        private void AssertPlayerPositionIs(Point expectedPosition)
        {
            var actualPosition = game.GetPlayerPosition();
            Assert.AreEqual(expectedPosition, actualPosition);
        }
    }
}
