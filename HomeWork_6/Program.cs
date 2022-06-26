using System;
using System.Diagnostics;
using System.Linq;
namespace HomeWork_6
{
    class Program
    {
           
        static void Main(string[] args)
        {
            Process[] processes = Process.GetProcesses();
            Console.WriteLine("ID - Имя");
            foreach (Process process in processes)
            {
                Console.WriteLine($"{process.Id} - {process.ProcessName}");
            }

            KillProcess();

            /// <summary>
            /// Метод дает возможность удалить процесс по ID/name.
            /// </summary>     
            void KillProcess()
            {
                Console.Write("Удаление по имени или ID процесса?: ID/name ");
                string variant = Console.ReadLine();
                if (variant == "ID")
                {
                    Console.Write("Укажите ID процесса для удаления: ");
                    int processID = int.Parse(Console.ReadLine());

                    foreach (Process process in processes)
                    {
                        if (process.Id == processID)
                        {
                            process.Kill();
                            Console.WriteLine($"Процесс под номером {processID} удален.");
                        }
                    }
                }
                else
                {
                    Console.Write("Укажите имя процесса для удаления: ");
                    string processName = Console.ReadLine();
                    foreach (Process process in processes)
                    {
                        if (process.ProcessName == processName)
                        {
                            process.Kill();
                            Console.WriteLine($"Процесс под именем {processName} удален.");
                        }
                    }
                }
            }
            
            Console.WriteLine("Для выхода нажмите Enter\n");
            Console.ReadKey(true);
        }
    }
}
