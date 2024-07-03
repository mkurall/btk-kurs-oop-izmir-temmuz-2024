namespace BankaUygulamasi;

//Bu müşteri türleri için temel sınıf olacak (abstract)
public abstract class Musteri
{
    public int MusteriNo { get; private set; }
    public string Tel { get; set; }
    public string Adres { get; set; }
    public abstract void BilgileriGoster();
}
