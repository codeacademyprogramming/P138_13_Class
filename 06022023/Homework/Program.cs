using System;

namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[0];
            string opt;
            do
            {
                Console.WriteLine("1. Butun telebelere bax");
                Console.WriteLine("2. Yeni telebe elave et");
                Console.WriteLine("3. Telebeler uzre axtaris et ");
                Console.WriteLine("4. Telebelerin adlarına bax");
                Console.WriteLine("5. Soyad sonluguna gore axtaris");
                Console.WriteLine("0. Cix");

                opt = Console.ReadLine();

                switch (opt)
                {
                    case "0":
                        Console.WriteLine("Proqram bitdi");
                        break;
                    case "1":
                        Console.WriteLine("\n============Telebeler===============");
                        for (int i = 0; i < students.Length; i++)
                        {
                            Console.WriteLine(students[i]);
                        }
                        break;
                    case "2":

                        string studentFullName;
                        do
                        {
                            Console.WriteLine("Telebe ad soyadi:");
                            studentFullName = Console.ReadLine();
                        } while (studentFullName.Length < 3);

                        Array.Resize(ref students, students.Length + 1);
                        students[students.Length-1] = ToCapitalize(studentFullName.Trim());
                        break;
                    case "3":
                        Console.WriteLine("Axtaris deyeri:");
                        string search = Console.ReadLine();

                        for (int i = 0; i < students.Length; i++)
                        {
                            if (students[i].Contains(search,StringComparison.OrdinalIgnoreCase))
                            {
                                Console.WriteLine(students[i]);
                            }
                        }
                        break;
                    case "4":
                        for (int i = 0; i < students.Length; i++)
                        {
                            Console.WriteLine(students[i].Substring(0, students[i].IndexOf(' ')));
                        }
                        break;
                    case "5":
                        Console.WriteLine("Soyad sonlugunu daxil edin");
                        string surnameEnding = Console.ReadLine();
                        for (int i = 0; i < students.Length; i++)
                        {
                            if (students[i].EndsWith(surnameEnding))
                                Console.WriteLine(students[i]);
                        }
                        break;
                    default:
                        Console.WriteLine("Seciminiz yanlisdir");
                        break;
                }

            } while (opt!="0");
        }
        static string ToCapitalize(string fullname)
        {
            var arr = fullname.Split(' ');

            for (int i = 0; i < arr.Length; i++)
            {
                var word = arr[i];

                if(word != "")
                {
                    arr[i] = char.ToUpper(word[0]) + word.Substring(1).ToLower();
                }
            }

            return String.Join(' ', arr);
        }
    }
}
