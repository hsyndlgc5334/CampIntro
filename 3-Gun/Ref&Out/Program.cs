using System;

namespace Ref_Out
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b = 1;
            _OutE(b);
            _RefE(b);
            _Out(out a);
            _Out(out b);
            _Ref(ref b);
            System.Console.WriteLine(a);
            System.Console.WriteLine(b);

        }
        static void _Out(out int s)
        {
            s = 10;
            s++;
        }
        static void _Ref(ref int s)
        {
            s = 10;
            s++;
        }
        static void _OutE(int s)
        {
            s = 10;
            s++;
        }
        static void _RefE(int s)
        {
            s = 10;
            s++;
        }
    }
}
