using System;
using yeni_nese;

namespace bezdim
{
    internal class Program
    {
        static void Main(string[] args)
        {

            student student = new student("Kitabulla", "Qarayev", "Bm99", 98);
            student student2 = new student("KERIM", "Agayev", "KL-76", 64);
            student.GetInfo();
            student.GetDiplomDegree();
            student.CheckGraduation();
            student2.GetInfo();
            student2.CheckGraduation();
            student2.GetDiplomDegree();
        }
    }
}