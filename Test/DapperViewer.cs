using BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class DapperViewer
    {
        static Logic Log0;
        public DapperViewer(Logic log)
        {
            Log0 = log;
        }
        public void AddStudent_Dapp()
        {
            Console.WriteLine("Введите ФИО студента");
            string name = Console.ReadLine(), speciality, group;
            Console.WriteLine("Введите специальность студента");
            speciality = Console.ReadLine();
            Console.WriteLine("Введите номер группы студента");
            group = Console.ReadLine();
            Log0.AddStudent_Dapp(name, speciality, group);
        }

        public void RemoveStudent_Dapp()
        {
            Console.WriteLine("Введите номер студента, которого необходимо удалить");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Log0.DeleteStudent_Dapp(number2));
        }

        public void ShowChart_Dapp()
        {
            Console.WriteLine(Log0.Get_gist_Console_Dapp());

        }

        public void ShowStudents_Dapp()
        {

            int number3 = 0;
            foreach (var stud in Log0.GetStudents_Dapp())
            {

                number3++;

                Console.WriteLine($"{number3}. {stud[0]}, {stud[1]},{stud[2]}");
            }
        }
    }
}
