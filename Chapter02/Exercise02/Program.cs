using System;
using System.Collections;
using static System.Console;

namespace Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine($"sbyte   size: {sizeof(sbyte)} bytes   min: {sbyte.MinValue, -30}  max: {sbyte.MaxValue}");
            WriteLine($"byte    size: {sizeof(byte)} bytes   min: {byte.MinValue, -30}  max: {byte.MaxValue}");
            WriteLine($"short   size: {sizeof(short)} bytes   min: {short.MinValue, -30}  max: {short.MaxValue}");
            WriteLine($"ushort  size: {sizeof(ushort)} bytes   min: {ushort.MinValue, -30}  max: {ushort.MaxValue}");
            WriteLine($"int     size: {sizeof(int)} bytes   min: {int.MinValue, -30}  max: {int.MaxValue}");
            WriteLine($"uint    size: {sizeof(uint)} bytes   min: {uint.MinValue, -30}  max: {uint.MaxValue}");
            WriteLine($"long    size: {sizeof(long)} bytes   min: {long.MinValue, -30}  max: {long.MaxValue}");
            WriteLine($"ulong   size: {sizeof(ulong)} bytes   min: {ulong.MinValue, -30}  max: {ulong.MaxValue}");
            WriteLine($"float   size: {sizeof(float)} bytes   min: {float.MinValue, -30}  max: {float.MaxValue}");
            WriteLine($"double  size: {sizeof(double)} bytes   min: {double.MinValue, -30}  max: {double.MaxValue}");
            WriteLine($"decimal size: {sizeof(long)} bytes   min: {decimal.MinValue, -30}  max: {decimal.MaxValue}");

        }

    }
}
