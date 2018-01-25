using CalculatorLibrary;
using System.Linq;
using System.Collections.Generic;
using CalculatorLibrary.Operations;
using System.Reflection;
using System;
using System.IO;

namespace ConsoleCalculator
{
    public class Calculate
    {

        public Calculate()
        {
            Operations = new List<IOperation>();

            var curAssembly = Assembly.GetExecutingAssembly();
            // Операции из текущей сборки
            
            //Операции сторонних разработчиков
            var pathExtinsion = Path.Combine(Environment.CurrentDirectory + "extensions");

            //Если отсутствует дирректория 
            if (Directory.Exists(pathExtinsion))
            {
                var assemblies = Directory.GetFiles(pathExtinsion, "*.dll");

                foreach (var fileName in assemblies)
                {
                    LoadOperation(Assembly.LoadFile(fileName));
                }
            }
        }
   
        private void LoadOperation(Assembly assembly)
        {
            var types = assembly.GetTypes();

            foreach (var type in types)
            {
                if (type.IsAbstract)
                    continue;
                var intarfece = type.GetInterfaces();
                if (intarfece.Contains(typeof(IOperation)))
                {
                    var obj = Activator.CreateInstance(type) as IOperation;
                    if (obj != null)
                    {
                        Operations.Add(obj);

                    }
                }
            }

            var sumType = typeof(SumOperation);
            sumType.GetMethods();
            sumType.GetInterfaces();//рефлексия
        }

        private IList<IOperation> Operations;

        public string[] GetOperationNames()
        {
            return Operations.Select(o => o.Name).ToArray();
        }


        public double Exec(string operationName, string[] args)
        {
            IOperation oper;

            //bool Func (IOperation it, string operationName)
            //{
            //    return it.Name == operationName;
            //}

            //найти операцию в списке операций

            oper = Operations.FirstOrDefault(it => it.Name == operationName);

            //если не удалось найти возвращаем NaN

            if (oper == null)
            {
                return double.NaN;
            }
            //иначе
            //вычисляем результат
            var result = oper.Exec(args);

            //если в результате ошибка заполненна выводим ее на экран
            if (!string.IsNullOrWhiteSpace(result.Error))
            {
                //выводим на экран
                Console.WriteLine(result.Error);
            }
            else
            {
                //иначе выводим результат
                return result.Result;
            }

            return double.NaN;
        }



        [Obsolete("НЕ ИСПОЛЬЗОВАТЬ!")]
        public double Sum(double x, double y)
        {
            return x + y;
        }
        public double Sub(double x, double y)
        {
            return x - y;
        }
        public double Mul(double x, double y)
        {
            return x * y;
        }
        public double Div(double x, double y)
        {
            return x / y;
        }
    }
}
