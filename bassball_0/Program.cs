using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bassball_0
{
    class Program
    {
        /// <summary>
        /// 숫자 배열을 출력한다.
        /// </summary>
        /// <param name="prefix">숫자 출력전에 출력할 문자열</param>
        /// <param name="numbers">출력할 숫자</param>
        static void PintNumbers(string prefix, int[] numbers)
        {
            Console.WriteLine(prefix);
            for (int i = 0; i < Constant.Digit; i++)
                Console.Write(numbers[i] + " ");
            Console.WriteLine();
        }
        
        /// <summary>
        /// 3개의 랜덤한 숫자를 중복되지 않게 정답을 생성한다.
        /// </summary>
        /// <returns></returns>
        static int CreateAnswers()
        {
            Random random = new Random();
            int[] answers = new int[Constant.Digit];

            while (true)
            {
                for (int i = 0; i < Constant.Digit; i++)
                    answers[i] = random.Next(Constant.maxValue);
                // todo: 나중에 수정
                if (answers[0] != answers[1] && answers[1] != answers[2] && answers[2] != answers[0])
                    break;
            }

            return answers;
        }

        /// <summary>
        /// 추측을 입력 받는 장소를 만든다.
        /// </summary>
        /// <returns></returns>
        static int InputGuesses()
        {
            int[] guesses = new int[Constant.Digit];
            for (int i = 0; i < Constant.Digit; i++)
            {
                guesses[i] = Convert.ToInt32(Console.ReadLine());
            }

            return guesses;
        }

        static void Main(string[] args)
        {
            // 1. 정답을 생성한다.
            int[] answers = CreateAnswers();

            PintNumbers("[정답] ", answers);

            int tryCount = 0;
            
            while(true)
            {
                tryCount++;
                // 2. 추축을 입력받는다.
                int[] guesses = InputGuesses();

                PintNumbers("[추측] ", guesses);

                // 3. 정답과 추측을 비교하여 결과를 생성한다.
                Result result = new Result();

                result.Calculate(answers,guesses);

                // 4. 결과를 출력한다.
                result.print();

                // 5. 정답과 추측이 일치하지 않으면 2번으로 돌아간다.
                if (result.IsCorrect())
                    break;
            }
            // 6. 정답을 맞추는데 걸린 횟수를 출력하고 종료한다.
            Console.WriteLine($"총{tryCount}번 만에 했습니다.");
        }
    }
}
