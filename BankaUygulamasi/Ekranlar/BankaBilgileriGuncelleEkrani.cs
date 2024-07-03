using BankaUygulamasi.Konsol;

namespace BankaUygulamasi;

public class BankaBilgileriGuncelleEkrani : TemelEkran
{
    public override void Cikis()
    {
        throw new NotImplementedException();
    }

    public override void Goster()
    {
        Veri.Bankam.BankaAd = Klavye.StrOku("Banka adınız Gir:");
        Veri.Bankam.BankaTel = Klavye.StrOku("Banka Telefonunu Gir:");
        Veri.Bankam.BankaAdres = Klavye.StrOku("Banka Adresini Gir:");
        Veri.Bankam.KurulusYili = Klavye.IntOku("Kuruluş Yılını Gir:");
        //ana ekrana dönüş
    }
}
