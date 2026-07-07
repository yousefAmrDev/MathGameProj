using System;

namespace GameProj
{
    internal class Helper
    {
        public void ReadInt(ref int OutIn)
        {
            bool isConverted = int.TryParse(Console.ReadLine(), out OutIn);
            while (!isConverted)
            {
                Console.WriteLine("invalid input !! -->try again");
                isConverted = int.TryParse(Console.ReadLine(), out OutIn);
            }
        }
        public void ReadDouble(ref double OutIn)
        {
            bool isConverted = double.TryParse(Console.ReadLine(), out OutIn);
            while (!isConverted)
            {
                Console.WriteLine("invalid input !! -->try again");
                isConverted = double.TryParse(Console.ReadLine(), out OutIn);
            }
        }
        public void ReadChar(ref char OutIn)
        {
            bool isConverted = char.TryParse(Console.ReadLine().ToLower(), out OutIn);

            while (!isConverted)
            {
                Console.WriteLine("invalid input !! -->try again");
                isConverted = char.TryParse(Console.ReadLine(), out OutIn);
            }
        }

        public void ClearScreen()
        {
            Console.Clear();
        }

    }
}
