using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Student
    {
        private int _id;

        public int Id
        {
            set
            {
                if( value <= 0 )
                {
                    throw new Exception("Student ID ne može biti negativan broj");
                }
                this._id = Id;
            }
            get
            {
                return this._id;
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Student S1 = new Student();
            S1.Id=2;
            

            Console.WriteLine(" This student id is {0}", S1.Id);
            
            Console.ReadKey();
        }
    }
}
