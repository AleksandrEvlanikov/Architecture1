﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture2.Singleton
{
    internal class Singleton
    {
        private static Singleton? instance;

        private Singleton() { }

        public static Singleton getInstance()
        {
            if (instance == null)
            {
                instance = new Singleton();

            }
            return instance;
            
        }
    }
}
