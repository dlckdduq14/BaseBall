﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bassball_0
{
    class Answer
    {
        // public    : 접근 제한 없음
        // private   : 클래스 안에서만 접근가능
        // protected : 
        private int[] numbers = new int[Constant.Digit];

        public int At(int index)
        {
            Writelog();

            return numbers[index];
        }
        private void Writelog()
        {
        }
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
            Console.WriteLine("[정답] ");
            for (int i = 0; i < Constant.Digit; i++)
                Console.Write(numbers[i] + " ");
            Console.WriteLine();
        }
    }
}