using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bassball_0
{
    class Guesses : NumberContainer
    {
        public void Input()
        {
            for (int i = 0; i < Constant.Digit; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        public void print()
        {
            // todo: 둘중하나만 출력해야한다 =  가상함수로 해결
            Console.WriteLine("[추측] ");
            //Console.WriteLine("[정답] ");
            for (int i = 0; i < Constant.Digit; i++)
                Console.Write(numbers[i] + " ");
            Console.WriteLine();
        }
    }
}
