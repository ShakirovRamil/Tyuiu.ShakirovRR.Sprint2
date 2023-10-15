using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ShakirovRR.Sprint2.Task6.V10.Lib
{
    public class DataService : ISprint2Task6V10
    {
        public string FindDateOfPreviousDay(int n, int m, int g)
        {
            string res;
            switch (n)
            {
                case 1:
                    switch (m)
                    {
                        case 1:
                            n = 31;
                            m = 12;
                            g--;
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    n--;
                    break;
            }
            res = ($"{n}.{m}.{g}");
            return res;
        }
    }
}