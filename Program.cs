using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba5
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int i;
                produkt prod = null;
                do
                {
                    Console.Write("Меню:\n1) Создать новый продукт \n2) Установить атрибуты текущего продукта \n3) Вывести информацию о продуктах \n4) Вернуться \n\nЧто выберем: ");
                    i = int.Parse(Console.ReadLine());
                    switch (i)
                    {
                        case 1:
                            {
                                Console.WriteLine("\n1) Cоздать с помощью пользовательского конструктора \n2) Создать по умолчанию \n\nЧто выберем: ");
                                int F = Convert.ToInt32(Console.ReadLine());
                                string name = new string(' ', 20);
                                int amount;
                                float cost;
                                if (F == 1)
                                {
                                    Console.Write("Введите наименование товара ");
                                    name = Console.ReadLine();
                                    Console.Write("Введите кол-во товара ");
                                    amount = Convert.ToInt32(Console.ReadLine());
                                    Console.Write("Введите стоимость ");
                                    cost = Convert.ToSingle(Console.ReadLine());
                                    prod = new produkt(name, amount, cost);
                                    Console.WriteLine("Продукт создан");
                                }
                                else if (F == 2)
                                {
                                    prod = new produkt();
                                    Console.WriteLine("Продукт создан");
                                }
                                else
                                {
                                    Console.WriteLine("Ошибка");
                                }
                                break;
                            }
                        case 2:
                            {
                                if (prod != null)
                                {
                                    string name = new string(' ', 20);
                                    int amount;
                                    float cost;
                                    Console.Write("Введите наименование товара ");
                                    name = Console.ReadLine();
                                    Console.Write("Введите количество товара ");
                                    amount = Convert.ToInt32(Console.ReadLine());
                                    Console.Write("Введите стоимость ");
                                    cost = Convert.ToSingle(Console.ReadLine());
                                    prod.Name = name;
                                    prod.Amount = amount;
                                    prod.Cost = cost;
                                    Console.WriteLine("Продукт успешно изменен");
                                }
                                else
                                {
                                    Console.WriteLine("Вы забыли создать продукт");
                                }
                                break;
                            }
                        case 3:
                            {
                                if (prod != null)
                                {
                                    prod.GetInfo();
                                }
                                else
                                {
                                    Console.WriteLine("Вы забыли создать продукт");
                                }
                                break;
                            }
                        case 4:
                            {
                                Console.WriteLine("Обратно...");
                                break;
                            }
                        default:
                            Console.WriteLine("Нито...");
                            break;
                    }
                    Console.Write("\n\nНажмите любую клавишу...");
                    Console.ReadLine();
                    Console.Clear();
                }
                while (i != 4);
            }
        }
        }
}

