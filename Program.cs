using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KockákOKTV2021
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Adja meg a torony magasságát: ");
            int s = int.Parse(Console.ReadLine());
            int ketmagas = 2;
            int harommagas = 3;
            int lehetoseg = 0;
            

            while(s != 0)
            {
                if(s % ketmagas == 0)
                {
                    for (int i = 0; i < s; i += 2)
                    {
                        lehetoseg++;
                    }
                }
                if(s % harommagas == 0)
                {
                    for (int i = 0; i < s; i += 3)
                    {
                        lehetoseg++;
                    }
                }
                lehetoseg += 2;
                
                s--;
            }
            Console.WriteLine(lehetoseg);
            Console.ReadKey();
        }
    }
}
