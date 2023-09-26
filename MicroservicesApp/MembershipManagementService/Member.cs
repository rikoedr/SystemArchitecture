﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroservicesApp.MembershipManagementService;

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
