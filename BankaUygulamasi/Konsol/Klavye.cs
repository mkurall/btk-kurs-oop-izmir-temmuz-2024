using System.IO.Compression;

namespace BankaUygulamasi.Konsol;

//Yardımcı metotlar içeren sınıflar genellikle static oluşturulur
//Tüm projeden bu static sınıflar erişilir ve aynı nesneyi kullanır
//**static sınıfların tüm üyeleri de static olur
public static class Klavye
{
    public static string StrOku(string mesaj)
    {
        Console.Write(mesaj);
        return Console.ReadLine();
    }
    public static int IntOku(string mesaj)
    {
        do
        {
            Console.Write(mesaj);
            string okunan = Console.ReadLine();
            try
            {
                //başarılı ise metotttan çıkacak
                return okunan.ToInt();
            }
            catch (Exception)
            {
                //başarılı olamadıysan tekrar oku
                Console.WriteLine("Lütfen geçerli bir sayı girin.");
            }
            
        } while(true);
    }
    public static double DoubleOku(string mesaj)
    {
        Console.Write(mesaj);
        string okunan = Console.ReadLine();
        return okunan.ToDouble();
    }
}
