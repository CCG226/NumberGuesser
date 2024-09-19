using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuesser
{
    internal class RandomNumberGuesser
    {

        public RandomNumberGuesser(int min, int max)
        {
            ValidRange(min, max);

            this.min = min;

            this.max = max;

            random = new Random();

            CreateNewRandomNumber();
        }

        private readonly int min;

        private readonly int max;

        private int numberToGuess;

        private Random random;

        public static readonly Color HighGuess = Color.Blue;

        public static readonly Color LowGuess = Color.Red;

        public static readonly Color PerfectGuess = Color.Green;

        public int GuessCount { get; set; }

        public void ValidRange(int minVal, int maxVal)
        {
            if (minVal > maxVal)
            {
                throw new ArgumentException("RandomNumberGuesser Error: min value cannot be greater than max! ");
            }
        }

        public void CreateNewRandomNumber()
        {
            GuessCount = 0;

            numberToGuess = random.Next(min, max + 1);
        }

        public Color Guess(int guess)
        {
            GuessCount++;

            if(guess > numberToGuess)
            {
                return HighGuess;
            }
            else if(guess < numberToGuess)
            {
                return LowGuess;
            }
            else
            {
                return PerfectGuess;
            }
        }
    }
}
