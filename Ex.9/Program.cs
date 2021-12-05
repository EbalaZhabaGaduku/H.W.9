using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._9
{
    class Program
    {
        static void Main(string[] args)
        {
            int answer = 0;
            
            try
            {
                Console.WriteLine("Введите первое число");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите второе число");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("код операции (например, 1 – сложение, 2 – вычитание, 3 – произведение, 4 – частное).");
                char k = Convert.ToChar(Console.ReadLine());
                switch (k)
                {
                    case '1':
                        answer = a + b;
                        Console.WriteLine("Ответ:",answer);
                        break;
                    case '2':
                        answer = a - b;
                        Console.WriteLine("Ответ:", answer);
                        break;
                    case '3':
                        answer = a * b;
                        Console.WriteLine("Ответ:", answer);
                        break;
                    case '4':
                        try
                        {
                            answer = a/b;
                            Console.WriteLine("Ответ:", answer);
                        }
                        catch (DivideByZeroException) 
                        {
                            Console.WriteLine("Деление на ноль");
                        }
                        break;
                }
                
            }
            catch
            {
                Console.WriteLine("Неверный тип данных");
            }
            Console.ReadKey();
        }
    }
}
