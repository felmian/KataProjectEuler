﻿using KataProjectEuler.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*  EN
 * Each new term in the Fibonacci sequence is generated by adding the previous two terms. By starting with 1 and 2, the first 10 terms will be:
1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...
By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.
    RU
    Каждый новый член в последовательности Фибоначчи генерируется путем добавления двух предыдущих членов. Начиная с 1 и 2, первые 10 слагаемых будут:
1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...
Рассматривая члены в последовательности Фибоначчи, значения которых не превышают четырех миллионов, найдите сумму четных членов.
 */
namespace KataProjectEuler.Problems
{
    class _002_EvenFibonaccinumbers: IProblemResult
    {
        public void GetResult()
        {
            int sumChet = 0;
            int oldNum = 1;
            int newNum = 2;
            int bufer;

            while (newNum < 4_000_000)
            {
                bufer = GetSum(oldNum, newNum);
                oldNum = newNum;
                newNum = bufer;

                if (oldNum % 2 == 0)
                    sumChet += oldNum;

            }
            Console.WriteLine("2:   " + sumChet);
        }

        private int GetSum(int v1, int v2)
        {
            return v1 + v2;
        }

    }
}
/*
 * Congratulations, the answer you gave to problem 2 is correct.
You are the 654909th person to have solved this problem.
This problem had a difficulty rating of 5%. The highest difficulty rating you have solved remains at 5%.


    Поздравляю, ответ, который вы дали на проблему 2, правильный.
Вы 654909-й человек, который решил эту проблему.
Эта проблема имела оценку сложности 5%. Самый высокий уровень сложности, который вы решили, остается на уровне 5%.
 */
