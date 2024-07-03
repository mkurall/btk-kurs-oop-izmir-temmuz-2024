namespace BankaUygulamasi;

//Kalıtım yoluyla Musteri sınıfını al
public class BireyselMusteri : Musteri
{
    public BireyselMusteri(int no) : base(no)//temel sınıftaki yapıcıyı çağırır
    {
    }

    public string AdSoyad { get; set; }
    public override void BilgileriGoster()
    {
        Console.WriteLine("Bireysel Müşteri Bilgileri");
        Console.WriteLine($"Ad Soyad:{AdSoyad}");
    }
}
