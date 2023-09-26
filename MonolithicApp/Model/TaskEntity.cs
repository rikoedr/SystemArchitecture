using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonolithicApp.Model;

public class TaskEntity
{
    public int ID { get; set; }
    public string Task { get; set; }
    public string Category { get; set; }

    public override string? ToString()
    {
        return $"[{ID}] {Task}({Category})";
    }
}
