using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic;
using DataAccessLayer;
using Test;

namespace BusinessLogic
{
    public class ConsoleViewier
    {
        DapperViewer dapperViewer;

        Logic Log0 { get; set; }
        public ConsoleViewier(Logic log) 
        {
            Log0=log;
            dapperViewer = new DapperViewer(Log0);
        }
        public void Main()
        {
            
            Console.WriteLine("Вас приветствует ДеканатPRO Entity version");
            while (true)
            {
                Console.WriteLine("\nВыберите дальнейшее действие:\n1 - Добавить студента\n2 - Удалить студента\n3 - Показать список студентов\n4 - Сформировать гистограмму с количеством студентов по направлениям\n5 - Выход из системы\n6 - Секретная функция\n");
                try
                {

                    int choice = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(" ");
                    switch (choice)
                    {
                        case 1:
                            AddStudent(Log0);
                            break;

                        case 2:
                            RemoveStudent(Log0);
                            break;

                        case 3:
                            
                            ShowStudents(Log0);
                            
                            break;
                        case 4:
                            ShowChart(Log0);
                            break;

                        case 5:
                            QuitProgram();
                            break;
                        case 6:
                            SecretFunction();
                            break;

                        default:
                            Console.WriteLine("\nТакой команды не существует\n");
                            break;
                    }
                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine("\nТакой команды не существует\n");
                }
            }
        
        }
        private void SecretFunction()
        {
            Console.WriteLine("\nВас приветствует ДеканатPRO Dapper version");
            while (true)
            {
                Console.WriteLine("\nВыберите дальнейшее действие:\n1 - Добавить студента\n2 - Удалить студента\n3 - Показать список студентов\n4 - Сформировать гистограмму с количеством студентов по направлениям\n5 - Выход из системы\n6 - Возвращение в несекретный режим\n");
                try
                {

                    int choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            dapperViewer.AddStudent_Dapp();
                            break;

                        case 2:
                            dapperViewer.RemoveStudent_Dapp();
                            break;

                        case 3:
                            dapperViewer.ShowStudents_Dapp();
                            break;
                        case 4:
                            dapperViewer.ShowChart_Dapp();
                            break;

                        case 5:
                            QuitProgram();
                            break;
                        case 6:
                            Main();
                            break;

                        default:
                            Console.WriteLine("\nТакой команды не существует\n");
                            break;
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("\nТакой команды не существует\n");
                }
            }
        }
      
        private static void QuitProgram()
        {
            Environment.Exit(0);
        }

        private static void ShowChart(Logic Log0)
        {
            Console.WriteLine(Log0.Get_gist_Console());
         
        }

        private static void ShowStudents(Logic Log0)
        {

            int number3 = 0;
            foreach (var stud in Log0.GetStudents())
            {

                number3++;

                Console.WriteLine($"{number3}. {stud[0]}, {stud[1]},{stud[2]}");
            }
        }

        private static void RemoveStudent(Logic Log0)
        {
            Console.WriteLine("Введите номер студента, которого необходимо удалить");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Log0.DeleteStudent(number2));
        }

        private static void AddStudent(Logic Log0)
        {
            Console.WriteLine("Введите ФИО студента");
            string name = Console.ReadLine(), speciality, group;
            Console.WriteLine("Введите специальность студента");
            speciality = Console.ReadLine();
            Console.WriteLine("Введите номер группы студента");
            group = Console.ReadLine();
            Log0.AddStudent(name, speciality, group);
        }
    }
}
