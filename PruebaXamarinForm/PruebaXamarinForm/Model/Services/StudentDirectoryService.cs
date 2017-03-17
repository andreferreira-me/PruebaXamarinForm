using PruebaXamarinForm.Model.Entites;
using System;
using System.Collections.ObjectModel;

namespace PruebaXamarinForm.Model.Services
{
    public class StudentDirectoryService
    {
        public static StudentDirectory LoadStudentDirectory()
        {
            StudentDirectory studentDirectory = new StudentDirectory();
            ObservableCollection<Student> students;

            string[] names = { "André", "Luís", "Marcos", "José" };

            string[] lastNames = { "André", "Luís", "Marcos", "José" };

            Random rdn = new Random(DateTime.Now.Millisecond);

            students = new ObservableCollection<Student>();

            for (int i = 0; i < 20; i++)
            {
                Student student = new Student();
                student.Name = names[rdn.Next(0, 4)];
                student.LastName = lastNames[rdn.Next(0, 4)];

                string group = rdn.Next(456, 458).ToString();
                student.Group = group;
                student.StudentNumber = rdn.Next(123456, 3223423).ToString();
                student.Average = rdn.Next(100, 1000) / 10;

                students.Add(student);
            }

            studentDirectory.Students = students;
            return studentDirectory;
        }
    }
}
