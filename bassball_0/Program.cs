using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bassball_0
{
    class Program
    {
        const int maxValue = 10;
        const int Digit = 3;
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] answers = new int[Digit];
            
            while(true)
            {
                //int i = 0;
                //while(i<Digit)
                //{
                //    answers[i] = random.Next(maxValue);
                //    i++;
                //}

                for (int i = 0; i < Digit; i++)
                    answers[i] = random.Next(maxValue);
                // todo: 나중에 수정
                if (answers[0] != answers[1] && answers[1] != answers[2] && answers[2] != answers[0])
                    break;
            }
            Console.WriteLine("[정답] ");
            for (int i = 0; i < Digit; i++)
                Console.WriteLine(answers[i] + "  ");
            Console.WriteLine();

            int tryCount = 0;

            while(true)
            {
                tryCount++;

                int[] guesses = new int[Digit];

                for (int i = 0; i < Digit; i++)
                {
                    guesses[i] = Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine("[추측] ");
                for (int i = 0; i < Digit; i++)
                    Console.WriteLine(guesses[i] + "  ");
                Console.WriteLine();

                int strike = 0;
                int ball   = 0;
                int @out   = 0;

                for (int i = 0; i < Digit; i++)
                {
                    int j = (i + 1) % Digit;
                    int k = (i + 2) % Digit;

                    if (answers[i] == guesses[i])
                        strike++;
                    else if ( answers[i] == guesses[j] 
                           || answers[i] == guesses[k])
                        ball++;
                    else
                        @out++;
                }

                Console.WriteLine($"S: {strike}, B:{ball}, C:{@out}");

                if (strike == Digit)
                    break;
            }

            Console.WriteLine($"총{tryCount}번 만에 했습니다.");
        }
    }
}
