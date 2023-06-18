internal class Program
{
    public static void Main(string[] args)
    {
        string S = Console.ReadLine();
       StringToInteger(S);
    }
    public static void StringToInteger(string S)
    {
      
        int parsedInt;

        if (int.TryParse(S, out parsedInt))
        {
            Console.WriteLine(parsedInt); // Print the parsed integer
        }
        else
        {
            Console.WriteLine("Bad String"); // Print "Bad String" if parsing fails
        }
    }
}


