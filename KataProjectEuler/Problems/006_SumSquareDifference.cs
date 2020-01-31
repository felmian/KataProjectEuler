using KataProjectEuler.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*EN
    The sum of the squares of the first ten natural numbers is,
    1*1 + 2*2 + ... + 10*10 = 385
    The square of the sum of the first ten natural numbers is,
    (1 + 2 + ... + 10)*(1 + 2 + ... + 10) = 55*55 = 3025
    Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.
    Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.

  RU
    Сумма квадратов первых десяти натуральных чисел равна
    1*1 + 2*2 + ... + 10*10 = 385
    Квадрат суммы первых десяти натуральных чисел равен
    (1 + 2 + ... + 10)*(1 + 2 + ... + 10) = 55*55 = 3025
    Следовательно, разница между суммой квадратов первых десяти натуральных чисел и квадратом суммы составляет 3025 - 385 = 2640.
    Найти разницу между суммой квадратов первых ста натуральных чисел и квадратом суммы.
 */
namespace KataProjectEuler.Problems
{
    class _006_SumSquareDifference : IProblemResult
    {
        public void GetResult()
        {
            int maxRowNum = 100;
            int sumQuadrat = 0;
            int sumNum = 0;
            for (int i = 1; i <= maxRowNum; i++)
            {
                sumQuadrat += i * i;
                sumNum += i;
            }

            var result = sumNum * sumNum - sumQuadrat;
            Console.WriteLine("6:   " + result);
        }
    }
}
/*
 * Congratulations, the answer you gave to problem 6 is correct.
You are the 425545th person to have solved this problem.
This problem had a difficulty rating of 5%. The highest difficulty rating you have solved remains at 5%.

    Поздравляю, ответ, который вы дали на проблему 6, правильный.
Вы 425545-й человек, который решил эту проблему.
Эта проблема имела оценку сложности 5%. Самый высокий уровень сложности, который вы решили, остается на уровне 5%.
 */
