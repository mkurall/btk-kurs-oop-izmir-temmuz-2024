using BankaUygulamasi.Konsol;

namespace BankaUygulamasi;

public class AnaEkran : TemelEkran
{
    public override void Cikis()
    {
        throw new NotImplementedException();
    }

    public override void Goster()
    {
        TemelEkran ekran;
        do
        {
                Console.WriteLine("<<ANAEKRAN>>");
                Console.WriteLine("1-Banka Bilgilerini Guncelle");
                Console.WriteLine("2-Banka Bilgilerini Goster");
                Console.WriteLine("0-Çıkış");

                int secim = Klavye.IntOku("Seçiminiz:");

                switch (secim)
                {
                        case 1:
                            ekran =  new BankaBilgileriGuncelleEkrani();
                            ekran.Goster();
                        
                        break;
                        case 2:
                            ekran = new BankaBilgileriniGosterEkrani();
                            ekran.Goster();
                        break;
                        case 0:Console.WriteLine("0 seçildi.");return;//metottan çık
                        default:Console.WriteLine("Yanlış Seçim.");break;
                }

                Klavye.StrOku("Devam etmek için <<enter> tuşuna basın...");

        } while(true);
    }
}
