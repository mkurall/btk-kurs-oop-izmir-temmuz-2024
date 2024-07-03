using System.Security.Cryptography;

namespace BankaUygulamasi;

public static class Veri
{
    public static Banka Bankam {get; set;} 


    public static void DosyayaKaydet()
    {
        string data = System.Text.Json.JsonSerializer.Serialize<Banka>(Bankam);
        File.WriteAllText("veriler.txt", data);
    }

    public static void DosyadanOku()
    {
        if(File.Exists("veriler.txt"))
        {
            string data = File.ReadAllText("veriler.txt");
            Bankam = System.Text.Json.JsonSerializer.Deserialize<Banka>(data);
        }
        else 
            Bankam = new Banka();
    }
}
