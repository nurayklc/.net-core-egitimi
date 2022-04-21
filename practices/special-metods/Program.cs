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


//Remove : Verilen indexteki değerden sonrasını siler
Console.WriteLine(variable.Remove(10));
// 5. indexten başlayarak 3 karakter siler
Console.WriteLine(variable.Remove(5, 3));
Console.WriteLine(variable.Remove(0, 1));


//Replace : Verilen ilk parametre yerine ikinci parametreyle yer değiştirir
Console.WriteLine(variable.Replace("C#", "C Sharp"));
Console.WriteLine(variable.Replace(" ", "*"));


//Split: Stringi istenilen biçimde parçalar.
Console.WriteLine(variable.Split(" ")[1]);


//SubString : 4. indexten başlayarak stringin sonuna kadar tüm karakterleri getirir
Console.WriteLine(variable.Substring(4));



// DateTime Kütüphanesi

Console.WriteLine(DateTime.Now);
Console.WriteLine(DateTime.Now.Date);
Console.WriteLine(DateTime.Now.Day);
Console.WriteLine(DateTime.Now.Month);
Console.WriteLine(DateTime.Now.Year);
Console.WriteLine(DateTime.Now.Hour);
Console.WriteLine(DateTime.Now.Minute);
Console.WriteLine(DateTime.Now.Second);

Console.WriteLine(DateTime.Now.DayOfWeek);
Console.WriteLine(DateTime.Now.DayOfYear);

Console.WriteLine(DateTime.Now.ToLongDateString());
Console.WriteLine(DateTime.Now.ToShortDateString());
Console.WriteLine(DateTime.Now.ToLongTimeString());
Console.WriteLine(DateTime.Now.ToShortTimeString());

Console.WriteLine(DateTime.Now.AddDays(2));
Console.WriteLine(DateTime.Now.AddHours(3));
Console.WriteLine(DateTime.Now.AddSeconds(30));
Console.WriteLine(DateTime.Now.AddMonths(5));
Console.WriteLine(DateTime.Now.AddYears(10));
Console.WriteLine(DateTime.Now.AddMilliseconds(50));

// DateTime Format
Console.WriteLine(DateTime.Now.ToString("dd"));   // 16
Console.WriteLine(DateTime.Now.ToString("ddd"));  // Sat
Console.WriteLine(DateTime.Now.ToString("dddd")); // Saturday

Console.WriteLine(DateTime.Now.ToString("MM"));   // 04
Console.WriteLine(DateTime.Now.ToString("MMM"));  // Apr
Console.WriteLine(DateTime.Now.ToString("MMMM")); // April

Console.WriteLine(DateTime.Now.ToString("yy"));   // 22
Console.WriteLine(DateTime.Now.ToString("yyyy"));  // 2022


// Math Kütüphanesi
Console.WriteLine(Math.Abs(-25)); // 25

Console.WriteLine(Math.Sin(10)); // 25
Console.WriteLine(Math.Cos(10)); // 25
Console.WriteLine(Math.Tan(10)); // 25

Console.WriteLine(Math.Ceiling(22.3)); // 23
Console.WriteLine(Math.Round(22.3));   // 22
Console.WriteLine(Math.Round(22.7));   // 23
Console.WriteLine(Math.Floor(22.7));   // 22

Console.WriteLine(Math.Max(2,6)); 
Console.WriteLine(Math.Min(2,6)); 

Console.WriteLine(Math.Pow(2,6)); 
Console.WriteLine(Math.Sqrt(9)); 
Console.WriteLine(Math.Log(9));  
Console.WriteLine(Math.Exp(3));  
Console.WriteLine(Math.Log10(10)); 