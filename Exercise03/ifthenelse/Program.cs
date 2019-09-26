using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifthenelse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //Console.WriteLine("nhập vào 1 số");
            //int so = Int32.Parse(Console.ReadLine());
            //problem2(so);
            problem3(10, 4, 9);
            Console.WriteLine(nhapdiem(30));
            Console.ReadLine();
        }
        static void problem2(int n)
        {
            if (IsOdd(n))
                Console.WriteLine("{0} is Odd number", n);
            if (IsEven(n))
                Console.WriteLine("{0} is even number", n);
        }

        static bool IsOdd(int n)
        {
            return n % 2 == 1;
        }

        static bool IsEven(int n)
        {
            return n % 2 == 0;
        }

        //input: a,b,c
        //output: a is max if a>b>c
        //output: b is med if a>b>c
        //output: c is med if a>b>c
        static void problem3(int so1, int so2, int so3)
        {
            int max = FindMaxium(so1, so2, so3);
            int med = FindMedium(so1, so2, so3);
            int min = FindMinium(so1, so2, so3);
            Console.WriteLine("{0} is maxium between {1},{2},{3}", max, so1, so2, so3);
            Console.WriteLine("{0} is medium between {1},{2},{3}", med, so1, so2, so3);
            Console.WriteLine("{0} is minium between {1},{2},{3}", min, so1, so2, so3);
        }
        static int FindMaxium(int so1, int so2, int so3)
        {
            if (so1 >= so2 && so1 >= so3)
                return so1;
            else if (so2 >= so1 && so2 >= so3)
                return so2;
            else if (so3 >= so1 && so3 >= so2)
                return so3;
            return 0;
        }
        static int FindMedium(int so1, int so2, int so3)
        {
            if ((so1 >= so2 && so1 <= so2) || (so1 <= so2 && so1 >= so2))
                return so1;

            else if ((so2 >= so1 && so2 <= so3) || (so2 >= so1 && so2 <= so3))
                return so2;
            else if ((so3 >= so1 && so3 <= so2) || (so3 <= so1 && so3 >= so2))
                return so3;
            return 0;
        }
        static int FindMinium(int so1, int so2, int so3)
        {
            if (so1 <= so2 && so1 <= so3)
                return so1;
            else if (so2 <= so1 && so2 <= so3)
                return so2;
            else if (so3 <= so1 && so3 <= so2)
                return so3;
            return 0;
        }

        static string nhapdiem(int diem)
        {
            if (100 >= diem && diem >= 90) return "điểm A";
            else if (90 >= diem && diem > 80) return "điểm B";
            else if (80 >= diem && diem > 70) return "điểm C";
            else if (70 >= diem && diem > 60) return "điểm D";
            else if (60 >= diem && diem > 0) return "điểm F";
            else return "ko hợp lệ";
        }
    }
}
