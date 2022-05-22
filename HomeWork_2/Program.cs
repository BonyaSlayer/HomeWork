using System;

namespace HomeWork_2
{
    class Program
    {
        /// <summary>
        /// Выводим среднесуточную температуру в теплый период .
        /// </summary>
        static void Task1()
        {
            Console.WriteLine("Средняя температура в теплый период");
            Console.WriteLine("===================================");
            Console.Write("Укажите минимальную погоду на сегодня: ");
            string min = Console.ReadLine();
            int minTem = Convert.ToInt32(min);

            Console.Write("Укажите максимальную погоду на сегодня: ");
            string max = Console.ReadLine();
            int maxTem = Convert.ToInt32(max);

            int midTem = (minTem + maxTem) / 2;
            Console.WriteLine($"Средняя темпаратура {midTem}.");

            Console.Write("Для выхода нажмите Enter\n");
            Console.ReadKey();
        }
        /// <summary>
        /// Выводим название месяца по порядковому номеру.
        /// </summary>
        static void Task2()
        {
            Console.WriteLine("Какой сейчас месяц?");
            Console.WriteLine("===================");
            Console.Write("Укажите порядковый номер текущего месяца в формате ММ: ");        
            int monthN = int.Parse(Console.ReadLine());
            switch(monthN)
            {
                case 01: Console.WriteLine("Сейчас Январь"); 
                    break;
                case 02: Console.WriteLine("Сейчас Февраль");
                    break;
                case 03:
                    Console.WriteLine("Сейчас Март");
                    break;
                case 04:
                    Console.WriteLine("Сейчас Апрель");
                    break;
                case 05:
                    Console.WriteLine("Сейчас Май");
                    break;
                case 06:
                    Console.WriteLine("Сейчас Июнь");
                    break;
                case 07:
                    Console.WriteLine("Сейчас Июль");
                    break;
                case 08:
                    Console.WriteLine("Сейчас Август");
                    break;
                case 09:
                    Console.WriteLine("Сейчас Сентябрь");
                    break;
                case 10:
                    Console.WriteLine("Сейчас Октябрь");
                    break;
                case 11:
                    Console.WriteLine("Сейчас Ноябрь");
                    break;
                case 12:
                    Console.WriteLine("Сейчас Декабрь");
                    break;
            }
            Console.Write("Для выхода нажмите Enter\n");
            Console.ReadKey();
            }
        /// <summary>
        /// Выясняем четное или нечетное число.
        /// </summary>
        static void Task3()
        {
            Console.WriteLine("Четное или нечетное?");
            Console.WriteLine("===================");
            Console.Write("Укажите ваше число: ");
            int number = int.Parse(Console.ReadLine());

            if (number == 0)
            {
                Console.WriteLine("Вы ввели 0");
                return;
            } 
            else if (number % 2 == 0)
            {
                Console.WriteLine("Число четное");
                return;
            }
             else
            {
                Console.WriteLine("Число нечетное");
                
            }
            Console.Write("Для выхода нажмите Enter\n");
            Console.ReadKey();
        }
        /// <summary>
        /// Рисуем чек с переменными.
        /// </summary>
        static void Task4()
        {
            DateTime dat1 = DateTime.Now;
            Random rnd = new Random();
            int check = rnd.Next(1,500);
            int gang = rnd.Next(0, 3);

            Console.WriteLine("========== ООО Ромашка ==========");
            Console.WriteLine($"№ Чека: {check}");
            Console.WriteLine($"№ Смены: {gang}");
            Console.WriteLine($"Дата: {dat1}");
            Console.WriteLine("Наименование..Колл-во...Сумма   =");
            Console.WriteLine("Хлеб............1......25.00руб.=");
            Console.WriteLine("Молоко..........1......56.00руб.=");
            Console.WriteLine("Сыр Гауда.......1.....178.00руб.=");
            Console.WriteLine("Итого:..........3.....259.00руб.=");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("       Cпасибо за покупку        ");
            Console.WriteLine("=================================");
            Console.Write("Для выхода нажмите Enter\n");
            Console.ReadKey();
        }
        /// <summary>
        /// исходя из данных пользователя выводим сообщение.
        /// </summary>
        static void Task5() 
        {

            Console.WriteLine("Что по дождику?");
            Console.WriteLine("===============");
            Console.Write("Укажите порядковый номер месяца в формате ММ: ");
            int month = int.Parse(Console.ReadLine());
            Console.Write("Укажите минимальную погоду на сегодня: ");
            string min = Console.ReadLine();
            int minTem = Convert.ToInt32(min);

            Console.Write("Укажите максимальную погоду на сегодня: ");
            string max = Console.ReadLine();
            int maxTem = Convert.ToInt32(max);

            int midTem = (minTem + maxTem) / 2;
            if ((month == 12 || month == 01 || month == 02 ) && midTem > 0)
            {
                Console.WriteLine("Доджливая зима.");
            } else if (month == 12 || month == 01 || month == 02)
            {
                Console.WriteLine("Не дождливая зима");
            }else
            {
                Console.WriteLine("Сейчас не зима.");
            }
            Console.Write("Для выхода нажмите Enter\n");
            Console.ReadKey();
        }

        [Flags]
        public enum Graf
        {
            Понедельник = 0b0000001,
            Вторник = 0b0000010,
            Среда = 0b0000100,
            Четверг = 0b0001000,
            Пятница = 0b0010000,
            Суббота = 0b0100000,
            Воскресенье = 0b1000000

        }

        static void Task6() 
        {
           
            while (true)
            {
                Console.WriteLine("Расписание работы офиса");
                Console.WriteLine("=================================");
                Console.WriteLine("1 -> Офис 1");
                Console.WriteLine("2 -> Офис 2");
                Console.WriteLine("0 -> Завершение работы приложения");
                Console.WriteLine("=================================");

                Console.WriteLine("Выберите номер офиса.");
                Console.WriteLine("=====================");
                int OfficeN = int.Parse(Console.ReadLine());
                Graf office1 = (Graf)0b0011110;
                Graf office2 = (Graf)0b1111111;


                switch (OfficeN)
                {

                    case 0:
                        Console.WriteLine("Завершение работы приложения ...");
                        Console.Write("Для выхода нажмите Enter\n");
                        Console.ReadKey();
                        return;
                    case 1:
                        Console.WriteLine($"Офис 1 работает по графику {office1}\n");
                    break;
                    case 2:
                        Console.WriteLine($"Офис 2 работает по графику {office2}\n");
                        break;
                    default:
                        Console.WriteLine("Вы указали неверный номер офиса.");
                        break;
                }

            }
            

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
                Console.WriteLine("5 -> Задача 5");
                Console.WriteLine("6 -> Задача 6");
                Console.WriteLine("0 -> Завершение работы приложения");
                Console.WriteLine("=================================");

                Console.Write("Введите номер задачи: ");
                int number = int.Parse(Console.ReadLine());



                switch (number)
                {
                    case 2:
                        Task2();
                        break;

                    case 0:
                        Console.WriteLine("Завершение работы приложения ...");
                        Console.ReadKey();
                        return;

                    case 1:
                        Task1();
                        break;
                    case 3:
                        Task3();
                        break;
                    case 4:
                        Task4();
                        break;
                    case 5:
                        Task5();
                        break;
                    case 6:
                        Task6();
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
