# Dictionary

> Anahtar(Key) ve Değer(Value) olmak üzere iki kavram karşımıza çıkmakta. Konuyu daha anlaşılır kılmak açısından; standart dizilere eklediğimiz elemanları Değer, o elemanlara erişmek için kullandığımız indeksleri de Anahtar olarak düşünebilirsiniz.
>
> Her bir Değerin farklı bir Anahtarı olmalıdır yani koleksiyon içerisinde yer alan Anahtarlar birbirinden farklı olmalıdır.

Örneğin;

```c#
Dictionary<int,string> plakalar = new Dictionary<int, string>()
            {
                {53,"rize"},
                {34,"istanbul"},
                {35,"izmir"}
            };

            foreach(var item in plakalar)
            {
                System.Console.WriteLine($"{item.Key} {item.Value}");
            }
```

