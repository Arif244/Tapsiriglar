 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_and_constraction
{
    internal class Student
    {
        public string FirstName;
        public string Surname;
        public byte Point;
        public bool IsGraduated;





        public Student(string name, string surname,byte point,bool Isgraduated):this(point,Isgraduated)
        {
            FirstName = name;
            Surname = surname;
            
        }

        public Student(byte point,bool Isgraduated):this(Isgraduated)
        {
            Point = point;
            if (point>80)
            {
                Console.WriteLine("imtahana buraxilir");
            }
            else
            {
                Console.WriteLine("imtahana buraxilmir");
            }
            
        }

        public Student(bool IsGraduated)
        {
            IsGraduated = true;

            if (true)
            {
                Console.WriteLine("bu telebe mezun olub");
            }
            else 
            {
                Console.WriteLine("bu telebe tehsilini davam etdirir");
            }
        }
    }
}
