using System;

namespace GameProj
{
    internal abstract class Level
    {
        protected Random random = new Random();

        protected char GetRandomOperator(char[] operators)
        {
            return operators[random.Next(operators.Length)];
        }

        public int GenerateRandom(int min, int max)
        {
            return random.Next(min, max + 1);
        }

        public abstract (string question, double result) GenerateQuestion();

    }
}
