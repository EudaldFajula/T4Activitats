﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4Activitats.Act1
{
    internal class Parella<T1, T2>
    {
        public T1 Item1 { get; set; }
        public T2 Item2 { get; set; }
        public Parella(T1 item1, T2 item2)
        {
            Item1 = item1;
            Item2 = item2;
        }
        public void MostrarValors()
        {
            Console.WriteLine($"{Item1}, {Item2}");
        }
    }
}
