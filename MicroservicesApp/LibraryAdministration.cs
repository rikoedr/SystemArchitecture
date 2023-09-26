using MicroservicesApp.AppClient;
using MicroservicesApp.BookLendingService;
using MicroservicesApp.BooksManagementService;
using MicroservicesApp.MembershipManagementService;

namespace MicroservicesApp;

public class LibraryManager
{
    bool isRun = true;

    BooksServices booksServices;
    MembershipServices membershipServices;
    LendingService lendingService;

    public static void Main(string[] args)
    {
        LibraryManager libraryManager = new LibraryManager();

        libraryManager.Start();
    }

    public void Start()
    {
        booksServices = new BooksServices();
        membershipServices = new MembershipServices();
        lendingService = new LendingService(booksServices, membershipServices);

        BooksClient booksClient = new BooksClient(booksServices);
        MembershipClient membershipClient = new MembershipClient(membershipServices);
        LendingClient lendingClient = new LendingClient(lendingService);

        SampleData sampleData = new SampleData(booksServices, membershipServices);
        sampleData.Insert();

        while (isRun)
        {
            Console.WriteLine("LIBRARY MANAGER");
            Console.WriteLine("1. Books Management");
            Console.WriteLine("2. Membership Management");
            Console.WriteLine("3. Lending Management");
            Console.WriteLine("x  Exit");

            string input = Util.InputString("Choose menu : ");

            switch (input)
            {
                case "1":
                    booksClient.Menu();
                    break;
                case "2":
                    membershipClient.Menu();
                    break;
                case "3":
                    lendingClient.Menu();
                    break;
                case "x":
                    isRun = false;
                    break;
            }
        }
    }
}
