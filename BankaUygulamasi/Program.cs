//ANAPROGRAM

using BankaUygulamasi;
using BankaUygulamasi.Konsol;

string str = Klavye.StrOku("Banka Adını Gir:");

//Benim tanımladığım banka sınıfından bir örnek oluşturdum
Banka yeniBanka = new(); 
yeniBanka.BankaAd = str;

Console.WriteLine("Yeni Banka Oluşturuldu.");
Console.WriteLine($"Yeni Bankanın adı:{yeniBanka.BankaAd}");