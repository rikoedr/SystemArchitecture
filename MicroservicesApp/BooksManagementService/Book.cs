using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
