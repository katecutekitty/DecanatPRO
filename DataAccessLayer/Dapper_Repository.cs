using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;
using System.Data;
using Model;

namespace DataAccessLayer
{
    public class Dapper_Repository : IRepository<Student>
    {
        string connectionString = "DefaultConnection";
        public Dapper_Repository(string conn)
        {
            connectionString = conn;
        }

        public void Create(Student stud)
        {
            
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                
                var sqlQuery = "INSERT INTO Students (Name, Speciality,[Group]) VALUES(@Name, @Speciality, @Group)";
                db.Execute(sqlQuery, stud);

                
            }

        }
        public void Delete(Student student)
        {
            int id = student.Id;
            try
            {
                using (IDbConnection db = new SqlConnection(connectionString))
                {
                    var sqlQuery = "DELETE FROM Students WHERE Id = @id";
                    db.Execute(sqlQuery, new { id });
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Нельзя ввести пустой номер");
            }
                
            
        }
        public IEnumerable<Student> ReadAll() //переделать на лист
        {
            List<Student> students;
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                students = db.Query<Student>("SELECT * FROM Students ").ToList();
            }
            return students;
            
        }

        public Student ReadById(int id)
        {
            Student student;
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                student = db.Query<Student>("SELECT * FROM Students WHERE Id="+id).FirstOrDefault();
            }
            return student;
        }
    }
}
