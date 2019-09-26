using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            xuatngay(23, 2, 2019);
            Console.ReadLine();
        }

        static void xuatngay(int day, int month, int year)
        {
            Console.Write("số ngày từ 1/1 đến ngày {0}/{1}/{2} bạn nhập là: ", day, month, year);
            Console.Write(TinhToanNgay(day, month, year));
        }
        static int TinhToanNgay(int day, int month, int year)
        {
            int SoNgay = 0;

            switch (month)
            {
                case 12:
                    SoNgay = 365 - 31 + day;

                    break;
                case 11:
                    SoNgay = 365 - 31 - 30 + day;
                    break;
                case 10:
                    SoNgay = 365 - 31 - 30 - 31 + day;
                    break;
                case 9:
                    SoNgay = 365 - 31 - 30 - 31 - 30 + day;
                    break;
                case 8:
                    SoNgay = 365 - 31 - 30 - 31 - 30 - 31 + day;
                    break;
                case 7:
                    SoNgay = 365 - 31 - 30 - 31 - 30 - 31 - 31 + day;
                    break;
                case 6:
                    SoNgay = 365 - 31 - 30 - 31 - 30 - 31 - 31 - 30 + day;
                    break;
                case 5:
                    SoNgay = 365 - 31 - 30 - 31 - 30 - 31 - 31 - 30 - 31 + day;
                    break;
                case 4:
                    SoNgay = 365 - 31 - 30 - 31 - 30 - 31 - 31 - 30 - 31 - 30 + day;
                    break;
                case 3:
                    SoNgay = 365 - 31 - 30 - 31 - 30 - 31 - 31 - 30 - 31 - 30 - 31 + day;
                    break;
                case 2:
                    if (year % 4 == 0) SoNgay = 365 - 31 - 30 - 31 - 30 - 31 - 31 - 30 - 31 - 30 - 31 - 28 + day;
                    else SoNgay = 366 - 31 - 30 - 31 - 30 - 31 - 31 - 30 - 31 - 30 - 31 - 29 + day;
                    break;
                case 1:
                    SoNgay = 365 - 31 - 30 - 31 - 30 - 31 - 31 - 30 - 31 - 30 - 32 - 28 - 31 + day;
                    break;

            }
            return SoNgay;

        }

    }
}
