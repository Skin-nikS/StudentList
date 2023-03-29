using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.Arm;


///Напишите метод, который соберет всех учеников всех классов в один список, используя LINQ.
namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            var classes = new[]
            {
               new Classroom { Students = {"Evgeniy", "Sergey", "Andrew" },  },
               new Classroom { Students = {"Anna", "Viktor", "Vladimir"}, },
               new Classroom { Students = {"Bulat", "Alex", "Galina"}, }
           };
            var allStudents = GetAllStudents(classes);

            Console.WriteLine(string.Join(" ", allStudents));
        }

        static string[] GetAllStudents(Classroom[] classes)
        {
            var NameStudents = from student in classes
                               join st in classes on classroom.Stu equals st.Students
                               select new // выборка в новую сущность
                               {
                                   ClassroomStudent = st.Student
                                  
                               };// соединим по общему ключу (имя производителя) с производителями

            Console.WriteLine(NameStudents);
            foreach (var student in NameStudents)
                Console.WriteLine(student);
            
        }

        public class Classroom
        {
            public List<string> Students = new List<string>();
        }
    }
}