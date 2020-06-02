using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overridemethos
{
    class Program
    {
        class math
        {
            public int Power(int input)
            {
                return input * input;
            }
            public int Power(int input, int count)
            {
                int result=0;
                for(int i = 0; i < count; i++)
                {
                }
                return result;
            }
            int SumAll(int end)
            {
                int result = 0;
                for(int i = 1; i <= end; i++)
                {
                    result += i;
                }
                return result;
            }
            int SumAll(int start,int end)
            {
                int result = 0;
                for (int i = start; i <= end; i++)
                {
                    result += i;
                }
                return result;
            }
        }
        
        static void Main(string[] args)
        {
        }
    }
}
