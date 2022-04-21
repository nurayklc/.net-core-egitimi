// See https://aka.ms/new-console-template for more information

string variable = "Welcomeeeeee Everyone";
string variable2 = "Lesson C# 101";

// Lenght uzunluğunu verir
Console.WriteLine(variable.Length);


// Büyük harf
Console.WriteLine(variable.ToLower());
// Küçük harf
Console.WriteLine(variable.ToUpper());


// Değişkenin sonuna ekleme yapar
Console.WriteLine(String.Concat(variable, "Merhaba!"));


// İki değişkeni karşılaştırır ve eşitse 0, ilk değişken büyükse 1 değilse -1 döner
Console.WriteLine(variable.CompareTo(variable2));


// Parametler : 1.değişken, 2. değişken, ignore case durumu
// ignore case: büyük küçük harfe duyarlı olması isteniyorsa true, değilse false durumudur
Console.WriteLine(String.Compare(variable, variable2, false));
Console.WriteLine(String.Compare(variable, variable2, true));


// Contains değişkenin içinde içerip içermediğini bool olarak döner
Console.WriteLine(variable.Contains(variable2));
// Değişkenin verilen değerle bitip bitmediğini bool olarak döner
Console.WriteLine(variable.EndsWith("Friends"));
// Değişkenin verilen değerle başlayıp başlamadığını bool olarak döner
Console.WriteLine(variable.StartsWith("Helloo!"));


// IndexOf : Değişkenin içerisinde istenilen değer varsa bu değerin index numarasını döner
Console.WriteLine(variable.IndexOf("Everyone"));
Console.WriteLine(variable.IndexOf("Ali"));
Console.WriteLine(variable.LastIndexOf("ee"));


// Insert : Değişkenin verilen değerine o stringi ekler
Console.WriteLine(variable.Insert(0, "Hello"));


//PadLeft,PadRight : Değişkenin sağına veya soluna verilen değeri koyarak 30 a tamamla
Console.WriteLine(variable + variable2.PadLeft(30, '*'));
Console.WriteLine(variable.PadRight(50, '-') + variable2);


//Remove : Verilen indexteki değeri siler
Console.WriteLine(variable.Remove(10));
Console.WriteLine(variable.Remove(5, 3));
Console.WriteLine(variable.Remove(0, 1));


//Replace : Verilen ilk parametre yerine ikinci parametreyle yer değiştirir
Console.WriteLine(variable.Replace("C#", "C Sharp"));
Console.WriteLine(variable.Replace(" ", "*"));


//Split: Stringi istenilen biçimde parçalar.
Console.WriteLine(variable.Split(" ")[1]);


//SubString
Console.WriteLine(variable.Substring(4));