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
            int myVar=new int();
            Console.WriteLine("int");
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);
            Console.WriteLine(myVar);

            uint myVar1 = new uint();
            Console.WriteLine("uint");
            Console.WriteLine(uint.MaxValue);
            Console.WriteLine(uint.MinValue);
            Console.WriteLine(myVar1);

            short myVar2 = new short();
            Console.WriteLine("short");
            Console.WriteLine(short.MaxValue);
            Console.WriteLine(short.MinValue);
            Console.WriteLine(myVar2);

            ushort myVar3 = new ushort();
            Console.WriteLine("ushort");
            Console.WriteLine(ushort.MaxValue);
            Console.WriteLine(ushort.MinValue);
            Console.WriteLine(myVar3);

            long myVar4 = new long();
            Console.WriteLine("long");
            Console.WriteLine(long.MaxValue);
            Console.WriteLine(long.MinValue);
            Console.WriteLine(myVar4);

            ulong myVar5 = new ulong();
            Console.WriteLine("ulong");
            Console.WriteLine(ulong.MaxValue);
            Console.WriteLine(ulong.MinValue);
            Console.WriteLine(myVar5);

            byte myVar6 = new byte();
            Console.WriteLine("byte");
            Console.WriteLine(byte.MaxValue);
            Console.WriteLine(byte.MinValue);
            Console.WriteLine(myVar6);

            sbyte myVar7 = new sbyte();
            Console.WriteLine("sbyte");
            Console.WriteLine(sbyte.MaxValue);
            Console.WriteLine(sbyte.MinValue);
            Console.WriteLine(myVar7);


            Console.ReadLine();
        }
    }
}
