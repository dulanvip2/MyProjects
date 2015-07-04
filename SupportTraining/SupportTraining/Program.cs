using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupportTraining
{
    //Support Training Program writtten by Dulan Chiranthaka
    // Interview Phase 2 - Segment 1
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("SupportTraining");
                    continue;
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Training");
                    continue;
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Support");
                    continue;
                }
                else
                {
                    Console.WriteLine(i);
                    continue;
                }
            }
            Console.Read();
        }
    }
}
