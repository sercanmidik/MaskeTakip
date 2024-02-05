using Business.Concrete;
using Entities.Concrete;
using Workaround;

Degiskenler();
Vatandas vatandas1= new Vatandas();
vatandas1.TcNo = 12345678900;
vatandas1.DogumYili = 1988;
vatandas1.Adi = "Sercan";
vatandas1.SoyAdi = "Mıdık";


int sonuc = Topla(4,5);
SelamVer("Sercan");
SelamVer("Gonca");
SelamVer("Çınar");
SelamVer();


//Diziler
//string ogrenci = "Sercan";
//string ogrenci1 = "Gonca";
//string ogrenci2 = "çınar";
//string ogrenci3 = "bayram";
string[] ogrenciler = { "Sercan","Gonca","Çınar","Bayram" };

ogrenciler = new string[5];
ogrenciler[4] = "Gülsün Mıdık";

foreach (var item in ogrenciler)
{
    Console.WriteLine(item);
}

string[] sehirler1 = { "Ankara", "İstanbul", "Bursa" };
string[] sehirler2 = { "İzmir", "Uşak", "Manisa" };

List<string> yeniSehirler = new List<string>();
yeniSehirler.Add("Ankara");
yeniSehirler.Add("Usak");
yeniSehirler.Add("Bursa");


sehirler1[0] = "Adana";
sehirler2 = sehirler1;

int sayi1 = 10;
int sayi2 = 20;
sayi2 = sayi1;
sayi1 = 30;

Person person1=new Person();
person1.FirstName = "sercan";
person1.NationalIdentity = 60805406278;
person1.LastName = "mıdık";
person1.DateOfBirthYear = 1988;

Person person2 = new Person();
person2.FirstName = "Çınar Bayram";

PttManager pttManager = new PttManager(new PersonManager());
pttManager.GiveMask(person1);


Console.WriteLine(sayi2);


Console.WriteLine(sehirler2[0]);

static int Topla(int sayi1,int sayi2)
{
    int sonuc= sayi1 + sayi2;
    Console.WriteLine(sonuc);
    return sonuc;
}

static void SelamVer(string? isim="Null")
{
    Console.WriteLine("Merhaba"+isim);
}


static void Degiskenler()
{
    string selamver = "Sercan MIDIK";
    double tutar = 100000;
    int sayi = 100;
    bool girisYapmisMi = false;

    string adi = "Sercan";
    string soyAdi = "Mıdık";
    int dogumYili = 1988;
    long tcNo = 60805406278;

    Console.WriteLine(tutar * 1.18);
    Console.WriteLine(tutar * 1.18);
    Console.WriteLine(tutar * 1.18);
    Console.WriteLine(selamver);
    Console.WriteLine(selamver);
    Console.WriteLine(selamver);
}

