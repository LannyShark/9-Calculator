using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, choice;
            Console.WriteLine("Вас приветствует калькулятор.");
            Console.Write("Введите целое число X=");
            try
            {
                x = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка! {0}", ex.Message);
            }
            Console.Write("Введите целое число Y=");
            try
            {
                y = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка! {0}", ex.Message);
            }
            Console.WriteLine("Введите код операции:\n\t1-сложение\n\t2-вычитание\n\t3-произведение\n\t4-частное");
            Console.Write("Ваш выбор: ");
            try
            {
                choice = Convert.ToInt32(Console.ReadLine());
            }
            catch when (choice < 1 || choice > 4)
            {
                Console.WriteLine("Нет операции с указанным номером");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                switch (choice)
                {
                    case 1:
                        {
                            x += y;
                            Console.WriteLine(x);
                            break;
                        }
                    case 2:
                        {
                            x -= y;
                            Console.WriteLine(x);
                            break;
                        }
                    case 3:
                        {
                            x *= y;
                            Console.WriteLine(x);
                            break;
                        }
                    case 4:
                        {
                            x /= y;
                            Console.WriteLine(x);
                            break;
                        }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            Console.ReadKey();
        }
    }
}
