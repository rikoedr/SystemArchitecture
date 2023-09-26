using MonolithicApp.Controller;

namespace MonolithicApp;

public class TaskManagerApplication
{
    public static void Main(string[] args)
    {
        TaskController taskManager = new TaskController();
        bool isRun = true;

        while (isRun)
        {
            Console.WriteLine("TASK MANAGER APPLICATION");
            Console.WriteLine("1. Show All Task");
            Console.WriteLine("2. Search Task by ID");
            Console.WriteLine("3. Insert Task");
            Console.WriteLine("4. Update Task");
            Console.WriteLine("5. Delete Task");
            Console.WriteLine("x  Exit");
            
            Console.Write("Choose menu : ");
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    taskManager.GetAll();
                    break;
                case "2":
                    taskManager.GetByID();
                    break;
                case "3":
                    taskManager.Insert();
                    break;
                case "4":
                    taskManager.Update();
                    break;
                case "5":
                    taskManager.Delete();
                    break;
                case "x":
                    isRun = false;
                    break;
            }
        }
    }
}