using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Your mother");
            Account derp = new Account(1000);
            derp.deposit(10000);
            derp.deposit(-1);
            derp.withdraw(1000);
            derp.withdraw(-1);
            derp.withdraw(9999999);
            Console.WriteLine(derp.getBalance());
            while (true) { }
        }
    }
}
