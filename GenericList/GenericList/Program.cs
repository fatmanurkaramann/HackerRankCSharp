
using System.Collections;

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

        //Console.WriteLine(renkListesi[0]);

        List<Users> users = new List<Users>();
        Users user1 = new Users();
        user1.Name = "Ayşe";
        user1.Surname = "yılmaz";

        users.Add(user1);   

        List<Users> users2 = new List<Users>();
        users2.Add(new Users()
        {
            Name = "",
            Surname = ""
        }
            );
        //Farklı veri tiplerini array list içerisinde saklayabilirsiniz.
        //Ve eleman ekleyerek ve cıkararak boyutunu dinamik olarak değiştirebilirsiniz.
        ArrayList liste = new ArrayList();

        //adrange toplu akleme sağlar
        string[] renkler = {"sarı", "kırmızı" };
        renkListesi.AddRange(renkler);
       // renkListesi.ForEach(e => Console.WriteLine(e));
        liste.AddRange(renkler);


        //reverse sondaki elemanı başa baştakini soona yazar.
        liste.Reverse();

        foreach (var item in liste)
        {
            Console.WriteLine(item);
        }


        //Dictionary koleksiyonunda key-value yani anahtar-deger denen 2 kavram ile karşılaşıyoruz.
        //Dizilere eklediğimiz elemanları value, index lerini ise key olarak düşünebilirsiniz.

        Dictionary<int,string> kullanıcılar = new Dictionary<int,string>();

        kullanıcılar.Add(10, "Ayşe");
        kullanıcılar.Add(17, "Fato");
        kullanıcılar.Add(20, "Emre");
        //dizinin elemanlarına erişim
        Console.WriteLine(kullanıcılar[10]);
        foreach (var item in kullanıcılar)
        {
            Console.WriteLine(item);
        }

        //count
        Console.WriteLine(kullanıcılar.Count);
    }


}
public class Users
{
    string name;
    string surname;

    public string Surname { get => surname; set => surname = value; }
    public string Name { get => name; set => name = value; }
}