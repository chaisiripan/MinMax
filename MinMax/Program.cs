using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Min sbyte = " + SByte.MinValue);
            Console.WriteLine("Max sbyte = " + SByte.MaxValue);
            Console.WriteLine("Min byte = " + Byte.MinValue);
            Console.WriteLine("Max byte = " + Byte.MaxValue);
            Console.WriteLine("Min short = " + Int16.MinValue);
            Console.WriteLine("Max short = " + Int16.MaxValue);
            Console.WriteLine("Min ushort = " + UInt16.MinValue);
            Console.WriteLine("Max ushort = " + UInt16.MaxValue);
            Console.WriteLine("Min int = " + Int32.MinValue);
            Console.WriteLine("Max int = " + Int32.MaxValue);
            Console.WriteLine("Min uint = " + UInt32.MinValue);
            Console.WriteLine("Max uint = " + UInt32.MaxValue);
        }
    }
}
