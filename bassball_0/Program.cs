using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bassball_0
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. 정답을 생성한다.
            Answer answer = new Answer();
            answer.Create(); //int[] answers = CreateAnswers();
            answer.print(); //PintNumbers("[정답] ", answers);

            int tryCount = 0;

            while(true)
            {
                tryCount++;

                // 2. 추축을 입력받는다.
                Guesses guess = new Guesses(); 
                guess.Input(); //int[] guesses = InputGuesses();
                guess.Print(); //PintNumbers("[추측] ", guesses);

                // 3. 정답과 추측을 비교하여 결과를 생성한다.
                Result result = new Result();
                result.Calculate(answer,guess);

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
