using System;
using System.Collections.Generic;
using System.Text;
using WutzgeTest;

namespace WutzgeTest
{
    internal class Wutzge
    {
        string name;
        bool geilesHessisch;

        public Wutzge (string n, bool gH)
        {
            name = n;
            geilesHessisch = gH;
        }

        public void isserDes()
        {
            if (geilesHessisch)
            {
                Console.ForegroundColor =  ConsoleColor.Green;
                Console.WriteLine("Hiiieer, des mussä sein!");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Des verwechselste!");
                Console.ResetColor();
            }
        }
    }
    
    }


