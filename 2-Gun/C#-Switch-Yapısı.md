Switch yapısı, if elseif yapılarına alternatif bir operatördür.

Örnek vermek gerekirse;

```c#
int number = 1;
if(number == 1) {
    Console.WriteLine("Durum 1");
} else if (number == 2) {
    Console.WriteLine("Durum 2");
} else {
    Console.WriteLine("Varsayılan durum");
} 
```

Switch ile kullanırsak;

```c#
int number = 1;

switch (number)

{

  case 1:

​    Console.WriteLine("Durum 1");

​    break;

  case 2:

​    Console.WriteLine("Durum 2");

​    break;

  default:

​    Console.WriteLine("Varsayılan durum");

​    break;

}
```

