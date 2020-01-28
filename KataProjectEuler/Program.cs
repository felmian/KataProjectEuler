﻿using KataProjectEuler.Interface;
using KataProjectEuler.Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            //001
            IProblemResult _001 = new _001_MultiplesOf3and5();
            _001.GetResult();

            //002
            IProblemResult _002 = new _002_EvenFibonaccinumbers();
            _002.GetResult();



            Console.ReadKey();
        }
    }
}
