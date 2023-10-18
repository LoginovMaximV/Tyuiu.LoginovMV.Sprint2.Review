using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.LoginovMV.Sprint2.TaskReview.V.Lib
{
    public class DataService : ISprint2Task7V15
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;
            if ((y >= 0) && ((Math.Pow(x, 2)) + (Math.Pow(y, 2)) <= 4) && (Math.Pow(x, 2) + Math.Pow(y, 2) >= 1))
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }
    }
}
