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

            Student s = new Student();
            s.setId(2);
            s.setName("BigBarda");
            s.setM1(90);
            s.setM2(90);
            s.setM3(90);
            Char D= s.Grade();
            Console.WriteLine(D);


        }
    }

    class Student
    {

        int M;


        private int Id;
        public void setId(int id)
        {
            this.Id = id;
        }

        public int getId()
        {
            return Id;
        }
        private string Name;

        public void setName(string Name)
        {
            this.Name = Name;
        }

        public string getName()
        {
            return Name;
        }

        private int M1;
        public void setM1(int M1)
        {
            this.M1 = M1;
        }

        public int getM1()
        {
            return M1;
        }

        private int M2;
        public void setM2(int M2)
        {
            this.M2 = M2;
        }

        public int getM2()
        {
            return M2;
        }


        private int M3;
        public void setM3(int M3)
        {
            this.M3 = M3;
        }

        public int getM3()
        {
            return M3;
        }


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
