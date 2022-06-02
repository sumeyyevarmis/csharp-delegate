using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @delegate
{
    class Program
    {
        static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }
        static void Main(string[] args)
        {
            Func<int, int, int> add = Sum;
            int result = add(3, 5);
            Console.WriteLine(result);
            Console.ReadLine();
        }

    }
}
