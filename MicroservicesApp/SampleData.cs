using MicroservicesApp.BooksManagementService;
using MicroservicesApp.MembershipManagementService;

namespace MicroservicesApp;

public class SampleData
{
    BooksServices booksServices;
    MembershipServices membershipServices;

    public SampleData(BooksServices booksServices, MembershipServices membershipServices)
    {
        this.booksServices = booksServices;
        this.membershipServices = membershipServices;
    }

    public void Insert()
    {
        bookSample();
        membershipSample();
    }

    private void bookSample()
    {
        booksServices.Add("978-0345538376", "The Hobbit", "J.R.R. Tolkien");
        booksServices.Add("978-0062073484", "Ender's Game", "Orson Scott Card");
        booksServices.Add("978-0439023528", "The Hunger Games", "Suzanne Collins");
        booksServices.Add("978-0141439747", "The Odyssey", "Homer");
        booksServices.Add("978-1401945903", "The Power of Now: A Guide to Spiritual Enlightenment", "Eckhart Tolle");
        booksServices.Add("978-0062457714", "Daring Greatly: How the Courage to Be Vulnerable Transforms the Way We Live, Love, Parent, and Lead", "Brené Brown");
        booksServices.Add("978-1501199533", "Atomic Habits: An Easy & Proven Way to Build Good Habits & Break Bad Ones", "James Clear");
        booksServices.Add("978-0062315007", "The Subtle Art of Not Giving a F*ck: A Counterintuitive Approach to Living a Good Life", "Mark Manson");
        booksServices.Add("978-0525537443", "Grit: The Power of Passion and Perseverance", "Angela Duckworth");
        booksServices.Add("978-0545790352", "Harry Potter and the Sorcerer's Stone", "J.K. Rowling");
        booksServices.Add("978-0439064873", "Harry Potter and the Chamber of Secrets", "J.K. Rowling");
    }

    private void membershipSample()
    {
        membershipServices.Add("John Smith", "john.smith@example.com");
        membershipServices.Add("Alice Johnson", "alice.johnson@example.com");
        membershipServices.Add("Michael Davis", "michael.davis@example.com");
        membershipServices.Add("Emily Wilson", "emily.wilson@example.com");
        membershipServices.Add("David Lee", "david.lee@example.com");
        membershipServices.Add("Sarah Williams", "sarah.williams@example.com");
        membershipServices.Add("Robert Anderson", "robert.anderson@example.com");
        membershipServices.Add("Jennifer Brown", "jennifer.brown@example.com");
        membershipServices.Add("Daniel Clark", "daniel.clark@example.com");
        membershipServices.Add("Sophia Garcia", "sophia.garcia@example.com");
    }
}