using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @delegate
{
    class Program
    {
        static void Sum(int number1, double number2)
        {
            Console.WriteLine("Number1: {0} + Number2: {1} = result {2}", number1, number2, number1 + number2);
        }
        delegate void sumDelegate(int x, double y);
        static void Main(string[] args)
        {
            sumDelegate sum = Sum; // sumDelegate sum = new sumDelegate(Topla);
            sum(3, 5);
            Console.ReadLine();
        }
    }
}
