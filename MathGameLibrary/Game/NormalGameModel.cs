using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGameLibrary.Game
{
    public class NormalGameModel : GameModel, IGameMode
    {
        public string Difficulty { get; } = "Normal";
        public NormalGameModel()
        {
            NumberOfQuestions = 10;
        }

        public int GetRand()
        {
            Random rand = new Random();
            return rand.Next(100) + 1;
        }
    }
}
