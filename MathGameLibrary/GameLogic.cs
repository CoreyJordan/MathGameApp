using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGameLibrary
{
    public class GameLogic
    {
        public static int Solution(int number1, int number2, Operator mode)
        {
            throw new NotImplementedException();
        }

        public static int GetRandomNumber()
        {
            Random rand = new Random();
            return rand.Next(100) + 1;
        }

        public static bool CheckGuess(int correctAnswer, int userGuess)
        {
            throw new NotImplementedException();
        }
    }
}
