using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase_1_Project_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            student s = new student();
            s.gets();
            s.prints();
            s = new teacher();
            s.gets();
            s.prints();
            s = new subject();
            s.gets();
            s.prints();

            Console.ReadKey();
        }
    }
}
