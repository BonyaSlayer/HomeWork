using System;

namespace HomeWork_4
{
    class Program
    {
        /// <summary>
        /// Программа вывода ФИО.
        /// </summary>
        static void Task1()
        {
            string GetfirstName()
            {
                Console.WriteLine("Введите имя");
                return Console.ReadLine();
            }
            string GetlasttName()
            {
                Console.WriteLine("Введите фамилию");
                return Console.ReadLine();
            }
            string Getpatronymic()
            {
                Console.WriteLine("Введите отчество");
                return Console.ReadLine();
            }
            //Склейка полученных данных
            string GetFullName(string firstName, string lastName, string patronymic)
            {
                return firstName + " " + lastName + " " + patronymic;
            }
            //Вывод данных из массива ФИО
            void PrintFLP()
            {
                //Создание массива ФИО                
                Console.WriteLine("-------Записная книжка с ФИО-----");
                Console.Write("Укажите колл-во ФИО для вывода: ");
                int i = int.Parse(Console.ReadLine());
                string[] arrFLP = new string[i];
                for (int a = 0; a < arrFLP.Length; a++)
                {
                    arrFLP[a] = GetFullName(GetfirstName(), GetlasttName(), Getpatronymic());
                }
                //Вывод данных из массива
                foreach (string FLP in arrFLP)
                {
                    Console.WriteLine("---------------------------------");
                    Console.WriteLine(FLP);
                    Console.WriteLine("---------------------------------");
                }
            }
            PrintFLP();
            Console.WriteLine("Для выхода нажмите Enter\n");
            Console.ReadKey(true);
        }
        /// <summary>
        /// Складываем конвертированые значения от пользователя.
        /// </summary>
        static void Task2()
        {
            Console.WriteLine("_________Сумма чисел___________");
            Console.WriteLine("Введите ваши числа через пробел");
            Console.WriteLine("=================================");
            string numbers = Console.ReadLine();
            string[] splitted = numbers.Split(' ');
            ConvertNumAndSum(splitted);
            //Метод конвертирует и складывает значения из массива строк.
            int ConvertNumAndSum(string[] splitted)
            {
                int result = 0;
                foreach (string value in splitted)
                {
                    result += Convert.ToInt32(value);
                }
                Console.WriteLine("=================================");
                Console.WriteLine("Сумма ваших чисел равна " + result);

                return 0;
            }
            Console.WriteLine("Для выхода нажмите Enter\n");
            Console.ReadKey(true);
        }
        public enum Seasons
        {
            Winter = 1,
            Spring = 2,
            Summer = 3,
            Autumn = 4,

        }
        /// <summary>
        /// Вывводим с помощью методов название времени года.
        /// </summary>
        static void Task3()
        {
            Console.WriteLine("____________Время года___________");            
            Console.WriteLine("=================================");
            NameofMonth(NumofMonth());
            
           

             object NumofMonth()
            {
                Console.Write("Введите номер месяца: ");
                int numMonth = int.Parse(Console.ReadLine());
                if(numMonth <= 0 || numMonth > 12){
                    Console.WriteLine("Ошибка: введите число от 1 до 12 ");
                    Console.WriteLine("Завершение работы...");
                    return 0;
                }
                else if (numMonth == 12 || numMonth == 1 || numMonth == 2)
                {
                    Seasons a = (Seasons)1;
                    object season = a;
                    return season;
                }
                else if (numMonth == 3 || numMonth == 4 || numMonth == 5)
                {
                    Seasons a = (Seasons)2;
                    object season = a;
                    return season;
                }
                else if (numMonth == 6 || numMonth == 7 || numMonth == 8)
                {
                    Seasons a = (Seasons)3;
                    object season = a;
                    return season;
                }
                else
                {
                    Seasons a = (Seasons)4;
                    object season = a;
                    return season;
                }                
            }
            object NameofMonth(object seson)
            {

                if (seson is (Seasons)1 )
                {
                string a = "Зима";
                    Console.WriteLine($"Сейчас {a}");
                }else if (seson is (Seasons)2 )
                {
                    string a = "Весна";
                    Console.WriteLine($"Сейчас {a}");
                }else if (seson is (Seasons)3)
                {
                    string a = "Лето";
                    Console.WriteLine($"Сейчас {a}");
                }
                else if (seson is (Seasons)4)
                {
                    string a = "Осень";
                    Console.WriteLine($"Сейчас {a}");
                }

                return 0;
            }

            Console.WriteLine("Для выхода нажмите Enter\n");
            Console.ReadKey(true);
            
        }
        /// <summary>
        /// Число Фибоначчи
        /// </summary>
        static void Task4()
        {
            Console.WriteLine("_________Число Фибоначчи_________");
            Console.WriteLine("=================================");
            Console.Write("Введите число: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine($"Число Фибоначчи равно {Fib(a)}");
            int Fib(int a)
            {
                if (a == 0 || a == 1) return a;

                return Fib(a - 1) + Fib(a - 2);
            }
            Console.WriteLine("Для выхода нажмите Enter\n");
            Console.ReadKey(true);
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
