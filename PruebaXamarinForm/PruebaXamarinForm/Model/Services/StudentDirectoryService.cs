using PruebaXamarinForm.Model.Entites;
using PruebaXamarinForm.Storage;
using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace PruebaXamarinForm.Model.Services
{
    public class StudentDirectoryService
    {
        public static StudentDirectory LoadStudentDirectory()
        {
            DatabaseManager dbManager = new DatabaseManager();
            ObservableCollection<Student> students = new ObservableCollection<Student>(dbManager.GetAllItems<Student>());
            StudentDirectory studentDirectory = new StudentDirectory();

            if (students.Any())
            {
                studentDirectory.Students = students;
                return studentDirectory;
            }

            students = new ObservableCollection<Student>();

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
                student.Key = student.StudentNumber;
                student.Average = rdn.Next(100, 1000) / 10;

                students.Add(student);
                dbManager.SaveValue(student);
            }

            studentDirectory.Students = students;
            return studentDirectory;
        }
    }
}
