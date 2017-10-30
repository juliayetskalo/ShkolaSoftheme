using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "*****";
            for (int i=0;i<5;i++)
            {
                str -= "*****";
                Console.WriteLine(str);
            }
          
          
            Console.ReadLine();
        }
    }
}
