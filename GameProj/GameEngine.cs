using System;

namespace GameProj
{
    internal class GameEngine
    {
        Helper oHelper = new Helper();

        Level currentLevel;

        public GameEngine()
        {
            currentLevel = new EasyLevel();
        }

        public void StartGame()
        {
            bool keepPlaying = true;
            while (keepPlaying)
            {
                PlayRound();

                Console.WriteLine("\nDo you want to play another round? (y/n)");
                char choice = 'n';
                oHelper.ReadChar(ref choice);

                if (choice == 'n')
                {
                    keepPlaying = false;
                    Console.WriteLine("Thanks for playing!");
                }
            }
        }

        private void PlayRound()
        {
            oHelper.ClearScreen();

            // دي حركة ذكية بتجيب اسم الكلاس الحالي وتطبعه عشان متكتبوش بإيدك
            Console.WriteLine($"========== Hello in {currentLevel.GetType().Name} ===========");

            int questionCount = 0;
            Console.WriteLine("\nHow Many Questions do you want in this level?");
            oHelper.ReadInt(ref questionCount);

            double userAnswer = 0;
            byte score = 0;

            for (int i = 0; i < questionCount; i++)
            {

                var (question, result) = currentLevel.GenerateQuestion();

                Console.WriteLine($"\nQuestion {i + 1}-> : {question}");
                oHelper.ReadDouble(ref userAnswer);

                if (userAnswer == result)
                {
                    score++;
                }
            }

            double percentage = ((double)score / questionCount) * 100;

            if (percentage >= 50)
            {
                Console.WriteLine($@"\nCongratulations !!
You won and got {percentage}% ");

                UpgradeLevel();
            }
            else
            {
                Console.WriteLine($@"\nFailed !!
Your Percentage is {percentage}%. Try again!");
            }
        }

        // دالة مسؤولة عن ترقية المستوى
        private void UpgradeLevel()
        {
            if (currentLevel is EasyLevel)
            {
                Console.WriteLine("--> Level Up! You unlocked MidLevel.");
                currentLevel = new MidLevel(); // تغيير الأوبجكت للمستوى المتوسط
            }
            else if (currentLevel is MidLevel)
            {
                Console.WriteLine("--> Level Up! You unlocked HardLevel.");
                currentLevel = new HardLevel(); // تغيير الأوبجكت للمستوى الصعب
            }
            else if (currentLevel is HardLevel)
            {
                Console.WriteLine("--> You are a Master! You completed the HardLevel.");
                // بيفضل في المستوى الصعب زي ما هو لأنه آخر مستوى
            }
        }
    }
}