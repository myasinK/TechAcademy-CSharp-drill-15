using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesDrill4
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassWithMethod classWithMethod = new ClassWithMethod();
            Console.WriteLine("Enter a number:");
            int x = Convert.ToInt32( Console.ReadLine() );
            Console.WriteLine("Enter a second optional number");
            string y = Console.ReadLine();
            if (String.IsNullOrEmpty(y))
            {
                Console.WriteLine(classWithMethod.Method(x));
            }
            else
            {
                int y_int = Convert.ToInt32( y );
                Console.WriteLine(classWithMethod.Method(x,y_int)); // return x/(y+1)
            }
        }
        public class ClassWithMethod
        {
            public int Method(int x, int y = 1)
            {
                return x / (y + 1);
            }            
        }
    }

}
