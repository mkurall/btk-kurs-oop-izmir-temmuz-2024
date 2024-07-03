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
        Console.Write(mesaj);
        return Convert.ToInt32(Console.ReadLine());
    }
    public static double DoubleOku(string mesaj)
    {
        Console.Write(mesaj);
        return Convert.ToDouble(Console.ReadLine());
    }
}
