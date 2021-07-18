using NUnit.Framework;
using UglyTrivia;


namespace TriviaTests
{
    [TestFixture]
    public class TriviaTests
    {
        [Test]
        public void Game_NewGame_CreatesGame()
        {
            var game = new Game();
            
            Assert.That(game,Is.Not.Null);
        }

        [Test]
        public void InPlayable_AddOnePlayer_ReturnsFalse()
        {
            var game = new Game();
            game.Add("Mike");
            Assert.That(game.IsPlayable, Is.False);
        }
        
        [Test]
        public void InPlayable_AddTwoPlayers_ReturnsTrue()
        {
            var game = new Game();
            game.Add("Mike");
            game.Add("Mary");
            Assert.That(game.IsPlayable, Is.True);
        }
    }
}