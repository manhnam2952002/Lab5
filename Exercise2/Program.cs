using System;

namespace Exercise2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var highSchoolTeacher = new HightScholTeacher()
            {
                IdentityNumber = "ID001",
                Name = "Manhnam",
                BaseSalary = 100,
                Level = 1,
                Bonus = 100,
                IsSenior = false,
                HighSchoolCode = "HSOO1"
            };
            Console.WriteLine(highSchoolTeacher.CalculateSalary());

            var universityTeacher = new UniversityTeacher()
            {
                IdentityNumber = "ID002",
                Name = "Manhnam",
                BaseSalary = 60000,
                Level = 1,
                Bonus = 9000,
                IsSenior = true,
                EnglisLevel = 2,
                UniversityCode = "HSOO1"
            };
            Console.WriteLine(universityTeacher.CalculateSalary());
        }
    }
}