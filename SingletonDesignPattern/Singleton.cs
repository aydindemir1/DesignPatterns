﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{
    public class Singleton
    {
        private static Singleton instance = null;
        private static readonly object padlock = new object();

        Singleton()
        {
        }

        public static Singleton Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new Singleton();
                    }
                    return instance;
                }
            }
        }

        public void DoSomething()
        {
            Console.WriteLine("Singleton instance is working!");
        }
    }

}
