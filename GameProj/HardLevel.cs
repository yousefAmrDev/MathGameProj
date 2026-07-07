using System;

namespace GameProj
{
    internal class HardLevel : Level
    {
        public double GenerateRandom(double min, double max)
        {
            return random.NextDouble() * (max - min) + min;
        }

        public override (string question, double result) GenerateQuestion()
        {

            double firstNumber = Math.Round(GenerateRandom(0, 30), 2);
            double secondNumber = Math.Round(GenerateRandom(0, 30), 2);
            char op = GetRandomOperator(new char[] { '+', '-', '*', '/' });

            double result = 0;

            if (op == '/')
            {
                secondNumber = Math.Round(GenerateRandom(1, 30), 2);
            }

            switch (op)
            {
                case '+': result = firstNumber + secondNumber; break;
                case '-': result = firstNumber - secondNumber; break;
                case '*': result = firstNumber * secondNumber; break;
                case '/': result = firstNumber / secondNumber; break;
            }

            result = Math.Round(result, 2);

            return ($"{firstNumber} {op} {secondNumber}", result);
        }

    }
}