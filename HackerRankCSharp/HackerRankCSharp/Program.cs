internal class Program
{
    public static void Main(string[] args)
    {
        //string S = Console.ReadLine();
        //StringToInteger(S);
        //PrintEvenOddIndices("Hacker");

        //int n, p;
        //n=int.Parse(Console.ReadLine());
        //p = int.Parse(Console.ReadLine());

        //    Calculator calculator = new Calculator();
        //    int result = calculator.power(n, p);
        //    Console.WriteLine(result);

        //string date = "07:05:45PM";

        //if (date.EndsWith("PM"))
        //{
        //    string hourString = date.Substring(0, 2); // Extract the hour part (e.g., "07")
        //    int hour = int.Parse(hourString); // Convert the hour string to an integer
        //    hour += 12;
        //    string time24HourFormat = hour.ToString().PadLeft(2, '0') + date.Substring(2, 6); // Create the time string in 24-hour format

        //    Console.WriteLine(time24HourFormat);
        //}

        string s = Console.ReadLine();

        string result = Result.timeConversion(s);
        Console.WriteLine(result);  


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

        string hour24Format = hour.ToString().PadLeft(2, '0');
        string time24Format = hour24Format + s.Substring(2, 6);

        return time24Format;
    }

}

