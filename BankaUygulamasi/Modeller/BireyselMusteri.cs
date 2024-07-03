namespace BankaUygulamasi;

//Kalıtım yoluyla Musteri sınıfını al
public class BireyselMusteri : Musteri
{
    public string AdSoyad { get; set; }
    public override void BilgileriGoster()
    {
        Console.WriteLine("Bireysel Müşteri Bilgileri");
    }

}
