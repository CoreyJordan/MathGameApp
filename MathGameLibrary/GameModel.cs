namespace MathGameLibrary
{
    public class GameModel
    {
        public int NumberOfQuestions { get; set; } = 10;
        public Operator Operation { get; set; }
        public int CorrectAnswers { get; set; }
        private double percentCorrect;

        public double PercentCorrect
        {
            get
            {
                percentCorrect = (double)CorrectAnswers / (double)NumberOfQuestions * 100;
                return percentCorrect; 
            }
        }

    }
}