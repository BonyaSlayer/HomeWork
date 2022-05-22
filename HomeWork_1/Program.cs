using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_1
{
    class HomeWork_1
    {
        static void Main(string[] args)
        {
            Console.Write("Пожалуйста введите ваше имя: "); //Вывожу что требуется от юзера.
            string UserName = Console.ReadLine(); //Создаю переменную с инпутом.

            DateTime dateTime = DateTime.Now; // Создаю переменную с текущей датой и временем.
            Console.WriteLine($"{UserName}, сейчас :{dateTime}"); //Вывожу конечный результат с полученными данными
            Console.Write("Для закрытия программы введите quit и нажмите Enter: "); // Вывожу что требуется для завершения программы
            Console.ReadLine(); // конец программы
        }
    }
}
