using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yeni_nese
{
    internal class student
    {
        public string Name;
        public string Surname;
        public string Group;
        public byte Point;
        public bool IsGraduated;

        public student(string name, string surname, string group, byte point)
        {
            Name = name;
            Surname = surname;
            Group = group;
            Point = point;
            CheckGraduation();
        }

        public void GetInfo()
        {
            Console.WriteLine($"Name: {Name}, Surname: {Surname}, Group: {Group}, Point: {Point}, IsGraduated: {IsGraduated}");
        }
        public void CheckGraduation()
        {
            IsGraduated = Point >= 65;

            if (IsGraduated)
            {
                Console.WriteLine("Finished");
            }
            else
            {
                Console.WriteLine("Failed");
            }
        }



        public void GetDiplomDegree()
        {
            if (Point < 65)
            {
                Console.WriteLine("None");
            }
            else if (Point <= 80)
            {
                Console.WriteLine("Simple");
            }
            else if (Point <= 90)
            {
                Console.WriteLine("Honor");
            }
            else 
            {
                Console.WriteLine("High honor");
            }
        }
    }
}
