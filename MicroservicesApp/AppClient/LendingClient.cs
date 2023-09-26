using MicroservicesApp.BookLendingService;

namespace MicroservicesApp.AppClient;

public class LendingClient : AbstractClient
{

    LendingService lendingService;

    public LendingClient(LendingService lendingService)
    {
        this.lendingService = lendingService;
    }
    public override void Menu()
    {
        bool isRun = true;

        while (isRun)
        {
            Console.WriteLine("\nBook Lending Management");
            Console.WriteLine("1. Show All Book Lending");
            Console.WriteLine("2. Add New Book Lending");
            Console.WriteLine("3. Edit Book Lending");
            Console.WriteLine("4. Delete Book Lending");
            Console.WriteLine("x  Back");

            string input = Util.InputString("Choose menu : ");

            switch (input)
            {
                case "1":
                    GetAll();
                    break;
                case "2":
                    Add();
                    break;
                case "3":
                    Edit();
                    break;
                case "4":
                    Delete();
                    break;
                case "x":
                    isRun = false;
                    break;
            }
        }
    }

    protected override void Add()
    {
        string memberID = Util.InputString("Insert Member ID : ");
        string bookISBN = Util.InputString("Insert Book ISBN : ");
        string transaction = lendingService.Add(memberID, bookISBN);

        Console.WriteLine(transaction);
    }

    protected override void Delete()
    {
        string id = Util.InputString("Insert Lending ID : ");
        string transaction = lendingService.Delete(id);

        Console.WriteLine(transaction);
    }

    protected override void Edit()
    {
        string id = Util.InputString("Insert Lending ID : ");
        string memberID = Util.InputString("Insert Member ID : ");
        string bookISBN = Util.InputString("Insert Book ISBN : ");
        string transaction = lendingService.Edit(id, memberID, bookISBN);

        Console.WriteLine(transaction);
    }

    protected override void GetAll()
    {
        List<object> lendings = lendingService.GetAll();

        if (lendings.Count == 0)
        {
            Console.WriteLine("Book Lendings is empty!");
        }
        else
        {
            Util.PrintList<object>(lendings);
        }
    }
}
