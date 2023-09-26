namespace MicroservicesApp.BooksManagementService;

public class Book
{
    public string ISBN { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }

    public override string? ToString()
    {
        return $"[{ISBN}] {Title} by {Author}";
    }
}
