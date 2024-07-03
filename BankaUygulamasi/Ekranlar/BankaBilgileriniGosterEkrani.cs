namespace BankaUygulamasi;

public class BankaBilgileriniGosterEkrani : TemelEkran
{
    public override void Cikis()
    {
        throw new NotImplementedException();
    }

    public override void Goster()
    {
        Veri.Bankam.BilgileriniYaz();
    }
}
