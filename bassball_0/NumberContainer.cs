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
    }
}
