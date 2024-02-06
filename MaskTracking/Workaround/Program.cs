using Business.Concrete;
using Entities.Concrete;

/*
Vatandas vatandas1 = new();
SelamVer("İlker");
SelamVer("Engin");
SelamVer("Ayşe");
SelamVer();

int sonuc = Topla(6, 58);

string ogrenci1 = "Engin";
string ogrenci2 = "Kerem";
string ogrenci3 = "Berkay";

Console.WriteLine(ogrenci1);
Console.WriteLine(ogrenci2);
Console.WriteLine(ogrenci3);

string[] ogrenciler = new string[3];
ogrenciler[0] = "Engin";
ogrenciler[1] = "Kerem";
ogrenciler[2] = "Berkay";
ogrenciler = new string[4];
//ogrenciler[3] = "İlker";

for (int i = 0; i < ogrenciler.Length; i++)
{
    Console.WriteLine(ogrenciler[i]);
}

string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" };
string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır" };
sehirler2 = sehirler1;
sehirler1[0] = "Adana";

Console.WriteLine(sehirler2[0]);


Citizen citizen1 = new Citizen();
citizen1.FirstName = "Engin";

Citizen citizen2 = new Citizen();
citizen2.FirstName = "Murat";

foreach (var sehir in sehirler1)
{
    Console.WriteLine(sehir);
}

List<string> yeniSehirler1 = new List<string> { "Ankara 1", "İstanbul 1", "İzmir 1" };
yeniSehirler1.Add("Adana 1");
foreach (var sehir in yeniSehirler1)
{
    Console.WriteLine(sehir);
}
*/


PttManager pttManager = new PttManager(new PersonManager());

Person person = new Person
{
    DateOfBirthYear = 2024,
    LastName = "AAA",
    FirstName = "BBB",
    NationalIdentity = 11111111111
};

pttManager.GiveMask(person);


static void SelamVer(string isim = "İsimsiz")
{
    Console.WriteLine("Merhaba " + isim);
}



static int Topla(int sayi1 = 5, int sayi2 = 10)
{
    int sonuc = sayi1 + sayi2;
    Console.WriteLine("Toplam: " + sonuc);
    return sonuc;
}

static void Degiskenler()
{
    string mesaj = "Selam";
    double tutar = 100000;
    int sayi = 100;
    bool girisYapmisMi = false;

    string ad = "Engin";
    string soyad = "Demiroğ";
    int dogumYili = 1985;
    long tcNo = 12345678910;


    Console.WriteLine(tutar * 1.18);

    Console.WriteLine(tutar * 1.18);
}


public class Vatandas
{
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public int DogumYili { get; set; }
    public long TcNo { get; set; }

}