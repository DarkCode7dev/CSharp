using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {

            Student s = new Student { Id = 2, Name = "Bat", M1 = 77, M2 = 98, M3 = 88 };
           Char D= s.Grade();
            Console.WriteLine(D);


        }
    }

    class Student
    {

        int M;
        public int Id { get; set; }

        public string Name { get; set; }

        public int M1 { get; set; }
        public int M2 { get; set; }

        public int M3 { get; set; }


        public int Total()
        {
         
            M = M1 + M2 + M3;
            return M;
        }

        public char Grade()
        {
            M = Total();
            if (M > 90)
                return 'A';

            if (M < 90 && M > 80)
                return 'B';

            return 'C';
        }
    }
}
