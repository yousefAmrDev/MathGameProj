namespace GameProj
{
    internal class MidLevel : Level
    {
        public override (string question, double result) GenerateQuestion()
        {
            int firstNumber = GenerateRandom(0, 15);
            int secondNumber = GenerateRandom(0, 15);
            char op = GetRandomOperator(new char[] { '+', '-', '*' });

            double result = 0;

            switch (op)
            {
                case '+': result = firstNumber + secondNumber; break;
                case '-': result = firstNumber - secondNumber; break;
                case '*': result = firstNumber * secondNumber; break;
            }

            return ($"{firstNumber} {op} {secondNumber}", result);
        }
    }
}