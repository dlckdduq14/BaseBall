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
    }
}
