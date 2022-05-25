using System;
using System.Linq;

namespace HomeWork_3
{
    class Program
    {
        /// <summary>
        /// Выводим элементы двумерного массива по диагонали.
        /// </summary>
        static void Task1()
        {
            Console.WriteLine("Элементы двумерного массива по диагонали");
            Console.WriteLine("========================================");
            int[,] arr1 = new int[5, 5];
            Random rnd = new Random();
            int padleft = 0;

            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                for (int j = 0; j < arr1.GetLength(1); j++)
                {
                    arr1[i, j] = rnd.Next(0, 10);

                    Console.WriteLine(arr1[i, j].ToString().PadLeft(padleft += 1));
                }
            }

            Console.Write("Для выхода нажмите Enter\n");
            Console.ReadKey();
        }

        /// <summary>
        /// Телефонный справочник.
        /// </summary>
        static void Task2()
        {
            string[,] arr2;
            arr2 = new string[5, 2] { { "Вася", "+79221234545" }, { "Дима", "+79514789898" }, { "Женя", "example@email.com" }, { "Андрей", "+79997771212" }, { "Вова", "+79323221562" } };


            while (true)
            {
                Console.WriteLine("  Телефонный справочник");
                Console.WriteLine("=======================");
                Console.WriteLine("1 -> 1 контакт");
                Console.WriteLine("2 -> 2 контакт");
                Console.WriteLine("3 -> 3 контакт");
                Console.WriteLine("4 -> 4 контакт");
                Console.WriteLine("5 -> 5 контакт");
                Console.WriteLine("0 -> Закрыть справочник");
                Console.WriteLine("=======================");
                Console.WriteLine("Выберите контакт");
                int check = int.Parse(Console.ReadLine());
                switch (check)
                {
                    case 1:
                        Console.WriteLine($"{arr2[0, 0]} {arr2[0, 1]}\n");
                        break;
                    case 0:
                        Console.WriteLine("Закрываем... ");
                        Console.ReadKey();
                        return;
                    case 2:
                        Console.WriteLine($"{arr2[1, 0]} {arr2[1, 1]}\n");
                        break;
                    case 3:
                        Console.WriteLine($"{arr2[2, 0]} {arr2[2, 1]}\n");
                        break;
                    case 4:
                        Console.WriteLine($"{arr2[3, 0]} {arr2[3, 1]}\n");
                        break;
                    case 5:
                        Console.WriteLine($"{arr2[4, 0]} {arr2[4, 1]}\n");
                        break;
                    default:
                        Console.WriteLine("Выбран неверный контакт");
                        break;
                }
            }


        }
        /// <summary>
        /// Выводим введённую пользователем строку в обратном порядке
        /// </summary>
        static void Task3()
        {
            Console.WriteLine("Игра АПОЖ");
            Console.WriteLine("=========");
            Console.WriteLine("Напишите ваше слово.");
            string word = Console.ReadLine();
            Console.WriteLine(word.Reverse().ToArray());
            Console.Write("Для выхода нажмите Enter\n");
            Console.ReadKey();
        }
        /// <summary>
        /// Морской бой.
        /// </summary>
        static void Task4()
        {
            Console.WriteLine("Поле Морского боя");
            Console.WriteLine("=================");
            Random r = new Random();
            string[,] arr3 = new string[10, 10];
            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < 10; y++)
                {
                    arr3[x, y] = ".";
                }
            }
            
            AddShip();
            Draw();
            
            void AddShip()
            {
                
                    for (int x = 0; x < 10; x = r.Next(1, 11))
                    {
                        for (int y = 0; y < 10; y = r.Next(1, 11))
                        {
                        
                            arr3[x, y] = "X";
                        }
                    }
                
            }
            void Draw()
            {
                for (int x = 0; x < 10; x++)
                {
                    for (int y = 0; y < 10; y++)
                    {
                        Console.SetCursorPosition(11 + x * 2, 11 + y);
                        Console.WriteLine(arr3[x, y]);
                    }
                }


            }
            //void FreeSpace()
            //{
            //if (arr3[x, y] != '.')
            //{
            //
            //}
            //Здесь я хотел реализовать метод проверки, что бы корабли не пересекались но пока не понимаю как.
            //}
            Console.WriteLine("Для выхода нажмите Enter\n");
            Console.ReadKey();
        }

            static void Main(string[] args)
            {
                while (true)
                {

                    Console.WriteLine("Мои задачи");
                    Console.WriteLine("=================================");
                    Console.WriteLine("1 -> Задача 1");
                    Console.WriteLine("2 -> Задача 2");
                    Console.WriteLine("3 -> Задача 3");
                    Console.WriteLine("4 -> Задача 4");
                    Console.WriteLine("0 -> Завершение работы приложения");
                    Console.WriteLine("=================================");

                    Console.Write("Введите номер задачи: ");
                    int number = int.Parse(Console.ReadLine());



                    switch (number)
                    {
                        case 0:
                            Console.WriteLine("Завершение работы приложения ...");
                            Console.ReadKey();
                            return;

                        case 1:
                            Task1();
                            break;
                        case 2:
                            Task2();
                            break;
                        case 3:
                            Task3();
                            break;
                        case 4:
                            Task4();
                            break;
                        default:
                            Console.WriteLine("Некорректный номер задачи,\nповторите попытку ввода ...");
                            Console.ReadKey();
                            break;

                    }
                }
            }
        }
    }

