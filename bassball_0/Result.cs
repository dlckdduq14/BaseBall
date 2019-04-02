using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bassball_0
{
    class Result
    {
        public int Strike; //internal 도 같은기능
        public int Ball;
        public int Out;

        public bool IsCorrect()
        {
            return Strike == Constant.Digit;   
        }

        internal void print()
        {
            Console.WriteLine($"S: {Strike}, B:{Ball}, O:{Out}");
        }

        public void Calculate(int[] answers, int[] guesses)
        {
            for (int i = 0; i < Constant.Digit; i++)
            {
                int j = (i + 1) % Constant.Digit;
                int k = (i + 2) % Constant.Digit;

                if (answers[i] == guesses[i])
                    Strike++;
                else if (answers[i] == guesses[j]
                       || answers[i] == guesses[k])
                    Ball++;
                else
                    Out++;
            }
        }
    }
}
