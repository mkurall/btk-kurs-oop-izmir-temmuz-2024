namespace BankaUygulamasi;

public class Banka
{
    private string ad;//kapsüllenmiş
    private string tel;//sadece sınıf içinden erişilebilir

    //full property
    public string BankaAd
    {
        get //property okunmaya çalışıldığında
        {
            return ad;
        }
        set //property yazılmaya çalışıldığında
        {
           
            ad = value;//bu anahtar kelime gelen veriyi temsil eder
        }
    }

    public string BankaTel
    {
        get => tel; //lambda kullanımı
        set => tel = value;
    }

    //otomatik property
    public string BankaAdres
    {
        get; // (arkaplanda değişkeni kendi oluşturur)
        set;
    }

    public int KurulusYili { get; set; }

    public void BilgileriniYaz()
    {
        Console.WriteLine($"Banka Adı: {BankaAd}");
        Console.WriteLine($"Banka Telefonu: {BankaTel}");
        Console.WriteLine($"Banka Adresi: {BankaAdres}");
        Console.WriteLine($"Banka Kuruluş Yılı: {KurulusYili}");
    }
}
