﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.SamarAA.Sprint0.Task2.V0.Lib;

namespace Tyuiu.SamarAA.Sprint0.Task2.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DataService.GetMessage("Андрей"));
            Console.ReadKey();
        }
    }
}
