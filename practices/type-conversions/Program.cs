// See https://aka.ms/new-console-template for more information

// Implicit Conversions (Bilinçsiz Dönüşüm)

byte a = 5;
sbyte b = 6;
short c = 7;

int d = a + b + c;
Console.WriteLine("implicit: " + a);

long h = d;
Console.WriteLine("h : " + h);

float i = h;
Console.WriteLine("i : " + h);

string s = "string";
char ch = 'c';
object g = s + ch + d;
Console.WriteLine("Object : " + g);

// Explicit Conversions (Bilinçli Dönüşüm)

int x = 8;
byte y = (byte)x;
Console.WriteLine("byte y: " + y);

int z = 100;
byte t = (byte)z;
Console.WriteLine("byte t: " + t);

float w = 3.10f;
byte v = (byte)w;
Console.WriteLine("byte v: " + v);

// ToString Metodu - aldığı veriyi string'e cast eder
int xx = 6;
string stri = xx.ToString();
Console.WriteLine("string : " + stri);

string zz = 12.5f.ToString();
Console.WriteLine("zz: " + zz);

//System.Convert
string s1 = "10", s2 = "20";
int sayi3, sayi4;
int Toplam;

sayi3 = Convert.ToInt32(s1);
sayi4 = Convert.ToInt32(s2);

Toplam = sayi3 + sayi4;
Console.WriteLine("Toplam: " + Toplam);

//Parse
Console.WriteLine("***** Parse Methodu *****");
ParseMethod();

static void ParseMethod()
{
    string metin1 = "10";
    string metin2 = "10.25";
    int rakam1;
    double double1;

    rakam1 = Int32.Parse(metin1);
    double1 = Double.Parse(metin2);

    Console.WriteLine("rakam1: " + rakam1);
    Console.WriteLine("double1: " + double1);

}