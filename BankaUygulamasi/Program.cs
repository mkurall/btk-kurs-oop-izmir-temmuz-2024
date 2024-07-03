//ANAPROGRAM

using BankaUygulamasi;
using BankaUygulamasi.Konsol;
/*
string str = Klavye.StrOku("Banka Adını Gir:");

//Benim tanımladığım banka sınıfından bir örnek oluşturdum
//Banka bir sınıf
//yeniBanka Banka sınıfından oluşturulmuş bir örnek
Banka yeniBanka = new(); 
yeniBanka.BankaAd = str;
yeniBanka.BankaTel = Klavye.StrOku("Banka Telefonunu Gir:");
yeniBanka.BankaAdres = Klavye.StrOku("Banka Adresini Gir:");
yeniBanka.KurulusYili = Klavye.IntOku("Kuruluş Yılını Gir:");

Console.WriteLine("Yeni Banka Oluşturuldu.");
yeniBanka.BilgileriniYaz();


//Musteri yeniMusteri = new Musteri();*soyut sınıflar kullanılamaz

BireyselMusteri yeniMusteri = new BireyselMusteri(123456);
yeniMusteri.AdSoyad = "Mustafa KURAL";
yeniMusteri.Tel = "555 6767";
yeniMusteri.Adres = "İzmir";

yeniMusteri.BilgileriGoster();

KurumsalMusteri yeniMusteri2 = new KurumsalMusteri(2345242);
yeniMusteri2.SirketAdi = "BTK AKADEMİ";
yeniMusteri2.Tel = "11111";
yeniMusteri2.Adres = "Ankara";

yeniMusteri2.BilgileriGoster();

yeniBanka.Musteriler.Add(yeniMusteri);//bankanın içindeki listeye ekler
yeniBanka.Musteriler.Add(yeniMusteri2);

Console.Read();
*/


Veri.DosyadanOku();

AnaEkran ekran = new AnaEkran();
ekran.Goster();

Veri.DosyayaKaydet();


/*
string klasorum = Directory.GetCurrentDirectory();

Console.WriteLine("Aktif Klasor: " + klasorum);

string[] dosyalar = Directory.GetFiles(klasorum);

for (int i = 0;i<dosyalar.Length; i++)
{
    string dosyaAdi = Path.GetFileName(dosyalar[i]);
    Console.WriteLine(dosyaAdi);
}

string yeniDosyaAdi = "Bilgiler.txt";
File.WriteAllText(yeniDosyaAdi, "Bu bizim programdan oluşturulan dosya.");

string okunacakDosya = "Bilgiler2.txt";
if(File.Exists(okunacakDosya))
{
    string icerik = File.ReadAllText(okunacakDosya);
    Console.WriteLine("İçerik: " + icerik);
}
else 
    Console.WriteLine("Dosya bulunamadı!");
*/