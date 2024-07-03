namespace BankaUygulamasi;

public class Banka
{
    private string ad;//kapsüllenmiş
    private string tel;//sadece sınıf içinden erişilebilir
    private string adres;

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

}
