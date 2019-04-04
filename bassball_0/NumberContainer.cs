using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bassball_0
{
    class NumberContainer
    {
        // public    : 제한 없음
        // private   : 클래스 안에서만
        // protected : 자기 자신과 자식들에게는 허용
        protected int[] numbers = new int[Constant.Digit];
        public int At(int index)
        {
            return numbers[index];
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
