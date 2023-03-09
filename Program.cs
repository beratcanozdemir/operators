Console.WriteLine("*****Atama ve Islemli Atama Operatorleri*****");
//Atama ve İşlemli Atama Operatörleri

int x = 3;
int y = 3;

y = y + 2;
Console.WriteLine(y);

y += 2;
Console.WriteLine(y);

y /= 1;
Console.WriteLine(y);

x *= 2;
Console.WriteLine(x);

Console.WriteLine("*****Mantiksal Operatorler*****");
//Mantıksal Operatörler
//||, &&, !

bool isSuccess = true;
bool isCompleted = false;

if (isSuccess && isCompleted)
    Console.WriteLine("Perfect!");

if (isSuccess || isCompleted)
    Console.WriteLine("Great!");

if(isSuccess && !isCompleted)
    Console.WriteLine("Fine!");

Console.WriteLine("*****İliskisel Operatorler*****");
//İlişkisel Operatörler
//<, >, <=, >=, ==, !=

int a = 3;
int b = 4;
bool sonuc = a < b;
Console.WriteLine(sonuc);
sonuc = a > b;
Console.WriteLine(sonuc);
sonuc = a >= b;
Console.WriteLine(sonuc);
sonuc = a <= b;
Console.WriteLine(sonuc);
sonuc = a == b;
Console.WriteLine(sonuc);
sonuc = a != b;
Console.WriteLine(sonuc);

Console.WriteLine("*****Aritmetik Operatorler*****");
//Aritmetik Operatörler
//+, -, *, /, %, ++, --

int sayi1 = 10;
int sayi2 = 5;
int sonuc1 = sayi1 + sayi2;
Console.WriteLine(sonuc1);
sonuc1 = sayi1 - sayi2;
Console.WriteLine(sonuc1);
sonuc1 = sayi1 * sayi2;
Console.WriteLine(sonuc1);
sonuc1 = sayi1 / sayi2;
Console.WriteLine(sonuc1);
sonuc1 = sayi1++;
Console.WriteLine(sayi1);
sonuc1 = sayi2--;
Console.WriteLine(sayi2);

int sayi3 = 20;
int sonuc2 = sayi3 % 3;
Console.WriteLine(sonuc2);
