﻿namespace MicroservicesApp.MembershipManagementService;

public class Member
{
    public string ID { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }

    public override string? ToString()
    {
        return $"[{ID}] {Name} - {Email}";
    }
}
