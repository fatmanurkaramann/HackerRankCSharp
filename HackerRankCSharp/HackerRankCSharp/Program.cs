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

        int n = Convert.ToInt32(Console.ReadLine());
        int[] intArray = new int[n];
        for (int i = 0; i < n; i++)
        {
            intArray[i] = Convert.ToInt32(Console.ReadLine());
        }



        Printer.PrintArray(args);
        //DictionaryAndMaps.PhoneBook();

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