namespace MicroservicesApp;

public class Util
{
    public static string InputString(string message)
    {
        Console.Write(message);
        string input = Console.ReadLine();

        return input;
    }

    public static int InputInteger(string message)
    {
        Console.Write(message);
        string input = Console.ReadLine();

        return int.Parse(input);
    }

    public static void PrintList<T>(List<T> list)
    {
        int counter = 1;
        foreach (T item in list)
        {
            Console.WriteLine(counter + " - " + item.ToString());
            counter += 1;
        }
    }
}
