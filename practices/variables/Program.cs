// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

byte byt = 5;       // Bellekte 1 byte alan kaplar. 0-128 arası deger
sbyte sbyt = 5;     // Bellekte 1 byte alan kaplar.

short shrt = 5;     // Bellekte 2 byte alan kaplar.
ushort ushrt = 4;   // Bellekte 2 byte alan kaplar.

Int16 i16 = 6;      // Bellekte 2 byte alan kaplar.
int variable = 6;   // Bellekte 4 byte alan kaplar.
Int32 i32 = 6;      // Bellekte 4 byte alan kaplar.
Int64 i64 = 6;      // Bellekte 8 byte alan kaplar.

uint ui = 5;       // Bellekte 4 byte alan kaplar.
long l = 6;        // Bellekte 8 byte alan kaplar.
ulong ul = 6;      // Bellekte 8 byte alan kaplar.

// Reel sayılar
float f = 5;        // Bellekte 4 byte alan kaplar.
double d = 6;      // Bellekte 8 byte alan kaplar.
decimal de = 6;      // Bellekte 16 byte alan kaplar.

char c = '2';        // Bellekte 2 byte alan kaplar.
string s = "Nuray";      // Bellekte sınırsız alan kaplar.

bool b = true;
bool fal = false;

DateTime dt = DateTime.Now;
Console.WriteLine("DateTime " + dt);

// Object Türü
object o1 = "string ifade";
object o2 = "c";
object o3 = 4;
object o4 = 4.2;

// String ifadeler
string str = string.Empty;  // = null

// Değişken Dönüşümleri
string str20 = "20";
int int20 = 20;
string newValue = str20 + int20.ToString();
Console.WriteLine(newValue); // Çıktı : 2020

int int21 = int20 + Convert.ToInt32(str20);
Console.WriteLine(int21); // Çıktı : 40

int int22 = int20 + int.Parse(str20);
Console.WriteLine(int22); // Çıktı : 40

string dateTime = DateTime.Now.ToString("dd.MM.yyyy");
Console.WriteLine(dateTime);

string dateTime2 = DateTime.Now.ToString("dd/MM/yyyy");
Console.WriteLine(dateTime2);

string hour = DateTime.Now.ToString("HH:mm");
Console.WriteLine(hour);

