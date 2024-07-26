void lyricsLogger()
{
    Console.WriteLine("Ve ayrılıklar bitmez öğütür");
    Console.WriteLine("Ve gölgeler siner ömrüne kaçar kendinden");
}

int ranNumGenerator()
{
    Random rnd = new Random();
    int ranNum = rnd.Next(1, 100);
    Console.WriteLine(ranNum / 2); //console it before return to check if it works
    return (ranNum / 2);
}

int multiplicator(int a, int b)
{
    Console.WriteLine(a * b); //console it before return to check if it works
    return (a * b);
}

void greeter(string name, string lastname)
{
    Console.WriteLine($"Hoş Geldiniz {name} {lastname}");
}