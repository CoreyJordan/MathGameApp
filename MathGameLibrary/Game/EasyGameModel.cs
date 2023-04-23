using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGameLibrary.Game
{
    public class EasyGameModel : GameModel, IGameMode
    {
        public string Difficulty { get; } = "Easy";
        public EasyGameModel()
        {
            NumberOfQuestions = 5;
        }

        public int GetRand()
        {
            Random rand = new Random();
            return rand.Next(50) + 1;
        }
    }
}
