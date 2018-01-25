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

            Calculate calculate = new Calculate();

            Double result = double.NaN;
            var oper = "";

            var data = new List<string>();

            var operations = calculate.GetOperationNames();

            //{
            //    "sum - сумма", "sub - разность", "div - деление", "sqrt - корень степени n","get - список операций"
            //};

            


            if (args.Length > 0)
            {
                oper = args[0];
                //x = Convert.ToDouble(args[1]);
                //y = Convert.ToDouble(args[2]);
                data.AddRange(new[] { args[1], args[2] });
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
                data = Console.ReadLine().Split(' ').ToList();
                    //x = data[0];
                    //y = data.Length > 1 ? data[1] : 0;
           
                
            }

            result = calculate.Exec(oper, data.ToArray());

            Console.WriteLine($"{oper}({string.Join(", ", data)}) = {result}");
            
            //Console.WriteLine($"{oper}({x}, {y}) = {result}");

            Console.ReadKey();
        }
    }
}
