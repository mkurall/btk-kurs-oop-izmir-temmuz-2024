//ANAPROGRAM

using BankaUygulamasi;
using BankaUygulamasi.Konsol;

string str = Klavye.StrOku("Banka Adını Gir:");

//Benim tanımladığım banka sınıfından bir örnek oluşturdum
//Banka bir sınıf
//yeniBanka Banka sınıfından oluşturulmuş bir örnek
Banka yeniBanka = new(); 
yeniBanka.BankaAd = str;
yeniBanka.BankaTel = Klavye.StrOku("Banka Telefonunu Gir:");
yeniBanka.BankaAdres = Klavye.StrOku("Banka Adresini Gir:");

Console.WriteLine("Yeni Banka Oluşturuldu.");
yeniBanka.BilgileriniYaz();

