using System;
using System.IO;
using System.Text.Json;
using System.Runtime.Serialization.Formatters.Binary;


namespace HomeWork_5
{
    
    class Program
    {
        /// <summary>
        /// Ввести с клавиатуры произвольный набор данных и сохранить его в текстовый файл.
        /// </summary>
        static void Task1()
        {
            Console.WriteLine("________Запись текста в файл_________");
            Console.WriteLine("=====================================");
            Console.Write($"В файл записан текст: {SaveFile()}\n");
            Console.WriteLine("Для выхода нажмите Enter\n");
            Console.ReadKey(true);


            string SaveFile()
            {
                string filename = "SomeText.txt";
                Console.WriteLine("Введите текс:");
                string sometext = Console.ReadLine();
                File.WriteAllText(filename, sometext);
                string fileText = File.ReadAllText(filename);
                return fileText;
            }
        }
        /// <summary>
        /// Программа, которая при старте дописывает текущее время в файл «startup.txt».
        /// </summary>
        static void Task2()
        {
            Console.WriteLine("________Запись текущего времени в файл_________");
            Console.WriteLine("===============================================");
            Console.Write($"В файл записан текст: {TextToFile()}\n");
            Console.WriteLine("Для выхода нажмите Enter\n");
            Console.ReadKey(true);
            string TextToFile()
            {
                string filename = "startup.txt";                
                DateTime currenttime = DateTime.Now;
                string sometext = $"Текущее время = {currenttime.ToShortTimeString()}";
                File.WriteAllText(filename, sometext);
                string fileText = File.ReadAllText(filename);
                return fileText;
            }
        }
        /// <summary>
        /// Ввод с клавиатуры произвольный набор чисел (0...255) и запись их в бинарный файл.
        /// </summary>
        static void Task3()
        {
            Console.WriteLine("_____Запись в бинарый файл_____");
            Console.WriteLine("===============================");
            Console.WriteLine("Введите числа через пробел от 0 до 255");
            string numbers = Console.ReadLine();
            string[] arrNum = numbers.Split(' ');
            byte[] byteNum = new byte[arrNum.Length];
            for (int i = 0; i < byteNum.Length; i++)
            {
                byteNum[i] = Convert.ToByte(arrNum[i]);
            }
            File.WriteAllBytes("bytes.bin", byteNum);
            //Здесь я пытался записывать числа методом рекурсии, но файл перезаписывался а не добавлял значения.
            //Console.Write("Введите колл-во чисел: ");
            //int i = int.Parse(Console.ReadLine());            

            //byte[] numbers = new byte[i];
            //SaveBytes(numbers,i);

            //object SaveBytes(byte[] numbers,int i){
            //    if ( i == 0 ){ return 0; }
            //else
            //    {
            //        Console.Write("Введите число от 0 до 255: ");
            //        byte[] bytenumbers = new byte[] { Convert.ToByte(Console.ReadLine()) };
            //        File.WriteAllBytes("bytes.bin", bytenumbers);
            //    }


            //    return SaveBytes(numbers, i-1);
            //}
            Console.WriteLine("Вы успешно записали файл.");
            Console.WriteLine("Для выхода нажмите Enter\n");
            Console.ReadKey(true);

        }
        static void Task4()
        {

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
