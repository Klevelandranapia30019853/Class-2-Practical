using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter your first name");
            string fname = Console.ReadLine();

            Console.WriteLine("please enter your last name");
            string lname = Console.ReadLine();
            /*string concantination*/

            Console.WriteLine(fname+ " " +lname);
            Console.ReadLine();

            Console.WriteLine("please enter your name");
            string name = Console.ReadLine();

            Console.WriteLine("please enter your address");
            string address = Console.ReadLine();

            Console.WriteLine("please enter your age");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("please enter your email address");
            String email = Console.ReadLine();

            Console.WriteLine("please enter your 4-digit PIN number");
            int PIN = int.Parse (Console.ReadLine());

        }
    }
}
