using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.IlyinME.Sprint3.Task6.V16.Lib
{
    public class DataService : ISprint3Task6V16
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int x;
            int count1 = 0;
            for (x = startValue; x <= stopValue; x++)
            {
                for (int del = 1; del <= x; del++)
                {
                    if (x % del == 0)
                    {
                        count1 += 1;
                    }
                }
            }
            return count1; 
        }
    }
}
