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
                Console.WriteLine("Hiiieer, des mussä sein!");
            }
            else
            {
                Console.WriteLine("Des verwechselste!");
            }
        }
    }
    
    }


