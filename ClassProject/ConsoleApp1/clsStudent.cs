﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class clsStudent
    {
        private string name = "Ümit"; //private->public
        public void getName()
        {
            Console.WriteLine(" Öğrencinin adı : {0}",this.name);
        }
    }
}
