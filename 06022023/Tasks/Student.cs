using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks
{
    internal class Student
    {
        public Student(byte point)
        {
            Point = point;
        }
        public string FullName;
        public byte Point;
        public string GroupNo;

        public bool IsPassed()
        {
            if (Point >= 65)
                return true;
            else
                return false;
        }
    }
}
