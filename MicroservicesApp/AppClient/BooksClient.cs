using MicroservicesApp.BooksManagementService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroservicesApp.AppClient;

public class BooksClient : AbstractClient
{
    BooksServices booksService;
    

    public BooksClient(BooksServices booksServices)
    {
        this.booksService = booksServices;
    }

    public override void Menu()
    {
        bool isRun = true;

        while (isRun)
        {
            Console.WriteLine("\nBooks Management");
            Console.WriteLine("1. Show All Books");
            Console.WriteLine("2. Add New Book");
            Console.WriteLine("3. Edit Book");
            Console.WriteLine("4. Delete Book");
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
        string isbn = Util.InputString("Input Book ISBN : ");
        string title = Util.InputString("Input Book Title : ");
        string author = Util.InputString("Input Book Author : ");

        string transaction = booksService.Add(isbn, title, author);
        Console.WriteLine(transaction);
    }

    protected override void Delete()
    {
        string isbn = Util.InputString("Input Book ISBN : ");
        string transaction = booksService.DeleteBook(isbn);

        Console.WriteLine(transaction);
    }

    protected override void Edit()
    {
        string isbn = Util.InputString("Input Book ISBN : ");
        string title = Util.InputString("Input Book Title : ");
        string author = Util.InputString("Input Book Author : ");

        string transaction = booksService.Edit(isbn, title, author);
        Console.WriteLine(transaction);
    }

    protected override void GetAll()
    {
        List<object> books = booksService.GetBooks();

        if(books.Count == 0)
        {
            Console.WriteLine("Books empty!");
        }
        else
        {
            Util.PrintList<object>(books);
        }
    }
}
