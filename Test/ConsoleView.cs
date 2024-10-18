using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic;
using DataAccessLayer;


namespace Test
{
    internal class ConsoleView
    {
        static void Main(string[] args)
        {
            //консольный вывод, при необходимости раскоментировать:

            //ConsoleViewier view = new ConsoleViewier(new Logic(Logic.Create_new_Repository()));

            Dapper_Repository Dapp = Logic.Create_new_Dapper_Repository();
            EntityRepository Ent = Logic.Create_new_Entity_Repository();

            ConsoleViewier view = new ConsoleViewier(new Logic(Ent,Dapp));
            view.Main();

            //Logic log0 = new Logic(Logic.Create_new_Repository());
            //log0.AddStudent("Алексей", "ПИ", "КИ23");
            //Console.ReadLine();
        }
    }
}
