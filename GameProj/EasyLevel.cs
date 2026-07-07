namespace GameProj
{
    internal class EasyLevel : Level
    {
        public override (string question, double result) GenerateQuestion()
        {
            int firstNumber = GenerateRandom(0, 11);
            int secondNumber = GenerateRandom(0, 11);
            char op = GetRandomOperator(new char[] { '+', '-' });

            double result = 0;

            switch (op)
            {
                case '+': result = firstNumber + secondNumber; break;
                case '-': result = firstNumber - secondNumber; break;
            }

            return ($"{firstNumber} {op} {secondNumber}", result);
        }
    }
}