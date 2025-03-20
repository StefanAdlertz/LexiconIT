//class Program
//{
//    static void Main()
//    {
//        //Läs in värdena för a, b och n
//        Console.Write("Skriv in värdet för a: ");
//        string? input_a = Console.ReadLine();
//        Console.Write("Skriv in värdet för b: ");
//        string? input_b = Console.ReadLine();
//        Console.Write("Skriv in värdet för n: ");
//        string? input_n = Console.ReadLine();
//        Console.WriteLine("");

//        //Kontrollerar att inmatningen är korrekt och tilldelar värdena till variablerna a, b och n
//        if (int.TryParse(input_a, out int a) && int.TryParse(input_b, out int b) && int.TryParse(input_n, out int n))
//        {
//            //Anropa metoden FizzBuzz med värdena för a, b och n
//            FizzBuzz(a, b, n);
//        }
//        else
//        {
//            //Felmeddelande om inmatningen är felaktig
//            Console.WriteLine("Felaktig inmatning, skriv in tre heltal");
//        }
//    }

//    //Metod för att kontrollera om i är en multipel av a och/eller b och skriva ut resultatet
//    public static void FizzBuzz(int a, int b, int n)
//    {
//        for (int i = 1; i <= n; i++)
//        {
//            string result;
//            switch ((i % a == 0, i % b == 0))
//            {
//                case (true, true):
//                    result = i + " är en multipel av både " + a + " (a) och " + b + " (b) - FizzBuzz";
//                    break;
//                case (true, false):
//                    result = i + " är en multipel av " + a + " (a) - Fizz";
//                    break;
//                case (false, true):
//                    result = i + " är en multipel av " + b + " (b) - Buzz";
//                    break;
//                default:
//                    result = i + " är inte en multipel av " + a + " (a) eller " + b + " (b)";
//                    break;
//            }
//            Console.WriteLine(result);
//        }
//    }
//}

// Läs in värdena för a, b och n
Console.Write("Skriv in värdet för a: ");
string? inputA = Console.ReadLine();
Console.Write("Skriv in värdet för b: ");
string? inputB = Console.ReadLine();
Console.Write("Skriv in värdet för n: ");
string? inputN = Console.ReadLine();
Console.WriteLine("");

// Kontrollera att inmatningen är korrekt och tilldela värdena till variablerna a, b och n
if (int.TryParse(inputA, out int a) && int.TryParse(inputB, out int b) && int.TryParse(inputN, out int n))
{
    // Anropa metoden FizzBuzz med värdena för a, b och n
    FizzBuzz(a, b, n);
}
else
{
    // Felmeddelande om inmatningen är felaktig
    Console.WriteLine("Felaktig inmatning, skriv in tre heltal");
}

// Metod för att kontrollera om i är en multipel av a och/eller b och skriva ut resultatet
void FizzBuzz(int a, int b, int n)
{
    for (int i = 1; i <= n; i++)
    {
        string result;
        switch ((i % a == 0, i % b == 0))
        {
            case (true, true):
                result = i + " är en multipel av både " + a + " (a) och " + b + " (b) - FizzBuzz";
                break;
            case (true, false):
                result = i + " är en multipel av " + a + " (a) - Fizz";
                break;
            case (false, true):
                result = i + " är en multipel av " + b + " (b) - Buzz";
                break;
            default:
                result = i + " är inte en multipel av " + a + " (a) eller " + b + " (b)";
                break;
        }
        Console.WriteLine(result);
    }
}
