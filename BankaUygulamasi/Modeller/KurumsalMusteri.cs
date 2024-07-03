namespace BankaUygulamasi;

public class KurumsalMusteri : Musteri
{
    public string SirketAdi { get; set; }
    public override void BilgileriGoster()
    {
        Console.WriteLine("Kurumsal Müşteri Bilgileri");
    }
}
