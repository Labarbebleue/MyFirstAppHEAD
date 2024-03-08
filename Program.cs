using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstAppHEAD
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            int area = 2;
            int height = 2;
            int width = 2;

            while (area<50)
            {
                height++;
                area = width * height;

            }
            do
            {
                width--;
                area = width * height;
            } while (area>25);

        }

    }
}

