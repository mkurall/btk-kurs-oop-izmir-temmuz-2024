namespace BankaUygulamasi;

//Bu müşteri türleri için temel sınıf olacak (abstract)
public abstract class Musteri
{
    public int MusteriNo { get; private set; }
    public string Tel { get; set; }
    public string Adres { get; set; }

    public Musteri() //yapıcı metot
    {//ilk sınıfın oluştuğu an

    }
    public Musteri(int no)//parametreli yapıcı metot
    {
        MusteriNo = no;
    }

    public abstract void BilgileriGoster();
}
