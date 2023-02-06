using System;

namespace Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human human1 = new Human();


            human1.Name = "Hikmet";

            human1.Name = "Tofiq";
            human1.Surname = "Abbasov";
            human1.Age = 35;

            Human human2 = new Human();
            human2.Name = "Nermin";

            Console.WriteLine(human1.GetFullName());

            Student std1 = new Student(47)
            {
                FullName = "Eleddin",
                GroupNo = "P138",
            };

            Console.WriteLine(std1.IsPassed());


            Student std2 = new Student(76)
            {
                FullName = "Hikmet",
                GroupNo = "P123",
            };

            Console.WriteLine(std2.IsPassed());



        }
    }
}
