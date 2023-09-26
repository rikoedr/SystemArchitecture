using MicroservicesApp.MembershipManagementService;

namespace MicroservicesApp.AppClient;

public class MembershipClient : AbstractClient
{
    MembershipServices membershipServices;

    public MembershipClient(MembershipServices membershipServices)
    {
        this.membershipServices = membershipServices;
    }

    public override void Menu()
    {
        bool isRun = true;

        while (isRun)
        {
            Console.WriteLine("\nMembership Management");
            Console.WriteLine("1. Show All Members");
            Console.WriteLine("2. Add New Member");
            Console.WriteLine("3. Edit Member");
            Console.WriteLine("4. Delete Member");
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
        string name = Util.InputString("Insert Member Name : ");
        string email = Util.InputString("Insert Member Email : ");

        string transaction = membershipServices.Add(name, email);
        Console.WriteLine(transaction);
    }

    protected override void Delete()
    {
        string id = Util.InputString("Insert Member ID : ");
        string transaction = membershipServices.Delete(id);

        Console.WriteLine(transaction);
    }

    protected override void Edit()
    {
        string id = Util.InputString("Insert Member ID : ");
        string name = Util.InputString("Insert Member Name : ");
        string email = Util.InputString("Insert Member Email : ");

        string transaction = membershipServices.Edit(id, name, email);
        Console.WriteLine(transaction);
    }

    protected override void GetAll()
    {
        List<object> members = membershipServices.GetAll();

        if (members.Count == 0)
        {
            Console.WriteLine("Membership List is empty!");
        }
        else
        {
            Util.PrintList<object>(members);
        }
    }
}
