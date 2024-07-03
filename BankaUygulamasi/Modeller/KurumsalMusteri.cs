namespace BankaUygulamasi;

public class KurumsalMusteri : Musteri
{
    public KurumsalMusteri(int no) : base(no)
    {
    }

    public string SirketAdi { get; set; }
    public override void BilgileriGoster()
    {
        Console.WriteLine("Kurumsal Müşteri Bilgileri");
        Console.WriteLine($"Şirket Adı: {SirketAdi}");
    }
}
