using ConsoleCalculator;
using System;
using System.Collections.Generic;
using System.Linq;

    
namespace CalculatorLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            var oper = "";
            double x;
            double y;

            var operations = new List<string>()
            {
                "sum - сумма", "sub - разность", "div - деление", "sqrt - корень степени n"
            };

            if (args.Length > 0)
            {
                oper = args[0];
                x = Convert.ToDouble(args[1]);
                y = Convert.ToDouble(args[2]);
            }
            else
            {
                Console.WriteLine("Выберите операцию:");
                foreach (var item in operations)
                {
                    Console.WriteLine(item);
                }

                oper = Console.ReadLine();

                Console.WriteLine("Введите данные в одну строку, разделяя числа пробелом");
                var data = Console.ReadLine().Split(' ').Select(d => Convert.ToDouble(d)).ToArray();
                x = data[0];
                y = data.Length > 1 ? data[1] : 0;
            }

            Double result = double.NaN;

            Calculate calculate = new Calculate();

            result = calculate.Exec(oper, new[] { x.ToString(), y.ToString() });
            

            Console.WriteLine($"{oper}({x}, {y}) = {result}");

            Console.ReadKey();
        }
    }
}
