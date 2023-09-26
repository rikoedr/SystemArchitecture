namespace MicroservicesApp.BookLendingService;

public class Lending
{
    public string ID { get; set; }

    public string BookTitle { get; set; }
    public string BookISBN { get; set; }
    public string MemberID { get; set; }
    public string MemberName { get; set; }

    public override string? ToString()
    {
        return $"[{ID}] [{MemberName}] {BookTitle}";
    }
}
