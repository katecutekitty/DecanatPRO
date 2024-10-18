using System.Collections.Generic;
using Model;
using System.Data.Entity;
//using Microsoft.Entit
using DataAccessLayer;
using System.ComponentModel;
using System.Linq;
using System;
using System.Diagnostics.Eventing.Reader;
using System.Data.Entity.ModelConfiguration.Conventions;
namespace BusinessLogic
{
    public class Logic
    {
        public IRepository<Student> repository { get; set; }
        
        public Logic(IRepository<Student> rep)
        {
            this.repository = rep;
            
        }
        public Logic()
        {

        }

        public static EntityRepository Create_new_Entity_Repository()
        {
            return new EntityRepository(new DataContext());
        }

        public static Dapper_Repository Create_new_Dapper_Repository()
        {
            return new Dapper_Repository("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\artem\\Downloads\\LABA2\\DecanPro\\DataAccessLayer\\Database1.mdf;Integrated Security=True");
        }

        public string AddStudent(string name, string speciality, string group)
        {
            repository.Create(new Student() { Name = name, Group = group, Speciality = speciality });
            return "Студент успешно добавлен";
        }


        public string AddStudent_Dapp(string name, string speciality, string group)
        {
            repository_dapp.Create(new Student() { Name = name, Group = group, Speciality = speciality });
            return "Студент успешно добавлен";
        }

        /// <summary>
        /// Возвращает информацию о студентах в формате строк. По индексу 0 - имя студента (Name), 1 - специальность (Speciality), 2 - Группа (Group)
        /// </summary>
        /// <returns>Лист листов строк, где каждый элемент - это лист из трёх строк. 
        /// По индексу 0 - имя студента (Name), 1 - специальность (Speciality), 2 - Группа (Group)
        /// </returns>
        public List<List<string>> GetStudents()
        {
            List<List<string>> studentsInfo = new List<List<string>>();

            foreach (Student student in repository.ReadAll().ToList())
            {
                studentsInfo.Add(new List<string> { student.Name, student.Speciality, student.Group });
            }
            return studentsInfo;
        }

        public List<List<string>> GetStudents_Dapp()
        {
            List<List<string>> studentsInfo = new List<List<string>>();

            foreach (Student student in repository_dapp.ReadAll().ToList())
            {
                studentsInfo.Add(new List<string> { student.Name, student.Speciality, student.Group });
            }
            return studentsInfo;
        }

        public Dictionary<string, int> Get_gist_Form()
        {
            Dictionary<string, int> Specialities = new Dictionary<string, int>();


            int mxLenSpec = 0;


            if (repository.ReadAll().ToList().Count() > 0)
            {
                foreach (Student student in repository.ReadAll().ToList())
                {

                    string spec = student.Speciality;

                    if (spec.Length > mxLenSpec)
                    {

                        mxLenSpec = spec.Length;

                    }

                    if (Specialities.ContainsKey(spec))
                    {
                        Specialities[spec] += 1;
                    }
                    else
                    {
                        Specialities.Add(spec, 1);
                    }
                }

            }
            return Specialities;
        }

        public Dictionary<string, int> Get_gist_Form_Dapp()
        {
            Dictionary<string, int> Specialities = new Dictionary<string, int>();


            int mxLenSpec = 0;


            if (repository_dapp.ReadAll().ToList().Count() > 0)
            {
                foreach (Student student in repository_dapp.ReadAll().ToList())
                {

                    string spec = student.Speciality;

                    if (spec.Length > mxLenSpec)
                    {

                        mxLenSpec = spec.Length;

                    }

                    if (Specialities.ContainsKey(spec))
                    {
                        Specialities[spec] += 1;
                    }
                    else
                    {
                        Specialities.Add(spec, 1);
                    }
                }

            }
            return Specialities;
        }


        
        public string Get_gist_Console() //только для консольного вывода
        {
            var Specialities = new Dictionary<string, int>();

            int mxLenSpec = 0;

            string result = string.Empty;

            if (repository.ReadAll().ToList().Count() > 0)
            {
                foreach (Student student in repository.ReadAll().ToList())
                {

                    string spec = student.Speciality;

                    if (spec.Length > mxLenSpec)
                    {

                        mxLenSpec = spec.Length;

                    }

                    if (Specialities.ContainsKey(spec))
                    {
                        Specialities[spec] += 1;
                    }
                    else
                    {
                        Specialities.Add(spec, 1);
                    }


                };
                foreach (var spec in Specialities)
                {
                    result += $"{spec.Key} ";
                    for (int i = 0; i < mxLenSpec - spec.Key.Length; ++i)
                    {
                        result += ' ';
                    };
                    for (int i = 0; i < spec.Value; i++)
                    {
                        result += '0';

                    }
                    result += "\n";
                }
                return result;
            }
            else return "Список студентов пуст.";
        }



        public string Get_gist_Console_Dapp() //только для консольного вывода
        {
            var Specialities = new Dictionary<string, int>();

            int mxLenSpec = 0;

            string result = string.Empty;

            if (repository_dapp.ReadAll().ToList().Count() > 0)
            {
                foreach (Student student in repository_dapp.ReadAll().ToList())
                {

                    string spec = student.Speciality;

                    if (spec.Length > mxLenSpec)
                    {

                        mxLenSpec = spec.Length;

                    }

                    if (Specialities.ContainsKey(spec))
                    {
                        Specialities[spec] += 1;
                    }
                    else
                    {
                        Specialities.Add(spec, 1);
                    }


                };
                foreach (var spec in Specialities)
                {
                    result += $"{spec.Key} ";
                    for (int i = 0; i < mxLenSpec - spec.Key.Length; ++i)
                    {
                        result += ' ';
                    };
                    for (int i = 0; i < spec.Value; i++)
                    {
                        result += '0';

                    }
                    result += "\n";
                }
                return result;
            }
            else return "Список студентов пуст.";
        }

        public string DeleteStudent(int index)
        {
            int i = 0;
            if (index > repository.ReadAll().ToList().Count() || index < 1) return "Студент с таким номером не найден";
            else
            {
                repository.Delete(repository.ReadAll().ToList()[index-1]);
                return "Студент успешно удалён"; 
            }
            return "Студент не найден";
        }

        public string DeleteStudent_Dapp(int index)
        {
            //int i = 0;
            if (index > repository_dapp.ReadAll().ToList().Count() || index < 1) return "Студент с таким номером не найден";
            else
            {
                
                repository_dapp.Delete(repository_dapp.ReadAll().ToList()[index - 1]);
                return "Студент успешно удалён";
            }
            return "Студент не найден";
        }
    }
}
