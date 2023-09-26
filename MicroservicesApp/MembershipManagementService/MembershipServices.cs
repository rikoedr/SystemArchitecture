namespace MicroservicesApp.MembershipManagementService;

public class MembershipServices
{
    List<Member> members = new List<Member>();

    public List<object> GetAll()
    {
        List<object> result = new List<object>();

        foreach (Member item in members)
        {
            result.Add(item);
        }

        return result;
    }

    public List<string> GetByID(string id)
    {
        int index = members.FindIndex(item => item.ID == id);

        if (index < 0)
        {
            return new List<string>();
        }

        return new List<string>
        {
            members[index].ID,
            members[index].Name,
            members[index].Email
        };
    }

    public string Add(string name, string email)
    {
        int lastIndex = members.Count - 1;

        members.Add(new Member
        {
            ID = CreateID(),
            Name = name,
            Email = email
        });

        return "Add success!";
    }



    public string Edit(string id, string name, string email)
    {
        int index = members.FindIndex(item => item.ID == id);

        if (index < 0)
        {
            return "Edit failed. Member not found!";
        }

        members[index].Name = name;
        members[index].Email = email;

        return "Edit success!";
    }

    public string Delete(string id)
    {
        int index = members.FindIndex(item => item.ID == id);

        if (index < 0)
        {
            return "Delete failed. Member not found!";

        }

        members.RemoveAt(index);

        return "Delete success";
    }

    public string CreateID()
    {
        string guid = Guid.NewGuid().ToString("N");


        return guid.Substring(0, 6);
    }
}
