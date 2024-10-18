using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic;
using DataAccessLayer;
using Model;
//Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\artem\Downloads\LABA2\DecanPro\DataAccessLayer\Database1.mdf;Integrated Security=True
namespace DataBaseTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dapper_Repository Dapp = new Dapper_Repository("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\artem\\Downloads\\LABA2\\DecanPro\\DataAccessLayer\\Database1.mdf;Integrated Security=True");
            Student stud0 = new Student() { Name = "1", Group = "1", Speciality = "1", Id=52 };
            Dapp.Delete(stud0);
            
        }
    }
}
