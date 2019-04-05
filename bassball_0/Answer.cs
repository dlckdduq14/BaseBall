using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bassball_0
{
    class Answer : NumberContainer
    {
        public void Create()
        {
            Random random = new Random();

            while (true)
            {
                for (int i = 0; i < Constant.Digit; i++)
                    numbers[i] = random.Next(Constant.maxValue);
                // todo: 나중에 수정
                if (numbers[0] != numbers[1] && numbers[1] != numbers[2] && numbers[2] != numbers[0])
                    break;
            }
        }
        public void print()
        {
            // todo: 둘중하나만 출력해야한다 =  가상함수로 해결
            //Console.WriteLine("[추측] ");
            Console.WriteLine("[정답] ");
            for (int i = 0; i < Constant.Digit; i++)
                Console.Write(numbers[i] + " ");
            Console.WriteLine();
        }
    }
}
