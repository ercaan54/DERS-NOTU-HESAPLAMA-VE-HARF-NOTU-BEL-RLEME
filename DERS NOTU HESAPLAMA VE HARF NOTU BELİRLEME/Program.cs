namespace DERS_NOTU_HESAPLAMA_VE_HARF_NOTU_BELİRLEME
{
    internal class Program
    {
        static void Main(string[] args)
        {

        kullanıcıGiris:
            Console.Write("ders adını giriniz:");
            String dersAdi = Console.ReadLine();

        notGiris:
            Console.Write("vize notunu giriniz 0-100: ");
            int vize = Convert.ToInt32(Console.ReadLine());

            Console.Write("final notunu giriniz 0-100: ");
            int final = Convert.ToInt32(Console.ReadLine());

            if (vize < 0 || vize > 100 || final < 0 || final > 100)
            {
                Console.WriteLine("hatalı  giriş,notlar 0-100 arasında olmalıdır, lütfen tekrar giriniz");
                goto notGiris;


            }

            double ortalama = vize * 0.4 + final * 0.6;
            string harfNotu;

            if (ortalama <= 50)
                harfNotu = "D";
            else if (ortalama <= 59)
                harfNotu = "C2";
            else if (ortalama <= 64)
                harfNotu = "C1";
            else if (ortalama <= 69)
                harfNotu = "B2";
            else if (ortalama <= 74)
                harfNotu = "B1";
            else if (ortalama <= 84)
                harfNotu = "A2";
            else
                harfNotu = "A1";


            Console.WriteLine($"{dersAdi} dersi dönem sonu puanınız: {harfNotu}");
            Console.WriteLine(harfNotu == "D" ? "kaldınız" : "geçtiniz");

        }
    }
}
