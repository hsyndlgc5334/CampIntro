# REF ve OUT Keywords

**Ref** keywordu metoda parametre olarak gelen değer tipli değişkenin değerini değiştirmek için kullanılır.

Örneğin

```c#
using System;

namespace Ref_Out
{
    class Program
    {
        static void Main(string[] args)
        {
            int b = 1;
            _RefE(b);
            _Ref(ref b); // b değişkenin referansını alır ve metod içindeki parametre b ye aktarılır.
            System.Console.WriteLine(b);

        }
        static void _Ref(ref int s)
        {
            s = 10;
            s++;
        }
        static void _RefE(int s) // referans parametresi almadan değer b ye aktarılmaz.
        {
            s = 10;
            s++;
        }
    }
}

```

**Out** keywordu ise değişken tanımlansın yada tanımlanmasın parametre olarak gönderilen değer tipli değişkeni referans ederek tekrar değer tipine aktarır.

Örneğin

```c#
using System;

namespace Ref_Out
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b = 1;
            _Out(out a); //tanımlanmamış değişken değeri ile
            _Out(out b); //tanımlanmış değişken değeri ile
            _OutE(b); //referans olarak gitmeden gönderirsek
            System.Console.WriteLine(a);
            System.Console.WriteLine(b);

        }
        static void _Out(out int s)
        {
            s = 10;
            s++;
        }
        static void _OutE(int s)
        {
            s = 10;
            s++;
        }
       
    }
}
```

