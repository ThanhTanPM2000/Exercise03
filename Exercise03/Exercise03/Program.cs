using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03
{
    class Program
    {
        static void Main(string[] args)
        {

            VeCheo(4, 'k');
            Console.ReadLine();

        }
        static void VeNgang(int n, char c)
        {


            for (int i = 0; i < n; i++)
            {

                Console.Write(c);
            }
        }
        static void VeDoc(int n, char c)
        {


            for (int i = 0; i < n; i++)
            {

                Console.WriteLine("*");
            }
        }
        static void VeCheo(int n, char c)
        {
            for (int i = 0; i < n; i++)
            {
                VeNgang(i, ' ');
                Console.WriteLine(c);
            }
        }


    }
}

