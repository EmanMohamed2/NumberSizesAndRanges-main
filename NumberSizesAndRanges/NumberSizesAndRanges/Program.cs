using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberSizesAndRanges
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine($"sbyte uses {sizeof(sbyte)}   bytes and can store numbers in the range { sbyte.MinValue:N0} to { sbyte.MaxValue:N0}.\n");
                Console.WriteLine($"byte uses {sizeof(byte)}    bytes and can store numbers in the range { byte.MinValue:N0} to { byte.MaxValue:N0}.\n");
                Console.WriteLine($"short uses {sizeof(short)}   bytes and can store numbers in the range { short.MinValue:N0} to { short.MaxValue:N0}.\n");
                Console.WriteLine($"ushort uses {sizeof(ushort)}  bytes and can store numbers in the range { ushort.MinValue:N0} to { ushort.MaxValue:N0}.\n");
                Console.WriteLine($"int     uses {sizeof(int)}     bytes and can store numbers in the range { int.MinValue:N0} to { int.MaxValue:N0}.\n");
                Console.WriteLine($"uint  uses {sizeof(uint)}  bytes and can store numbers in the range { uint.MinValue:N0}to { uint.MaxValue:N0}.\n");
                Console.WriteLine($"long uses {sizeof(long)} bytes and can store numbers in the range { long.MinValue:N0} to { long.MaxValue:N0}.\n");
                Console.WriteLine($"ulong uses {sizeof(ulong)} bytes and can store numbers in the range {ulong.MinValue:N0} to { ulong.MaxValue:N0}.\n");
                Console.WriteLine($"float uses {sizeof(float)} bytes and can store numbers in the range { float.MinValue:N0} to { float.MaxValue:N0}.\n");
                Console.WriteLine($"double uses {sizeof(double)} bytes and can store numbers in the range { double.MinValue:N0} to { double.MaxValue:N0}.\n");
                Console.WriteLine($"decimal uses {sizeof(decimal)} bytes and can store numbers in the range { decimal.MinValue:N0} to { decimal.MaxValue:N0}.\n");


        }
    }
}


