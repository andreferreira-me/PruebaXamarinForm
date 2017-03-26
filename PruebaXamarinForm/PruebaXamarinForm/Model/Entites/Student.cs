using PruebaXamarinForm.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaXamarinForm.Model.Entites
{
    public class Student : ObservableBaseObject, IKeyObject
    {
        public string Key { get; set; }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; OnPropertyChanged(); }
        }

        private string lastName;

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; OnPropertyChanged(); }
        }

        private string group;

        public string Group
        {
            get { return group; }
            set { group = value; OnPropertyChanged(); }
        }

        private string studentNumber;

        public string StudentNumber
        {
            get { return studentNumber; }
            set { studentNumber = value; OnPropertyChanged(); }
        }

        private int average;

        public int Average
        {
            get { return average; }
            set { average = value; OnPropertyChanged(); }
        }
    }
}
