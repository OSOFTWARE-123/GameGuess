int x = 1, y = 101;
Console.Clear();

Console.Write("1 İle 100 Arası Bir Sayi Tutunuz: ");
int sayi = int.Parse(Console.ReadLine());

int tahmax = 1;

Random r = new Random();

while (true)
{
    int tahmin = r.Next(x, y);

    if (tahmin < sayi)
    {
        x = tahmin;
        Console.WriteLine(String.Format("Bilgisayar Tahminini " + tahmin + 
        " Olarak Yaptı. {0} İle {1} Arasında Yeniden Tahmin Yapıyor...",x,y));
        Console.ReadKey();
        tahmax++;
    }
    else if (tahmin > sayi)
    {
        y = tahmin + 1;
        Console.WriteLine(String.Format("Bilgisayar Tahminini " + tahmin + 
        " Olarak Yaptı. {0} İle {1} Arasında Yeniden Tahmin Yapıyor...",x,y));
        Console.ReadKey();
        tahmax++;
    }
    else
    {
        Console.WriteLine("Bilgisayar " + sayi + " Sayısını " + tahmax + ". Deneme Buldu.");
        break;
    }

}

Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.BackgroundColor = ConsoleColor.Blue;
Console.WriteLine("\nProgram Bitti!\n");

Console.ForegroundColor = ConsoleColor.Green;
Console.BackgroundColor = ConsoleColor.Black;