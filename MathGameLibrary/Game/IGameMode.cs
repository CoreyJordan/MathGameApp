using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGameLibrary.Game
{
    public interface IGameMode
    {
        string Difficulty { get; }
        int NumberOfQuestions { get; set; }
        int CorrectAnswers { get; set; }
        double PercentCorrect { get; }
        int GetRand();
    }
}
