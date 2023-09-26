using MicroservicesApp.BooksManagementService;
using MicroservicesApp.MembershipManagementService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroservicesApp.BookLendingService;

public class LendingService
{
    List<Lending> lendings = new List<Lending>();
    BooksServices booksServices;
    MembershipServices membershipServices;

    public LendingService(BooksServices booksServices, MembershipServices membershipServices)
    {
        this.booksServices = booksServices;
        this.membershipServices = membershipServices;
    }

    public List<Object> GetAll()
    {
        List<object> result = new List<object>();

        foreach(Lending item in lendings)
        {
            result.Add(item);
        }

        return result;
    }

    public string Add(string memberID, string bookISBN)
    {
        List<string> member = membershipServices.GetByID(memberID);
        List<string> book = booksServices.GetByID(bookISBN);
        
        if(member.Count == 0)
        {
            return "Member not found";
        }

        if(book.Count == 0)
        {
            return "Book Not Found";
        }

        lendings.Add(new Lending
        {
            ID = CreateID(),
            MemberID = member[0],
            MemberName = member[1],
            BookISBN = book[0],
            BookTitle = book[1]
        });

        return "Add Success";
    }

    public string Edit(string id, string memberID, string bookISBN)
    {
        int index = lendings.FindIndex(item => item.ID == id);

        if(index < 0)
        {
            return "Lending Not Found";
        }

        List<string> member = membershipServices.GetByID(memberID);
        List<string> book = booksServices.GetByID(bookISBN);

        if (member.Count == 0)
        {
            return "Member not found";
        }

        if (book.Count == 0)
        {
            return "Book Not Found";
        }

        lendings[index].MemberID = member[0];
        lendings[index].MemberName = member[1];
        lendings[index].BookISBN = book[0];
        lendings[index].BookTitle = book[1];

        return "Edit Success";
    }

    public string Delete(string id)
    {
        int index = lendings.FindIndex(item => item.ID == id);

        if (index < 0)
        {
            return "Delete failed. Lending not found!";

        }

        lendings.RemoveAt(index);

        return "Delete success";
    }

    public string CreateID()
    {
        string guid = Guid.NewGuid().ToString("N");

        return guid.Substring(0, 6);
    }

}
