using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.LoginovMV.Sprint2.TaskReview.V.Lib;

namespace Tyuiu.LoginovMV.Sprint2.TaskReview.V15
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            double x, y;
            Console.WriteLine("Введите значение Х:");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение Y:");
            y = Convert.ToDouble(Console.ReadLine());
            bool res = ds.CheckDotInShadedArea(x, y);
            if (res)
            {
                Console.WriteLine("Точка находится в заштрихованной области");
            }
            else
            {
                Console.WriteLine("Точка вне закрашенной области");
            }
            Console.ReadKey();

        }
    }
}
