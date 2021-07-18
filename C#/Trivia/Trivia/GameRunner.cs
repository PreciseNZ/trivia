using System;
using UglyTrivia;

namespace Trivia
{
    public class GameRunner
    {
        private static bool _notAWinner;

        public static void Main(string[] args)
        {
            var aGame = new Game();

            AddPlayers(aGame);
            PlayGame(aGame);
        }

        private static void PlayGame(Game aGame)
        {
            var rand = new Random();

            do
            {
                aGame.Roll(rand.Next(5) + 1);

                _notAWinner = rand.Next(9) == 7 ? aGame.WrongAnswer() : aGame.WasCorrectlyAnswered();
            } while (_notAWinner);
        }

        private static void AddPlayers(Game aGame)
        {
            aGame.Add("Chet");
            aGame.Add("Pat");
            aGame.Add("Sue");
        }
    }
}