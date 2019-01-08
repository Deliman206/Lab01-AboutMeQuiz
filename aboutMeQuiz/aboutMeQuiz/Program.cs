using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace aboutMeQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] questions = { "Do I have a dog?", "What is my favorite sport?", "How many siblings do I have.", "What state did I go to college?", "What is my favorite color?" };
            string[] answersList = { "Yes\nNo", "Baseball\nFootball\nSoccer\nHockey", "Zero\nOne\nTwo\nThree", "California\nColorado\nOregon\nTexas", "Blue\nGreen\nPurple\nRed" };
            string[] answersCorrect = { "Yes", "Football", "Zero", "Colorado", "Blue" };
            bool[] userCorrectness = new bool[5];
            int questionCount = 0;

            Console.WriteLine("Welcome to a quiz about Sean! Answer the questions and I will give you a score at the end.");
            while(questionCount < 5)
            {
                Console.WriteLine(questions[questionCount]);
                Console.WriteLine(answersList[questionCount]);
                string userAnswer = Console.ReadLine();
                bool x = correct(userAnswer, answersCorrect, questionCount);
                userCorrectness[questionCount] = x;
                questionCount += 1;
            }
            int y = score(userCorrectness);
            string z = finalScript(y);
            Console.WriteLine(z);
            Console.Read();
        }
        static bool correct(string userAnswer, string[] answers, int questionCount)
        {
            try
            {
                if (userAnswer == answers[questionCount]) return true;
                return false;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return false;
        }
        static int score(bool[] userCorrectness)
        {
            int score = 0;
            foreach(bool answer in userCorrectness)
            {
                if (answer == true) score += 1;
            }
            return score;
        }
        static string finalScript(int score) => $"Congragulations, all done! Your score is {score}";
    }
}
