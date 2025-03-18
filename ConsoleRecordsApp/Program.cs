internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        foreach(int number in numbers)
        {
            Print(GetFizzBuzz(number));
        }

        Record1 r1a = new Record1("John", "Doe");

        Record1 r1b = new Record1("John", "Doe");

        Print($" record type :  {r1a}");

        Print($" are equal:  {Equals(r1a, r1b)}" );

        Print(isPalindrome("madam") ? "Palindrome" : "Not Palindrome");
    }

    public record Record1 (string FirstName, string LastName);








    public static Boolean isPalindrome(string str)
    {
        int half = str.Length / 2;
        for (int i = 0; i < half; i++)
            if (str[i] != str[str.Length - i - 1])
                return false;
        return true;

    }
















    public static string GetFizzBuzz(int number)
    {
        if (number % 3 == 0 && number % 5 == 0)
        {
            return "FizzBuzz";
        } else if (number % 3 == 0)
        {
            return "Fizz";
        }
        else if (number % 5 == 0)
        {
            return "Buzz";
        }
        else
        {
            return number.ToString();
        }
    }

    public static string GetInput(string message)
    {
        Print(message);
        return Console.ReadLine();
    }

    public static void Print(string message)
    {
        Console.WriteLine(message);
    }
}