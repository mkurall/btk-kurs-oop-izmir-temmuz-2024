namespace BankaUygulamasi;

//1-Extension metotlar static yazılmalı
public static class TipDonusumleri
{
    //Ben string sınıfının içine bu metodu ekleyeceğim
    //string sınıfını ilk yazan microsoft
    public static int ToInt(this string str)
    {
        return Convert.ToInt32(str);
    }
    public static double ToDouble(this string str)
    {
        return Convert.ToInt32(str);
    }
}
