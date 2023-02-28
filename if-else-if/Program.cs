internal class Program
{
    private static void Main(string[] args)
    {
        int time = DateTime.Now.Hour;


        if (time >= 6 && time < 11 )
            Console.WriteLine("Günaydın");

        else if (time <= 16)
            Console.WriteLine("İyi Günler");

        else
            Console.WriteLine("İyi Geceler");

        string sonuc = time <= 18 ? "iyi günler" : "iyi geceler";

        sonuc = time >= 6 && time < 17 ? "Günaydın" : time <= 18 ? "iyi günler" : "iyi geceler";
        Console.WriteLine(sonuc);



    }
}