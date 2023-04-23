using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGameLibrary.Game
{
    public class HardGameModel : GameModel, IGameMode
    {
        public string Difficulty { get; } = "Hard";
        public HardGameModel()
        {
            NumberOfQuestions = 15;
        }
        public int GetRand()
        {
            Random rand = new Random();
            return rand.Next(200) + 1;
        }
    }
}
