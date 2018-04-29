using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i % 2 != 0)
                    {
                        if (j % 2 != 0)
                        {
                            Console.Write(j);

                        }
                    }
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
