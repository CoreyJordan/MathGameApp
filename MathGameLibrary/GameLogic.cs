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
            int answer;
            switch (mode)
            {
                case Operator.Add:
                    answer = number1 + number2;
                    break;
                case Operator.Subtract:
                    answer = number1 - number2;
                    break;
                case Operator.Multiply:
                    answer = number1 * number2;
                    break;
                case Operator.Divide:
                    answer = number1 / number2;
                    break;
                default:
                    answer = -1;
                    break;
            }
            return answer;
        }

        public static int GetRandomNumber()
        {
            Random rand = new Random();
            return rand.Next(100) + 1;
        }

        public static bool CheckGuess(int correctAnswer, int userGuess)
        {
            bool isMatch = false;
            if (correctAnswer == userGuess)
            {
                isMatch = true;
            }
            return isMatch;
        }
    }
}
