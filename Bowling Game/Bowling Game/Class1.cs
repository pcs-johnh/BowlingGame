using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Bowling_Game
{
   public class Game {
      public int Score { get; internal set; }
   }

   [TestFixture]
   public class GameTests {

      [Test]
      public void TestNoScore() {
         Game g = new Game();
         Assert.That(g.Score, Is.EqualTo(0));
      }
   }
}
