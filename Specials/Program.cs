using System;

namespace Specials
{
    class Program
    {
        static void Main(string[] args)
        {
           sbyte sbMin = sbyte.MinValue;
           Console.WriteLine(sbMin);

           sbyte sbMax = sbyte.MaxValue;
           Console.WriteLine(sbMax);

           short shortMin = short.MinValue;
           Console.WriteLine(shortMin);

           short shortMax = short.MaxValue;
           Console.WriteLine(shortMax);

           int intMin = int.MinValue;
           Console.WriteLine(intMin);

           int intMax = int.MaxValue;
           Console.WriteLine(intMax);

           long longMin = long.MinValue;
           Console.WriteLine(longMin);

           long longMax = long.MaxValue;
           Console.WriteLine(longMax);

           byte byteMin = byte.MinValue;
           Console.WriteLine(byteMin);

           byte byteMax = byte.MaxValue;
           Console.WriteLine(byteMax);

           ushort uMin = ushort.MinValue;
           Console.WriteLine(uMin);

           ushort uMax = ushort.MaxValue;
           Console.WriteLine(uMax);

           uint uintMin = uint.MinValue;
           Console.WriteLine(uintMin);

           uint uintMax = uint.MaxValue;
           Console.WriteLine(uintMax);

           ulong ulongMin = ulong.MinValue;
           Console.WriteLine(ulongMin);

           ulong  ulongMax = ulong.MaxValue;
           Console.WriteLine(ulongMax);

           char charMin = char.MinValue;
           Console.WriteLine(charMin);

           char charMax = char.MaxValue;
           Console.WriteLine(charMax);

           double x = double. PositiveInfinity;
           Console.WriteLine(x);

           double y = double. NegativeInfinity;
           Console.WriteLine(y);

           double N = double .NaN; 
           Console.WriteLine(N);

           float fx = float. PositiveInfinity;
           Console.WriteLine(fx);

           float fy = float. NegativeInfinity;
           Console.WriteLine(fy);

           float fN = float .NaN; 
           Console.WriteLine(fN);



           int i = int.MaxValue;
           Console.WriteLine(( int) ( i + 1)); 

           float ffi = float.MaxValue;
           Console.WriteLine(( float) ( ffi + 1));

           double ddi = double.MaxValue;
           Console.WriteLine(( double) ( ddi + 1));


           float f1 , f2 ;
           f1 = f2 = 10000.0f;
           Console.WriteLine(f1 == f2 + 0.0001f);

           double d1 , d2 ;
           d1 = d2 = 10000.0d;
           Console.WriteLine(d1 == d2 + 0.0001d);



        }
    }
}
