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
        private string _name;

        public void SetId(int Id)
        {
            if (Id <= 0)
            {
                throw new Exception("Students Id cannot be negative");
            }
            this._id = Id;
        }

        public int GetId()
        {
            return this._id;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Student S1 = new Student();
            S1.SetId(01);

            Console.WriteLine(" This student id is {0}", S1.GetId());
            
            Console.ReadKey();
        }
    }
}
