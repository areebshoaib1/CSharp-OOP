using System;
using System.Collections.Generic;
using System.Text;

namespace _03_ConstructorObjectCounter
{
    internal class Student
    {
        private static int objectcount = 0;

        public Student()
        {
            objectcount++;
        }

        public int GetCount()
        {
            return objectcount;
        }
    }
}
