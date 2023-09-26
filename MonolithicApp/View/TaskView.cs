using MonolithicApp.Model;

namespace MonolithicApp.View;

public class TaskView
{
    public void List(List<TaskEntity> tasks)
    {
        Console.WriteLine("TASK LIST : ");

        foreach (TaskEntity item in tasks)
        {
            Console.WriteLine(item.ToString());
        }

        Console.WriteLine("");
    }

    public void Single(TaskEntity task)
    {
        Console.WriteLine("Search by ID : ");
        Console.WriteLine(task.ToString());

        Console.WriteLine("");
    }

    public void Transaction<T>(T result, string message)
    {
        Console.Write(message);
        Console.WriteLine(result);
        Console.WriteLine("");
    }

    public string StringInput(string message)
    {
        Console.Write(message);
        string input = Console.ReadLine();

        return input;
    }

    public int IntegerInput(string message)
    {
        Console.Write(message);
        string input = Console.ReadLine();

        return int.Parse(input);
    }

}
