using MonolithicApp.Model;
using MonolithicApp.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonolithicApp.Controller;

public class TaskController
{
    private TaskModel model = new TaskModel();
    private TaskView view = new TaskView();

    public void GetAll()
    {
        Console.WriteLine("");
        view.List(model.GetAll());
    }

    public void GetByID()
    {
        Console.WriteLine("");
        int id = view.IntegerInput("Insert Task ID : ");
        string task = model.GetByID(id).ToString();

        view.Transaction(task, "Task Result : ");
    }

    public void Insert()
    {
        Console.WriteLine("");
        string task = view.StringInput("Insert Task : ");
        string category = view.StringInput("Insert Category : ");

        model.Insert(task, category);

        view.Transaction("Succsess", "Insert status : ");
    }

    public void Delete()
    {
        Console.WriteLine("");
        int id = view.IntegerInput("Insert Task ID : ");
        bool isDeleted = model.Delete(id);

        if (!isDeleted)
        {
            view.Transaction("Failed", "Delete status : ");
        }else
        {
            view.Transaction("Success", "Delete status : ");
        }
    }

    public void Update()
    {
        Console.WriteLine("");
        int id = view.IntegerInput("Insert Task ID : ");
        string task = view.StringInput("Insert New Task : ");
        string category = view.StringInput("Insert New Category : ");

        bool isUpdated = model.Update(id, task, category);

        if(!isUpdated)
        {
            view.Transaction("Failed", "Update status : ");
        }else
        {
            view.Transaction("Success", "Update status : ");
        }
    }
}
