using System;
using System.Collections;
internal class Program
{
    public static void Main(string[] args)
    {
        //string S = Console.ReadLine();
        //StringToInteger(S);
        //PrintEvenOddIndices("Hacker");

        //int n, p;
        //n = int.Parse(Console.ReadLine());
        //p = int.Parse(Console.ReadLine());

        //Calculator calculator = new Calculator();
        //int result = calculator.power(n, p);
        //Console.WriteLine(result);


        //string date = Console.ReadLine();

        //string dateResult = Result.timeConversion(date);
        //Console.WriteLine(dateResult);

        //int n = Convert.ToInt32(Console.ReadLine());
        //int[] intArray = new int[n];
        //for (int i = 0; i < n; i++)
        //{
        //    intArray[i] = Convert.ToInt32(Console.ReadLine());
        //}
        //Printer.PrintArray(args);



        //DictionaryAndMaps.PhoneBook();

        //ArrayListExercise.PrimeNumber();

        //Average.AverageNumbers();

        SesliHarf.sesliHarfBul();

    }
    public static void StringToInteger(string S)
    {
      
        int parsedInt;

        if (int.TryParse(S, out parsedInt))
        {
            Console.WriteLine(parsedInt);
        }
        else
        {
            Console.WriteLine("Bad String");
        }
    }
    static void PrintEvenOddIndices(string S)
    {
        string evenChars = "";
        string oddChars = "";
        for (int i = 0; i < S.Length; i++)
        {
            if (i % 2 == 0)
            {
                evenChars += S[i];
            }
            else
            {
                oddChars += S[i];
            }
        }
        Console.WriteLine(evenChars + " " + oddChars);
    }
}
public class Calculator
{
    public int power(int n, int p)
    {
        if (n < 0 || p < 0)
        {
            throw new Exception("n and p should be non-negative");

        }
         int sonuc = (int)Math.Pow(n, p);
         return sonuc;

        
    }
}
class Result
{
    public static string timeConversion(string s)
    {
        string hourString = s.Substring(0, 2);
        int hour = int.Parse(hourString);

        if (s.EndsWith("PM") && hour != 12)
        {
            hour += 12;
        }
        else if (s.EndsWith("AM") && hour == 12)
        {
            hour = 0;
        }

        string hour24Format = hour.ToString().PadLeft(2, '0'); //soldan bir tane 0 koyar
        string time24Format = hour24Format + s.Substring(2, 6); //pm ve am yazısını yok eder

        return time24Format;
    }

}
class Printer
{
    public static void PrintArray<T>(T[] array)
    {
        foreach (T element in array)
        {
            Console.WriteLine(element);
        }
    }
}
class DictionaryAndMaps
{
    public static void PhoneBook()
    {
        int n = int.Parse(Console.ReadLine());
        Dictionary<string, string> phoneBook = new Dictionary<string, string>();

        for (int i = 0; i < n; i++)
        {
            string[] entry;
            entry = Console.ReadLine().Split(' ');
            string name = entry[0];
            string phoneNumber = entry[1];
            phoneBook[name] = phoneNumber;
        }
        string query;
        while ((query = Console.ReadLine()) != null)
        {
            if (phoneBook.ContainsKey(query))
            {
                Console.WriteLine(query + "=" + phoneBook[query]);
            }
            else
            {
                Console.WriteLine("Not found");
            }
        }

    }
}
public class ArrayListExercise
{
    public static void PrimeNumber()
    {
        
        ArrayList primeNumbers = new ArrayList();
        ArrayList notPrimeNumbers = new ArrayList();

        int sayac = 1;
        while (sayac <= 5)
        {
            Console.Write("{0}. sayıyı girin: ", sayac);
            int sayi = int.Parse(Console.ReadLine());
            if (sayi > 0)
            {
                if (IsPrime(sayi))
                    primeNumbers.Add(sayi);
                else
                    notPrimeNumbers.Add(sayi);

                sayac++;
            }
            else
            {
                Console.WriteLine("Geçersiz giriş! Pozitif bir sayı girin.");
            }
        }

        primeNumbers.Sort();
        notPrimeNumbers.Sort();
        primeNumbers.Reverse();
        notPrimeNumbers.Reverse();

        Console.WriteLine("Asal sayılar:");
        foreach (int sayi in primeNumbers)
        {
            Console.WriteLine(sayi);
        }

        Console.WriteLine("Asal olmayan sayılar:");
        foreach (int sayi in notPrimeNumbers)
        {
            Console.WriteLine(sayi);
        }

        Console.WriteLine("Asal sayıların eleman sayısı: {0}", primeNumbers.Count);
        Console.WriteLine("Asal olmayan sayıların eleman sayısı: {0}", notPrimeNumbers.Count);

        double asalOrtalama = primeNumbers.Count > 0 ? primeNumbers.Cast<int>().Average() : 0;
        double asalOlmayanOrtalama = notPrimeNumbers.Count > 0 ? notPrimeNumbers.Cast<int>().Average() : 0;

        Console.WriteLine("Asal sayıların ortalaması: {0}", asalOrtalama);
        Console.WriteLine("Asal olmayan sayıların ortalaması: {0}", asalOlmayanOrtalama);

        Console.ReadLine();
    }

    public static bool IsPrime(int number)
    {
        if (number < 2)
        {
            return false;
        }

        for (int i = 2; i * i <= number; i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}
public class Average
{
    public static void AverageNumbers()
    {
        ArrayList numbers = new ArrayList();
        int sayac = 1;
        while (sayac<=5)
        {
            Console.Write("{0}. sayıyı girin: ", sayac);
            int sayi = int.Parse(Console.ReadLine());
            numbers.Add(sayi);
            sayac++;
        }
        numbers.Sort();
        ArrayList smallestThree = new ArrayList(numbers.GetRange(0, 3));
        ArrayList largestThree =new ArrayList(numbers.GetRange(numbers.Count - 3, 3));

        double smallestAverage = CalculateAverage(smallestThree);
        double largestAverage = CalculateAverage(largestThree);
        double totalAverage = CalculateAverage(numbers);

        Console.WriteLine("En küçük 3 sayı: {0}", string.Join(", ", smallestThree.ToArray()));
        Console.WriteLine("En büyük 3 sayı: {0}", string.Join(", ", largestThree.ToArray()));
        Console.WriteLine("En küçük 3 sayının ortalaması: {0}", smallestAverage);
        Console.WriteLine("En büyük 3 sayının ortalaması: {0}", largestAverage);
        Console.WriteLine("Tüm sayıların ortalaması: {0}", totalAverage);
    }
    static double CalculateAverage(ArrayList numbers)
    {
        double sum = 0;

        foreach (int number in numbers)
        {
            sum += number;
        }

        return sum / numbers.Count;
    }
}

public class SesliHarf
{
    public static void sesliHarfBul()
    {
        Console.WriteLine("Bir cümle girin: ");
        string cumle = Console.ReadLine();

        char[] sesliHarfler = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };
        List<char> sesliHarfListesi = new List<char>();

        foreach (char harf in cumle)
        {
            if (Array.IndexOf(sesliHarfler, char.ToLower(harf)) != -1 && !sesliHarfListesi.Contains(harf))
            {
                sesliHarfListesi.Add(harf);
            }
        }

        sesliHarfListesi.Sort();

        Console.WriteLine("Cümledeki sesli harfler:");
        foreach (char sesliHarf in sesliHarfListesi)
        {
            Console.WriteLine(sesliHarf);
        }
    }
}