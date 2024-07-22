using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // 1 - Aşağıdaki çıktıyı yazan bir program.
        Console.WriteLine("Merhaba");
        Console.WriteLine("Nasılsın ?");
        Console.WriteLine("İyiyim");
        Console.WriteLine("Sen nasılsın ?");
        Console.WriteLine("--------------------------------------------------");

        // 2 - Bir adet metinsel, bir adet tam sayı verisi tutmak için 2 adet değişken tanımlayınız. Bunların değerlerini atayıp, ekrana yazdırınız.
        string metin = "Merhaba";
        int sayi = 15;
        Console.WriteLine(metin + " " + sayi);
        Console.WriteLine("--------------------------------------------------");

        // 3 - Rastgele bir sayı üretip, ekrana yazdırınız.
        Random rnd = new Random();
        Console.WriteLine(rnd.Next());
        Console.WriteLine("--------------------------------------------------");

        // 4 - Rastgele bir sayı üretip, bunun 3'e bölümünden kalanı ekrana yazdırınız.
        int bolum = rnd.Next() % 3;
        Console.WriteLine($"3'e bölümünden kalan: {bolum}");
        Console.WriteLine("--------------------------------------------------");

        // 5 - Kullanıcıya yaşını sorup, 18'den büyükse "+" küçükse "-" yazdıran bir uygulama.
        Console.Write("Lütfen Yaşınızı Girin: ");
        int yas = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(yas > 18 ? "+" : "-");
        Console.WriteLine("--------------------------------------------------");

        // 6 - Ekrana 10 defa " Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem." yazan bir uygulama.
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Sen Vodafone gibi anı yaşarken, ben Turkcell gibi seni her yerde çekemem.");
        }
        Console.WriteLine("--------------------------------------------------");

        // 7 - Kullanıcıdan 2 adet metinsel değer alıp, bunların yerlerini değiştiriniz.
        Console.Write("İlk ismi giriniz: ");
        string firstName = Console.ReadLine();
        Console.Write("İkinci ismi giriniz: ");
        string secondName = Console.ReadLine();

        string temp = firstName;
        firstName = secondName;
        secondName = temp;

        Console.WriteLine("Değiştirilmiş değerler:");
        Console.WriteLine("İlk isim: " + firstName);
        Console.WriteLine("İkinci isim: " + secondName);
        Console.WriteLine("--------------------------------------------------");

        // 8 - Değer döndürmeyen ismi BenDegerDondurmem olan bir metot tanımlayınız.
        BenDegerDondurmem();
        static void BenDegerDondurmem()
        {
            Console.WriteLine("Ben değer döndürmem, benim bir karşılığım yok, beni değişkene atamaya çalışma");
        }
        Console.WriteLine("--------------------------------------------------");

        // 9 - İki sayıyı alıp bunların toplam değerini geriye döndüren bir metot yazınız.
        Console.Write("Birinci sayıyı giriniz: ");
        int say1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("İkinci sayıyı giriniz: ");
        int say2 = Convert.ToInt32(Console.ReadLine());

        int toplam = Topla(say1, say2);
        Console.WriteLine("Toplam: " + toplam);

        static int Topla(int say1, int say2)
        {
            return say1 + say2;
        }
        Console.WriteLine("--------------------------------------------------");

        // 10 - Kullanıcıdan true ya da false değeri alıp string bir değer dönen bir metot tanımlayınız.
        Console.Write("True veya false giriniz: ");
        bool kg = Convert.ToBoolean(Console.ReadLine());
        string result = BooleanToString(kg);
        Console.WriteLine(result);

        static string BooleanToString(bool value)
        {
            return value ? "Kullanıcı true değerini girdi." : "Kullanıcı false değerini girdi.";
        }
        Console.WriteLine("--------------------------------------------------");

        // 11 - 3 Kişinin yaşlarını alıp en yaşlı olanının yaş bilgisini dönen bir metot yazınız.
        Console.Write("Birinci kişinin yaşını giriniz: ");
        int age1 = int.Parse(Console.ReadLine());

        Console.Write("İkinci kişinin yaşını giriniz: ");
        int age2 = int.Parse(Console.ReadLine());

        Console.Write("Üçüncü kişinin yaşını giriniz: ");
        int age3 = int.Parse(Console.ReadLine());

        int oldestAge = FindOldestAge(age1, age2, age3);
        Console.WriteLine("En yaşlı kişinin yaşı: " + oldestAge);

        static int FindOldestAge(int age1, int age2, int age3)
        {
            return Math.Max(age1, Math.Max(age2, age3));
        }
        Console.WriteLine("--------------------------------------------------");

        // 12 - Kullanıcıdan sınırsız sayıda sayı alıp, bunlardan en büyüğünü ekrana yazdıran ve aynı zamanda geriye dönen bir metot yazınız.
        List<int> numbers = new List<int>();
        Console.WriteLine("Sayıları girin (bitirmek için 'q' tuşuna basın):");

        while (true)
        {
            string input = Console.ReadLine();
            if (input.ToLower() == "q")
            {
                break;
            }

            if (int.TryParse(input, out int numberr))
            {
                numbers.Add(numberr);
            }
            else
            {
                Console.WriteLine("Geçersiz giriş, lütfen bir sayı girin veya 'q' ile çıkın.");
            }
        }

        if (numbers.Count > 0)
        {
            int maxNumber = FindMax(numbers);
            Console.WriteLine("En büyük sayı: " + maxNumber);
        }
        else
        {
            Console.WriteLine("Hiç sayı girilmedi.");
        }

        static int FindMax(List<int> numbers)
        {
            int max = numbers[0];
            foreach (int number in numbers)
            {
                if (number > max)
                {
                    max = number;
                }
            }
            return max;
        }
        Console.WriteLine("--------------------------------------------------");

        // 13 - Bir metot yardımıyla kullanıcıdan alınan 2 ismin yerlerini değiştiren uygulamayı yazınız.
        Console.Write("Birinci ismi giriniz: ");
        string name1 = Console.ReadLine();

        Console.Write("İkinci ismi giriniz: ");
        string name2 = Console.ReadLine();

        (name1, name2) = SwapNames(name1, name2);
        Console.WriteLine("Değiştirilmiş isimler:");
        Console.WriteLine("Birinci isim: " + name1);
        Console.WriteLine("İkinci isim: " + name2);

        static (string, string) SwapNames(string name1, string name2)
        {
            return (name2, name1);
        }
        Console.WriteLine("--------------------------------------------------");

        // 14 - Kullanıcıdan alınan sayının tek mi yoksa çift mi olduğu bilgisini (true/false) dönen bir metot.
        Console.Write("Bir sayı giriniz: ");
        int number = int.Parse(Console.ReadLine());
        bool isEven = IsEven(number);
        Console.WriteLine(isEven);

        static bool IsEven(int number)
        {
            return number % 2 == 0;
        }
        Console.WriteLine("--------------------------------------------------");

        // 15 - Kullanıcıdan alınan hız ve zaman bilgileriyle, gidilen yolu hesaplayan bir metot yazınız.
        Console.Write("Hızı giriniz (km/s): ");
        double speed = double.Parse(Console.ReadLine());

        Console.Write("Zamanı giriniz (saat): ");
        double time = double.Parse(Console.ReadLine());

        double distance = CalculateDistance(speed, time);
        Console.WriteLine($"Gidilen yol: {distance} km");

        static double CalculateDistance(double speed, double time)
        {
            return speed * time;
        }
        Console.WriteLine("--------------------------------------------------");

        // 16 - Yarıçap bilgisi verilen bir dairenin alanını hesaplayan bir metot yazınız.
        Console.Write("Yarıçapı giriniz: ");
        double radius = double.Parse(Console.ReadLine());

        double area = CalculateArea(radius);
        Console.WriteLine($"Dairenin alanı: {area}");

        static double CalculateArea(double radius)
        {
            return Math.PI * radius * radius;
        }
        Console.WriteLine("--------------------------------------------------");

        // 17 - "Zaman bir GeRi SayIm" cümlesini alıp, hepsi büyük harf ve hepsi küçük harfle yazdırınız.
        string sentence = "Zaman bir GeRi SayIm";
        Console.WriteLine("Büyük harflerle: " + sentence.ToUpper());
        Console.WriteLine("Küçük harflerle: " + sentence.ToLower());
        Console.WriteLine("--------------------------------------------------");

        // 18 - "    Selamlar   " metnini bir değişkene atayıp, başındaki ve sonundaki boşlukları siliniz.
        string text = "    Selamlar   ";
        text = text.Trim();
        Console.WriteLine("Düzenlenmiş metin: '" + text + "'");
        Console.WriteLine("--------------------------------------------------");
    }
}
