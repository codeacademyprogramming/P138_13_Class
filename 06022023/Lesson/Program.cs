using System;

namespace Lesson
{
    class Student
    {
       
        public string FullName;
        public byte Age;
        public string GroupNo;
        public byte Point;

        public void ShowInfo()
        {
            Console.WriteLine($"Fullname: {FullName} - Age: {Age} - GroupNo: {GroupNo} - Point: {Point}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Human human1 = new Human("Hikmet Abbasov");
            Human human2 = new Human("Tofiq Qulamov");
            Human human4 = new Human("Nermin Abbaszade", 39);




            Student std1 = new Student()
            {
                FullName = "Abbas Huseynov",
                Age = 34,
            };

            std1.ShowInfo();

            std1.Point = 76;
            std1.GroupNo = "P138";

            std1.Point = 80;


            Student std2 = new Student();

            std2.FullName = "Nermin Abbasova";
            std2.Age = 40;

            Student[] students = new Student[] { std1, std2 , new Student { FullName = "Hikmet  Abbasov" } };


            for (int i = 0; i < students.Length; i++)
            {
                students[i].ShowInfo();
            }


            Console.WriteLine();
        }
    }

}
