
internal class Program
{
    private static void Main(string[] args)
    {
        //List<T> class 
        //T generic olduğunu söyler ve T object türündedir nesne alır.Nesnenin tipini ifade eder

        List<int> sayiListesi = new List<int>();
        sayiListesi.Add(1);

        List<string> renkListesi = new List<string>();
        renkListesi.Add("sarı");

        Console.WriteLine(renkListesi[0]);
    }
}