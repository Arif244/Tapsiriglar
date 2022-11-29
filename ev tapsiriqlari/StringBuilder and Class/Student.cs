using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilder_and_Class
{
    internal class Student
    {
        public string FirstName;
        public string Surname;
        public string Age;
        public string Gender;
        public string GroupNumber;
        public int Point;
        public Boolean IsGraduated;
        
        public string Firstname { get; internal set; }

        public void ShowFirstName()
        {
            Console.WriteLine(FirstName);
        }


        public void ShowFullName()
        {
            Console.WriteLine(FirstName+ " " + Surname);
        }
    }
}
