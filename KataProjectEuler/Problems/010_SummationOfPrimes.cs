using KataProjectEuler.Interface;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
/*  EN
* The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
Find the sum of all the primes below two million.
RU
Сумма простых чисел ниже 10 составляет 2 + 3 + 5 + 7 = 17.
Найдите сумму всех простых чисел ниже двух миллионов.
*/
namespace KataProjectEuler.Problems
{
    class _010_SummationOfPrimes : IProblemResult
    {
        const int MAX_NUMBER = 2_000_000;
        ///// <summary>
        ///// Standart method
        ///// </summary>
        //public void GetResult()
        //{
        //    long sumRezult = 2;
        //    int colDelitel;
        //    for (int i = 2; i <= MAX_NUMBER; i++)
        //    {
        //        if (i % 2 == 0)
        //            continue;
        //        colDelitel = i / 2;
        //        for (int j = 2; j <= (i / 2) + 1; j++)
        //        {
        //            if (i % j == 0)
        //                break;
        //            colDelitel--;
        //        }
        //        if (colDelitel == 0)
        //        {
        //            sumRezult += i;
        //        }
        //    }
        //    Console.WriteLine("not paralel: "+sumRezult); //142913828922   
        //}
        /// <summary>
        /// Paralel
        /// </summary>
        public void GetResult()
        {
            long[] result = new long[20];
            long sumResult = 0;
            Parallel.Invoke(
                () => { result[1] += GetParalelResult(2, 200_000); },
                () => { result[2] += GetParalelResult(200_000, 400_000); },
                () => { result[3] += GetParalelResult(400_000, 600_000); },
                () => { result[4] += GetParalelResult(600_000, 800_000); },
                () => { result[5] += GetParalelResult(800_000, 1_000_000); },
                () => { result[6] += GetParalelResult(1_000_000, 1_100_000); },
                () => { result[7] += GetParalelResult(1_100_000, 1_200_000); },
                () => { result[8] += GetParalelResult(1_200_000, 1_300_000); },
                () => { result[9] += GetParalelResult(1_300_000, 1_400_000); },
                () => { result[10] += GetParalelResult(1_400_000, 1_500_000); },
                () => { result[11] += GetParalelResult(1_500_000, 1_600_000); },
                () => { result[12] += GetParalelResult(1_600_000, 1_650_000); },
                () => { result[13] += GetParalelResult(1_650_000, 1_700_000); },
                () => { result[14] += GetParalelResult(1_700_000, 1_750_000); },
                () => { result[15] += GetParalelResult(1_750_000, 1_800_000); },
                () => { result[16] += GetParalelResult(1_800_000, 1_850_000); },
                () => { result[17] += GetParalelResult(1_850_000, 1_900_000); },
                () => { result[18] += GetParalelResult(1_900_000, 1_950_000); },
                () => { result[19] += GetParalelResult(1_950_000, 1_990_000); },
                () => { result[0] += GetParalelResult(1_990_000, 2_000_000); }
                );
            for (int i = 0; i < result.Length; i++)
            {
                sumResult += result[i];
            }
            Console.WriteLine("9:   " + (sumResult + 2));
        }
       /// <summary>
       /// Task
       /// </summary>
        public void GetParalel()
        {
            long sumResult = 0;
            List<Task<long>> tasks = new List<Task<long>>();
            tasks.Add(GetTaskResult(2, 200_000));
            tasks.Add(GetTaskResult(200_000, 400_000));
            tasks.Add(GetTaskResult(400_000, 600_000));
            tasks.Add(GetTaskResult(600_000, 800_000));
            tasks.Add(GetTaskResult(800_000, 1_000_000));
            tasks.Add(GetTaskResult(1_000_000, 1_100_000));
            tasks.Add(GetTaskResult(1_100_000, 1_200_000));
            tasks.Add(GetTaskResult(1_200_000, 1_300_000));
            tasks.Add(GetTaskResult(1_300_000, 1_400_000));
            tasks.Add(GetTaskResult(1_400_000, 1_500_000));
            tasks.Add(GetTaskResult(1_500_000, 1_600_000));
            tasks.Add(GetTaskResult(1_600_000, 1_650_000));
            tasks.Add(GetTaskResult(1_650_000, 1_700_000));
            tasks.Add(GetTaskResult(1_700_000, 1_750_000));
            tasks.Add(GetTaskResult(1_750_000, 1_800_000));
            tasks.Add(GetTaskResult(1_800_000, 1_850_000));
            tasks.Add(GetTaskResult(1_850_000, 1_900_000));
            tasks.Add(GetTaskResult(1_900_000, 1_950_000));
            tasks.Add(GetTaskResult(1_950_000, 1_990_000));
            tasks.Add(GetTaskResult(1_990_000, 2_000_000));

            Task.WaitAll(tasks.ToArray());
            foreach (var item in tasks)
            {
                sumResult += item.Result;
            }
            Console.WriteLine("9:   " + (sumResult + 2));
        }
        private Task<long> GetTaskResult(int start, int end)
        {
            return Task.Run(() =>
            {
                long sumRezult = 0;
                int colDelitel;
                for (int i = start; i <= end; i++)
                {
                    if (i % 2 == 0)
                        continue;
                    colDelitel = i / 2;
                    for (int j = 2; j <= (i / 2) + 1; j++)
                    {
                        if (i % j == 0)
                            break;
                        colDelitel--;
                    }
                    if (colDelitel == 0)
                    {
                        sumRezult += i;
                    }
                }
                //Console.WriteLine($"start[{start}:] " + sumRezult);
                return sumRezult;
            });
           

        }
        private long GetParalelResult(int start, int end)
        {

            long sumRezult = 0;
            int colDelitel;
            for (int i = start; i <= end; i++)
            {
                if (i % 2 == 0)
                    continue;
                colDelitel = i / 2;
                for (int j = 2; j <= (i / 2) + 1; j++)
                {
                    if (i % j == 0)
                        break;
                    colDelitel--;
                }
                if (colDelitel == 0)
                {
                    sumRezult += i;
                }
            }
            //Console.WriteLine($"start[{start}:] " + sumRezult);
            return sumRezult;


        }
    }
}
/*
 * Congratulations, the answer you gave to problem 10 is correct.
You are the 283862nd person to have solved this problem.
You have earned 1 new award:
Decathlete: Solve ten consecutive problems
This problem had a difficulty rating of 5%. The highest difficulty rating you have solved remains at 5%.

    Поздравляю, ответ, который вы дали на проблему 10, правильный.
Вы - 283862-й человек, который решил эту проблему.
Вы заработали 1 новую награду:
Decathlete: решить десять последовательных задач
Эта проблема имела оценку сложности 5%. Самый высокий уровень сложности, который вы решили, остается на уровне 5%.
 */
