using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace BusinessLogic
{
    public class Logic
    {
        private List<Student> students { get; set; } = new List<Student>() { 
            new Student() {Name = "1", Speciality = "1", Group = "1" },
            new Student() {Name = "2", Speciality = "2", Group = "2" },
            new Student() {Name = "3", Speciality = "1", Group = "1" }};

        public string AddStudent(string name, string speciality, string group)
        {
            students.Add(new Student() { Name = name,Speciality = speciality, Group = group});
            //return (students.Count()).ToString();
            return "Студент успешно добавлен.";
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
            foreach (var student in students)
            {
                studentsInfo.Add(new List<string> {student.Name, student.Speciality, student.Group});
            }
            return studentsInfo;
        }

        public Dictionary<string, int> Get_gist_Form()
        {
            Dictionary<string, int> Specialities = new Dictionary<string, int>();


            int mxLenSpec = 0;


            if (students.Count > 0)
            {
                foreach (Student student in students)
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

            if (students.Count > 0)
            {
                foreach (Student student in students)
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
            if (index > students.Count || index < 1) return "Студент с таким номером не найден";
            else
            {
                students.Remove(students[index - 1]);
                return "Студент успешно удалён";
            }
        }
    }

    
}
